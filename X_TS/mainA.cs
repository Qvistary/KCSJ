using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace X_TS
{
	public partial class mainA : Form
	{
		public mainA()
		{
			InitializeComponent();
		}
		
		//窗口拖动
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		private void main_Load(object sender, EventArgs e)
		{
			if (TempData.userlevel == "管理员")
			{
				menu学生选题.Visible = false;
				menu个人.Visible = false;
				label用户.Visible = false;
			}

			if (TempData.userlevel == "用户")
			{
				menu选题管理.Visible = false;
				menu学生管理.Visible = false;
				menu题目管理.Visible = false;
				label管理员.Visible = false;

			}

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void main_MouseDown(object sender, MouseEventArgs e)
		{
				if (e.Button == MouseButtons.Left)
				{
					ReleaseCapture(); //释放鼠标捕捉
				    //发送左键点击的消息至该窗体(标题栏)
					SendMessage(Handle, 0xA1, 0x02, 0);
				}
		}



		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;//最小化
		}

		private void 学生信息查询编辑ToolStripMenuItem_Click(object sender, EventArgs e)//学生信息编辑
		{
			panel1.Controls.Clear();
			STbj frm = new STbj();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);
			frm.Parent = this.panel1;
			frm.Show();
		}


		private void 选题ToolStripMenuItem_Click(object sender, EventArgs e)//题目查询
		{
			panel1.Controls.Clear();
			TMcx frm = new TMcx();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void 选题信息编辑ToolStripMenuItem_Click(object sender, EventArgs e)//题目编辑
		{
			panel1.Controls.Clear();//panel清空
			TMbj frm = new TMbj();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)//学生信息查询
		{
			panel1.Controls.Clear();//panel清空
			STcx frm = new STcx();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void 选题信息查询ToolStripMenuItem_Click(object sender, EventArgs e)//选题查询
		{
			panel1.Controls.Clear();//panel清空
			XTcx frm = new XTcx();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void 教师信息编辑ToolStripMenuItem_Click(object sender, EventArgs e)//选题操作
		{
			panel1.Controls.Clear();//panel清空
			XTcxtm frm = new XTcxtm();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void 选题人数统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();//panel清空
			XTtj frm = new XTtj();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void menu学生选题_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();//panel清空
			STxt frm = new STxt();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void 个人信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();//panel清空
			STgrxx frm = new STgrxx();
			frm.TopLevel = false;
			this.panel1.Controls.Add(frm);//在panel里添加窗体
			frm.Parent = this.panel1;
			frm.Show();
		}

		private void label用户_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form myform = new Pass();
			myform.ShowDialog();
			this.Close();
		}

		private void label管理员_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form myform = new Pass();
			myform.ShowDialog();
			this.Close();
		}
	}
}
