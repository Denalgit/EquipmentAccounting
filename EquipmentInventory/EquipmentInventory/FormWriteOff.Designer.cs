namespace EquipmentInventory
{
    partial class FormWriteOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWriteOff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewWriteOff = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maskedTextBoxWriteOffDate = new System.Windows.Forms.MaskedTextBox();
            this.labelWriteOffDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdEquipment = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelIdNameWriteOff = new System.Windows.Forms.Label();
            this.textBoxIdWriteOff = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOff)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewWriteOff);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 589);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewWriteOff
            // 
            this.dataGridViewWriteOff.AllowUserToAddRows = false;
            this.dataGridViewWriteOff.AllowUserToDeleteRows = false;
            this.dataGridViewWriteOff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWriteOff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.dataGridViewWriteOff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriteOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWriteOff.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewWriteOff.Name = "dataGridViewWriteOff";
            this.dataGridViewWriteOff.ReadOnly = true;
            this.dataGridViewWriteOff.Size = new System.Drawing.Size(758, 396);
            this.dataGridViewWriteOff.TabIndex = 16;
            this.dataGridViewWriteOff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsumption_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBoxWriteOffDate);
            this.panel2.Controls.Add(this.labelWriteOffDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxIdEmployee);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxIdEquipment);
            this.panel2.Controls.Add(this.textBoxQuantity);
            this.panel2.Controls.Add(this.labelIdNameWriteOff);
            this.panel2.Controls.Add(this.textBoxIdWriteOff);
            this.panel2.Controls.Add(this.ButtonUpdate);
            this.panel2.Controls.Add(this.labelQuantity);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 155);
            this.panel2.TabIndex = 15;
            // 
            // maskedTextBoxWriteOffDate
            // 
            this.maskedTextBoxWriteOffDate.Location = new System.Drawing.Point(497, 43);
            this.maskedTextBoxWriteOffDate.Name = "maskedTextBoxWriteOffDate";
            this.maskedTextBoxWriteOffDate.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxWriteOffDate.TabIndex = 35;
            // 
            // labelWriteOffDate
            // 
            this.labelWriteOffDate.AutoSize = true;
            this.labelWriteOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWriteOffDate.ForeColor = System.Drawing.Color.Black;
            this.labelWriteOffDate.Location = new System.Drawing.Point(376, 42);
            this.labelWriteOffDate.Name = "labelWriteOffDate";
            this.labelWriteOffDate.Size = new System.Drawing.Size(115, 18);
            this.labelWriteOffDate.TabIndex = 33;
            this.labelWriteOffDate.Text = "Дата списания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(106, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Код сотрудника:";
            // 
            // textBoxIdEmployee
            // 
            this.textBoxIdEmployee.Location = new System.Drawing.Point(236, 45);
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
            this.label2.Location = new System.Drawing.Point(86, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Код оборудования:";
            // 
            // textBoxIdEquipment
            // 
            this.textBoxIdEquipment.Location = new System.Drawing.Point(236, 80);
            this.textBoxIdEquipment.Name = "textBoxIdEquipment";
            this.textBoxIdEquipment.ReadOnly = true;
            this.textBoxIdEquipment.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdEquipment.TabIndex = 29;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(497, 8);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuantity.TabIndex = 28;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelIdNameWriteOff
            // 
            this.labelIdNameWriteOff.AutoSize = true;
            this.labelIdNameWriteOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIdNameWriteOff.ForeColor = System.Drawing.Color.Black;
            this.labelIdNameWriteOff.Location = new System.Drawing.Point(122, 8);
            this.labelIdNameWriteOff.Name = "labelIdNameWriteOff";
            this.labelIdNameWriteOff.Size = new System.Drawing.Size(108, 18);
            this.labelIdNameWriteOff.TabIndex = 25;
            this.labelIdNameWriteOff.Text = "Код списания:";
            // 
            // textBoxIdWriteOff
            // 
            this.textBoxIdWriteOff.Location = new System.Drawing.Point(236, 8);
            this.textBoxIdWriteOff.Name = "textBoxIdWriteOff";
            this.textBoxIdWriteOff.ReadOnly = true;
            this.textBoxIdWriteOff.Size = new System.Drawing.Size(122, 20);
            this.textBoxIdWriteOff.TabIndex = 24;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.Black;
            this.ButtonUpdate.Location = new System.Drawing.Point(335, 120);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(90, 29);
            this.ButtonUpdate.TabIndex = 23;
            this.ButtonUpdate.Text = "Изменить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(395, 7);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(96, 18);
            this.labelQuantity.TabIndex = 20;
            this.labelQuantity.Text = "Количество:";
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
            this.toolStrip1.TabIndex = 13;
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
            // FormWriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 589);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWriteOff";
            this.Text = "Списание оборудования";
            this.Load += new System.EventHandler(this.FormWriteOff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriteOff)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWriteOffDate;
        private System.Windows.Forms.Label labelWriteOffDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdEquipment;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelIdNameWriteOff;
        private System.Windows.Forms.TextBox textBoxIdWriteOff;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DataGridView dataGridViewWriteOff;
    }
}