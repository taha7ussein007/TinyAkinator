namespace TinyAkinator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.minimize = new System.Windows.Forms.PictureBox();
            this.maxi_restore = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_why = new System.Windows.Forms.PictureBox();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.label_ProbablyNot = new System.Windows.Forms.Label();
            this.label_ProbablyYes = new System.Windows.Forms.Label();
            this.label_Unknown = new System.Windows.Forms.Label();
            this.label_No = new System.Windows.Forms.Label();
            this.label_Yes = new System.Windows.Forms.Label();
            this.label_Q_Num = new System.Windows.Forms.Label();
            this.label_Question = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_How = new System.Windows.Forms.Label();
            this.label_PlayAgain = new System.Windows.Forms.Label();
            this.result_string = new System.Windows.Forms.Label();
            this.result_img = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.playAgain_pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_How = new System.Windows.Forms.TextBox();
            this.textBox_why = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_why)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.result_img)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.BackgroundImage = global::TinyAkinator.Properties.Resources.minimize;
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Location = new System.Drawing.Point(1166, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maxi_restore
            // 
            this.maxi_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxi_restore.BackColor = System.Drawing.Color.Transparent;
            this.maxi_restore.BackgroundImage = global::TinyAkinator.Properties.Resources.maximize;
            this.maxi_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxi_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxi_restore.Location = new System.Drawing.Point(1202, 12);
            this.maxi_restore.Name = "maxi_restore";
            this.maxi_restore.Size = new System.Drawing.Size(30, 30);
            this.maxi_restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maxi_restore.TabIndex = 1;
            this.maxi_restore.TabStop = false;
            this.maxi_restore.Click += new System.EventHandler(this.maxi_restore_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::TinyAkinator.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(1238, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.textBox_age);
            this.panel1.Location = new System.Drawing.Point(467, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // play
            // 
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Location = new System.Drawing.Point(76, 61);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(74, 23);
            this.play.TabIndex = 1;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // textBox_age
            // 
            this.textBox_age.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_age.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(8, 14);
            this.textBox_age.MaxLength = 3;
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(180, 23);
            this.textBox_age.TabIndex = 0;
            this.textBox_age.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox_why);
            this.panel2.Controls.Add(this.pictureBox_why);
            this.panel2.Controls.Add(this.pictureBox_Back);
            this.panel2.Controls.Add(this.label_ProbablyNot);
            this.panel2.Controls.Add(this.label_ProbablyYes);
            this.panel2.Controls.Add(this.label_Unknown);
            this.panel2.Controls.Add(this.label_No);
            this.panel2.Controls.Add(this.label_Yes);
            this.panel2.Controls.Add(this.label_Q_Num);
            this.panel2.Controls.Add(this.label_Question);
            this.panel2.Location = new System.Drawing.Point(285, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 500);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox_why
            // 
            this.pictureBox_why.BackgroundImage = global::TinyAkinator.Properties.Resources.why;
            this.pictureBox_why.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_why.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_why.Location = new System.Drawing.Point(66, 17);
            this.pictureBox_why.Name = "pictureBox_why";
            this.pictureBox_why.Size = new System.Drawing.Size(58, 56);
            this.pictureBox_why.TabIndex = 11;
            this.pictureBox_why.TabStop = false;
            this.pictureBox_why.Visible = false;
            this.pictureBox_why.Click += new System.EventHandler(this.pictureBox_why_Click);
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.BackgroundImage = global::TinyAkinator.Properties.Resources.back;
            this.pictureBox_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Back.Location = new System.Drawing.Point(66, 79);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(58, 56);
            this.pictureBox_Back.TabIndex = 10;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Visible = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.pictureBox_Back_Click);
            // 
            // label_ProbablyNot
            // 
            this.label_ProbablyNot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ProbablyNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ProbablyNot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProbablyNot.Location = new System.Drawing.Point(190, 414);
            this.label_ProbablyNot.Name = "label_ProbablyNot";
            this.label_ProbablyNot.Size = new System.Drawing.Size(204, 31);
            this.label_ProbablyNot.TabIndex = 9;
            this.label_ProbablyNot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ProbablyNot.Click += new System.EventHandler(this.label_ProbablyNot_Click);
            // 
            // label_ProbablyYes
            // 
            this.label_ProbablyYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ProbablyYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_ProbablyYes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProbablyYes.Location = new System.Drawing.Point(190, 372);
            this.label_ProbablyYes.Name = "label_ProbablyYes";
            this.label_ProbablyYes.Size = new System.Drawing.Size(204, 31);
            this.label_ProbablyYes.TabIndex = 8;
            this.label_ProbablyYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ProbablyYes.Click += new System.EventHandler(this.label_ProbablyYes_Click);
            // 
            // label_Unknown
            // 
            this.label_Unknown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Unknown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Unknown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Unknown.Location = new System.Drawing.Point(190, 329);
            this.label_Unknown.Name = "label_Unknown";
            this.label_Unknown.Size = new System.Drawing.Size(204, 31);
            this.label_Unknown.TabIndex = 7;
            this.label_Unknown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Unknown.Click += new System.EventHandler(this.label_Unknown_Click);
            // 
            // label_No
            // 
            this.label_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_No.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_No.Location = new System.Drawing.Point(190, 288);
            this.label_No.Name = "label_No";
            this.label_No.Size = new System.Drawing.Size(204, 31);
            this.label_No.TabIndex = 6;
            this.label_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_No.Click += new System.EventHandler(this.label_No_Click);
            // 
            // label_Yes
            // 
            this.label_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Yes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Yes.Location = new System.Drawing.Point(190, 244);
            this.label_Yes.Name = "label_Yes";
            this.label_Yes.Size = new System.Drawing.Size(204, 31);
            this.label_Yes.TabIndex = 5;
            this.label_Yes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Yes.Click += new System.EventHandler(this.label_Yes_Click);
            // 
            // label_Q_Num
            // 
            this.label_Q_Num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Q_Num.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Q_Num.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Q_Num.Location = new System.Drawing.Point(216, 17);
            this.label_Q_Num.Name = "label_Q_Num";
            this.label_Q_Num.Size = new System.Drawing.Size(71, 24);
            this.label_Q_Num.TabIndex = 5;
            this.label_Q_Num.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Question
            // 
            this.label_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Question.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(144, 52);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(283, 137);
            this.label_Question.TabIndex = 0;
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label_How);
            this.panel3.Controls.Add(this.label_PlayAgain);
            this.panel3.Controls.Add(this.result_string);
            this.panel3.Controls.Add(this.result_img);
            this.panel3.Location = new System.Drawing.Point(391, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 645);
            this.panel3.TabIndex = 5;
            // 
            // label_How
            // 
            this.label_How.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_How.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_How.Location = new System.Drawing.Point(50, 577);
            this.label_How.Name = "label_How";
            this.label_How.Size = new System.Drawing.Size(204, 31);
            this.label_How.TabIndex = 6;
            this.label_How.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_How.Click += new System.EventHandler(this.label_How_Click);
            // 
            // label_PlayAgain
            // 
            this.label_PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_PlayAgain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PlayAgain.Location = new System.Drawing.Point(286, 577);
            this.label_PlayAgain.Name = "label_PlayAgain";
            this.label_PlayAgain.Size = new System.Drawing.Size(204, 31);
            this.label_PlayAgain.TabIndex = 5;
            this.label_PlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_PlayAgain.Click += new System.EventHandler(this.label_PlayAgain_Click);
            // 
            // result_string
            // 
            this.result_string.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_string.ForeColor = System.Drawing.Color.DarkRed;
            this.result_string.Location = new System.Drawing.Point(107, 382);
            this.result_string.Name = "result_string";
            this.result_string.Size = new System.Drawing.Size(298, 86);
            this.result_string.TabIndex = 5;
            this.result_string.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // result_img
            // 
            this.result_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.result_img.Location = new System.Drawing.Point(131, 14);
            this.result_img.Name = "result_img";
            this.result_img.Size = new System.Drawing.Size(274, 225);
            this.result_img.TabIndex = 7;
            this.result_img.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.playAgain_pictureBox);
            this.panel4.Controls.Add(this.textBox_How);
            this.panel4.Location = new System.Drawing.Point(12, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1148, 690);
            this.panel4.TabIndex = 6;
            // 
            // playAgain_pictureBox
            // 
            this.playAgain_pictureBox.BackgroundImage = global::TinyAkinator.Properties.Resources.replay1;
            this.playAgain_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playAgain_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgain_pictureBox.Location = new System.Drawing.Point(803, 531);
            this.playAgain_pictureBox.Name = "playAgain_pictureBox";
            this.playAgain_pictureBox.Size = new System.Drawing.Size(106, 67);
            this.playAgain_pictureBox.TabIndex = 1;
            this.playAgain_pictureBox.TabStop = false;
            this.playAgain_pictureBox.Click += new System.EventHandler(this.playAgain_pictureBox_Click);
            // 
            // textBox_How
            // 
            this.textBox_How.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_How.Location = new System.Drawing.Point(421, 245);
            this.textBox_How.Multiline = true;
            this.textBox_How.Name = "textBox_How";
            this.textBox_How.ReadOnly = true;
            this.textBox_How.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_How.Size = new System.Drawing.Size(296, 406);
            this.textBox_How.TabIndex = 0;
            this.textBox_How.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_why
            // 
            this.textBox_why.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_why.Location = new System.Drawing.Point(616, 171);
            this.textBox_why.Multiline = true;
            this.textBox_why.Name = "textBox_why";
            this.textBox_why.ReadOnly = true;
            this.textBox_why.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_why.Size = new System.Drawing.Size(246, 317);
            this.textBox_why.TabIndex = 12;
            this.textBox_why.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_why.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TinyAkinator.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.maxi_restore);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiny Akinator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_why)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.result_img)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playAgain_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox maxi_restore;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label play;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Label label_Q_Num;
        private System.Windows.Forms.Label label_ProbablyNot;
        private System.Windows.Forms.Label label_ProbablyYes;
        private System.Windows.Forms.Label label_Unknown;
        private System.Windows.Forms.Label label_No;
        private System.Windows.Forms.Label label_Yes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_How;
        private System.Windows.Forms.Label label_PlayAgain;
        private System.Windows.Forms.Label result_string;
        private System.Windows.Forms.PictureBox result_img;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_How;
        private System.Windows.Forms.PictureBox playAgain_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.PictureBox pictureBox_why;
        private System.Windows.Forms.TextBox textBox_why;
    }
}

