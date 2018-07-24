namespace X_TS
{
	partial class mainA
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainA));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menu题目管理 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu题目查询 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu题目编辑 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu学生管理 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu学生查询 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu学生编辑 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu选题管理 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu按学生查询 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu按题查询 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu选题统计 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu学生选题 = new System.Windows.Forms.ToolStripMenuItem();
			this.menu个人 = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label管理员 = new System.Windows.Forms.Label();
			this.label用户 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu题目管理,
            this.menu学生管理,
            this.menu选题管理,
            this.menu学生选题,
            this.menu个人});
			this.menuStrip1.Location = new System.Drawing.Point(0, 36);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(828, 31);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menu题目管理
			// 
			this.menu题目管理.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.menu题目管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu题目查询,
            this.menu题目编辑});
			this.menu题目管理.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.menu题目管理.Name = "menu题目管理";
			this.menu题目管理.Size = new System.Drawing.Size(142, 27);
			this.menu题目管理.Text = "题目信息管理";
			// 
			// menu题目查询
			// 
			this.menu题目查询.Name = "menu题目查询";
			this.menu题目查询.Size = new System.Drawing.Size(216, 28);
			this.menu题目查询.Text = "题目信息查询";
			this.menu题目查询.Click += new System.EventHandler(this.选题ToolStripMenuItem_Click);
			// 
			// menu题目编辑
			// 
			this.menu题目编辑.Name = "menu题目编辑";
			this.menu题目编辑.Size = new System.Drawing.Size(216, 28);
			this.menu题目编辑.Text = "题目信息编辑";
			this.menu题目编辑.Click += new System.EventHandler(this.选题信息编辑ToolStripMenuItem_Click);
			// 
			// menu学生管理
			// 
			this.menu学生管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu学生查询,
            this.menu学生编辑});
			this.menu学生管理.Name = "menu学生管理";
			this.menu学生管理.Size = new System.Drawing.Size(142, 27);
			this.menu学生管理.Text = "学生信息管理";
			// 
			// menu学生查询
			// 
			this.menu学生查询.Name = "menu学生查询";
			this.menu学生查询.Size = new System.Drawing.Size(206, 28);
			this.menu学生查询.Text = "学生信息查询";
			this.menu学生查询.Click += new System.EventHandler(this.学生信息查询ToolStripMenuItem_Click);
			// 
			// menu学生编辑
			// 
			this.menu学生编辑.Name = "menu学生编辑";
			this.menu学生编辑.Size = new System.Drawing.Size(206, 28);
			this.menu学生编辑.Text = "学生信息编辑";
			this.menu学生编辑.Click += new System.EventHandler(this.学生信息查询编辑ToolStripMenuItem_Click);
			// 
			// menu选题管理
			// 
			this.menu选题管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu按学生查询,
            this.menu按题查询,
            this.menu选题统计});
			this.menu选题管理.Name = "menu选题管理";
			this.menu选题管理.Size = new System.Drawing.Size(142, 27);
			this.menu选题管理.Text = "选题信息管理";
			// 
			// menu按学生查询
			// 
			this.menu按学生查询.Name = "menu按学生查询";
			this.menu按学生查询.Size = new System.Drawing.Size(216, 28);
			this.menu按学生查询.Text = "学生选题查询";
			this.menu按学生查询.Click += new System.EventHandler(this.选题信息查询ToolStripMenuItem_Click);
			// 
			// menu按题查询
			// 
			this.menu按题查询.Name = "menu按题查询";
			this.menu按题查询.Size = new System.Drawing.Size(216, 28);
			this.menu按题查询.Text = "题目被选查询";
			this.menu按题查询.Click += new System.EventHandler(this.教师信息编辑ToolStripMenuItem_Click);
			// 
			// menu选题统计
			// 
			this.menu选题统计.Name = "menu选题统计";
			this.menu选题统计.Size = new System.Drawing.Size(216, 28);
			this.menu选题统计.Text = "选题人数统计";
			this.menu选题统计.Click += new System.EventHandler(this.选题人数统计ToolStripMenuItem_Click);
			// 
			// menu学生选题
			// 
			this.menu学生选题.Name = "menu学生选题";
			this.menu学生选题.Size = new System.Drawing.Size(102, 27);
			this.menu学生选题.Text = "我要选题";
			this.menu学生选题.Click += new System.EventHandler(this.menu学生选题_Click);
			// 
			// menu个人
			// 
			this.menu个人.Name = "menu个人";
			this.menu个人.Size = new System.Drawing.Size(142, 27);
			this.menu个人.Text = "个人信息管理";
			this.menu个人.Click += new System.EventHandler(this.个人信息管理ToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("方正姚体", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(-5, -1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(421, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "欢迎使用课程设计选题管理系统";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox3.Location = new System.Drawing.Point(1094, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(35, 34);
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pictureBox5.Location = new System.Drawing.Point(1042, 12);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(35, 34);
			this.pictureBox5.TabIndex = 11;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(0, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1131, 617);
			this.panel1.TabIndex = 12;
			// 
			// label管理员
			// 
			this.label管理员.AutoSize = true;
			this.label管理员.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label管理员.Font = new System.Drawing.Font("方正姚体", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label管理员.ForeColor = System.Drawing.Color.Red;
			this.label管理员.Location = new System.Drawing.Point(413, -1);
			this.label管理员.Name = "label管理员";
			this.label管理员.Size = new System.Drawing.Size(99, 32);
			this.label管理员.TabIndex = 13;
			this.label管理员.Text = "管理员";
			this.label管理员.Click += new System.EventHandler(this.label管理员_Click);
			// 
			// label用户
			// 
			this.label用户.AutoSize = true;
			this.label用户.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label用户.Font = new System.Drawing.Font("方正姚体", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label用户.ForeColor = System.Drawing.Color.Red;
			this.label用户.Location = new System.Drawing.Point(413, -1);
			this.label用户.Name = "label用户";
			this.label用户.Size = new System.Drawing.Size(71, 32);
			this.label用户.TabIndex = 14;
			this.label用户.Text = "用户";
			this.label用户.Click += new System.EventHandler(this.label用户_Click);
			// 
			// mainA
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1131, 689);
			this.Controls.Add(this.label用户);
			this.Controls.Add(this.label管理员);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "mainA";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "管理员主页";
			this.Load += new System.EventHandler(this.main_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_MouseDown);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem menu题目管理;
		private System.Windows.Forms.ToolStripMenuItem menu学生管理;
		private System.Windows.Forms.ToolStripMenuItem menu选题管理;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.ToolStripMenuItem menu题目查询;
		private System.Windows.Forms.ToolStripMenuItem menu题目编辑;
		private System.Windows.Forms.ToolStripMenuItem menu学生查询;
		private System.Windows.Forms.ToolStripMenuItem menu学生编辑;
		private System.Windows.Forms.ToolStripMenuItem menu按学生查询;
		private System.Windows.Forms.ToolStripMenuItem menu按题查询;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem menu选题统计;
		private System.Windows.Forms.ToolStripMenuItem menu学生选题;
		private System.Windows.Forms.Label label管理员;
		private System.Windows.Forms.Label label用户;
		private System.Windows.Forms.ToolStripMenuItem menu个人;
	}
}