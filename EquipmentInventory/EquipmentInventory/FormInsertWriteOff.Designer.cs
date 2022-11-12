namespace EquipmentInventory
{
    partial class FormInsertWriteOff
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
            this.components = new System.ComponentModel.Container();
            this.labelWriteOffDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPMENT_ACCOUNTINGDataSet = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSet();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.writeOffTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.WriteOffTableAdapter();
            this.employeeTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EmployeeTableAdapter();
            this.equipmentTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter();
            this.equipDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipDirectoryTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipDirectoryTableAdapter();
            this.balanceTableAdapter1 = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.BalanceTableAdapter();
            this.balanceTableAdapter2 = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.BalanceTableAdapter();
            this.maskedTextBoxWriteOffDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDirectoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWriteOffDate
            // 
            this.labelWriteOffDate.AutoSize = true;
            this.labelWriteOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWriteOffDate.ForeColor = System.Drawing.Color.Black;
            this.labelWriteOffDate.Location = new System.Drawing.Point(61, 130);
            this.labelWriteOffDate.Name = "labelWriteOffDate";
            this.labelWriteOffDate.Size = new System.Drawing.Size(115, 18);
            this.labelWriteOffDate.TabIndex = 45;
            this.labelWriteOffDate.Text = "Дата списания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Код сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "Код оборудования:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(182, 96);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuantity.TabIndex = 40;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(80, 95);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(96, 18);
            this.labelQuantity.TabIndex = 36;
            this.labelQuantity.Text = "Количество:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(214, 169);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(90, 29);
            this.ButtonCancel.TabIndex = 48;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInsert.ForeColor = System.Drawing.Color.Black;
            this.ButtonInsert.Location = new System.Drawing.Point(92, 169);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 29);
            this.ButtonInsert.TabIndex = 47;
            this.ButtonInsert.Text = "Добавить";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "IdEmployee", true));
            this.comboBoxEmployee.DataSource = this.employeeBindingSource;
            this.comboBoxEmployee.DisplayMember = "IdEmployee";
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(183, 30);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployee.TabIndex = 50;
            this.comboBoxEmployee.ValueMember = "IdEmployee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // eQUIPMENT_ACCOUNTINGDataSet
            // 
            this.eQUIPMENT_ACCOUNTINGDataSet.DataSetName = "EQUIPMENT_ACCOUNTINGDataSet";
            this.eQUIPMENT_ACCOUNTINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipmentBindingSource, "IdEquipment", true));
            this.comboBoxEquipment.DataSource = this.equipmentBindingSource;
            this.comboBoxEquipment.DisplayMember = "IdEquipment";
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(183, 64);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipment.TabIndex = 51;
            this.comboBoxEquipment.ValueMember = "IdEquipment";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // writeOffTableAdapter
            // 
            this.writeOffTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // equipDirectoryBindingSource
            // 
            this.equipDirectoryBindingSource.DataMember = "EquipDirectory";
            this.equipDirectoryBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // equipDirectoryTableAdapter
            // 
            this.equipDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // balanceTableAdapter1
            // 
            this.balanceTableAdapter1.ClearBeforeFill = true;
            // 
            // balanceTableAdapter2
            // 
            this.balanceTableAdapter2.ClearBeforeFill = true;
            // 
            // maskedTextBoxWriteOffDate
            // 
            this.maskedTextBoxWriteOffDate.Location = new System.Drawing.Point(182, 131);
            this.maskedTextBoxWriteOffDate.Mask = "00/00/0000";
            this.maskedTextBoxWriteOffDate.Name = "maskedTextBoxWriteOffDate";
            this.maskedTextBoxWriteOffDate.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxWriteOffDate.TabIndex = 52;
            this.maskedTextBoxWriteOffDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxWriteOffDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxWriteOffDate_KeyPress);
            // 
            // FormInsertWriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(366, 219);
            this.ControlBox = false;
            this.Controls.Add(this.maskedTextBoxWriteOffDate);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.labelWriteOffDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInsertWriteOff";
            this.Text = "Списать оборудование";
            this.Load += new System.EventHandler(this.FormInsertWriteOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDirectoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWriteOffDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private EQUIPMENT_ACCOUNTINGDataSet eQUIPMENT_ACCOUNTINGDataSet;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.WriteOffTableAdapter writeOffTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.BindingSource equipDirectoryBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipDirectoryTableAdapter equipDirectoryTableAdapter;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.BalanceTableAdapter balanceTableAdapter1;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.BalanceTableAdapter balanceTableAdapter2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWriteOffDate;
    }
}