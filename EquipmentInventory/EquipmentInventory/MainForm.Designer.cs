namespace EquipmentInventory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEquipment = new System.Windows.Forms.ToolStripDropDownButton();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ComingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsumptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WriteOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonEquipDirectory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonApplication = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProvider = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDepartment = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdmin = new System.Windows.Forms.ToolStripButton();
            this.eQUIPMENT_ACCOUNTINGDataSet = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSet();
            this.applicationTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.ApplicationTableAdapter();
            this.equipmentTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxUserStatus = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.dataGridViewEquipment);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 499);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.AllowUserToAddRows = false;
            this.dataGridViewEquipment.AllowUserToDeleteRows = false;
            this.dataGridViewEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEquipment.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.ReadOnly = true;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(847, 461);
            this.dataGridViewEquipment.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEquipment,
            this.toolStripButtonEquipDirectory,
            this.toolStripSeparator1,
            this.toolStripButtonApplication,
            this.toolStripButtonProvider,
            this.toolStripButtonEmployee,
            this.toolStripButtonDepartment,
            this.toolStripButtonExit,
            this.toolStripButtonAdmin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonEquipment
            // 
            this.toolStripButtonEquipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderToolStripMenuItem,
            this.расходToolStripMenuItem,
            this.ComingToolStripMenuItem,
            this.ConsumptionToolStripMenuItem,
            this.WriteOffToolStripMenuItem,
            this.BalanceToolStripMenuItem});
            this.toolStripButtonEquipment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEquipment.Image")));
            this.toolStripButtonEquipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEquipment.Name = "toolStripButtonEquipment";
            this.toolStripButtonEquipment.Size = new System.Drawing.Size(101, 35);
            this.toolStripButtonEquipment.Text = "Оборудование";
            this.toolStripButtonEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.OrderToolStripMenuItem.Text = "Заказ оборудования";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // расходToolStripMenuItem
            // 
            this.расходToolStripMenuItem.Name = "расходToolStripMenuItem";
            this.расходToolStripMenuItem.Size = new System.Drawing.Size(183, 6);
            // 
            // ComingToolStripMenuItem
            // 
            this.ComingToolStripMenuItem.Name = "ComingToolStripMenuItem";
            this.ComingToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ComingToolStripMenuItem.Text = "Приход";
            this.ComingToolStripMenuItem.Click += new System.EventHandler(this.ComingToolStripMenuItem_Click);
            // 
            // ConsumptionToolStripMenuItem
            // 
            this.ConsumptionToolStripMenuItem.Name = "ConsumptionToolStripMenuItem";
            this.ConsumptionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ConsumptionToolStripMenuItem.Text = "Расход";
            this.ConsumptionToolStripMenuItem.Click += new System.EventHandler(this.ConsumptionToolStripMenuItem_Click);
            // 
            // WriteOffToolStripMenuItem
            // 
            this.WriteOffToolStripMenuItem.Name = "WriteOffToolStripMenuItem";
            this.WriteOffToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.WriteOffToolStripMenuItem.Text = "Списание";
            this.WriteOffToolStripMenuItem.Click += new System.EventHandler(this.WriteOffToolStripMenuItem_Click);
            // 
            // BalanceToolStripMenuItem
            // 
            this.BalanceToolStripMenuItem.Name = "BalanceToolStripMenuItem";
            this.BalanceToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.BalanceToolStripMenuItem.Text = "Остаток";
            this.BalanceToolStripMenuItem.Click += new System.EventHandler(this.BalanceToolStripMenuItem_Click);
            // 
            // toolStripButtonEquipDirectory
            // 
            this.toolStripButtonEquipDirectory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEquipDirectory.Image")));
            this.toolStripButtonEquipDirectory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEquipDirectory.Name = "toolStripButtonEquipDirectory";
            this.toolStripButtonEquipDirectory.Size = new System.Drawing.Size(161, 35);
            this.toolStripButtonEquipDirectory.Text = "Справочник оборудования";
            this.toolStripButtonEquipDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonEquipDirectory.Click += new System.EventHandler(this.toolStripButtonEquipDirectory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonApplication
            // 
            this.toolStripButtonApplication.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonApplication.Image")));
            this.toolStripButtonApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApplication.Name = "toolStripButtonApplication";
            this.toolStripButtonApplication.Size = new System.Drawing.Size(49, 35);
            this.toolStripButtonApplication.Text = "Заявки";
            this.toolStripButtonApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonApplication.Click += new System.EventHandler(this.toolStripButtonApplication_Click);
            // 
            // toolStripButtonProvider
            // 
            this.toolStripButtonProvider.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProvider.Image")));
            this.toolStripButtonProvider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProvider.Name = "toolStripButtonProvider";
            this.toolStripButtonProvider.Size = new System.Drawing.Size(81, 35);
            this.toolStripButtonProvider.Text = "Поставщики";
            this.toolStripButtonProvider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonProvider.Click += new System.EventHandler(this.toolStripButtonProvider_Click);
            // 
            // toolStripButtonEmployee
            // 
            this.toolStripButtonEmployee.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEmployee.Image")));
            this.toolStripButtonEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEmployee.Name = "toolStripButtonEmployee";
            this.toolStripButtonEmployee.Size = new System.Drawing.Size(77, 35);
            this.toolStripButtonEmployee.Text = "Сотрудники";
            this.toolStripButtonEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonEmployee.Click += new System.EventHandler(this.toolStripButtonEmployee_Click);
            // 
            // toolStripButtonDepartment
            // 
            this.toolStripButtonDepartment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDepartment.Image")));
            this.toolStripButtonDepartment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDepartment.Name = "toolStripButtonDepartment";
            this.toolStripButtonDepartment.Size = new System.Drawing.Size(44, 35);
            this.toolStripButtonDepartment.Text = "Отдел";
            this.toolStripButtonDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDepartment.Click += new System.EventHandler(this.toolStripButtonDepartment_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(46, 35);
            this.toolStripButtonExit.Text = "Выход";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripButtonAdmin
            // 
            this.toolStripButtonAdmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdmin.Image")));
            this.toolStripButtonAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdmin.Name = "toolStripButtonAdmin";
            this.toolStripButtonAdmin.Size = new System.Drawing.Size(77, 35);
            this.toolStripButtonAdmin.Text = "Управление";
            this.toolStripButtonAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonAdmin.Click += new System.EventHandler(this.toolStripButtonAdmin_Click);
            // 
            // eQUIPMENT_ACCOUNTINGDataSet
            // 
            this.eQUIPMENT_ACCOUNTINGDataSet.DataSetName = "EQUIPMENT_ACCOUNTINGDataSet";
            this.eQUIPMENT_ACCOUNTINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationTableAdapter
            // 
            this.applicationTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxUserStatus});
            this.toolStrip2.Location = new System.Drawing.Point(0, 474);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(847, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripTextBoxUserStatus
            // 
            this.toolStripTextBoxUserStatus.Enabled = false;
            this.toolStripTextBoxUserStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxUserStatus.Name = "toolStripTextBoxUserStatus";
            this.toolStripTextBoxUserStatus.Size = new System.Drawing.Size(130, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 499);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список хранимого оборудования";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private EQUIPMENT_ACCOUNTINGDataSet eQUIPMENT_ACCOUNTINGDataSet;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.ApplicationTableAdapter applicationTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonEquipment;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator расходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsumptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WriteOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonApplication;
        private System.Windows.Forms.ToolStripButton toolStripButtonProvider;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem BalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonEquipDirectory;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxUserStatus;
        private System.Windows.Forms.ToolStripButton toolStripButtonEmployee;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdmin;
        private System.Windows.Forms.ToolStripButton toolStripButtonDepartment;
    }
}