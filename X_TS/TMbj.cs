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
	public partial class TMbj : Form
	{
		DataView mydv = new DataView();
		DataTable mytable = new DataTable();
		DataTable mytable1 = new DataTable();
		string condstr = "";           //存放过滤条件,初始时为空

		public TMbj()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)//添加确认
		{
			condstr = "";
			this.TMbj_Load(sender, e);//重载数据

			TempData.flag = 1;                //TempData.flag为全局变量,传递给editstudent1窗体,临时数据存储
			Form myform = new TMbj1();
			myform.ShowDialog();            //调用窗口
			this.TMbj_Load(sender, e);
		}



		private void TMbj_Load(object sender, EventArgs e)
		{

			mytable.Clear();
			if (condstr != "")
				mytable = CommDbOp.Exesql("SELECT * FROM X_T WHERE " + condstr);
			else
				mytable = CommDbOp.Exesql("SELECT * FROM X_T");
			mydv = mytable.DefaultView;  //获得DataView对象mydv

			//以下设置dataGridView1的属性

			dataGridView1.DataSource = mydv;
			dataGridView1.ReadOnly = true;      //只读
			dataGridView1.AllowUserToAddRows = false; //去掉最后空白行
			dataGridView1.GridColor = Color.Gray;
			dataGridView1.ScrollBars = ScrollBars.Vertical;
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 12);
			dataGridView1.DefaultCellStyle.Font = new Font("微软雅黑", 10);
			dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
			//行高，列宽调整到适合位于屏幕上当前显示的行中的列的所有单元格（包括标头单元格）的内容。
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

		}

		private void button3_Click(object sender, EventArgs e)//删除确认
		{
			TempData.flag = 3;
			if (TempData.no != "")
			{
				if (MessageBox.Show("真的要删除编号为" + TempData.no + "的选题记录吗?",
					"删除确认",
					MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					TempData.flag = 3;
					string mysql = "DELETE X_T WHERE 选题编号='" + TempData.no.Trim() + "'";
					mytable1 = CommDbOp.Exesql(mysql);
					this.TMbj_Load(sender, e);
				}
			}
			else
			MessageBox.Show("先选择要删除的选题记录", "错误提示");


			condstr = "";
			this.TMbj_Load(sender, e);//重载数据
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//单击数据框选择
		{
			if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount )
				TempData.no = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
			else
				TempData.no = "";
		}

		private void button4_Click(object sender, EventArgs e)//修改确认
		{
			TempData.flag = 2;               //TempData.flag为全局变量,传递给editstudent1窗体
			if (TempData.no != "")
			{
				Form myform = new TMbj1();
				myform.ShowDialog();        //采用有模式方式调用
				this.TMbj_Load(sender, e);
				dataGridView1.Refresh();
			}
			else
				MessageBox.Show("先选择要修改的选题记录", "错误提示");

			condstr = "";
			this.TMbj_Load(sender, e);//重载数据
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();//清楚默认选择
			TempData.no = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button6_Click(object sender, EventArgs e)//查询确认
		{
			condstr = "";
			if (textBox1.Text == "" && textBox2.Text == "")
			{
				MessageBox.Show("请先输入查询条件", "错误信息");
			}
			else
			{
				if (textBox1.Text != "")
					condstr = "选题编号 Like '" + textBox1.Text.Trim() + "%'";
				if (textBox2.Text != "")
				{
					if (condstr != "")
						condstr = condstr + " AND 关键词 Like '" + textBox2.Text.Trim() + "%'";
					else
						condstr = "关键词 Like '" + textBox2.Text.Trim() + "%'";
				}
				this.TMbj_Load(sender, e);
			}
		}

		private void button5_Click(object sender, EventArgs e)//重置查询
		{
			textBox1.Text = ""; textBox2.Text = "";

			condstr = "";
			this.TMbj_Load(sender, e);//重载数据
		}
	}
}
