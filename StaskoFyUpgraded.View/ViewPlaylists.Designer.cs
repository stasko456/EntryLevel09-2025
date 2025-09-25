namespace StaskoFyUpgraded.View
{
    partial class ViewPlaylists
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
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 572);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(938, 226);
            button1.Name = "button1";
            button1.Size = new Size(180, 113);
            button1.TabIndex = 11;
            button1.Text = "Return to Main Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(152, 183);
            button2.Name = "button2";
            button2.Size = new Size(180, 46);
            button2.TabIndex = 8;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(150, 134);
            label3.Name = "label3";
            label3.Size = new Size(182, 34);
            label3.TabIndex = 4;
            label3.Text = "Load playlist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(304, 22);
            label1.Name = "label1";
            label1.Size = new Size(561, 70);
            label1.TabIndex = 0;
            label1.Text = "View your playlists";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(459, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(431, 395);
            listBox1.TabIndex = 9;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(40, 265);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(379, 256);
            checkedListBox1.TabIndex = 12;
            // 
            // ViewPlaylists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 597);
            Controls.Add(panel1);
            Name = "ViewPlaylists";
            Text = "ViewPlaylists";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label3;
        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
    }
}