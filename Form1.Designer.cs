﻿namespace Text_Adventure_Game
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            PlayerLabel = new Label();
            panel2 = new Panel();
            GameDisplayText = new Label();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(230, 233, 239);
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(PlayerLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1127, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2559052F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.051181F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.858268F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Size = new Size(242, 998);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(progressBar1);
            panel4.Location = new Point(5, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 80);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Power Green", 12F);
            label3.ForeColor = Color.FromArgb(76, 79, 105);
            label3.Location = new Point(84, 33);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 4;
            label3.Text = "100/100";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Power Green", 12F);
            label2.ForeColor = Color.FromArgb(76, 79, 105);
            label2.Location = new Point(89, 12);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Health";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 57);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(232, 23);
            progressBar1.TabIndex = 2;
            progressBar1.Value = 100;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 224, 232);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 142);
            panel1.TabIndex = 0;
            // 
            // PlayerLabel
            // 
            PlayerLabel.Anchor = AnchorStyles.None;
            PlayerLabel.AutoSize = true;
            PlayerLabel.Font = new Font("Power Green", 12F);
            PlayerLabel.ForeColor = Color.FromArgb(76, 79, 105);
            PlayerLabel.Location = new Point(94, 156);
            PlayerLabel.Name = "PlayerLabel";
            PlayerLabel.Size = new Size(53, 21);
            PlayerLabel.TabIndex = 1;
            PlayerLabel.Text = "Player";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(GameDisplayText);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1112, 721);
            panel2.TabIndex = 1;
            // 
            // GameDisplayText
            // 
            GameDisplayText.BackColor = Color.FromArgb(230, 233, 239);
            GameDisplayText.BorderStyle = BorderStyle.FixedSingle;
            GameDisplayText.Dock = DockStyle.Fill;
            GameDisplayText.Font = new Font("Power Green", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameDisplayText.ForeColor = Color.FromArgb(76, 79, 105);
            GameDisplayText.Location = new Point(0, 0);
            GameDisplayText.Name = "GameDisplayText";
            GameDisplayText.Size = new Size(1112, 721);
            GameDisplayText.TabIndex = 0;
            GameDisplayText.Text = "Welcome to the world of Pokémon, where creatures called Pokémon roam! Embark on adventures, battle other trainers, and strive to become a Pokémon Master! ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Location = new Point(3, 730);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 250);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 1, 0);
            tableLayoutPanel3.Controls.Add(button3, 0, 1);
            tableLayoutPanel3.Controls.Add(button4, 1, 1);
            tableLayoutPanel3.Location = new Point(5, 145);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tableLayoutPanel3.Size = new Size(1102, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Power Green Small", 9.75F);
            button1.ForeColor = Color.FromArgb(76, 79, 105);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(545, 42);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Power Green Small", 9.75F);
            button2.ForeColor = Color.FromArgb(76, 79, 105);
            button2.Location = new Point(554, 3);
            button2.Name = "button2";
            button2.Size = new Size(545, 42);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Power Green Small", 9.75F);
            button3.ForeColor = Color.FromArgb(76, 79, 105);
            button3.Location = new Point(3, 51);
            button3.Name = "button3";
            button3.Size = new Size(545, 46);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Dock = DockStyle.Fill;
            button4.Font = new Font("Power Green Small", 9.75F);
            button4.ForeColor = Color.FromArgb(76, 79, 105);
            button4.Location = new Point(554, 51);
            button4.Name = "button4";
            button4.Size = new Size(545, 46);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26F));
            tableLayoutPanel2.Size = new Size(1118, 983);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 241, 245);
            ClientSize = new Size(1369, 998);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label PlayerLabel;
        private ProgressBar progressBar1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label GameDisplayText;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
