using Encryption.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			
			// 
			rbtn2.Checked = true;
			//
			chose.Items.AddRange(new string[] { "Caesar", "RSA" });
			chose.SelectedIndex = 0; // Mặc định chọn "Caesar"
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (chose.SelectedIndex)
			{
				case 0: // Caesar
					if (rbtn2.Checked)
					{
						dataGridView1.Rows.Clear();
						MaHoaCaesar();
					}

					else
					{
						dataGridView1.Rows.Clear();
						GiaiMaCaesar();
					}
					break;

				case 1: // RSA
					MessageBox.Show("Bạn đã chọn RSA");
					
					break;

				default:
					MessageBox.Show("Vui lòng chọn một thuật toán.");
					break;
			}

			

		}
		private void MaHoaCaesar()
		{
			string input = rtb1.Text;
			StringBuilder output = new StringBuilder();

			for (int k = 1; k <= 25; k++)
			{
				string encrypted = CaesarCipher.Encrypt(input, k);
				
				dataGridView1.Rows.Add($"Khóa k = {k}", encrypted);
			}
		}

		private void GiaiMaCaesar()
		{
			string input = rtb1.Text;
			StringBuilder output = new StringBuilder();

			for (int k = 1; k <= 25; k++)
			{
				string decrypted = CaesarCipher.Decrypt(input, k);
				
				dataGridView1.Rows.Add($"Khóa k = {k}", decrypted);
			}
		}

		private void chose_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		// Btn Exit
		private void btn4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		// Save
		private void btn2_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "CSV file (*.csv)|*.csv";
			sfd.Title = "Lưu file CSV";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
					{
						// Ghi tên cột
						for (int i = 0; i < dataGridView1.Columns.Count; i++)
						{
							sw.Write(dataGridView1.Columns[i].HeaderText);
							if (i < dataGridView1.Columns.Count - 1)
								sw.Write("\t");
						}
						sw.WriteLine();

						// Ghi từng dòng dữ liệu
						foreach (DataGridViewRow row in dataGridView1.Rows)
						{
							if (!row.IsNewRow)
							{
								for (int i = 0; i < dataGridView1.Columns.Count; i++)
								{
									sw.Write(row.Cells[i].Value?.ToString());
									if (i < dataGridView1.Columns.Count - 1)
										sw.Write("\t");
								}
								sw.WriteLine();
							}
						}
					}

					MessageBox.Show("Đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
				}
			}
		}
		//
	}
}
