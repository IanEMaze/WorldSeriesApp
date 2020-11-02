namespace WorldSeriesApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamNameBox = new System.Windows.Forms.TextBox();
            this.numWinsBox = new System.Windows.Forms.TextBox();
            this.hasTeamWonBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.getSummary = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "World Series App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "This App with read data from a text file and display a list of baseball teams. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(831, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "The user will then select a team and the program with show if that team has won t" +
    "he World Series and how many times they won.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(646, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team Summary";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.teamNameBox);
            this.groupBox1.Controls.Add(this.numWinsBox);
            this.groupBox1.Controls.Add(this.hasTeamWonBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(643, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Summary";
            // 
            // teamNameBox
            // 
            this.teamNameBox.Location = new System.Drawing.Point(9, 43);
            this.teamNameBox.Name = "teamNameBox";
            this.teamNameBox.Size = new System.Drawing.Size(180, 20);
            this.teamNameBox.TabIndex = 6;
            // 
            // numWinsBox
            // 
            this.numWinsBox.Location = new System.Drawing.Point(8, 130);
            this.numWinsBox.Name = "numWinsBox";
            this.numWinsBox.Size = new System.Drawing.Size(180, 20);
            this.numWinsBox.TabIndex = 5;
            // 
            // hasTeamWonBox
            // 
            this.hasTeamWonBox.Location = new System.Drawing.Point(9, 87);
            this.hasTeamWonBox.Name = "hasTeamWonBox";
            this.hasTeamWonBox.Size = new System.Drawing.Size(180, 20);
            this.hasTeamWonBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Number of wins: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Has this team won the World Series?:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Team Name: ";
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(382, 153);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(195, 173);
            this.teamListBox.TabIndex = 7;
            // 
            // getSummary
            // 
            this.getSummary.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSummary.Location = new System.Drawing.Point(479, 401);
            this.getSummary.Name = "getSummary";
            this.getSummary.Size = new System.Drawing.Size(119, 37);
            this.getSummary.TabIndex = 8;
            this.getSummary.Text = "Get Summary";
            this.getSummary.UseVisualStyleBackColor = true;
            this.getSummary.Click += new System.EventHandler(this.getSummary_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(626, 401);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(119, 37);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset ";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeWindow.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow.Location = new System.Drawing.Point(771, 401);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(119, 37);
            this.closeWindow.TabIndex = 10;
            this.closeWindow.Text = "E&xit ";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select team, Press Get Summary";
            // 
            // Form1
            // 
            this.AcceptButton = this.getSummary;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.closeWindow;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.getSummary);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "World Series App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button getSummary;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button closeWindow;
        private System.Windows.Forms.TextBox teamNameBox;
        private System.Windows.Forms.TextBox numWinsBox;
        private System.Windows.Forms.TextBox hasTeamWonBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

