﻿
namespace BT_WindowsForms
{
	partial class FrmBai1
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
			this.lblThongBao = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblThongBao
			// 
			this.lblThongBao.AutoSize = true;
			this.lblThongBao.Location = new System.Drawing.Point(46, 87);
			this.lblThongBao.Name = "lblThongBao";
			this.lblThongBao.Size = new System.Drawing.Size(12, 17);
			this.lblThongBao.TabIndex = 0;
			this.lblThongBao.Text = ".";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Thông tin hàng hóa";
			// 
			// FrmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblThongBao);
			this.Name = "FrmBai1";
			this.Text = "Bài 1";
			this.Load += new System.EventHandler(this.FrmBai1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblThongBao;
		private System.Windows.Forms.Label label2;
	}
}