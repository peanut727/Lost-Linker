namespace LostLinker.menu
{
    partial class usermenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usermenu));
            panel1 = new Panel();
            userbtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            reportitemBtn = new Button();
            lostitemBtn = new Button();
            label1 = new Label();
            itemPic = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            descTB = new RichTextBox();
            itemLabel = new Label();
            button1 = new Button();
            itemReports1 = new itemReports();
            button2 = new Button();
            dateShow = new DateTimePicker();
            listView1 = new ListView();
            panel3 = new Panel();
            textBox2 = new TextBox();
            reportLbl = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPic).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 33, 36);
            panel1.Controls.Add(userbtn);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(reportitemBtn);
            panel1.Controls.Add(lostitemBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 606);
            panel1.TabIndex = 0;
            // 
            // userbtn
            // 
            userbtn.BackColor = Color.FromArgb(30, 33, 36);
            userbtn.FlatAppearance.BorderSize = 0;
            userbtn.FlatStyle = FlatStyle.Flat;
            userbtn.Font = new Font("Roboto", 12F);
            userbtn.ForeColor = Color.White;
            userbtn.Location = new Point(-2, 188);
            userbtn.Name = "userbtn";
            userbtn.Size = new Size(201, 31);
            userbtn.TabIndex = 11;
            userbtn.Text = "Lost Items";
            userbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 538);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(109, 538);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(47, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 102);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(205, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 6;
            // 
            // reportitemBtn
            // 
            reportitemBtn.BackColor = Color.FromArgb(30, 33, 36);
            reportitemBtn.FlatAppearance.BorderSize = 0;
            reportitemBtn.FlatStyle = FlatStyle.Flat;
            reportitemBtn.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportitemBtn.ForeColor = Color.White;
            reportitemBtn.Location = new Point(0, 326);
            reportitemBtn.Name = "reportitemBtn";
            reportitemBtn.Size = new Size(201, 31);
            reportitemBtn.TabIndex = 5;
            reportitemBtn.Text = "Report Lost Items";
            reportitemBtn.UseVisualStyleBackColor = false;
            reportitemBtn.Click += button2_Click;
            // 
            // lostitemBtn
            // 
            lostitemBtn.BackColor = Color.FromArgb(114, 137, 218);
            lostitemBtn.FlatAppearance.BorderSize = 0;
            lostitemBtn.FlatStyle = FlatStyle.Flat;
            lostitemBtn.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lostitemBtn.ForeColor = Color.White;
            lostitemBtn.Location = new Point(0, 275);
            lostitemBtn.Name = "lostitemBtn";
            lostitemBtn.Size = new Size(201, 31);
            lostitemBtn.TabIndex = 4;
            lostitemBtn.Text = "Lost Items";
            lostitemBtn.UseVisualStyleBackColor = false;
            lostitemBtn.Click += lostitemBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rowdies", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(196, 62);
            label1.TabIndex = 0;
            label1.Text = "LostLinker";
            // 
            // itemPic
            // 
            itemPic.Location = new Point(1011, 80);
            itemPic.Name = "itemPic";
            itemPic.Size = new Size(150, 150);
            itemPic.SizeMode = PictureBoxSizeMode.AutoSize;
            itemPic.TabIndex = 2;
            itemPic.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(66, 69, 73);
            label3.Font = new Font("Roboto Medium", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 305);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 4;
            label3.Text = "Found Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(66, 69, 73);
            label5.Font = new Font("Roboto Medium", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(943, 347);
            label5.Name = "label5";
            label5.Size = new Size(110, 19);
            label5.TabIndex = 5;
            label5.Text = "Found Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(66, 69, 73);
            label6.Font = new Font("Roboto Medium", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(943, 394);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 6;
            label6.Text = "Description:";
            // 
            // descTB
            // 
            descTB.BackColor = Color.FromArgb(54, 57, 62);
            descTB.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descTB.ForeColor = Color.White;
            descTB.Location = new Point(947, 416);
            descTB.Name = "descTB";
            descTB.Size = new Size(265, 90);
            descTB.TabIndex = 7;
            descTB.Text = "";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.BackColor = Color.FromArgb(66, 69, 73);
            itemLabel.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabel.ForeColor = Color.White;
            itemLabel.Location = new Point(133, 221);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(98, 19);
            itemLabel.TabIndex = 3;
            itemLabel.Text = "Item Name";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1025, 531);
            button1.Name = "button1";
            button1.Size = new Size(116, 32);
            button1.TabIndex = 8;
            button1.Text = "Claim item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // itemReports1
            // 
            itemReports1.BackColor = Color.FromArgb(54, 57, 62);
            itemReports1.Location = new Point(205, 0);
            itemReports1.Name = "itemReports1";
            itemReports1.Size = new Size(566, 606);
            itemReports1.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(114, 137, 218);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto Medium", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(853, 11);
            button2.Name = "button2";
            button2.Size = new Size(47, 43);
            button2.TabIndex = 13;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // dateShow
            // 
            dateShow.Enabled = false;
            dateShow.Location = new Point(1055, 314);
            dateShow.Name = "dateShow";
            dateShow.Size = new Size(200, 23);
            dateShow.TabIndex = 14;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(66, 69, 73);
            listView1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.ForeColor = Color.White;
            listView1.Location = new Point(208, 11);
            listView1.Name = "listView1";
            listView1.Size = new Size(641, 583);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(66, 69, 73);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(reportLbl);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(itemLabel);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(906, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 582);
            panel3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(66, 69, 73);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Roboto", 10F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(149, 335);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(199, 24);
            textBox2.TabIndex = 17;
            // 
            // reportLbl
            // 
            reportLbl.BackColor = Color.FromArgb(66, 69, 73);
            reportLbl.BorderStyle = BorderStyle.FixedSingle;
            reportLbl.Enabled = false;
            reportLbl.Font = new Font("Roboto", 10F);
            reportLbl.ForeColor = Color.White;
            reportLbl.Location = new Point(149, 262);
            reportLbl.Name = "reportLbl";
            reportLbl.ReadOnly = true;
            reportLbl.Size = new Size(199, 24);
            reportLbl.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(66, 69, 73);
            label2.Font = new Font("Roboto Medium", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 263);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 6;
            label2.Text = "Reporter Name:";
            // 
            // usermenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(1275, 606);
            Controls.Add(button2);
            Controls.Add(dateShow);
            Controls.Add(button1);
            Controls.Add(descTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(itemPic);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(itemReports1);
            Controls.Add(panel3);
            MaximizeBox = false;
            Name = "usermenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usermenu";
            Load += usermenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPic).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button reportitemBtn;
        private Button lostitemBtn;
        private PictureBox itemPic;
        private Label label3;
        private Label label5;
        private Label label6;
        private RichTextBox descTB;
        private Label itemLabel;
        private Button button1;
        private Panel panel2;
        private itemReports itemReports1;
        private Button button2;
        private DateTimePicker dateShow;
        private ListView listView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Button userbtn;
        private Label label2;
        private TextBox textBox2;
        private TextBox reportLbl;
    }
}