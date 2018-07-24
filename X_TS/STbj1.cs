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
	public partial class STbj1 : Form
	{
		public STbj1()
		{
			InitializeComponent();
		}

		//窗口拖动
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		private void STbj1_Load(object sender, EventArgs e)
		{
			if (TempData.flag == 1)    //新增学生记录
			{
				textBox1.Text = ""; textBox2.Text = "";
				textBox3.Text = ""; textBox5.Text = "";
				textBox4.Text = "";
				radioButton1.Checked = false; radioButton1.Checked = false;
			}
			else                   //修改选题记录
			{
				DataTable mytable = new DataTable();
				mytable.Clear();
				mytable = CommDbOp.Exesql("SELECT * FROM S_T WHERE 学号='" + TempData.no + "'");
				textBox1.Text = mytable.Rows[0]["学号"].ToString().Trim();
				textBox2.Text = mytable.Rows[0]["姓名"].ToString().Trim();
				if (mytable.Rows[0]["性别"].ToString() == "男")
					radioButton1.Checked = true;
				else if (mytable.Rows[0]["性别"].ToString() == "女")
					radioButton2.Checked = true;
				textBox3.Text = mytable.Rows[0]["年龄"].ToString().Trim();
				textBox4.Text = mytable.Rows[0]["班级"].ToString().Trim();
				textBox5.Text = mytable.Rows[0]["专业"].ToString().Trim();
				textBox1.Enabled = false;       //不允许修改编号
				textBox2.Focus();
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void STbj1_MouseDown(object sender, MouseEventArgs e)//窗口拖动
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture(); //释放鼠标捕捉 
				SendMessage(Handle, 0xA1, 0x02, 0);//发送左键点击的消息至该窗体(标题栏)
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string Sex, mysql;
			DataTable mytable1 = new DataTable();
			if (textBox1.Text.ToString() == "")
			{
				MessageBox.Show("必须输入学号", "错误提示");
				return;
			}
			if (textBox2.Text.ToString() == "")
			{
				MessageBox.Show("必须输入姓名", "错误提示");
				return;
			}
			if (textBox3.Text.ToString() == "")
			{
				MessageBox.Show("必须输入年龄", "错误提示");
				return;
			}
			if (textBox4.Text.Trim() == "")
			{
				MessageBox.Show("必须输入班级", "错误提示");
				return;
			}
			if (textBox5.Text.Trim() == "")
			{
				MessageBox.Show("必须输入专业", "错误提示");
				return;
			}
			if (radioButton1.Checked)
				Sex = "男";
			else if (radioButton2.Checked)
				Sex = "女";
			else
				Sex = "";
			try
			{
				if (TempData.flag == 1)  //新增学生记录
				{
					mytable1 = CommDbOp.Exesql("SELECT * FROM S_T WHERE 学号='" + textBox1.Text + "'");
					if (mytable1.Rows.Count == 1)
					{
						MessageBox.Show("输入的学号重复,不能新增学生记录", "错误提示");
						textBox1.Focus();
						return;
					}
					else          //不重复时插入学生记录
					{
						mysql = "INSERT INTO S_T (学号,姓名,性别,年龄,班级,专业,密码) VALUES( '" + textBox1.Text.Trim() + "','" +
							textBox2.Text.Trim() + "','" +
							Sex + "','" +
							textBox3.Text.Trim() + "','" +
							textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox1.Text.Trim() + "')";//初始密码学号
						mytable1 = CommDbOp.Exesql(mysql);
						this.Close();
					}
				}
				else   //修改选题记录
				{
					mysql = "UPDATE S_T SET 姓名='" + textBox2.Text.Trim() +
						"',性别='" + Sex +
						"',年龄='" + textBox3.Text.Trim() +
						"',班级='" + textBox4.Text.Trim() +
						"',专业='" + textBox5.Text.Trim() +
						"' WHERE 学号='" + textBox1.Text.Trim() + "'";
					mytable1 = CommDbOp.Exesql(mysql);
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "错误提示");
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
