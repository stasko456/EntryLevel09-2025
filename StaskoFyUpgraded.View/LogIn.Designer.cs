namespace StaskoFyUpgraded.View
{
    partial class LogIn
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
            panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.FromArgb(255, 192, 128);
            linkLabel1.Location = new Point(61, 456);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(393, 23);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register if you do not have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(163, 372);
            button2.Name = "button2";
            button2.Size = new Size(180, 46);
            button2.TabIndex = 8;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(70, 233);
            label3.Name = "label3";
            label3.Size = new Size(140, 34);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(70, 282);
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
            label2.Location = new Point(70, 112);
            label2.Name = "label2";
            label2.Size = new Size(151, 34);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(70, 161);
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
            label1.Size = new Size(95, 34);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 598);
            Controls.Add(panel1);
            Name = "LogIn";
            Text = "LogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}