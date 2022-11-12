namespace EquipmentInventory
{
    partial class FormComing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewComing = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxInvoiseNumber = new System.Windows.Forms.TextBox();
            this.labelInvoiseNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxDeliveryDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdEquipment = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelIdNameEquip = new System.Windows.Forms.Label();
            this.textBoxIdComing = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelEquipName = new System.Windows.Forms.Label();
            this.textBoxIdOrder = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComing)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewComing);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 589);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewComing
            // 
            this.dataGridViewComing.AllowUserToAddRows = false;
            this.dataGridViewComing.AllowUserToDeleteRows = false;
            this.dataGridViewComing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.dataGridViewComing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewComing.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewComing.Name = "dataGridViewComing";
            this.dataGridViewComing.ReadOnly = true;
            this.dataGridViewComing.Size = new System.Drawing.Size(758, 361);
            this.dataGridViewComing.TabIndex = 14;
            this.dataGridViewComing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxInvoiseNumber);
            this.panel2.Controls.Add(this.labelInvoiseNumber);
            this.panel2.Controls.Add(this.maskedTextBoxDeliveryDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxIdEmployee);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxIdEquipment);
            this.panel2.Controls.Add(this.textBoxQuantity);
            this.panel2.Controls.Add(this.labelIdNameEquip);
            this.panel2.Controls.Add(this.textBoxIdComing);
            this.panel2.Controls.Add(this.ButtonUpdate);
            this.panel2.Controls.Add(this.labelWeight);
            this.panel2.Controls.Add(this.labelEquipName);
            this.panel2.Controls.Add(this.textBoxIdOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 190);
            this.panel2.TabIndex = 13;
            // 
            // textBoxInvoiseNumber
            // 
            this.textBoxInvoiseNumber.Location = new System.Drawing.Point(529, 12);
            this.textBoxInvoiseNumber.Name = "textBoxInvoiseNumber";
            this.textBoxInvoiseNumber.Size = new System.Drawing.Size(122, 20);
            this.textBoxInvoiseNumber.TabIndex = 37;
            this.textBoxInvoiseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInvoiseNumber_KeyPress);
            // 
            // labelInvoiseNumber
            // 
            this.labelInvoiseNumber.AutoSize = true;
            this.labelInvoiseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInvoiseNumber.ForeColor = System.Drawing.Color.Black;
            this.labelInvoiseNumber.Location = new System.Drawing.Point(385, 12);
            this.labelInvoiseNumber.Name = "labelInvoiseNumber";
            this.labelInvoiseNumber.Size = new System.Drawing.Size(138, 18);
            this.labelInvoiseNumber.TabIndex = 36;
            this.labelInvoiseNumber.Text = "Номер накладной:";
            // 
            // maskedTextBoxDeliveryDate
            // 
            this.maskedTextBoxDeliveryDate.Location = new System.Drawing.Point(529, 78);
            this.maskedTextBoxDeliveryDate.Name = "maskedTextBoxDeliveryDate";
            this.maskedTextBoxDeliveryDate.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxDeliveryDate.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(424, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Дата заказа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(106, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Код сотрудника:";
            // 
            // textBoxIdEmployee
            // 
            this.textBoxIdEmployee.Location = new System.Drawing.Point(236, 78);
            this.textBoxIdEmployee.Name = "textBoxIdEmployee";
            this.textBoxIdEmployee.ReadOnly = true;
            this.textBoxIdEmployee.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdEmployee.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Код оборудования:";
            // 
            // textBoxIdEquipment
            // 
            this.textBoxIdEquipment.Location = new System.Drawing.Point(236, 115);
            this.textBoxIdEquipment.Name = "textBoxIdEquipment";
            this.textBoxIdEquipment.ReadOnly = true;
            this.textBoxIdEquipment.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdEquipment.TabIndex = 29;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(529, 45);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuantity.TabIndex = 28;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelIdNameEquip
            // 
            this.labelIdNameEquip.AutoSize = true;
            this.labelIdNameEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdNameEquip.ForeColor = System.Drawing.Color.Black;
            this.labelIdNameEquip.Location = new System.Drawing.Point(129, 12);
            this.labelIdNameEquip.Name = "labelIdNameEquip";
            this.labelIdNameEquip.Size = new System.Drawing.Size(101, 18);
            this.labelIdNameEquip.TabIndex = 25;
            this.labelIdNameEquip.Text = "Код прихода:";
            // 
            // textBoxIdComing
            // 
            this.textBoxIdComing.Location = new System.Drawing.Point(236, 12);
            this.textBoxIdComing.Name = "textBoxIdComing";
            this.textBoxIdComing.ReadOnly = true;
            this.textBoxIdComing.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdComing.TabIndex = 24;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdate.Location = new System.Drawing.Point(337, 149);
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
            this.labelWeight.Location = new System.Drawing.Point(427, 44);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(96, 18);
            this.labelWeight.TabIndex = 20;
            this.labelWeight.Text = "Количество:";
            // 
            // labelEquipName
            // 
            this.labelEquipName.AutoSize = true;
            this.labelEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquipName.ForeColor = System.Drawing.Color.Black;
            this.labelEquipName.Location = new System.Drawing.Point(138, 44);
            this.labelEquipName.Name = "labelEquipName";
            this.labelEquipName.Size = new System.Drawing.Size(92, 18);
            this.labelEquipName.TabIndex = 18;
            this.labelEquipName.Text = "Код заказа:";
            // 
            // textBoxIdOrder
            // 
            this.textBoxIdOrder.Location = new System.Drawing.Point(236, 44);
            this.textBoxIdOrder.Name = "textBoxIdOrder";
            this.textBoxIdOrder.ReadOnly = true;
            this.textBoxIdOrder.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdOrder.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInsert,
            this.toolStripButtonDelete,
            this.toolStripButtonClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 38);
            this.toolStrip1.TabIndex = 11;
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
            // FormComing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(758, 589);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComing";
            this.Text = "Приход оборудования";
            this.Load += new System.EventHandler(this.FormComing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComing)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsert;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDeliveryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdEquipment;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelIdNameEquip;
        private System.Windows.Forms.TextBox textBoxIdComing;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelEquipName;
        private System.Windows.Forms.TextBox textBoxIdOrder;
        private System.Windows.Forms.DataGridView dataGridViewComing;
        private System.Windows.Forms.TextBox textBoxInvoiseNumber;
        private System.Windows.Forms.Label labelInvoiseNumber;
    }
}