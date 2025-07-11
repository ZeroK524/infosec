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
			
			// 
			rbtn2.Checked = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
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

	}
}
