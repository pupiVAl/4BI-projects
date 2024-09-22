namespace UnisciArray
{
    partial class MainForm
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
            arrayText1 = new TextBox();
            arrayText2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEnter = new Button();
            arrayUnione = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // arrayText1
            // 
            arrayText1.Location = new Point(66, 40);
            arrayText1.Name = "arrayText1";
            arrayText1.Size = new Size(150, 23);
            arrayText1.TabIndex = 0;
            // 
            // arrayText2
            // 
            arrayText2.Location = new Point(306, 40);
            arrayText2.Name = "arrayText2";
            arrayText2.Size = new Size(150, 23);
            arrayText2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 48);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "array 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 48);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "array 2:";
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEnter.BackColor = Color.YellowGreen;
            btnEnter.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(225, 75);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 25);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "UNISCI";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += button2_Click;
            // 
            // arrayUnione
            // 
            arrayUnione.Location = new Point(99, 129);
            arrayUnione.Name = "arrayUnione";
            arrayUnione.ReadOnly = true;
            arrayUnione.Size = new Size(297, 23);
            arrayUnione.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 137);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "array unione:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 9);
            label4.Name = "label4";
            label4.Size = new Size(296, 15);
            label4.TabIndex = 8;
            label4.Text = "scrivi ogni numero diviso da solo una virgola. (Ex 1,2,3)\r\n";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.LightCoral;
            btnClear.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(402, 127);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 25);
            btnClear.TabIndex = 9;
            btnClear.Text = "PULISCI";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 161);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(arrayUnione);
            Controls.Add(btnEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(arrayText2);
            Controls.Add(arrayText1);
            MaximumSize = new Size(500, 200);
            MinimumSize = new Size(500, 200);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unisci Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox arrayText1;
        private TextBox arrayText2;
        private Label label1;
        private Label label2;
        private Button btnEnter;
        private TextBox arrayUnione;
        private Label label3;
        private Label label4;
        private Button btnClear;
    }
}
