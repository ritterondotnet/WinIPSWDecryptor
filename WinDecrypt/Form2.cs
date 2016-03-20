using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WinIPSWDecryptor
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : MetroForm
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002067 File Offset: 0x00000267
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002078 File Offset: 0x00000278
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length != 32)
			{
				MessageBox.Show("The Key must be 32 chars long.");
				return;
			}
			if (this.textBox2.Text.Length != 32)
			{
				MessageBox.Show("The IV must be 32 chars long.");
				return;
			}
			this.richTextBox1.Clear();
			this.richTextBox1.AppendText("KEY:" + this.textBox1.Text + "\nIV:" + this.textBox2.Text);
			this.richTextBox1.SaveFile(Application.StartupPath + "\\temp.txt", RichTextBoxStreamType.UnicodePlainText);
			base.Close();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002258 File Offset: 0x00000458
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F4 File Offset: 0x000003F4
		private void Form2_Load(object sender, EventArgs e)
		{
			this.richTextBox1.LoadFile(Application.StartupPath + "\\temp.txt", RichTextBoxStreamType.UnicodePlainText);
			this.label4.Text = this.richTextBox1.Text;
			this.richTextBox1.Clear();
			this.richTextBox1.SaveFile(Application.StartupPath + "\\temp.txt", RichTextBoxStreamType.UnicodePlainText);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000225A File Offset: 0x0000045A
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://ipsw.me/keys");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002124 File Offset: 0x00000324
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length != 32)
			{
				this.label5.Text = "The Key must be 32 chars long.";
				return;
			}
			if (this.textBox2.Text.Length != 32)
			{
				this.label5.Text = "The IV must be 32 chars long.";
				return;
			}
			this.label5.Text = "Check your keys twice before proceed.";
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000218C File Offset: 0x0000038C
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length != 32)
			{
				this.label5.Text = "The Key must be 32 chars long.";
				return;
			}
			if (this.textBox2.Text.Length != 32)
			{
				this.label5.Text = "The IV must be 32 chars long.";
				return;
			}
			this.label5.Text = "Check your keys twice before proceed.";
		}
	}
}
