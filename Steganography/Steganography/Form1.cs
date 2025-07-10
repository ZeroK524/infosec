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
using System.Security.Cryptography;
namespace Steganography
{
	public partial class Form1 : Form
	{

		string flag = "CTF{";
		public Form1()
		{
			InitializeComponent();
			btn3.Enabled = false;
			
		}

		// Xử lý nút nhận ảnh vào 
		private void btn1_Click(object sender, EventArgs e)
		{
			// Tạo hộp thoại chọn file
			OpenFileDialog openFileDialog = new OpenFileDialog();

			// Thiết lập bộ lọc để chỉ chọn các file ảnh
			openFileDialog.Filter = "Image Files|*.png"; //*.jpg;*.jpeg; ko phù hợp cho LSB do bị nén mất dữ liệu bit
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
				//bool isJPG = header[0] == 0xFF && header[1] == 0xD8 && header[2] == 0xFF;

				// PNG: 89 50 4E 47 0D 0A 1A 0A
				bool isPNG = header[0] == 0x89 && header[1] == 0x50 &&
							 header[2] == 0x4E && header[3] == 0x47 &&
							 header[4] == 0x0D && header[5] == 0x0A &&
							 header[6] == 0x1A && header[7] == 0x0A;

				if (!isPNG)
				{
					MessageBox.Show("File không hợp lệ. Chỉ chấp nhận ảnh .png đúng chuẩn.");
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
		// Xử lý nút nhận ảnh có giấu tin vào 
		private void btn2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.png";
			openFileDialog.Title = "Chọn ảnh để hiển thị";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;

				FileInfo fi = new FileInfo(filePath);
				if (fi.Length > 500 * 1024 * 1024)
				{
					MessageBox.Show("File quá lớn! Chỉ chấp nhận ảnh ≤ 500MB.");
					return;
				}

				// Kiểm tra magic bytes
				byte[] header = new byte[8];
				using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				{
					fs.Read(header, 0, header.Length);
				}
				bool isPNG = header[0] == 0x89 && header[1] == 0x50 &&
							 header[2] == 0x4E && header[3] == 0x47 &&
							 header[4] == 0x0D && header[5] == 0x0A &&
							 header[6] == 0x1A && header[7] == 0x0A;
				if (!isPNG)
				{
					MessageBox.Show("File không hợp lệ. Chỉ chấp nhận ảnh .png đúng chuẩn.");
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
					if (pb2.Image != null)
						pb2.Image.Dispose();

					pb2.Image = new Bitmap(img); // Tạo bản sao để tránh bị khóa file
												 // Thiết lập kiểu hiển thị ảnh trong PictureBox
					pb2.SizeMode = PictureBoxSizeMode.Zoom; // hoặc StretchImage tùy ý
				}
				// Kiểm tra CRC 
				if (CoTheCoTinGiau(filePath))
				{
					string thongDiep = GiaiMaTuAnh(pb2);
					txt2.Text = thongDiep;
					txt4.Text = null;
				}
				else
				{
					txt2.Text = null;
					txt4.Text = "Ảnh không có giấu tin";
				}
			}
		}


		// Xử lý nhập từ giấu
		private void txt1_TextChanged(object sender, EventArgs e)
		{
			/* ví dụ
			ảnh 100 x 100 = 10.000 pixel
			Ẩn LSB mỗi kênh (R, G, B) → 10.000 × 3 = 30.000 bit
			Tức là chứa được: 30.000 / 8 = 3.750 byte ≈ 3.75 KB
			=> Tức chứa tối đa 3.75 KB cho từ giấu 
			*/
			btn3.Enabled = false;
			if (pb1.Image == null) return; // Không có ảnh thì không kiểm tra
			System.Diagnostics.Debug.WriteLine("#####");
			// Tính độ dài thông điệp (số byte)

			int messageLength = Encoding.UTF8.GetByteCount(txt1.Text.Trim());
			int messageBits = messageLength * 8;
			System.Diagnostics.Debug.WriteLine(txt1.Text);
			System.Diagnostics.Debug.WriteLine(messageLength); // Chữ "a" = 1 byte -> 8 bit để giấu 
			System.Diagnostics.Debug.WriteLine($"Kích thước bit từ giấu tối đa:{messageBits}");
			
			// Lấy kích thước ảnh (từ PictureBox)
			using (Bitmap bmp = new Bitmap(pb1.Image)) // Clone ảnh để tránh khóa
			{
				int width = bmp.Width;
				int height = bmp.Height;
				int totalPixels = width * height;
				int maxBits = totalPixels * 3; // 3 bit/pixel (LSB trên R, G, B)
				
				System.Diagnostics.Debug.WriteLine($"Rộng: {width}");
				System.Diagnostics.Debug.WriteLine($"Cao: {height}");
				System.Diagnostics.Debug.WriteLine($"Pixel: {totalPixels}");
				// Đổi màu tức thời
				if (messageBits <= maxBits)
				{
					txt1.BackColor = Color.White;
					txt1.ForeColor = Color.Green;
					txt3.Text = messageBits > 0 ? $"Hợp lệ {messageBits} <= {maxBits}!" : "";
					txt3.ForeColor = Color.Green;
					btn3.Enabled = messageBits > 0;
				}
				else
				{
					txt1.BackColor = Color.White;
					txt1.ForeColor = Color.Red;
					txt3.Text = $"Kích thước chuỗi: {messageBits} <= Ảnh:{maxBits}!";
					txt3.ForeColor = Color.Red;
					btn3.Enabled = false;
				}

			}
		}

