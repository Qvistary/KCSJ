﻿using System;
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
	public partial class STxt : Form
	{
		DataView mydv = new DataView();
		DataTable mytable = new DataTable();
		string condstr = "";  //存放过滤条件,初始时为空

		public STxt()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void STxt_Load(object sender, EventArgs e)
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
			TempData.no = "";
		}

		private void button2_Click(object sender, EventArgs e)//确认选课
		{
			string  mysql;
			DataTable mytable1 = new DataTable();
			try
			{
				mysql = "UPDATE S_T SET 选题编号 = '" + TempData.no +
						"' WHERE 学号='" + Pass.LoginRule.username + "'";
				mytable1 = CommDbOp.Exesql(mysql);
				MessageBox.Show("恭喜你，选题'"+ TempData.no+"'成功！");
			}
			catch (Exception)
			{
				MessageBox.Show("请先单击选择你要选的课程", "错误提示");
			}

			condstr = "";
			this.STxt_Load(sender, e);//重载数据
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
				TempData.no = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
			else
				TempData.no = "";
		}

		private void button6_Click(object sender, EventArgs e)//确认查询
		{
			condstr = "";
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
				this.STxt_Load(sender, e);
			}
			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text = ""; textBox2.Text = "";

			condstr = "";
			this.STxt_Load(sender, e);//重载数据
		}
	}
}
