namespace GYM_YOUTUBE
{
    partial class ViewMember
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            MembersList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MembersList).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2029, 16);
            label3.Name = "label3";
            label3.Size = new Size(55, 88);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(795, 94);
            label2.Name = "label2";
            label2.Size = new Size(400, 88);
            label2.TabIndex = 6;
            label2.Text = "View Member";
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(730, 16);
            label1.Name = "label1";
            label1.Size = new Size(536, 88);
            label1.TabIndex = 5;
            label1.Text = "Koovapally Fitness";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.OliveDrab;
            textBox1.Location = new Point(705, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 78);
            textBox1.TabIndex = 36;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Berlin Sans FB", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 253);
            label4.Name = "label4";
            label4.Size = new Size(316, 68);
            label4.TabIndex = 35;
            label4.Text = "Member Name :";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1082, 243);
            button1.Name = "button1";
            button1.Size = new Size(208, 78);
            button1.TabIndex = 37;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1315, 243);
            button2.Name = "button2";
            button2.Size = new Size(208, 78);
            button2.TabIndex = 38;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(890, 1258);
            button3.Name = "button3";
            button3.Size = new Size(269, 96);
            button3.TabIndex = 39;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MembersList
            // 
            MembersList.BackgroundColor = Color.White;
            MembersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersList.Location = new Point(330, 343);
            MembersList.Name = "MembersList";
            MembersList.RowHeadersWidth = 82;
            MembersList.Size = new Size(1295, 833);
            MembersList.TabIndex = 55;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2127, 1405);
            Controls.Add(MembersList);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMember";
            Load += ViewMember_Load;
            ((System.ComponentModel.ISupportInitialize)MembersList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView MembersList;
    }
}