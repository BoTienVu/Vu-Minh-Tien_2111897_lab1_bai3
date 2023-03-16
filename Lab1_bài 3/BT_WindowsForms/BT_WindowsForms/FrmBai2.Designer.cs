
namespace BT_WindowsForms
{
	partial class FrmBai2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbTenHang = new System.Windows.Forms.ComboBox();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdChuyenKhoang = new System.Windows.Forms.RadioButton();
			this.rdTienMat = new System.Windows.Forms.RadioButton();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Đơn giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số lượng";
			// 
			// cbbTenHang
			// 
			this.cbbTenHang.FormattingEnabled = true;
			this.cbbTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
			this.cbbTenHang.Location = new System.Drawing.Point(209, 40);
			this.cbbTenHang.Name = "cbbTenHang";
			this.cbbTenHang.Size = new System.Drawing.Size(284, 24);
			this.cbbTenHang.TabIndex = 1;
			this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
			// 
			// txtDonGia
			// 
			this.txtDonGia.Location = new System.Drawing.Point(209, 90);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(284, 22);
			this.txtDonGia.TabIndex = 2;
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(209, 145);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(284, 22);
			this.txtSoLuong.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTienMat);
			this.groupBox1.Controls.Add(this.rdChuyenKhoang);
			this.groupBox1.Location = new System.Drawing.Point(209, 195);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hình thức thanh toán";
			// 
			// rdChuyenKhoang
			// 
			this.rdChuyenKhoang.AutoSize = true;
			this.rdChuyenKhoang.Location = new System.Drawing.Point(19, 34);
			this.rdChuyenKhoang.Name = "rdChuyenKhoang";
			this.rdChuyenKhoang.Size = new System.Drawing.Size(128, 21);
			this.rdChuyenKhoang.TabIndex = 0;
			this.rdChuyenKhoang.Text = "Chuyển khoảng";
			this.rdChuyenKhoang.UseVisualStyleBackColor = true;
			// 
			// rdTienMat
			// 
			this.rdTienMat.AutoSize = true;
			this.rdTienMat.Checked = true;
			this.rdTienMat.Location = new System.Drawing.Point(19, 73);
			this.rdTienMat.Name = "rdTienMat";
			this.rdTienMat.Size = new System.Drawing.Size(84, 21);
			this.rdTienMat.TabIndex = 0;
			this.rdTienMat.TabStop = true;
			this.rdTienMat.Text = "Tiền mặt";
			this.rdTienMat.UseVisualStyleBackColor = true;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(262, 312);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(94, 34);
			this.btnTinhTien.TabIndex = 4;
			this.btnTinhTien.Text = "Tính Tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(72, 370);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Số tiền thanh toán:";
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblSoTien.Location = new System.Drawing.Point(273, 370);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(17, 25);
			this.lblSoTien.TabIndex = 5;
			this.lblSoTien.Text = ".";
			// 
			// FrmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 450);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.cbbTenHang);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmBai2";
			this.Text = "Bài 2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbbTenHang;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdTienMat;
		private System.Windows.Forms.RadioButton rdChuyenKhoang;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblSoTien;
	}
}