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

namespace Steganography
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			// Tạo hộp thoại chọn file
			OpenFileDialog openFileDialog = new OpenFileDialog();

			// Thiết lập bộ lọc để chỉ chọn các file ảnh
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
			openFileDialog.Title = "Chọn ảnh để hiển thị";

			// Nếu người dùng chọn ảnh và nhấn OK
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;

				// 1. Kiểm tra size (<= 500MB)
				FileInfo fi = new FileInfo(filePath);
				if (fi.Length > 500 * 1024 * 1024) // 500 MB
				{
					MessageBox.Show("File quá lớn! Chỉ chấp nhận ảnh ≤ 500MB.");
					return;
				}

				// 2. Kiểm tra magic bytes đầu file để xác định định dạng thực
				byte[] header = new byte[8];
				using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				{
					fs.Read(header, 0, header.Length);
				}

				// JPEG: FF D8 FF
				bool isJPG = header[0] == 0xFF && header[1] == 0xD8 && header[2] == 0xFF;

				// PNG: 89 50 4E 47 0D 0A 1A 0A
				bool isPNG = header[0] == 0x89 && header[1] == 0x50 &&
							 header[2] == 0x4E && header[3] == 0x47 &&
							 header[4] == 0x0D && header[5] == 0x0A &&
							 header[6] == 0x1A && header[7] == 0x0A;

				if (!isJPG && !isPNG)
				{
					MessageBox.Show("File không hợp lệ. Chỉ chấp nhận ảnh .jpg hoặc .png đúng chuẩn.");
					return;
				}

				// 3. Load ảnh và kiểm tra kích thước
				using (Image img = Image.FromFile(filePath))
				{
					if (img.Width > 1366 || img.Height > 768)
					{
						MessageBox.Show($"Ảnh vượt quá kích thước cho phép (tối đa 1366x768). Ảnh hiện tại: {img.Width}x{img.Height}");
						return;
					}

					// Nếu mọi thứ hợp lệ, hiển thị ảnh lên PictureBox
					if (pb1.Image != null)
						pb1.Image.Dispose();

					pb1.Image = new Bitmap(img); // Tạo bản sao để tránh bị khóa file
					// Thiết lập kiểu hiển thị ảnh trong PictureBox
					pb1.SizeMode = PictureBoxSizeMode.Zoom; // hoặc StretchImage tùy ý
				}
			}
		}
	}
}
