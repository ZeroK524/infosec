namespace Steganography
{
	partial class Form1
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
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.pb2 = new System.Windows.Forms.PictureBox();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
			this.SuspendLayout();
			// 
			// pb1
			// 
			this.pb1.Location = new System.Drawing.Point(64, 47);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(298, 229);
			this.pb1.TabIndex = 0;
			this.pb1.TabStop = false;
			this.pb1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pb2
			// 
			this.pb2.Location = new System.Drawing.Point(414, 47);
			this.pb2.Name = "pb2";
			this.pb2.Size = new System.Drawing.Size(298, 229);
			this.pb2.TabIndex = 1;
			this.pb2.TabStop = false;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(64, 12);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(107, 23);
			this.btn1.TabIndex = 2;
			this.btn1.Text = "Select Picture";
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(414, 12);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(107, 23);
			this.btn2.TabIndex = 3;
			this.btn2.Text = "Select Picture";
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 283);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Message:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(411, 283);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Hidden Message:";
			// 
			// txt1
			// 
			this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt1.Location = new System.Drawing.Point(67, 311);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(295, 21);
			this.txt1.TabIndex = 6;
			// 
			// txt2
			// 
			this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.Location = new System.Drawing.Point(414, 311);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(295, 21);
			this.txt2.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(67, 397);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Hide Message";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.pb2);
			this.Controls.Add(this.pb1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pb1;
		private System.Windows.Forms.PictureBox pb2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Button button1;
	}
}

