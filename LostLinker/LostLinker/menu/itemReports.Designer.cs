namespace LostLinker.menu
{
    partial class itemReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemReports));
            reportBtn = new Button();
            addPicture = new PictureBox();
            label1 = new Label();
            itemtb = new TextBox();
            descriptiontb = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            itemPic = new PictureBox();
            datePicker = new DateTimePicker();
            timepicker = new DateTimePicker();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)addPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemPic).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // reportBtn
            // 
            reportBtn.BackColor = Color.FromArgb(114, 137, 218);
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Roboto Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportBtn.ForeColor = Color.White;
            reportBtn.Location = new Point(173, 477);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(208, 45);
            reportBtn.TabIndex = 32;
            reportBtn.Text = "Report Item";
            reportBtn.UseVisualStyleBackColor = false;
            reportBtn.Click += reportBtn_Click_1;
            // 
            // addPicture
            // 
            addPicture.BackColor = Color.FromArgb(66, 69, 73);
            addPicture.Image = (Image)resources.GetObject("addPicture.Image");
            addPicture.Location = new Point(356, 185);
            addPicture.Name = "addPicture";
            addPicture.Size = new Size(41, 39);
            addPicture.SizeMode = PictureBoxSizeMode.Zoom;
            addPicture.TabIndex = 31;
            addPicture.TabStop = false;
            addPicture.Click += addPicture_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(66, 69, 73);
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(104, 241);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 28;
            label1.Text = "Item Name:";
            // 
            // itemtb
            // 
            itemtb.BackColor = Color.FromArgb(54, 57, 62);
            itemtb.BorderStyle = BorderStyle.FixedSingle;
            itemtb.Font = new Font("Roboto", 12F);
            itemtb.ForeColor = Color.White;
            itemtb.Location = new Point(200, 233);
            itemtb.Name = "itemtb";
            itemtb.Size = new Size(248, 27);
            itemtb.TabIndex = 27;
            // 
            // descriptiontb
            // 
            descriptiontb.BackColor = Color.FromArgb(54, 57, 62);
            descriptiontb.BorderStyle = BorderStyle.FixedSingle;
            descriptiontb.Font = new Font("Roboto", 12F);
            descriptiontb.ForeColor = Color.White;
            descriptiontb.Location = new Point(104, 368);
            descriptiontb.Name = "descriptiontb";
            descriptiontb.Size = new Size(344, 92);
            descriptiontb.TabIndex = 26;
            descriptiontb.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(66, 69, 73);
            label6.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(104, 346);
            label6.Name = "label6";
            label6.Size = new Size(93, 19);
            label6.TabIndex = 25;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(66, 69, 73);
            label5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(104, 313);
            label5.Name = "label5";
            label5.Size = new Size(98, 19);
            label5.TabIndex = 24;
            label5.Text = "Found Time:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(66, 69, 73);
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(104, 279);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 23;
            label3.Text = "Found Date:";
            // 
            // itemPic
            // 
            itemPic.BorderStyle = BorderStyle.FixedSingle;
            itemPic.Location = new Point(200, 74);
            itemPic.Name = "itemPic";
            itemPic.Size = new Size(150, 150);
            itemPic.SizeMode = PictureBoxSizeMode.Zoom;
            itemPic.TabIndex = 22;
            itemPic.TabStop = false;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(200, 276);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(248, 23);
            datePicker.TabIndex = 33;
            // 
            // timepicker
            // 
            timepicker.Location = new Point(200, 310);
            timepicker.Name = "timepicker";
            timepicker.Size = new Size(248, 23);
            timepicker.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(66, 69, 73);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 607);
            panel1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 103);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // itemReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            Controls.Add(timepicker);
            Controls.Add(datePicker);
            Controls.Add(reportBtn);
            Controls.Add(addPicture);
            Controls.Add(label1);
            Controls.Add(itemtb);
            Controls.Add(descriptiontb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(itemPic);
            Controls.Add(panel1);
            Name = "itemReports";
            Size = new Size(566, 645);
            ((System.ComponentModel.ISupportInitialize)addPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reportBtn;
        private PictureBox addPicture;
        private Label label1;
        private TextBox itemtb;
        private RichTextBox descriptiontb;
        private Label label6;
        private Label label5;
        private Label label3;
        private PictureBox itemPic;
        private DateTimePicker datePicker;
        private DateTimePicker timepicker;
        private Panel panel1;
        private Label label2;
    }
}
