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
	
	public partial class TMcx : Form
	{
		DataView mydv = new DataView();
		DataTable mytable = new DataTable();
		string condstr = "";           //存放过滤条件,初始时为空

		public TMcx()
		{
			InitializeComponent();
		}


		private void TMcx_Load(object sender, EventArgs e)
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

		private void button1_Click(object sender, EventArgs e)//确认查询
		{
			condstr = "";
			if(textBox1.Text == ""&&textBox2.Text == "")
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
				this.TMcx_Load(sender, e);
			}			
		}

		private void button2_Click(object sender, EventArgs e)//重置查询
		{
			textBox1.Text = ""; textBox2.Text = "";

			condstr = "";
			this.TMcx_Load(sender, e);//重载数据
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();//清楚默认选择
		}
	}
}
