namespace ITEP_103_MATH_GAME
{
    partial class Game
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
            this.lb1Q = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.plyerhp = new System.Windows.Forms.ProgressBar();
            this.mobhp = new System.Windows.Forms.ProgressBar();
            this.enemypic = new System.Windows.Forms.PictureBox();
            this.palyerpic = new System.Windows.Forms.PictureBox();
            this.pb1q = new System.Windows.Forms.PictureBox();
            this.Scrlb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemypic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palyerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1Q
            // 
            this.lb1Q.BackColor = System.Drawing.Color.Transparent;
            this.lb1Q.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb1Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1Q.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb1Q.Location = new System.Drawing.Point(416, 285);
            this.lb1Q.Name = "lb1Q";
            this.lb1Q.Size = new System.Drawing.Size(416, 31);
            this.lb1Q.TabIndex = 1;
            this.lb1Q.Text = "label1";
            this.lb1Q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 90);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChkAnsEvnt);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 90);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChkAnsEvnt);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(643, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 90);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChkAnsEvnt);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(945, 588);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(296, 90);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ChkAnsEvnt);
            // 
            // plyerhp
            // 
            this.plyerhp.Location = new System.Drawing.Point(80, 21);
            this.plyerhp.Name = "plyerhp";
            this.plyerhp.Size = new System.Drawing.Size(296, 32);
            this.plyerhp.TabIndex = 8;
            this.plyerhp.Value = 100;
            // 
            // mobhp
            // 
            this.mobhp.BackColor = System.Drawing.Color.DarkRed;
            this.mobhp.ForeColor = System.Drawing.Color.Red;
            this.mobhp.Location = new System.Drawing.Point(1014, 554);
            this.mobhp.Name = "mobhp";
            this.mobhp.Size = new System.Drawing.Size(151, 14);
            this.mobhp.TabIndex = 9;
            this.mobhp.Value = 100;
            // 
            // enemypic
            // 
            this.enemypic.BackColor = System.Drawing.Color.Transparent;
            this.enemypic.Image = global::ITEP_103_MATH_GAME.Properties.Resources.boss1_still;
            this.enemypic.Location = new System.Drawing.Point(874, 284);
            this.enemypic.Name = "enemypic";
            this.enemypic.Size = new System.Drawing.Size(304, 216);
            this.enemypic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemypic.TabIndex = 7;
            this.enemypic.TabStop = false;
            // 
            // palyerpic
            // 
            this.palyerpic.BackColor = System.Drawing.Color.Transparent;
            this.palyerpic.Image = global::ITEP_103_MATH_GAME.Properties.Resources.char3;
            this.palyerpic.Location = new System.Drawing.Point(80, 362);
            this.palyerpic.Name = "palyerpic";
            this.palyerpic.Size = new System.Drawing.Size(150, 150);
            this.palyerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.palyerpic.TabIndex = 6;
            this.palyerpic.TabStop = false;
            // 
            // pb1q
            // 
            this.pb1q.BackColor = System.Drawing.Color.Black;
            this.pb1q.Image = global::ITEP_103_MATH_GAME.Properties.Resources.question;
            this.pb1q.Location = new System.Drawing.Point(302, 79);
            this.pb1q.Name = "pb1q";
            this.pb1q.Size = new System.Drawing.Size(640, 203);
            this.pb1q.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1q.TabIndex = 0;
            this.pb1q.TabStop = false;
            // 
            // Scrlb1
            // 
            this.Scrlb1.AutoSize = true;
            this.Scrlb1.BackColor = System.Drawing.Color.Transparent;
            this.Scrlb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scrlb1.ForeColor = System.Drawing.Color.White;
            this.Scrlb1.Location = new System.Drawing.Point(490, 21);
            this.Scrlb1.Name = "Scrlb1";
            this.Scrlb1.Size = new System.Drawing.Size(31, 32);
            this.Scrlb1.TabIndex = 11;
            this.Scrlb1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "HP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ITEP_103_MATH_GAME.Properties.Resources.ground;
            this.pictureBox1.Location = new System.Drawing.Point(-76, -287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 931);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ITEP_103_MATH_GAME.Properties.Resources.Settings;
            this.pictureBox2.Location = new System.Drawing.Point(1219, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // playername
            // 
            this.playername.AutoSize = true;
            this.playername.BackColor = System.Drawing.Color.Transparent;
            this.playername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playername.ForeColor = System.Drawing.Color.Black;
            this.playername.Location = new System.Drawing.Point(100, 322);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(70, 25);
            this.playername.TabIndex = 16;
            this.playername.Text = "label3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITEP_103_MATH_GAME.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 708);
            this.Controls.Add(this.playername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb1Q);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scrlb1);
            this.Controls.Add(this.mobhp);
            this.Controls.Add(this.plyerhp);
            this.Controls.Add(this.palyerpic);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb1q);
            this.Controls.Add(this.enemypic);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.enemypic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palyerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1q;
        private System.Windows.Forms.Label lb1Q;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox palyerpic;
        private System.Windows.Forms.PictureBox enemypic;
        private System.Windows.Forms.ProgressBar plyerhp;
        private System.Windows.Forms.ProgressBar mobhp;
        private System.Windows.Forms.Label Scrlb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label playername;
    }
}