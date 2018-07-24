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
	public partial class STbj : Form
	{
		DataView mydv = new DataView();
		DataTable mytable = new DataTable();
		DataTable mytable1 = new DataTable();
		string condstr = "";           //存放过滤条件,初始时为空

		public STbj()
		{
			InitializeComponent();
		}

		private void STbj_Load(object sender, EventArgs e)
		{
			mytable.Clear();
			if (condstr != "")
				mytable = CommDbOp.Exesql("SELECT 学号,姓名,性别,年龄,班级,专业 FROM S_T WHERE " + condstr);
			else
				mytable = CommDbOp.Exesql("SELECT 学号,姓名,性别,年龄,班级,专业 FROM S_T");
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

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)//初始数据绑定完成事件
		{
			dataGridView1.ClearSelection();//清楚默认选择
			TempData.no = "";
		}

		private void button6_Click(object sender, EventArgs e)//查询确认按钮
		{
			condstr = "";
			if (textBox1.Text == "" && textBox2.Text == "")
			{
				MessageBox.Show("请先输入查询条件", "错误信息");
			}
			else
			{
				if (textBox1.Text != "")
					condstr = "学号 Like '" + textBox1.Text.Trim() + "%'";
				if (textBox2.Text != "")
				{
					if (condstr != "")
						condstr = condstr + " AND 姓名 Like '" + textBox2.Text.Trim() + "%'";
					else
						condstr = "姓名 Like '" + textBox2.Text.Trim() + "%'";
				}
				this.STbj_Load(sender, e);
			}	
		}

		private void button5_Click(object sender, EventArgs e)//重置查询
		{
			textBox1.Text = ""; textBox2.Text = "";

			condstr = "";
			this.STbj_Load(sender, e);//重载数据
		}

		private void button2_Click(object sender, EventArgs e)//添加学生信息按钮
		{
			condstr = "";
			this.STbj_Load(sender, e);//重载数据

			TempData.flag = 1;                //TempData.flag为全局变量,传递给editstudent1窗体,临时数据存储
			Form myform = new STbj1();
			myform.ShowDialog();            //调用窗口
			this.STbj_Load(sender, e);
		}

		private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)//单击数据框选择
		{
			if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
				TempData.no = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
			else
				TempData.no = "";
		}

		private void button3_Click(object sender, EventArgs e)//删除确认按钮
		{
			TempData.flag = 3;
			if (TempData.no != "")
			{
				if (MessageBox.Show("真的要删除学号为" + TempData.no + "的学生记录吗?",
					"删除确认",
					MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					TempData.flag = 3;
					string mysql = "DELETE S_T WHERE 学号='" + TempData.no.Trim() + "'";
					mytable1 = CommDbOp.Exesql(mysql);
					this.STbj_Load(sender, e);
				}
			}
			else
				MessageBox.Show("先选择要删除的选题记录", "错误提示");

			condstr = "";
			this.STbj_Load(sender, e);//重载数据
		}

		private void button4_Click(object sender, EventArgs e)//修改确认按钮
		{
			TempData.flag = 2;               //TempData.flag为全局变量,传递给editstudent1窗体
			if (TempData.no != "")
			{
				Form myform = new STbj1();
				myform.ShowDialog();        //采用有模式方式调用
				this.STbj_Load(sender, e);
				dataGridView1.Refresh();
			}
			else
				MessageBox.Show("先选择要修改的选题记录", "错误提示");

			condstr = "";
			this.STbj_Load(sender, e);//重载数据
		}

		private void button1_Click(object sender, EventArgs e)//退出按钮
		{
			this.Close();
		}
	}
}
