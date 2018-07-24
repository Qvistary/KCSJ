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
	public partial class TMbj1 : Form
	{
		public TMbj1()
		{
			InitializeComponent();
		}


		//窗口拖动
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);


		private void pictureBox3_Click(object sender, EventArgs e)//关闭窗口
		{
			this.Close();
		}

		private void TMbj1_MouseDown(object sender, MouseEventArgs e)//窗口拖动
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture(); //释放鼠标捕捉
				SendMessage(Handle, 0xA1, 0x02, 0);//发送左键点击的消息至该窗体(标题栏)
			}
		}

		private void TMbj1_Load(object sender, EventArgs e)
		{
			if (TempData.flag == 1)    //新增选题记录
			{
				textBox1.Text = ""; textBox2.Text = "";
				textBox3.Text = ""; textBox4.Text = "";
			}
			else                   //修改选题记录
			{
				DataTable mytable = new DataTable();
				mytable.Clear();
				mytable = CommDbOp.Exesql("SELECT * FROM X_T WHERE 选题编号='" + TempData.no + "'");
					textBox1.Text = mytable.Rows[0]["选题编号"].ToString().Trim();
					textBox2.Text = mytable.Rows[0]["选题名称"].ToString().Trim();
					textBox3.Text = mytable.Rows[0]["关键词"].ToString().Trim();
					textBox4.Text = mytable.Rows[0]["实现技术"].ToString().Trim();
					textBox1.Enabled = false;       //不允许修改编号
					textBox2.Focus();
		     }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string mysql;
			DataTable mytable1 = new DataTable();
			if (textBox1.Text.ToString() == "")
			{
				MessageBox.Show("必须输入选题编号", "错误提示");
				return;
			}
			if (textBox2.Text.ToString() == "")
			{
				MessageBox.Show("必须输入选题名称", "错误提示");
				return;
			}
			if (textBox3.Text.ToString() == "")
			{
				MessageBox.Show("必须输入关键词", "错误提示");
				return;
			}
			if (textBox4.Text.Trim() == "")
			{
				MessageBox.Show("必须输入实现技术", "错误提示");
				return;
			}
			try
			{
				if (TempData.flag == 1)  //新增选题记录
				{
					mytable1 = CommDbOp.Exesql("SELECT * FROM X_T WHERE 选题编号='" + textBox1.Text + "'");
					if (mytable1.Rows.Count == 1)
					{
						MessageBox.Show("输入的编号重复,不能新增选题记录", "错误提示");
						textBox1.Focus();
						return;
					}
					else          //不重复时插入选题记录
					{
						mysql = "INSERT INTO X_T VALUES( '" + textBox1.Text.Trim() + "','" +
							textBox2.Text.Trim() + "','" +
							textBox3.Text.Trim() + "','" +
							textBox4.Text.Trim() + "')";
						mytable1 = CommDbOp.Exesql(mysql);
						this.Close();
					}
				}
				else   //修改选题记录
                {
							mysql = "UPDATE X_T SET 选题名称='" + textBox2.Text.Trim() +
								"',关键词='" + textBox3.Text.Trim() +
								"',实现技术='" + textBox4.Text.Trim() +
								"' WHERE 选题编号='" + textBox1.Text.Trim() + "'";
							mytable1 = CommDbOp.Exesql(mysql);
							this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "错误提示");//捕获错误
			}
		}

		private void button2_Click(object sender, EventArgs e)//重置
		{
			if (TempData.flag == 1)
			{
				textBox1.Text = ""; textBox2.Text = "";
				textBox3.Text = ""; textBox4.Text = "";
			}
			else
			{
				textBox2.Text = "";
				textBox3.Text = ""; textBox4.Text = "";
			}
				
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
