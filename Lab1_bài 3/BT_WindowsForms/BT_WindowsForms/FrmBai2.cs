using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_WindowsForms
{
	public partial class FrmBai2 : Form
	{
		public FrmBai2()
		{
			InitializeComponent();
		}

		private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
		{
			var stt = cbbTenHang.SelectedIndex;
			switch (stt)
			{
				case 0:
					txtDonGia.Text = "100000";
					break;
				case 1:
					txtDonGia.Text = "1500000";
					break;
				case 2:
					txtDonGia.Text = "200000";
					break;
			}
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int donGia = int.Parse(txtDonGia.Text);
			int soLuong = int.Parse(txtSoLuong.Text);
			double thanhTien = donGia * soLuong;

			if (rdChuyenKhoang.Checked)
				thanhTien = donGia * soLuong * 0.95;

			//Hiển thị kết quả
			lblSoTien.Text = thanhTien.ToString();
		}
	}
}
