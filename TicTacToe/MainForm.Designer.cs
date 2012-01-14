namespace TicTacToe
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
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.dumbDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.invencibleDifficultyRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.humanScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resetScoresButton = new System.Windows.Forms.Button();
            this.backgroundPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.White;
            this.panel0.Location = new System.Drawing.Point(0, 0);
            this.panel0.Margin = new System.Windows.Forms.Padding(1);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(120, 120);
            this.panel0.TabIndex = 0;
            this.panel0.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(122, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 120);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(244, 122);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 120);
            this.panel5.TabIndex = 5;
            this.panel5.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(122, 122);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 120);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 120);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(244, 244);
            this.panel8.Margin = new System.Windows.Forms.Padding(1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 120);
            this.panel8.TabIndex = 8;
            this.panel8.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(122, 244);
            this.panel7.Margin = new System.Windows.Forms.Padding(1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 120);
            this.panel7.TabIndex = 7;
            this.panel7.Click += new System.EventHandler(this.Panel_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 244);
            this.panel6.Margin = new System.Windows.Forms.Padding(1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 120);
            this.panel6.TabIndex = 6;
            this.panel6.Click += new System.EventHandler(this.Panel_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.Black;
            this.backgroundPanel.Controls.Add(this.panel0);
            this.backgroundPanel.Controls.Add(this.panel8);
            this.backgroundPanel.Controls.Add(this.panel3);
            this.backgroundPanel.Controls.Add(this.panel5);
            this.backgroundPanel.Controls.Add(this.panel1);
            this.backgroundPanel.Controls.Add(this.panel7);
            this.backgroundPanel.Controls.Add(this.panel4);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Controls.Add(this.panel6);
            this.backgroundPanel.Location = new System.Drawing.Point(12, 12);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(364, 364);
            this.backgroundPanel.TabIndex = 9;
            // 
            // dumbDifficultyRadioButton
            // 
            this.dumbDifficultyRadioButton.AutoSize = true;
            this.dumbDifficultyRadioButton.Location = new System.Drawing.Point(21, 35);
            this.dumbDifficultyRadioButton.Name = "dumbDifficultyRadioButton";
            this.dumbDifficultyRadioButton.Size = new System.Drawing.Size(189, 22);
            this.dumbDifficultyRadioButton.TabIndex = 10;
            this.dumbDifficultyRadioButton.Text = "Dumb (testing purposes)";
            this.dumbDifficultyRadioButton.UseVisualStyleBackColor = true;
            this.dumbDifficultyRadioButton.CheckedChanged += new System.EventHandler(this.dumbDifficultyRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.invencibleDifficultyRadioButton);
            this.groupBox1.Controls.Add(this.dumbDifficultyRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(382, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computer Level";
            // 
            // invencibleDifficultyRadioButton
            // 
            this.invencibleDifficultyRadioButton.AutoSize = true;
            this.invencibleDifficultyRadioButton.Checked = true;
            this.invencibleDifficultyRadioButton.Location = new System.Drawing.Point(21, 66);
            this.invencibleDifficultyRadioButton.Name = "invencibleDifficultyRadioButton";
            this.invencibleDifficultyRadioButton.Size = new System.Drawing.Size(90, 22);
            this.invencibleDifficultyRadioButton.TabIndex = 11;
            this.invencibleDifficultyRadioButton.TabStop = true;
            this.invencibleDifficultyRadioButton.Text = "Invencible";
            this.invencibleDifficultyRadioButton.UseVisualStyleBackColor = true;
            this.invencibleDifficultyRadioButton.CheckedChanged += new System.EventHandler(this.invencibleDifficultyRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.computerScoreLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.humanScoreLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(382, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 120);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Human:";
            // 
            // humanScoreLabel
            // 
            this.humanScoreLabel.AutoSize = true;
            this.humanScoreLabel.Location = new System.Drawing.Point(133, 46);
            this.humanScoreLabel.Name = "humanScoreLabel";
            this.humanScoreLabel.Size = new System.Drawing.Size(16, 18);
            this.humanScoreLabel.TabIndex = 1;
            this.humanScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Location = new System.Drawing.Point(133, 78);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(16, 18);
            this.computerScoreLabel.TabIndex = 3;
            this.computerScoreLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Computer:";
            // 
            // resetScoresButton
            // 
            this.resetScoresButton.Location = new System.Drawing.Point(382, 264);
            this.resetScoresButton.Name = "resetScoresButton";
            this.resetScoresButton.Size = new System.Drawing.Size(96, 23);
            this.resetScoresButton.TabIndex = 13;
            this.resetScoresButton.Text = "Reset Scores";
            this.resetScoresButton.UseVisualStyleBackColor = true;
            this.resetScoresButton.Click += new System.EventHandler(this.resetScoresButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 388);
            this.Controls.Add(this.resetScoresButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.backgroundPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.RadioButton dumbDifficultyRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton invencibleDifficultyRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label humanScoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetScoresButton;

    }
}

