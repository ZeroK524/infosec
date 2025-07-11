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
		}

	}
}
