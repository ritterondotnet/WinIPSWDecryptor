namespace WinIPSWDecryptor
{
	// Token: 0x02000003 RID: 3
	public partial class Form2
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002267 File Offset: 0x00000467
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002288 File Offset: 0x00000488
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the key and IV for: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Key";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 119);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "IV";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(63, 82);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(408, 22);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 115);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(408, 22);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(188, 193);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 28);
			this.button1.TabIndex = 5;
			this.button1.Text = "Decrypt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(240, 16);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 17);
			this.label4.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 147);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Enter the Key and IV to decrypt.";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(489, 15);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(255, 133);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(755, 16);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(132, 22);
			this.textBox3.TabIndex = 9;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(378, 147);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(93, 17);
			this.linkLabel1.TabIndex = 10;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Find Keys/IVs";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 234);
			this.ControlBox = false;
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MetroBorderThickness = 2;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.Padding = new System.Windows.Forms.Padding(27, 30, 27, 25);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Text = "Enter Key/IV";
			this.TitleFontStyle = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TextBox textBox3;
	}
}
