namespace StaskoFyUpgraded.View
{
    partial class UpdateUser
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
            label3 = new Label();
            listBox2 = new ListBox();
            button3 = new Button();
            label2 = new Label();
            textBox8 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            button4 = new Button();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(198, 23);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(759, 70);
            label3.TabIndex = 12;
            label3.Text = "Menu for updating a user";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(15, -135);
            listBox2.Margin = new Padding(6, 5, 6, 5);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(592, 124);
            listBox2.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(223, 460);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(281, 57);
            button3.TabIndex = 15;
            button3.Text = "Return to Main";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(119, -282);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 70);
            label2.TabIndex = 14;
            label2.Text = "Choose a user\r\nto update:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.DarkGray;
            textBox8.ForeColor = Color.White;
            textBox8.Location = new Point(198, 228);
            textBox8.Margin = new Padding(6, 5, 6, 5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(330, 41);
            textBox8.TabIndex = 22;
            textBox8.Text = "Enter user's name:";
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.DarkGray;
            textBox10.ForeColor = Color.White;
            textBox10.Location = new Point(627, 205);
            textBox10.Margin = new Padding(6, 5, 6, 5);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(330, 41);
            textBox10.TabIndex = 20;
            textBox10.Text = "Enter user's fav artist id:";
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.DarkGray;
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(627, 273);
            textBox11.Margin = new Padding(6, 5, 6, 5);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(330, 41);
            textBox11.TabIndex = 19;
            textBox11.Text = "Enter user's fav album id:";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.DarkGray;
            textBox12.ForeColor = Color.White;
            textBox12.Location = new Point(627, 340);
            textBox12.Margin = new Padding(6, 5, 6, 5);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(330, 41);
            textBox12.TabIndex = 18;
            textBox12.Text = "Enter user's fav song id:";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.ForeColor = Color.White;
            button4.Location = new Point(653, 458);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(281, 59);
            button4.TabIndex = 17;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.DarkGray;
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(198, 300);
            textBox9.Margin = new Padding(6, 5, 6, 5);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(330, 41);
            textBox9.TabIndex = 21;
            textBox9.Text = "Enter user's password:";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1167, 616);
            Controls.Add(textBox8);
            Controls.Add(textBox9);
            Controls.Add(textBox10);
            Controls.Add(textBox11);
            Controls.Add(textBox12);
            Controls.Add(button4);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label3);
            Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(6, 5, 6, 5);
            Name = "UpdateUser";
            Text = "UpdateUser";
            Load += UpdateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ListBox listBox2;
        private Button button3;
        private Label label2;
        private TextBox textBox8;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Button button4;
        private TextBox textBox9;
    }
}