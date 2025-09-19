namespace StaskoFyUpgraded.View
{
    partial class SignUp
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
            panel1 = new Panel();
            label4 = new Label();
            textBox3 = new TextBox();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 574);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGray;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(71, 318);
            label4.Name = "label4";
            label4.Size = new Size(186, 34);
            label4.TabIndex = 11;
            label4.Text = "Re-Password";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(71, 367);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 41);
            textBox3.TabIndex = 10;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.FromArgb(255, 192, 128);
            linkLabel1.Location = new Point(106, 508);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(297, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login if you have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(163, 437);
            button2.Name = "button2";
            button2.Size = new Size(180, 46);
            button2.TabIndex = 8;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(70, 192);
            label3.Name = "label3";
            label3.Size = new Size(140, 34);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(70, 241);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 41);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(70, 71);
            label2.Name = "label2";
            label2.Size = new Size(151, 34);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(70, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 41);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(116, 34);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 598);
            Controls.Add(panel1);
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox textBox3;
        private LinkLabel linkLabel1;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}