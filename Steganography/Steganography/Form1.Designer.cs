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
			this.btn3 = new System.Windows.Forms.Button();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt4 = new System.Windows.Forms.TextBox();
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
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(414, 12);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(107, 23);
			this.btn2.TabIndex = 3;
			this.btn2.Text = "Select Picture";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
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
			this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
			// 
			// txt2
			// 
			this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt2.Location = new System.Drawing.Point(414, 311);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(295, 21);
			this.txt2.TabIndex = 7;
			
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(67, 397);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(107, 23);
			this.btn3.TabIndex = 8;
			this.btn3.Text = "Hide Message";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// txt3
			// 
			this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt3.Location = new System.Drawing.Point(67, 338);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(295, 21);
			this.txt3.TabIndex = 9;
			// 
			// txt4
			// 
			this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt4.Location = new System.Drawing.Point(414, 338);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(295, 21);
			this.txt4.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.btn3);
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
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt4;
	}
}

