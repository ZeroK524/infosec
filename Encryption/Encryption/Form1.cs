using Encryption.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// Đảm bảo có đúng 2 cột
			dataGridView1.ColumnCount = 2;
			dataGridView1.Columns[0].Name = "col1";
			dataGridView1.Columns[1].Name = "col2";

			// Thêm các dòng
			dataGridView1.Rows.Add("pass", "12345");
			dataGridView1.Rows.Add("base64", "67891");
			dataGridView1.Rows.Add("RSA", "abcsd");
			dataGridView1.Rows.Add("Hoho", "hahha");
			// Tự động giãn ra cho vừa DataGridView
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.Columns[0].FillWeight = 10;  // Cột 1
			dataGridView1.Columns[1].FillWeight = 90;  // Cột 2
			// 
			rbtn2.Checked = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (rbtn2.Checked)
			{
				MaHoaCaesar();
			}
			
			else
			{
				GiaiMaCaesar();
			}

		}
		private void MaHoaCaesar()
		{
			string input = rtb1.Text;
			StringBuilder output = new StringBuilder();

			for (int k = 1; k <= 25; k++)
			{
				string encrypted = CaesarCipher.Encrypt(input, k);
				output.AppendLine($"Khóa {k}: {encrypted}");
			}

			MessageBox.Show(output.ToString(), "Mã hóa Caesar từ khóa 1 đến 25");
		}

		private void GiaiMaCaesar()
		{
			string input = rtb1.Text;
			StringBuilder output = new StringBuilder();

			for (int k = 1; k <= 25; k++)
			{
				string decrypted = CaesarCipher.Decrypt(input, k);
				output.AppendLine($"Khóa {k}: {decrypted}");
			}

			MessageBox.Show(output.ToString(), "Giải mã Caesar từ khóa 1 đến 25");
		}

	}
}
