using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IXS_Widescreen_Utility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Globals
        long[] widthOffset  = { 0x1A79D4, 0x1A79E0, 0x1A79EC, 0x1A79F8 }; //0x16EE5;
        long[] heightOffset = { 0x1A79D8, 0x1A79E4, 0x1A79F0, 0x1A79FC }; //0x16EF3;
        long[] stringOffset = { 0x1A7F51, 0x1A7F45, 0x1A7F35, 0x1A7F29, };
        int[] stringLength = { 9, 9, 10, 10 };
        long fovOffset      = 0x9F17;
        long aspectOffset   = 0x9F09;

        private void programStart()
        {
            //Automatically search for game.exe in common locations
            string[] gamePaths = { "Game.exe",
                                   "C:/Program Files (x86)/LEGO Interactive/Island Xtreme Stunts/Game.exe",
                                   "C:/Program Files/LEGO Interactive/Island Xtreme Stunts/Game.exe" };

            foreach (string path in gamePaths)
            {
                if (File.Exists(path))
                {
                    tbFileLocation.Text = Path.GetFullPath(path);
                    tbFileLocation.Select(0, 0); //Prevents weird automatic highlighting
                    break;
                }
            }
        }


        //Auto Fill Button
        private void button1_Click(object sender, EventArgs e)
        {
            //Set aspect ratio to auto
            rbAuto.Checked = true;

            //Set custom resolution to screen resolution
            Rectangle screen = Screen.PrimaryScreen.Bounds;

            tbWidth.Text = "" + screen.Width;
            tbHeight.Text = "" + screen.Height;
        }        


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Setup dialog box
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Executable Files (*.exe)|*.exe";
            dialog.FileName = "Game.exe";
            dialog.CheckFileExists = true;
            dialog.InitialDirectory = Path.GetDirectoryName(tbFileLocation.Text);

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFileLocation.Text = Path.GetFullPath(dialog.FileName);
            }
        }


        private int getToReplace()
        {
            if (rbRes1.Checked == true)
            {
                return 0;
            }
            else if (rbRes2.Checked == true)
            {
                return 1;
            }
            else if (rbRes3.Checked == true)
            {
                return 2;
            }
            else if (rbRes4.Checked == true)
            {
                return 3;
            }

            return 0;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            string finalMessage = "";

            string exePath = tbFileLocation.Text;

            if (File.Exists(exePath))
            {
                byte[] virtualFile = File.ReadAllBytes(exePath);

                //Reset aspect
                byte[] aspect = BitConverter.GetBytes(4f / 3f);

                for (int i = 0; i < 4; i++)
                {
                    virtualFile[aspectOffset + i] = aspect[i];
                }

                //Reset fov
                byte[] fov = BitConverter.GetBytes(0x200);

                for (int i = 0; i < 2; i++)
                {
                    virtualFile[fovOffset + i] = fov[i];
                }

                //Reset resolutions
                int[] widths  = { 640, 800, 1024, 1280 };
                int[] heights = { 480, 600,  768, 1024 };

                for (int i = 0; i < 4; i++)
                {
                    byte[] wBytes = BitConverter.GetBytes(widths[i]);
                    byte[] hBytes = BitConverter.GetBytes(heights[i]);

                    for (int a = 0; a < 4; a++)
                    {
                        virtualFile[widthOffset[i] + a] = wBytes[a];
                        virtualFile[heightOffset[i] + a] = hBytes[a];
                    }
                }

                try
                {
                    File.WriteAllBytes(exePath, virtualFile);
                    finalMessage += "Hacks removed.";
                }
                catch (UnauthorizedAccessException ex)
                {
                    finalMessage += "Could not remove hacks. Run this program as an administrator";
                }
            }

            finalMessage += "\n\nOperation completed.";
            MessageBox.Show(finalMessage);
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            string exePath = tbFileLocation.Text;
            bool doApply = true;

            //If the file name is not Game.exe, warn the user of their own stupidity
            string fileName = Path.GetFileName(exePath);
            
            if (!fileName.Equals("Game.exe"))
            {
                DialogResult result = MessageBox.Show("Are you certain that you want to patch " + fileName + "?\nYou could ruin the file if it's anything other than Island Xtreme Stunts.", "Unusual File Name", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes) {
                    DialogResult result2 = MessageBox.Show("Are you REALLY sure? This is your final warning.", "Last Warning", MessageBoxButtons.YesNo);

                    if (result2 == System.Windows.Forms.DialogResult.No)
                    {
                        doApply = false;
                    }
                }
            }


            if (doApply == true)
            {
                string finalMessage = "Operation Finished.\n";

                //Check if file exists at all
                if (File.Exists(exePath))
                {
                    byte[] virtualFile = File.ReadAllBytes(exePath);
                    bool writeVirtualFile = false;

                    //Check for bad exe version
                    byte[] badVersionBytes = { 0x9C, 0xF4, 0x9B, 0xC2 };
                    long badVersionOffset = 0x80;

                    if (virtualFile[badVersionOffset] == badVersionBytes[0] &&
                        virtualFile[badVersionOffset + 1] == badVersionBytes[1] &&
                        virtualFile[badVersionOffset + 2] == badVersionBytes[2] &&
                        virtualFile[badVersionOffset + 3] == badVersionBytes[3])
                    {
                        finalMessage += "\nUnsupported version detected. Use the patch mentioned in the Readme.";
                    }
                    else
                    {

                        //Backup file 
                        {
                            string backupPath = exePath + ".bak";

                            if (!File.Exists(backupPath))
                            {
                                try
                                {
                                    File.WriteAllBytes(backupPath, virtualFile);
                                    finalMessage += "\nMade a backup file.";
                                }
                                catch (UnauthorizedAccessException ex)
                                {
                                    finalMessage += "\nBackup file was not made. Run this program as an administrator.";
                                }
                            }
                        }

                        //Check if dimentions are valid
                        bool validResolution = true;

                        int width = StringToInt(tbWidth.Text);
                        int height = StringToInt(tbHeight.Text);

                        int toReplace = getToReplace();

                        if (width != 0 && height != 0)
                        {
                            byte[] widthBytes = BitConverter.GetBytes(width);
                            byte[] heightBytes = BitConverter.GetBytes(height);

                            for (int i = 0; i < 4; i++)
                            {
                                virtualFile[widthOffset[toReplace] + i] = widthBytes[i];
                                virtualFile[heightOffset[toReplace] + i] = heightBytes[i];
                            }

                            //Write new resolution strings
                            byte[] stringBytes = Encoding.ASCII.GetBytes(createResolutionString(toReplace));

                            for (int i = 0; i < stringLength[toReplace]; i++)
                            {
                                virtualFile[stringOffset[toReplace] + i] = stringBytes[i];
                            }

                            writeVirtualFile = true;
                            finalMessage += "\nWrote resolution " + width + "x" + height + ".";
                        }
                        else
                        {
                            validResolution = false;
                            finalMessage += "\nInvalid resolution input. Ignored.";
                        }

                        //Handle aspect ratio and fov
                        if (rbDoNothing.Checked == false)
                        {
                            float aspect = 4f / 3f;
                            bool writeFOV = true;

                            //Automatic aspect ratio
                            if (rbAuto.Checked == true)
                            {
                                //If valid resolution was entered, use those values
                                if (validResolution == true)
                                {
                                    aspect = (float)width / (float)height;
                                }
                                //Find resolution in file
                                else
                                {
                                    long wo = widthOffset[toReplace];
                                    long ho = heightOffset[toReplace];

                                    byte[] widthBytes = { virtualFile[wo], virtualFile[wo + 1], virtualFile[wo + 2], virtualFile[wo + 3] };
                                    byte[] heightBytes = { virtualFile[ho], virtualFile[ho + 1], virtualFile[ho + 2], virtualFile[ho + 3] };

                                    int foundWidth = BitConverter.ToInt32(widthBytes, 0);
                                    int foundHeight = BitConverter.ToInt32(heightBytes, 0);

                                    aspect = (float)foundWidth / (float)foundHeight;
                                }
                            }

                            //Custom fov
                            else
                            {
                                int aspW = StringToInt(tbAspectWidth.Text);
                                int aspH = StringToInt(tbAspectHeight.Text);

                                if (aspW != 0 && aspH != 0)
                                {
                                    aspect = (float)aspW / (float)aspH;
                                }
                                else
                                {
                                    writeFOV = false;
                                    finalMessage += "\nInvalid aspect ratio input. Ignored.";
                                }
                            }

                            //Convert data to bytes                
                            byte[] aspectBytes = BitConverter.GetBytes(aspect);

                            //Write values
                            if (writeFOV == true)
                            {
                                int fov = (int)(384f * aspect);

                                //Verified aspect ratios. Should be replaced with a perfect calculation algorithm
                                if (aspect == 4 / 3)
                                {
                                    fov = 512;
                                }
                                else if (aspect == 16 / 10)
                                {
                                    fov = 602;
                                }
                                else if (aspect == 16 / 9 || aspect == 1366 / 768)
                                {
                                    fov = 658;
                                }

                                byte[] fovBytes = BitConverter.GetBytes(fov);

                                for (int i = 0; i < 2; i++)
                                {
                                    virtualFile[fovOffset + i] = fovBytes[i];
                                }

                                for (int i = 0; i < 4; i++)
                                {
                                    virtualFile[aspectOffset + i] = aspectBytes[i];
                                }

                                writeVirtualFile = true;

                                finalMessage += "\nWrote aspect ratio " + aspect + ".";
                            }
                        }
                        else
                        {
                            finalMessage += "\nIgnored aspect ratio.";
                        }

                        if (writeVirtualFile == true)
                        {
                            try
                            {
                                File.WriteAllBytes(tbFileLocation.Text, virtualFile);
                                finalMessage += "\nPatched file successfully.";
                            }
                            catch (UnauthorizedAccessException ex)
                            {
                                finalMessage += "\n\nError: File was not patched. Run this program as an administrator.";
                            }
                        }
                        else
                        {
                            finalMessage += "\n\nNothing needed to be done, so nothing was done.";
                        }
                    }
                }
                else
                {
                    finalMessage += "File not found. Nothing was done.";
                }

                MessageBox.Show(finalMessage);
            }
        }


        private string createResolutionString(int index)
        {
            string result = "";

            result = tbWidth.Text.Trim() + "X" + tbHeight.Text.Trim();

            //Fill in sides with spaces
            int side = 1;
            while (result.Length < stringLength[index])
            {
                if (side == 1)
                {
                    side = 0;
                    result = " " + result;
                }
                else if (side == 0)
                {
                    side = 1;
                    result = result + " ";
                }
            }

            return result;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            programStart();
        }


        //Returns 0 if the string is not a number or less than zero
        private int StringToInt(String s)
        {
            if (s == "")
            {
                s = " ";
            }

            if (s.All(char.IsDigit) == true)
            {
                int result = Int32.Parse(s);

                if (result > 0)
                {
                    return result;
                }
            }

            return 0;
        }

    }
}
