namespace WinIPSWDecryptor
{
	// Token: 0x02000004 RID: 4
	public partial class Form1
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000033DD File Offset: 0x000015DD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000033FC File Offset: 0x000015FC
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Location = new System.Drawing.Point(16, 78);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(763, 217);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Input (Encrypted IMG3 Files)";
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(655, 177);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 28);
			this.button4.TabIndex = 4;
			this.button4.Text = "&Size";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(655, 140);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 28);
			this.button3.TabIndex = 3;
			this.button3.Text = "&MD5";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(655, 59);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 2;
			this.button2.Text = "&Remove";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(655, 23);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add &Files";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(8, 23);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(637, 180);
			this.listBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(9, 59);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(235, 109);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(36, 153);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(132, 22);
			this.textBox3.TabIndex = 8;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(253, 38);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(268, 154);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(888, 43);
			this.listBox2.Margin = new System.Windows.Forms.Padding(4);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(159, 116);
			this.listBox2.TabIndex = 5;
			this.listBox2.Visible = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "IMG3 Containers|*.img3";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.White;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripProgressBar1,
			this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(27, 408);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(746, 26);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1ItemClicked);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 21);
			this.toolStripStatusLabel1.Text = "Progress:";
			this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(373, 20);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 21);
			this.toolStripStatusLabel2.Text = "Ready.";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(16, 322);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(763, 62);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Output (decrypted .img3)";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button6);
			this.panel1.Location = new System.Drawing.Point(621, 14);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(132, 40);
			this.panel1.TabIndex = 2;
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(5, 4);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(119, 33);
			this.button6.TabIndex = 0;
			this.button6.Text = "&Decrypt...";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Location = new System.Drawing.Point(512, 22);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(100, 28);
			this.button5.TabIndex = 1;
			this.button5.Text = "&Browse";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(9, 25);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(493, 22);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Please select an output path!";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Choose an output path for your decrypted .img3 files!";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(16, 48);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(763, 23);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "How do I get IMG3 from IPSW?";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 459);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(27, 30, 27, 25);
			this.ShowIcon = false;
			this.Text = "IPSW Decryptor";
			this.TitleFontStyle = new System.Drawing.Font("Segoe UI", 11.25F);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		// Token: 0x04000024 RID: 36

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ListBox listBox2;

		// Token: 0x04000022 RID: 34

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000026 RID: 38

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000028 RID: 40

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

		// Token: 0x04000025 RID: 37

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000023 RID: 35
	}
}
