namespace Encryption
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.rtb1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rbtn1 = new System.Windows.Forms.RadioButton();
			this.rbtn2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.chose = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input:";
			// 
			// rtb1
			// 
			this.rtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtb1.Location = new System.Drawing.Point(56, 53);
			this.rtb1.Name = "rtb1";
			this.rtb1.Size = new System.Drawing.Size(509, 57);
			this.rtb1.TabIndex = 1;
			this.rtb1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(2, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Output:";
			// 
			// rbtn1
			// 
			this.rbtn1.AutoSize = true;
			this.rbtn1.Location = new System.Drawing.Point(571, 84);
			this.rbtn1.Name = "rbtn1";
			this.rbtn1.Size = new System.Drawing.Size(75, 17);
			this.rbtn1.TabIndex = 7;
			this.rbtn1.TabStop = true;
			this.rbtn1.Text = "Encryption";
			this.rbtn1.UseVisualStyleBackColor = true;
			// 
			// rbtn2
			// 
			this.rbtn2.AutoSize = true;
			this.rbtn2.Location = new System.Drawing.Point(571, 61);
			this.rbtn2.Name = "rbtn2";
			this.rbtn2.Size = new System.Drawing.Size(63, 17);
			this.rbtn2.TabIndex = 8;
			this.rbtn2.TabStop = true;
			this.rbtn2.Text = "Decode";
			this.rbtn2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(681, 57);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 46);
			this.button1.TabIndex = 9;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
			this.dataGridView1.Location = new System.Drawing.Point(56, 116);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.ShowCellErrors = false;
			this.dataGridView1.Size = new System.Drawing.Size(732, 291);
			this.dataGridView1.TabIndex = 10;
			// 
			// col1
			// 
			this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.col1.FillWeight = 20F;
			this.col1.HeaderText = "Encoding Method";
			this.col1.Name = "col1";
			// 
			// col2
			// 
			this.col2.HeaderText = "Result";
			this.col2.Name = "col2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Chose :";
			// 
			// chose
			// 
			this.chose.FormattingEnabled = true;
			this.chose.Location = new System.Drawing.Point(81, 18);
			this.chose.Name = "chose";
			this.chose.Size = new System.Drawing.Size(115, 21);
			this.chose.TabIndex = 12;
			this.chose.SelectedIndexChanged += new System.EventHandler(this.chose_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(447, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "IV:";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(492, 18);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(285, 20);
			this.txt1.TabIndex = 14;
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(56, 415);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 23);
			this.btn2.TabIndex = 15;
			this.btn2.Text = "Save";
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(148, 415);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(75, 23);
			this.btn3.TabIndex = 16;
			this.btn3.Text = "Open";
			this.btn3.UseVisualStyleBackColor = true;
			// 
			// btn4
			// 
			this.btn4.Location = new System.Drawing.Point(713, 415);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(75, 23);
			this.btn4.TabIndex = 17;
			this.btn4.Text = "Exit";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(230, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 20);
			this.label5.TabIndex = 18;
			this.label5.Text = "Key:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(275, 17);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(135, 21);
			this.comboBox1.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chose);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rbtn2);
			this.Controls.Add(this.rbtn1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rtb1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtb1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbtn1;
		private System.Windows.Forms.RadioButton rbtn2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col1;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox chose;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

