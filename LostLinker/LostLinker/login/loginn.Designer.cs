namespace LostLinker
{
    partial class loginn
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
            panel1 = new Panel();
            label1 = new Label();
            usertb = new TextBox();
            passtb = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            pass_showCB = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            statuslbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 33, 36);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 501);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rowdies", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 194);
            label1.Name = "label1";
            label1.Size = new Size(294, 94);
            label1.TabIndex = 0;
            label1.Text = "LostLinker\r\n";
            // 
            // usertb
            // 
            usertb.BackColor = Color.FromArgb(66, 69, 73);
            usertb.BorderStyle = BorderStyle.FixedSingle;
            usertb.Font = new Font("Roboto", 15F);
            usertb.ForeColor = Color.FromArgb(255, 254, 166);
            usertb.Location = new Point(366, 161);
            usertb.MaxLength = 16;
            usertb.Name = "usertb";
            usertb.Size = new Size(241, 32);
            usertb.TabIndex = 1;
            // 
            // passtb
            // 
            passtb.AcceptsReturn = true;
            passtb.BackColor = Color.FromArgb(66, 69, 73);
            passtb.BorderStyle = BorderStyle.FixedSingle;
            passtb.Font = new Font("Roboto", 15F);
            passtb.ForeColor = Color.FromArgb(255, 254, 166);
            passtb.Location = new Point(366, 234);
            passtb.MaxLength = 32;
            passtb.Name = "passtb";
            passtb.PasswordChar = '*';
            passtb.Size = new Size(241, 32);
            passtb.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(415, 323);
            button1.Name = "button1";
            button1.Size = new Size(145, 36);
            button1.TabIndex = 3;
            button1.Text = "SIGN IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(366, 134);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(366, 207);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // pass_showCB
            // 
            pass_showCB.AutoSize = true;
            pass_showCB.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass_showCB.ForeColor = Color.White;
            pass_showCB.Location = new Point(376, 272);
            pass_showCB.Name = "pass_showCB";
            pass_showCB.Size = new Size(119, 18);
            pass_showCB.TabIndex = 6;
            pass_showCB.Text = "Show Password?";
            pass_showCB.UseVisualStyleBackColor = true;
            pass_showCB.CheckedChanged += pass_showCB_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(427, 453);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 7;
            label4.Text = "Create Account";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(595, 486);
            label5.Name = "label5";
            label5.Size = new Size(72, 14);
            label5.TabIndex = 8;
            label5.Text = "admin login";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Medium", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(536, 9);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 9;
            label6.Text = "DBStatus:";
            // 
            // statuslbl
            // 
            statuslbl.AutoSize = true;
            statuslbl.Font = new Font("Roboto Medium", 10F);
            statuslbl.ForeColor = Color.White;
            statuslbl.Location = new Point(613, 9);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(42, 17);
            statuslbl.TabIndex = 10;
            statuslbl.Text = "down";
            // 
            // loginn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(669, 501);
            Controls.Add(statuslbl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pass_showCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(passtb);
            Controls.Add(usertb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "loginn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LostLinker";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox usertb;
        private TextBox passtb;
        private Button button1;
        private Label label2;
        private Label label3;
        private CheckBox pass_showCB;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label statuslbl;
    }
}
