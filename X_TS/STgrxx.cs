using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_TS
{
	public partial class STgrxx : Form
	{
		DataView mydv = new DataView();
		DataTable mytable = new DataTable();

		public STgrxx()
		{
			InitializeComponent();
		}

		private void STgrxx_Load(object sender, EventArgs e)
		{
			mytable.Clear();
			mytable = CommDbOp.Exesql("SELECT 学号,姓名,性别,年龄,班级,专业,X_T.选题编号,选题名称"+
				" FROM S_T LEFT OUTER JOIN X_T ON(S_T.选题编号 = X_T.选题编号)  WHERE 学号 = '"+Pass.LoginRule.username+ "'");
			mydv = mytable.DefaultView;  //获得DataView对象mydv

			//以下设置dataGridView1的属性
			dataGridView1.DataSource = mydv;
			dataGridView1.ReadOnly = true;      //只读
			dataGridView1.GridColor = Color.Gray;
			dataGridView1.ScrollBars = ScrollBars.Vertical;
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 12);
			dataGridView1.DefaultCellStyle.Font = new Font("微软雅黑", 10);
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			//行高，列宽调整到适合位于屏幕上当前显示的行中的列的所有单元格（包括标头单元格）的内容。
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();//清楚默认选择
		}

		private void button6_Click(object sender, EventArgs e)//确认修改密码按钮
		{
			if(textBox1.Text == "" )
			{
				MessageBox.Show("请输入密码", "错误提示");
			}
			else
			{
				if (textBox1.Text == textBox2.Text)
				{
					try
					{
						string mysql;
						DataTable mytable1 = new DataTable();
						mysql = "UPDATE S_T SET 密码 = '" + textBox1.Text.Trim() +
								"' WHERE 学号='" + Pass.LoginRule.username + "'";
						mytable1 = CommDbOp.Exesql(mysql);
						MessageBox.Show("恭喜你，密码修改成功！");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message.ToString(), "错误提示");
					}
				}
				else
				{
					MessageBox.Show("两次输入的密码不同，请重新输入");
					textBox1.Text = "";
					textBox2.Text = "";
				}
			
			}

		}

		private void button5_Click(object sender, EventArgs e)//重置按钮
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}
	}
}
