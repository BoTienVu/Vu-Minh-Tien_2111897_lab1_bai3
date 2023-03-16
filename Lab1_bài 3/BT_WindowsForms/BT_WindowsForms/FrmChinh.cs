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
	public partial class FrmChinh : Form
	{
		public FrmChinh()
		{
			InitializeComponent();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			//mở form bài 1 khi nhấn nút bài 1 trên form chính
			var form = new FrmBai1();
			form.ShowDialog();
		}

		private void tsbBai2_Click(object sender, EventArgs e)
		{
			var form = new FrmBai2();
			form.ShowDialog();
		}

		private void tsbBai3_Click(object sender, EventArgs e)
		{
			var form = new frmBai3();
			form.ShowDialog();
		}
	}
}
