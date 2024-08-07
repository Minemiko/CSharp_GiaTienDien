namespace CSharp_GiaTienDien
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtSD = new TextBox();
            label2 = new Label();
            txtTong = new TextBox();
            btnTinh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._10_11_2023_QD_2941_1__4_;
            pictureBox1.Location = new Point(512, 16);
            pictureBox1.Margin = new Padding(6, 7, 6, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 33);
            label1.TabIndex = 1;
            label1.Text = "Số điện:";
            // 
            // txtSD
            // 
            txtSD.Location = new Point(176, 6);
            txtSD.Name = "txtSD";
            txtSD.Size = new Size(100, 40);
            txtSD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 55);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(152, 33);
            label2.TabIndex = 1;
            label2.Text = "Thành tiền:";
            // 
            // txtTong
            // 
            txtTong.Location = new Point(176, 52);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(327, 40);
            txtTong.TabIndex = 2;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(403, 6);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(100, 40);
            btnTinh.TabIndex = 3;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 304);
            Controls.Add(btnTinh);
            Controls.Add(txtTong);
            Controls.Add(txtSD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSD;
        private Label label2;
        private TextBox txtTong;
        private Button btnTinh;
    }
}
