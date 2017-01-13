namespace IXS_Widescreen_Utility
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDoNothing = new System.Windows.Forms.RadioButton();
            this.tbAspectHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAspectWidth = new System.Windows.Forms.TextBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.gbResolutions = new System.Windows.Forms.GroupBox();
            this.rbRes4 = new System.Windows.Forms.RadioButton();
            this.rbRes3 = new System.Windows.Forms.RadioButton();
            this.rbRes2 = new System.Windows.Forms.RadioButton();
            this.rbRes1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbResolutions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Location = new System.Drawing.Point(12, 12);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(484, 20);
            this.tbFileLocation.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(404, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(49, 13);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(45, 20);
            this.tbWidth.TabIndex = 0;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(49, 41);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(45, 20);
            this.tbHeight.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDoNothing);
            this.groupBox1.Controls.Add(this.tbAspectHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAspectWidth);
            this.groupBox1.Controls.Add(this.rbCustom);
            this.groupBox1.Controls.Add(this.rbAuto);
            this.groupBox1.Location = new System.Drawing.Point(129, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aspect Ratio";
            // 
            // rbDoNothing
            // 
            this.rbDoNothing.AutoSize = true;
            this.rbDoNothing.Checked = true;
            this.rbDoNothing.Location = new System.Drawing.Point(7, 15);
            this.rbDoNothing.Name = "rbDoNothing";
            this.rbDoNothing.Size = new System.Drawing.Size(79, 17);
            this.rbDoNothing.TabIndex = 0;
            this.rbDoNothing.TabStop = true;
            this.rbDoNothing.Text = "Do Nothing";
            this.rbDoNothing.UseVisualStyleBackColor = true;
            // 
            // tbAspectHeight
            // 
            this.tbAspectHeight.Location = new System.Drawing.Point(86, 60);
            this.tbAspectHeight.Name = "tbAspectHeight";
            this.tbAspectHeight.Size = new System.Drawing.Size(35, 20);
            this.tbAspectHeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // tbAspectWidth
            // 
            this.tbAspectWidth.Location = new System.Drawing.Point(29, 60);
            this.tbAspectWidth.Name = "tbAspectWidth";
            this.tbAspectWidth.Size = new System.Drawing.Size(35, 20);
            this.tbAspectWidth.TabIndex = 3;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(7, 61);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(28, 17);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.Text = " ";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(7, 38);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(47, 17);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.Text = "Auto";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbWidth);
            this.groupBox2.Controls.Add(this.tbHeight);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Resolution";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(404, 128);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(92, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.Location = new System.Drawing.Point(404, 67);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(92, 23);
            this.btnAutoFill.TabIndex = 2;
            this.btnAutoFill.Text = "Auto Fill";
            this.btnAutoFill.UseVisualStyleBackColor = true;
            this.btnAutoFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbResolutions
            // 
            this.gbResolutions.Controls.Add(this.rbRes4);
            this.gbResolutions.Controls.Add(this.rbRes3);
            this.gbResolutions.Controls.Add(this.rbRes2);
            this.gbResolutions.Controls.Add(this.rbRes1);
            this.gbResolutions.Location = new System.Drawing.Point(268, 40);
            this.gbResolutions.Name = "gbResolutions";
            this.gbResolutions.Size = new System.Drawing.Size(130, 111);
            this.gbResolutions.TabIndex = 8;
            this.gbResolutions.TabStop = false;
            this.gbResolutions.Text = "Resolution To Replace";
            // 
            // rbRes4
            // 
            this.rbRes4.AutoSize = true;
            this.rbRes4.Location = new System.Drawing.Point(6, 88);
            this.rbRes4.Name = "rbRes4";
            this.rbRes4.Size = new System.Drawing.Size(78, 17);
            this.rbRes4.TabIndex = 3;
            this.rbRes4.Text = "1280x1024";
            this.rbRes4.UseVisualStyleBackColor = true;
            // 
            // rbRes3
            // 
            this.rbRes3.AutoSize = true;
            this.rbRes3.Location = new System.Drawing.Point(6, 65);
            this.rbRes3.Name = "rbRes3";
            this.rbRes3.Size = new System.Drawing.Size(72, 17);
            this.rbRes3.TabIndex = 2;
            this.rbRes3.Text = "1024x768";
            this.rbRes3.UseVisualStyleBackColor = true;
            // 
            // rbRes2
            // 
            this.rbRes2.AutoSize = true;
            this.rbRes2.Location = new System.Drawing.Point(6, 42);
            this.rbRes2.Name = "rbRes2";
            this.rbRes2.Size = new System.Drawing.Size(66, 17);
            this.rbRes2.TabIndex = 1;
            this.rbRes2.Text = "800x600";
            this.rbRes2.UseVisualStyleBackColor = true;
            // 
            // rbRes1
            // 
            this.rbRes1.AutoSize = true;
            this.rbRes1.Checked = true;
            this.rbRes1.Location = new System.Drawing.Point(6, 19);
            this.rbRes1.Name = "rbRes1";
            this.rbRes1.Size = new System.Drawing.Size(66, 17);
            this.rbRes1.TabIndex = 0;
            this.rbRes1.TabStop = true;
            this.rbRes1.Text = "640x480";
            this.rbRes1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 163);
            this.Controls.Add(this.gbResolutions);
            this.Controls.Add(this.btnAutoFill);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFileLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IXS Widescreen Tool v0.8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbResolutions.ResumeLayout(false);
            this.gbResolutions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAspectHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAspectWidth;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnAutoFill;
        private System.Windows.Forms.RadioButton rbDoNothing;
        private System.Windows.Forms.GroupBox gbResolutions;
        private System.Windows.Forms.RadioButton rbRes4;
        private System.Windows.Forms.RadioButton rbRes3;
        private System.Windows.Forms.RadioButton rbRes2;
        private System.Windows.Forms.RadioButton rbRes1;
    }
}