		// Xử lý nút giấu tin
		private void btn3_Click(object sender, EventArgs e)
		{
			string message = flag + txt1.Text.Trim() + '}'; // Dùng như vậy để giải mã dễ dàng 
			if (string.IsNullOrEmpty(message)) return;

			Bitmap original = new Bitmap(pb1.Image);
			int width = original.Width;
			int height = original.Height;

			List<int> bitList = new List<int>();
			foreach (char c in message)
			{
				byte b = (byte)c;
				for (int i = 7; i >= 0; i--)
				{
					int bit = (b >> i) & 1;
					bitList.Add(bit);
				}
			}

			int totalBits = bitList.Count;
			int p = (totalBits - 1) / 3 + 1;

			List<string> beforeList = new List<string>();
			List<string> afterList = new List<string>();

			int bitIndex = 0;
			int usedPixel = 0;

			Bitmap stego = new Bitmap(original);

			for (int i = 0; i < height && usedPixel < p; i++)
			{
				for (int j = 0; j < width && usedPixel < p; j++)
				{
					Color pixel = original.GetPixel(j, i); // từ ảnh gốc
					int r = pixel.R;
					int g = pixel.G;
					int b = pixel.B;

					beforeList.Add($"{usedPixel + 1,2}: {r,3} {g,3} {b,3}");

					// Giấu bit vào ảnh
					if (bitIndex < totalBits) r = (r & ~1) | bitList[bitIndex++];
					if (bitIndex < totalBits) g = (g & ~1) | bitList[bitIndex++];
					if (bitIndex < totalBits) b = (b & ~1) | bitList[bitIndex++];

					stego.SetPixel(j, i, Color.FromArgb(r, g, b));
					afterList.Add($"{usedPixel + 1,2}: {r,3} {g,3} {b,3}");

					usedPixel++;
				}
			}

			// Gộp 2 bên lại
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"Số pixel sử dụng: {p}\n");
			sb.AppendLine("Trước giấu       →     Sau giấu");
			sb.AppendLine("-----------------     -----------------");

			for (int i = 0; i < p; i++)
			{
				sb.AppendLine($"{beforeList[i]}     →     {afterList[i]}");
			}

			
			// hiển thị kết quả
			DialogResult result = MessageBox.Show(sb.ToString(), "So sánh RGB trước và sau khi giấu", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// Nếu người dùng nhấn OK → mở hộp thoại lưu
			if (result == DialogResult.OK)
			{
				using (SaveFileDialog saveDialog = new SaveFileDialog())
				{
					saveDialog.Title = "Lưu ảnh sau khi đã giấu tin (không re-encode)";
					saveDialog.Filter = "PNG files (*.png)|*.png";
					saveDialog.DefaultExt = "png";
					saveDialog.FileName = "LSB.png";

					if (saveDialog.ShowDialog() == DialogResult.OK)
					{
						using (MemoryStream ms = new MemoryStream())
						{
							//tego.Save(saveDialog.FileName); sẽ re-encode lại ảnh, làm mất dấu CRC cũ hoặc sắp xếp lại chunk.

							// Lưu ra memory stream để giữ đúng định dạng PNG thô
							stego.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
							File.WriteAllBytes(saveDialog.FileName, ms.ToArray());
						}

						MessageBox.Show("Đã lưu ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

		}

		// Xử lý giải mã 
		private string GiaiMaTuAnh(PictureBox pbLSB)
		{
			if (pbLSB.Image == null)
				return string.Empty;

			Bitmap bmp = new Bitmap(pbLSB.Image);
			int width = bmp.Width;
			int height = bmp.Height;

			StringBuilder message = new StringBuilder();
			int bitCount = 0;
			int currentByte = 0;
			bool foundEnd = false;

			for (int i = 0; i < height && !foundEnd; i++)
			{
				for (int j = 0; j < width && !foundEnd; j++)
				{
					Color pixel = bmp.GetPixel(j, i);
					int[] bitArray = {
				pixel.R & 1,
				pixel.G & 1,
				pixel.B & 1
			};

					foreach (int bit in bitArray)
					{
						currentByte = (currentByte << 1) | bit;
						bitCount++;

						if (bitCount == 8)
						{
							char c = (char)currentByte;

							if (c == '}')
							{
								string result = message.ToString();
								if (result.Contains("CTF{"))
								{
									string ctf = result.Replace("CTF{", "");
									return ctf; // Có chứa thông điệp CTF
								}
									
								else
									return "Không thể giải mã";
							}
							
							message.Append(c);
							currentByte = 0;
							bitCount = 0;
						}
					}
				}
			}
			System.Diagnostics.Debug.WriteLine(message);
			return "Không thể giải mã";
			
			
		}
		// Kiểm tra ảnh có LSB hay không
		private bool CoTheCoTinGiau(string filePath)
		{
			Bitmap bmp = new Bitmap(filePath);
			int width = bmp.Width;
			int height = bmp.Height;

			int bitCount = 0;
			int currentByte = 0;
			List<char> chars = new List<char>();

			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					Color pixel = bmp.GetPixel(x, y);
					int[] bits = {
				pixel.R & 1,
				pixel.G & 1,
				pixel.B & 1
			};

					foreach (int bit in bits)
					{
						currentByte = (currentByte << 1) | bit;
						bitCount++;

						if (bitCount == 8)
						{
							char c = (char)currentByte;

							if (!char.IsLetterOrDigit(c) && !char.IsPunctuation(c) && !char.IsWhiteSpace(c))
							{
								// Nếu xuất hiện ký tự không in được → có thể không phải ASCII → thoát
								return false;
							}

							chars.Add(c);
							if (chars.Count >= 4) // thấy khoảng vài ký tự ASCII đầu là đáng nghi
								return true;

							bitCount = 0;
							currentByte = 0;
						}
					}
				}
			}

			return false;
		}
	}
}
