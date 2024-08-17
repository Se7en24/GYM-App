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
            label2.Location = new Point(834, 112);
            label2.Name = "label2";
            label2.Size = new Size(400, 88);
            label2.TabIndex = 9;
            label2.Text = "Payment";
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(720, 24);
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
            Paymentlist.BackgroundColor = Color.White;
            Paymentlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Paymentlist.Location = new Point(737, 213);
            Paymentlist.Name = "Paymentlist";
            Paymentlist.RowHeadersWidth = 82;
            Paymentlist.Size = new Size(1295, 833);
            Paymentlist.TabIndex = 59;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2127, 1405);
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
    }
}