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
	public partial class XTtj : Form
	{
		DataView mydv = new DataView();
		DataTable mytable = new DataTable();
		string condstr = "";           //存放过滤条件,初始时为空

		public XTtj()
		{
			InitializeComponent();
		}


		private void XTtj_Load(object sender, EventArgs e)
		{
			mytable.Clear();
			if (condstr != "")
				mytable = CommDbOp.Exesql("select X_T.选题编号, COUNT(X_T.选题编号)人员数 from S_T, X_T where S_T.选题编号 = X_T.选题编号 group by X_T.选题编号 HAVING " + condstr);
			else
				mytable = CommDbOp.Exesql("select X_T.选题编号, COUNT(X_T.选题编号)人员数 from S_T, X_T where S_T.选题编号 = X_T.选题编号 group by X_T.选题编号");
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

		private void button6_Click(object sender, EventArgs e)//查询确认
		{
			condstr = "";
			if (textBox1.Text != "")
				condstr = "X_T.选题编号 = '" + textBox1.Text.Trim() + "'";
			else
				MessageBox.Show("请先输入查询条件", "错误信息");
			this.XTtj_Load(sender, e);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";

			condstr = "";
			this.XTtj_Load(sender, e);//重载数据
		}
	}
}
