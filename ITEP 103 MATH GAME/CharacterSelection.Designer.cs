namespace ITEP_103_MATH_GAME
{
    partial class CharacterSelection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Playerpic = new System.Windows.Forms.PictureBox();
            this.Playername = new System.Windows.Forms.TextBox();
            this.Playerslect = new System.Windows.Forms.ComboBox();
            this.Playerlabel = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Playerslect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 696);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.Enter);
            this.panel2.Controls.Add(this.Playername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(227, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 166);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Playerlabel);
            this.panel3.Controls.Add(this.Playerpic);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(227, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 530);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Character";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your name";
            // 
            // Playerpic
            // 
            this.Playerpic.Image = global::ITEP_103_MATH_GAME.Properties.Resources.char1;
            this.Playerpic.Location = new System.Drawing.Point(381, 130);
            this.Playerpic.Name = "Playerpic";
            this.Playerpic.Size = new System.Drawing.Size(248, 271);
            this.Playerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playerpic.TabIndex = 1;
            this.Playerpic.TabStop = false;
            // 
            // Playername
            // 
            this.Playername.Location = new System.Drawing.Point(100, 79);
            this.Playername.Name = "Playername";
            this.Playername.Size = new System.Drawing.Size(546, 22);
            this.Playername.TabIndex = 2;
            // 
            // Playerslect
            // 
            this.Playerslect.FormattingEnabled = true;
            this.Playerslect.Items.AddRange(new object[] {
            "Character 1",
            "Character 2",
            "Character 3"});
            this.Playerslect.Location = new System.Drawing.Point(3, 55);
            this.Playerslect.Name = "Playerslect";
            this.Playerslect.Size = new System.Drawing.Size(218, 24);
            this.Playerslect.TabIndex = 0;
            // 
            // Playerlabel
            // 
            this.Playerlabel.AutoSize = true;
            this.Playerlabel.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playerlabel.Location = new System.Drawing.Point(372, 428);
            this.Playerlabel.Name = "Playerlabel";
            this.Playerlabel.Size = new System.Drawing.Size(274, 51);
            this.Playerlabel.TabIndex = 2;
            this.Playerlabel.Text = "Character 1";
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(796, 40);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(163, 73);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // CharacterSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 696);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterSelection";
            this.Text = "CharacterSelection";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Playerpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Playername;
        private System.Windows.Forms.ComboBox Playerslect;
        private System.Windows.Forms.Label Playerlabel;
        private System.Windows.Forms.Button Enter;
    }
}