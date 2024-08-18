namespace GYM_YOUTUBE
{
    partial class Payment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Amounttb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            Period = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            NameCb = new ComboBox();
            Paymentlist = new DataGridView();
            SearchName = new TextBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)Paymentlist).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2019, 24);
            label3.Name = "label3";
            label3.Size = new Size(55, 88);
            label3.TabIndex = 10;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(917, 112);
            label2.Name = "label2";
            label2.Size = new Size(400, 88);
            label2.TabIndex = 9;
            label2.Text = "Payment";
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(803, 24);
            label1.Name = "label1";
            label1.Size = new Size(536, 88);
            label1.TabIndex = 8;
            label1.Text = "Koovapally Fitness";
            // 
            // Amounttb
            // 
            Amounttb.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amounttb.ForeColor = Color.OliveDrab;
            Amounttb.Location = new Point(115, 719);
            Amounttb.Name = "Amounttb";
            Amounttb.Size = new Size(354, 78);
            Amounttb.TabIndex = 27;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Berlin Sans FB", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 657);
            label5.Name = "label5";
            label5.Size = new Size(411, 88);
            label5.TabIndex = 26;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Berlin Sans FB", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(106, 480);
            label4.Name = "label4";
            label4.Size = new Size(411, 88);
            label4.TabIndex = 24;
            label4.Text = "Member Name :";
            // 
            // Period
            // 
            Period.Location = new Point(115, 383);
            Period.Name = "Period";
            Period.Size = new Size(354, 39);
            Period.TabIndex = 28;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Berlin Sans FB", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 322);
            label6.Name = "label6";
            label6.Size = new Size(411, 58);
            label6.TabIndex = 29;
            label6.Text = "Payment Month";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(245, 989);
            button3.Name = "button3";
            button3.Size = new Size(208, 71);
            button3.TabIndex = 35;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(354, 888);
            button2.Name = "button2";
            button2.Size = new Size(208, 71);
            button2.TabIndex = 34;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(125, 888);
            button1.Name = "button1";
            button1.Size = new Size(208, 71);
            button1.TabIndex = 33;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NameCb
            // 
            NameCb.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "Male ", "Female" });
            NameCb.Location = new Point(115, 547);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(354, 79);
            NameCb.TabIndex = 41;
            // 
            // Paymentlist
            // 
            Paymentlist.AllowUserToAddRows = false;
            Paymentlist.AllowUserToDeleteRows = false;
            Paymentlist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Paymentlist.BackgroundColor = Color.White;
            Paymentlist.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Paymentlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Paymentlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Paymentlist.GridColor = SystemColors.HotTrack;
            Paymentlist.Location = new Point(872, 332);
            Paymentlist.Name = "Paymentlist";
            Paymentlist.RowHeadersWidth = 82;
            Paymentlist.Size = new Size(887, 833);
            Paymentlist.TabIndex = 59;
            // 
            // SearchName
            // 
            SearchName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchName.ForeColor = Color.OliveDrab;
            SearchName.Location = new Point(917, 248);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(354, 78);
            SearchName.TabIndex = 60;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(1308, 248);
            button4.Name = "button4";
            button4.Size = new Size(208, 78);
            button4.TabIndex = 61;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSeaGreen;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(1540, 248);
            button5.Name = "button5";
            button5.Size = new Size(208, 78);
            button5.TabIndex = 62;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2127, 1405);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(SearchName);
            Controls.Add(Paymentlist);
            Controls.Add(NameCb);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(Period);
            Controls.Add(Amounttb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)Paymentlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Amounttb;
        private Label label5;
        private Label label4;
        private DateTimePicker Period;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox NameCb;
        private DataGridView Paymentlist;
        private TextBox SearchName;
        private Button button4;
        private Button button5;
    }
}