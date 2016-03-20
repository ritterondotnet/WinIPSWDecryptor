using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WinIPSWDecryptor
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : MetroForm
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000289A File Offset: 0x00000A9A
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000033C1 File Offset: 0x000015C1
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("WinIPSWDecryptor - (c) 2016 ExaPhaser Industries", "About WinIPSWDecryptor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002934 File Offset: 0x00000B34
		private void button1_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.ShowDialog();
			string fileName = this.openFileDialog1.FileName;
			string a;
			if (fileName != "")
			{
				a = fileName.Substring(fileName.Length - 5, 5);
			}
			else
			{
				a = "this.is.not.an.img3.file";
			}
			if (fileName == "" || a != ".img3")
			{
				MessageBox.Show("You did not select a .img3 container!", "Warning", MessageBoxButtons.OK);
				return;
			}
			if (this.listBox1.Items.Count == 0)
			{
				this.listBox2.Items.Add(this.openFileDialog1.SafeFileName);
				this.listBox1.Items.Add(this.openFileDialog1.FileName);
				this.listBox1.SelectedItem = this.listBox1.Items[0];
				return;
			}
			string fileName2 = this.openFileDialog1.FileName;
			if (fileName2.Replace(" ", "") == "")
			{
				MessageBox.Show("Remember, this version of APT-Packaging Utility CANNOT handle file names with space chars! \nPlease replace them with '_' '-' '.' or something else. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				return;
			}
			for (int i = 0; i < this.listBox1.Items.Count; i++)
			{
				if (this.listBox1.Items[i].ToString() == fileName2)
				{
					MessageBox.Show("no dups allowed:" + fileName2);
					return;
				}
			}
			this.listBox2.Items.Add(this.openFileDialog1.SafeFileName);
			this.listBox1.Items.Add(this.openFileDialog1.FileName);
			this.listBox1.SelectedItem = this.listBox1.Items[0];
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002AF0 File Offset: 0x00000CF0
		private void button2_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.listBox1.SelectedIndex;
			try
			{
				this.listBox1.Items.RemoveAt(selectedIndex);
				this.listBox2.Items.RemoveAt(selectedIndex);
				this.listBox1.SelectedItem = this.listBox1.Items[0];
			}
			catch
			{
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002B5C File Offset: 0x00000D5C
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.listBox1.Items.Count > 0)
			{
				string mD5HashFromFile = this.GetMD5HashFromFile(this.listBox1.SelectedItem.ToString());
				MessageBox.Show(mD5HashFromFile, "MD5 Sum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				this.toolStripProgressBar1.Value = 100;
				this.toolStripStatusLabel2.Text = "MD5 copied into clipboard!";
				Clipboard.SetText(mD5HashFromFile);
				return;
			}
			MessageBox.Show("Please add some img3 Containers first!", "Alert", MessageBoxButtons.OK);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002BE0 File Offset: 0x00000DE0
		private void button4_Click(object sender, EventArgs e)
		{
			if (this.listBox1.Items.Count > 0)
			{
				this.toolStripProgressBar1.Value = 45;
				this.toolStripStatusLabel2.Text = "Calculating Size...";
				string exactFileSize = this.GetExactFileSize(this.listBox1.SelectedItem.ToString());
				MessageBox.Show(exactFileSize + " Bytes", "Size", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
				this.toolStripProgressBar1.Value = 100;
				this.toolStripStatusLabel2.Text = "Size copied into clipboard!";
				Clipboard.SetText(exactFileSize);
				return;
			}
			MessageBox.Show("Please add some .img3 containers first!", "Information", MessageBoxButtons.OK);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C88 File Offset: 0x00000E88
		private void button5_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.ShowDialog();
			string selectedPath = this.folderBrowserDialog1.SelectedPath;
			this.textBox1.Text = selectedPath;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002CBC File Offset: 0x00000EBC
		private void button6_Click(object sender, EventArgs e)
		{
			this.toolStripProgressBar1.Value = 0;
			if (this.listBox1.Items.Count == 0)
			{
				MessageBox.Show("Please add some .img3 containers first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (this.textBox1.Text == "Please select an output path!")
			{
				MessageBox.Show("Please choose a valid output path!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text = null;
			string text2 = null;
			while (this.number < this.listBox1.Items.Count)
			{
				Console.WriteLine(this.number);
				this.toolStripProgressBar1.Value = 20;
				if (this.number == 0)
				{
					text = this.listBox1.Items[0].ToString();
				}
				if (this.number == 1)
				{
					text = this.listBox1.Items[1].ToString();
				}
				if (this.number == 2)
				{
					text = this.listBox1.Items[2].ToString();
				}
				if (this.number == 3)
				{
					text = this.listBox1.Items[3].ToString();
				}
				if (this.number == 4)
				{
					text = this.listBox1.Items[4].ToString();
				}
				if (this.number == 5)
				{
					text = this.listBox1.Items[5].ToString();
				}
				if (this.number == 6)
				{
					text = this.listBox1.Items[6].ToString();
				}
				if (this.number == 7)
				{
					text = this.listBox1.Items[7].ToString();
				}
				if (this.number == 8)
				{
					text = this.listBox1.Items[8].ToString();
				}
				if (this.number == 9)
				{
					text = this.listBox1.Items[9].ToString();
				}
				if (this.number == 10)
				{
					text = this.listBox1.Items[10].ToString();
				}
				if (this.number == 11)
				{
					text = this.listBox1.Items[11].ToString();
				}
				if (this.number == 12)
				{
					text = this.listBox1.Items[12].ToString();
				}
				if (this.number == 13)
				{
					text = this.listBox1.Items[13].ToString();
				}
				if (this.number == 0)
				{
					text2 = this.listBox2.Items[0].ToString();
				}
				if (this.number == 1)
				{
					text2 = this.listBox2.Items[1].ToString();
				}
				if (this.number == 2)
				{
					text2 = this.listBox2.Items[2].ToString();
				}
				if (this.number == 3)
				{
					text2 = this.listBox2.Items[3].ToString();
				}
				if (this.number == 4)
				{
					text2 = this.listBox2.Items[4].ToString();
				}
				if (this.number == 5)
				{
					text2 = this.listBox2.Items[5].ToString();
				}
				if (this.number == 6)
				{
					text2 = this.listBox2.Items[6].ToString();
				}
				if (this.number == 7)
				{
					text2 = this.listBox2.Items[7].ToString();
				}
				if (this.number == 8)
				{
					text2 = this.listBox2.Items[8].ToString();
				}
				if (this.number == 9)
				{
					text2 = this.listBox2.Items[9].ToString();
				}
				if (this.number == 10)
				{
					text2 = this.listBox2.Items[10].ToString();
				}
				if (this.number == 11)
				{
					text2 = this.listBox2.Items[11].ToString();
				}
				if (this.number == 12)
				{
					text2 = this.listBox2.Items[12].ToString();
				}
				if (this.number == 13)
				{
					text2 = this.listBox2.Items[13].ToString();
				}
				string text3 = text;
				string text4 = text3.Replace("\\", "/");
				Process process = new Process();
				string xpwnpath = Application.StartupPath + "\\xpwntool.exe";
				File.WriteAllBytes(xpwnpath, Properties.Resources.xpwntool);
				ProcessStartInfo processStartInfo = new ProcessStartInfo(xpwnpath);
				var fileStream = File.Open(Application.StartupPath + "\\temp.txt", FileMode.Open);
				byte[] bytes = new byte[1024];
				UTF8Encoding uTF8Encoding = new UTF8Encoding(true);
				string @string = uTF8Encoding.GetString(bytes);
				string[] lines = @string.Split(new char[]
				{
					'\n'
				});
				this.textBox2.Lines = lines;
				fileStream.Close();
				this.textBox2.AppendText(text2);
				this.richTextBox1.Lines = this.textBox2.Lines;
				this.richTextBox1.SaveFile(Application.StartupPath + "\\temp.txt", RichTextBoxStreamType.UnicodePlainText);
				this.toolStripProgressBar1.Value = 50;
				Form2 form = new Form2();
				int num = this.number;
				form.ShowDialog();
				this.number = 100;
				try
				{
					this.richTextBox1.LoadFile(Application.StartupPath + "\\temp.txt", RichTextBoxStreamType.UnicodePlainText);
					string text5 = string.Concat(new string[]
					{
						"\"",
						text4,
						"\" \"",
						this.textBox1.Text.Replace("\\", "/"),
						"/",
						text2.Remove(text2.Length - 4),
						"_decrypted.img3\" -k ",
						this.richTextBox1.Lines[0].Replace("KEY:", ""),
						" -iv ",
						this.richTextBox1.Lines[1].Replace("IV:", "")
					});
					processStartInfo.Arguments = text5;
					processStartInfo.CreateNoWindow = true;
					processStartInfo.UseShellExecute = false;
					process = Process.Start(processStartInfo);
					this.toolStripProgressBar1.Value = 70;
					this.richTextBox1.Clear();
					this.richTextBox1.SaveFile(Application.StartupPath + "\\temp.txt");
					process.WaitForExit();
					string a = process.ExitCode.ToString();
					this.textBox3.Text = text5;
					if (a != "0")
					{
						MessageBox.Show("There was an error during decrypting " + text2);
					}
					else
					{
						this.number = num + 1;
						this.toolStripProgressBar1.Value = 100;
					}
				}
				catch
				{
					MessageBox.Show("There was an error decrypting IMG3 \nfrom " + text4 + "\nPlease make sure you have a valid IMG3!", "Error -- Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002908 File Offset: 0x00000B08
		protected string GetExactFileSize(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			long length = fileStream.Length;
			fileStream.Close();
			return length.ToString();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000028A8 File Offset: 0x00000AA8
		protected string GetMD5HashFromFile(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			MD5 mD = new MD5CryptoServiceProvider();
			byte[] array = mD.ComputeHash(fileStream);
			fileStream.Close();
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000033D6 File Offset: 0x000015D6
		private void quitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000033B4 File Offset: 0x000015B4
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.theiphonewiki.com/wiki/index.php?title=Firmware");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002BDD File Offset: 0x00000DDD
		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000F RID: 15
		public string iv;

		// Token: 0x0400000E RID: 14
		public string key;

		// Token: 0x0400000D RID: 13
		public int number;
		void StatusStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Unzip the IPSW with 7-zip, then browse the contents, which will be full of IMG3 files.","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
