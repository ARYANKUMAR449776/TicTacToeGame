namespace TicTacToeGame
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnRestart = new Button();
            lblXwins = new Label();
            lblOWins = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 64);
            button1.Name = "button1";
            button1.Size = new Size(94, 85);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayerClick;
            // 
            // button2
            // 
            button2.Location = new Point(173, 64);
            button2.Name = "button2";
            button2.Size = new Size(94, 84);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayerClick;
            // 
            // button3
            // 
            button3.Location = new Point(288, 64);
            button3.Name = "button3";
            button3.Size = new Size(94, 85);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayerClick;
            // 
            // button4
            // 
            button4.Location = new Point(58, 166);
            button4.Name = "button4";
            button4.Size = new Size(94, 86);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerClick;
            // 
            // button5
            // 
            button5.Location = new Point(173, 167);
            button5.Name = "button5";
            button5.Size = new Size(94, 85);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayerClick;
            // 
            // button6
            // 
            button6.Location = new Point(288, 167);
            button6.Name = "button6";
            button6.Size = new Size(94, 85);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayerClick;
            // 
            // button7
            // 
            button7.Location = new Point(58, 271);
            button7.Name = "button7";
            button7.Size = new Size(94, 85);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayerClick;
            // 
            // button8
            // 
            button8.Location = new Point(173, 271);
            button8.Name = "button8";
            button8.Size = new Size(94, 85);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayerClick;
            // 
            // button9
            // 
            button9.Location = new Point(288, 271);
            button9.Name = "button9";
            button9.Size = new Size(94, 85);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayerClick;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.FromArgb(222, 209, 182);
            btnRestart.Font = new Font("Stencil", 10F);
            btnRestart.ForeColor = Color.Brown;
            btnRestart.Location = new Point(2, 388);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(434, 45);
            btnRestart.TabIndex = 9;
            btnRestart.Text = "Restart Rounds";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblXwins
            // 
            lblXwins.AutoSize = true;
            lblXwins.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblXwins.ForeColor = Color.Brown;
            lblXwins.Location = new Point(26, 21);
            lblXwins.Name = "lblXwins";
            lblXwins.Size = new Size(0, 20);
            lblXwins.TabIndex = 10;
            // 
            // lblOWins
            // 
            lblOWins.AutoSize = true;
            lblOWins.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOWins.ForeColor = Color.Brown;
            lblOWins.Location = new Point(259, 21);
            lblOWins.Name = "lblOWins";
            lblOWins.Size = new Size(0, 20);
            lblOWins.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 445);
            Controls.Add(lblOWins);
            Controls.Add(lblXwins);
            Controls.Add(btnRestart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Coral;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnRestart;
        private Label lblXwins;
        private Label lblOWins;
    }
}
