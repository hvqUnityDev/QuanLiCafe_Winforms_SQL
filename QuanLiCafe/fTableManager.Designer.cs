
namespace QuanLiCafe
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDisCount = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "Thông Tin Tài Khoản";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmFoodCount);
            this.panel2.Location = new System.Drawing.Point(551, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 255);
            this.panel2.TabIndex = 2;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.HideSelection = false;
            this.nmFoodCount.Location = new System.Drawing.Point(3, 3);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(328, 236);
            this.nmFoodCount.TabIndex = 0;
            this.nmFoodCount.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDisCount);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Location = new System.Drawing.Point(551, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 81);
            this.panel3.TabIndex = 3;
            // 
            // btnDisCount
            // 
            this.btnDisCount.Location = new System.Drawing.Point(121, 17);
            this.btnDisCount.Name = "btnDisCount";
            this.btnDisCount.Size = new System.Drawing.Size(94, 32);
            this.btnDisCount.TabIndex = 8;
            this.btnDisCount.Text = "Giảm Giá";
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 17);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(94, 33);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển Bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(237, 17);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(94, 61);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(121, 55);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(94, 23);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(551, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 60);
            this.panel4.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm Món";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(285, 19);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 34);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(175, 23);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(5, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(175, 23);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 33);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(524, 400);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 461);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Quán Cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView nmFoodCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnDisCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}