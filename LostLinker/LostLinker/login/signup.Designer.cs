namespace LostLinker.login
{
    partial class signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup));
            usertb = new TextBox();
            passtb = new TextBox();
            emailtb = new TextBox();
            phonetb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            userpicBox = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userpicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // usertb
            // 
            usertb.BackColor = Color.FromArgb(66, 69, 73);
            usertb.BorderStyle = BorderStyle.FixedSingle;
            usertb.Font = new Font("Roboto", 12F);
            usertb.Location = new Point(89, 268);
            usertb.Name = "usertb";
            usertb.Size = new Size(482, 27);
            usertb.TabIndex = 0;
            // 
            // passtb
            // 
            passtb.BackColor = Color.FromArgb(66, 69, 73);
            passtb.BorderStyle = BorderStyle.FixedSingle;
            passtb.Font = new Font("Roboto", 12F);
            passtb.Location = new Point(89, 353);
            passtb.Name = "passtb";
            passtb.PasswordChar = '*';
            passtb.Size = new Size(482, 27);
            passtb.TabIndex = 1;
            // 
            // emailtb
            // 
            emailtb.BackColor = Color.FromArgb(66, 69, 73);
            emailtb.BorderStyle = BorderStyle.FixedSingle;
            emailtb.Font = new Font("Roboto", 12F);
            emailtb.Location = new Point(89, 438);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(482, 27);
            emailtb.TabIndex = 2;
            // 
            // phonetb
            // 
            phonetb.BackColor = Color.FromArgb(66, 69, 73);
            phonetb.BorderStyle = BorderStyle.FixedSingle;
            phonetb.Font = new Font("Roboto", 12F);
            phonetb.Location = new Point(89, 523);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(482, 27);
            phonetb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 243);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 329);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 413);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 499);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 7;
            label4.Text = "Phone number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 33, 36);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 63);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 18);
            label5.Name = "label5";
            label5.Size = new Size(181, 29);
            label5.TabIndex = 0;
            label5.Text = "Create Account";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(245, 578);
            button1.Name = "button1";
            button1.Size = new Size(172, 50);
            button1.TabIndex = 9;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(89, 386);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 18);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // userpicBox
            // 
            userpicBox.BorderStyle = BorderStyle.FixedSingle;
            userpicBox.Location = new Point(254, 82);
            userpicBox.Name = "userpicBox";
            userpicBox.Size = new Size(150, 150);
            userpicBox.SizeMode = PictureBoxSizeMode.Zoom;
            userpicBox.TabIndex = 11;
            userpicBox.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(412, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // signup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(669, 657);
            Controls.Add(pictureBox2);
            Controls.Add(userpicBox);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phonetb);
            Controls.Add(emailtb);
            Controls.Add(passtb);
            Controls.Add(usertb);
            Name = "signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "createAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userpicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usertb;
        private TextBox passtb;
        private TextBox emailtb;
        private TextBox phonetb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Button button1;
        private CheckBox checkBox1;
        private PictureBox userpicBox;
        private PictureBox pictureBox2;
    }
}