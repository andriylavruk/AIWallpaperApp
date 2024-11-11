namespace AIWallpaperApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPrompt = new TextBox();
            btnGenerate = new Button();
            picBox = new PictureBox();
            btnSetWallpaper = new Button();
            prgImageGeneration = new ProgressBar();
            btnSelecFile = new Button();
            lblTitle = new Label();
            lblImageTip = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // textBoxPrompt
            // 
            textBoxPrompt.Location = new Point(12, 61);
            textBoxPrompt.Name = "textBoxPrompt";
            textBoxPrompt.PlaceholderText = "Enter your prompt";
            textBoxPrompt.Size = new Size(432, 23);
            textBoxPrompt.TabIndex = 0;
            textBoxPrompt.TextChanged += textBoxPrompt_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Enabled = false;
            btnGenerate.Location = new Point(450, 61);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(85, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // picBox
            // 
            picBox.BackColor = Color.White;
            picBox.BorderStyle = BorderStyle.FixedSingle;
            picBox.Location = new Point(12, 90);
            picBox.Name = "picBox";
            picBox.Size = new Size(705, 397);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 2;
            picBox.TabStop = false;
            // 
            // btnSetWallpaper
            // 
            btnSetWallpaper.Location = new Point(541, 61);
            btnSetWallpaper.Name = "btnSetWallpaper";
            btnSetWallpaper.Size = new Size(85, 23);
            btnSetWallpaper.TabIndex = 3;
            btnSetWallpaper.Text = "Set wallpaper";
            btnSetWallpaper.UseVisualStyleBackColor = true;
            btnSetWallpaper.Click += btnSetWallpaper_Click;
            // 
            // prgImageGeneration
            // 
            prgImageGeneration.ForeColor = Color.FromArgb(0, 192, 0);
            prgImageGeneration.Location = new Point(12, 493);
            prgImageGeneration.MarqueeAnimationSpeed = 10;
            prgImageGeneration.Name = "prgImageGeneration";
            prgImageGeneration.RightToLeft = RightToLeft.No;
            prgImageGeneration.Size = new Size(705, 23);
            prgImageGeneration.Style = ProgressBarStyle.Marquee;
            prgImageGeneration.TabIndex = 4;
            prgImageGeneration.Visible = false;
            // 
            // btnSelecFile
            // 
            btnSelecFile.Location = new Point(632, 61);
            btnSelecFile.Name = "btnSelecFile";
            btnSelecFile.Size = new Size(85, 23);
            btnSelecFile.TabIndex = 5;
            btnSelecFile.Text = "Select file";
            btnSelecFile.UseVisualStyleBackColor = true;
            btnSelecFile.Click += btnSelecFile_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(218, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(305, 37);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "AI wallpaper application";
            // 
            // lblImageTip
            // 
            lblImageTip.BackColor = Color.White;
            lblImageTip.Font = new Font("Segoe UI", 20F);
            lblImageTip.Location = new Point(111, 241);
            lblImageTip.Name = "lblImageTip";
            lblImageTip.Size = new Size(507, 94);
            lblImageTip.TabIndex = 7;
            lblImageTip.Text = "Enter prompt and generate an image or select an image from the folder";
            lblImageTip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 527);
            Controls.Add(lblImageTip);
            Controls.Add(lblTitle);
            Controls.Add(btnSelecFile);
            Controls.Add(prgImageGeneration);
            Controls.Add(btnSetWallpaper);
            Controls.Add(picBox);
            Controls.Add(btnGenerate);
            Controls.Add(textBoxPrompt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "AIWallpaperApp";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrompt;
        private Button btnGenerate;
        private PictureBox picBox;
        private Button btnSetWallpaper;
        private ProgressBar prgImageGeneration;
        private Button btnSelecFile;
        private Label lblTitle;
        private Label lblImageTip;
    }
}
