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
	public partial class Pass : Form
	{
		public Pass()
		{
			InitializeComponent();
		}

		//窗口拖动
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		public class LoginRule
		{
			//定义公共变量username
			public static string username = "";
		}


		private void Pass_Load(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}



		private void button1_Click(object sender, EventArgs e)
		{
			DataTable mytable;
			DataTable mytable2;
			DataTable mytable3;
			string mysql = "SELECT * FROM S_A WHERE 用户名='" + textBox1.Text +
				"' AND 密码='" + textBox2.Text + "'";
			mytable = CommDbOp.Exesql(mysql);
			if (mytable.Rows.Count == 0)
			{
				mysql = "SELECT * FROM S_T WHERE 学号='" + textBox1.Text +
				"' AND 密码='" + textBox2.Text + "'";
				mytable2 = CommDbOp.Exesql(mysql);
				if (mytable2.Rows.Count == 0)
				{
					mysql = "SELECT * FROM S_T WHERE 学号='" + textBox1.Text +
				  "' AND 密码='" + textBox2.Text + "'";
					mytable3 = CommDbOp.Exesql(mysql);

					if (mytable3.Rows.Count == 0)
					{
						MessageBox.Show("用户名或密码错误");
						textBox2.Text = "";
					}
				}
				else
				{
					TempData.userlevel = "用户";
					LoginRule.username = textBox1.Text.Trim();
					this.Hide();
					Form myform = new mainA();
					myform.ShowDialog();
					this.Close();
				}
			}
			else
			{
				TempData.userlevel = "管理员";
				this.Hide();
				Form myform = new mainA();
				myform.ShowDialog();
				this.Close();
			}
		}

		private void Pass_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture(); //释放鼠标捕捉
								  //发送左键点击的消息至该窗体(标题栏)
				SendMessage(Handle, 0xA1, 0x02, 0);
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)//窗口关闭
		{
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;//最小化
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}


}


