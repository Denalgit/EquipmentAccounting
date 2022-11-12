namespace EquipmentInventory
{
    partial class FormEquipDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipDirectory));
            this.dataGridViewEquipDirectory = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEquipment = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.UpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.CanselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelIdNameEquip = new System.Windows.Forms.Label();
            this.textBoxIdNameEquip = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelEquipName = new System.Windows.Forms.Label();
            this.textBoxEquipName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipDirectory)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEquipDirectory
            // 
            this.dataGridViewEquipDirectory.AllowUserToAddRows = false;
            this.dataGridViewEquipDirectory.AllowUserToDeleteRows = false;
            this.dataGridViewEquipDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEquipDirectory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.dataGridViewEquipDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEquipDirectory.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewEquipDirectory.Name = "dataGridViewEquipDirectory";
            this.dataGridViewEquipDirectory.ReadOnly = true;
            this.dataGridViewEquipDirectory.Size = new System.Drawing.Size(758, 551);
            this.dataGridViewEquipDirectory.TabIndex = 8;
            this.dataGridViewEquipDirectory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipDirectory_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInsert,
            this.toolStripButtonDelete,
            this.toolStripButtonClose,
            this.toolStripButtonEquipment});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 38);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInsert
            // 
            this.toolStripButtonInsert.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsert.Image")));
            this.toolStripButtonInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsert.Name = "toolStripButtonInsert";
            this.toolStripButtonInsert.Size = new System.Drawing.Size(63, 35);
            this.toolStripButtonInsert.Text = "Добавить";
            this.toolStripButtonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonInsert.Click += new System.EventHandler(this.toolStripButtonInsert_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(55, 35);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(57, 35);
            this.toolStripButtonClose.Text = "Закрыть";
            this.toolStripButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripButtonEquipment
            // 
            this.toolStripButtonEquipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.расходToolStripMenuItem,
            this.CanselToolStripMenuItem});
            this.toolStripButtonEquipment.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEquipment.Image")));
            this.toolStripButtonEquipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEquipment.Name = "toolStripButtonEquipment";
            this.toolStripButtonEquipment.Size = new System.Drawing.Size(86, 35);
            this.toolStripButtonEquipment.Text = "Сортировка";
            this.toolStripButtonEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpToolStripMenuItem,
            this.DownToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Цена";
            // 
            // UpToolStripMenuItem
            // 
            this.UpToolStripMenuItem.Image = global::EquipmentInventory.Properties.Resources.sortamountup_120333;
            this.UpToolStripMenuItem.Name = "UpToolStripMenuItem";
            this.UpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UpToolStripMenuItem.Text = "По возрастанию";
            this.UpToolStripMenuItem.Click += new System.EventHandler(this.UpToolStripMenuItem_Click);
            // 
            // DownToolStripMenuItem
            // 
            this.DownToolStripMenuItem.Image = global::EquipmentInventory.Properties.Resources.sortamountdown_120336;
            this.DownToolStripMenuItem.Name = "DownToolStripMenuItem";
            this.DownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DownToolStripMenuItem.Text = "По убыванию";
            this.DownToolStripMenuItem.Click += new System.EventHandler(this.DownToolStripMenuItem_Click);
            // 
            // расходToolStripMenuItem
            // 
            this.расходToolStripMenuItem.Name = "расходToolStripMenuItem";
            this.расходToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // CanselToolStripMenuItem
            // 
            this.CanselToolStripMenuItem.Name = "CanselToolStripMenuItem";
            this.CanselToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CanselToolStripMenuItem.Text = "Отмена";
            this.CanselToolStripMenuItem.Click += new System.EventHandler(this.CanselToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.dataGridViewEquipDirectory);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 589);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxWeight);
            this.panel2.Controls.Add(this.numericUpDownPrice);
            this.panel2.Controls.Add(this.labelIdNameEquip);
            this.panel2.Controls.Add(this.textBoxIdNameEquip);
            this.panel2.Controls.Add(this.ButtonUpdate);
            this.panel2.Controls.Add(this.labelWeight);
            this.panel2.Controls.Add(this.labelPrice);
            this.panel2.Controls.Add(this.labelEquipName);
            this.panel2.Controls.Add(this.textBoxEquipName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 189);
            this.panel2.TabIndex = 11;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(376, 119);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(122, 20);
            this.textBoxWeight.TabIndex = 28;
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(376, 85);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrice.TabIndex = 26;
            this.numericUpDownPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPrice_KeyPress);
            // 
            // labelIdNameEquip
            // 
            this.labelIdNameEquip.AutoSize = true;
            this.labelIdNameEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdNameEquip.ForeColor = System.Drawing.Color.Black;
            this.labelIdNameEquip.Location = new System.Drawing.Point(161, 11);
            this.labelIdNameEquip.Name = "labelIdNameEquip";
            this.labelIdNameEquip.Size = new System.Drawing.Size(212, 18);
            this.labelIdNameEquip.TabIndex = 25;
            this.labelIdNameEquip.Text = "Код названия оборудования:";
            // 
            // textBoxIdNameEquip
            // 
            this.textBoxIdNameEquip.Location = new System.Drawing.Point(376, 11);
            this.textBoxIdNameEquip.Name = "textBoxIdNameEquip";
            this.textBoxIdNameEquip.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdNameEquip.TabIndex = 24;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdate.Location = new System.Drawing.Point(359, 148);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 29);
            this.ButtonUpdate.TabIndex = 23;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeight.ForeColor = System.Drawing.Color.Black;
            this.labelWeight.Location = new System.Drawing.Point(285, 118);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(85, 18);
            this.labelWeight.TabIndex = 20;
            this.labelWeight.Text = "Масса (кг):";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(247, 83);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(123, 18);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Цена(1шт. RUB):";
            // 
            // labelEquipName
            // 
            this.labelEquipName.AutoSize = true;
            this.labelEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquipName.ForeColor = System.Drawing.Color.Black;
            this.labelEquipName.Location = new System.Drawing.Point(187, 47);
            this.labelEquipName.Name = "labelEquipName";
            this.labelEquipName.Size = new System.Drawing.Size(183, 18);
            this.labelEquipName.TabIndex = 18;
            this.labelEquipName.Text = "Название оборудования:";
            // 
            // textBoxEquipName
            // 
            this.textBoxEquipName.Location = new System.Drawing.Point(376, 48);
            this.textBoxEquipName.Name = "textBoxEquipName";
            this.textBoxEquipName.Size = new System.Drawing.Size(122, 20);
            this.textBoxEquipName.TabIndex = 17;
            // 
            // FormEquipDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(758, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEquipDirectory";
            this.Text = "Справочник оборудования";
            this.Load += new System.EventHandler(this.FormEquipDirectory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipDirectory)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEquipDirectory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsert;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelEquipName;
        private System.Windows.Forms.TextBox textBoxEquipName;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label labelIdNameEquip;
        private System.Windows.Forms.TextBox textBoxIdNameEquip;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonEquipment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem UpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator расходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanselToolStripMenuItem;
    }
}