namespace GYM_YOUTUBE
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            userid = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pswd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(52, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 186);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(691, 26);
            label1.Name = "label1";
            label1.Size = new Size(536, 88);
            label1.TabIndex = 1;
            label1.Text = "Koovapally Fitness";
            label1.Click += label1_Click;
            // 
            // userid
            // 
            userid.BackColor = Color.White;
            userid.BorderStyle = BorderStyle.FixedSingle;
            userid.Font = new Font("Old Antic Outline", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 178);
            userid.Location = new Point(691, 223);
            userid.Margin = new Padding(5);
            userid.Name = "userid";
            userid.Size = new Size(450, 64);
            userid.TabIndex = 2;
            userid.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(1149, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 64);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(1149, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 64);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pswd
            // 
            pswd.Font = new Font("Old Antic Outline", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 178);
            pswd.Location = new Point(691, 352);
            pswd.Margin = new Padding(5);
            pswd.Name = "pswd";
            pswd.PasswordChar = '*';
            pswd.Size = new Size(450, 64);
            pswd.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(691, 488);
            button1.Name = "button1";
            button1.Size = new Size(276, 92);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1022, 488);
            button2.Name = "button2";
            button2.Size = new Size(237, 92);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1398, 611);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pswd);
            Controls.Add(pictureBox2);
            Controls.Add(userid);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox userid;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox pswd;
        private Button button1;
        private Button button2;
    }
}
