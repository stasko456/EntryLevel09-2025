namespace StaskoFyUpgraded.View
{
    partial class SelectQueries
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
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            button6 = new Button();
            label7 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 587);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(657, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 32);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(637, 471);
            button1.Name = "button1";
            button1.Size = new Size(193, 79);
            button1.TabIndex = 22;
            button1.Text = "Return to \r\nMain Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(657, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(422, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(68, 117);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(530, 424);
            listBox1.TabIndex = 19;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGray;
            button6.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(899, 502);
            button6.Name = "button6";
            button6.Size = new Size(180, 46);
            button6.TabIndex = 18;
            button6.Text = "Read";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGray;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(845, 453);
            label7.Name = "label7";
            label7.Size = new Size(290, 34);
            label7.TabIndex = 17;
            label7.Text = "Read Select Queries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(266, 22);
            label1.Name = "label1";
            label1.Size = new Size(626, 70);
            label1.TabIndex = 0;
            label1.Text = "Select Queries Menu";
            // 
            // SelectQueries
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 613);
            Controls.Add(panel1);
            Name = "SelectQueries";
            Text = "SelectQueries";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label7;
        private Label label1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
    }
}