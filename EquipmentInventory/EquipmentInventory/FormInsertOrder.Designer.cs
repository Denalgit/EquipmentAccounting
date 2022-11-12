namespace EquipmentInventory
{
    partial class FormInsertOrder
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
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPMENT_ACCOUNTINGDataSet = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSet();
            this.labelProvider = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.maskedTextBoxOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.providerTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.ProviderTableAdapter();
            this.employeeTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EmployeeTableAdapter();
            this.equipmentTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.DataSource = this.providerBindingSource;
            this.comboBoxProvider.DisplayMember = "IdProvider";
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(172, 22);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvider.TabIndex = 80;
            this.comboBoxProvider.ValueMember = "IdProvider";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // eQUIPMENT_ACCOUNTINGDataSet
            // 
            this.eQUIPMENT_ACCOUNTINGDataSet.DataSetName = "EQUIPMENT_ACCOUNTINGDataSet";
            this.eQUIPMENT_ACCOUNTINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProvider.ForeColor = System.Drawing.Color.Black;
            this.labelProvider.Location = new System.Drawing.Point(34, 25);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(127, 18);
            this.labelProvider.TabIndex = 79;
            this.labelProvider.Text = "Код поставщика:";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(171, 172);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(122, 20);
            this.textBoxValue.TabIndex = 78;
            this.textBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValue_KeyPress);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValue.ForeColor = System.Drawing.Color.Black;
            this.labelValue.Location = new System.Drawing.Point(71, 171);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(90, 18);
            this.labelValue.TabIndex = 77;
            this.labelValue.Text = "Стоимость:";
            // 
            // maskedTextBoxOrderDate
            // 
            this.maskedTextBoxOrderDate.Location = new System.Drawing.Point(172, 207);
            this.maskedTextBoxOrderDate.Mask = "00/00/0000";
            this.maskedTextBoxOrderDate.Name = "maskedTextBoxOrderDate";
            this.maskedTextBoxOrderDate.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxOrderDate.TabIndex = 76;
            this.maskedTextBoxOrderDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxOrderDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxOrderDate_KeyPress);
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.DataSource = this.equipmentBindingSource;
            this.comboBoxEquipment.DisplayMember = "IdEquipment";
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(173, 100);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipment.TabIndex = 75;
            this.comboBoxEquipment.ValueMember = "IdEquipment";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DataSource = this.employeeBindingSource;
            this.comboBoxEmployee.DisplayMember = "IdEmployee";
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(173, 64);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployee.TabIndex = 74;
            this.comboBoxEmployee.ValueMember = "IdEmployee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(204, 245);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(90, 29);
            this.ButtonCancel.TabIndex = 73;
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
            this.ButtonInsert.Location = new System.Drawing.Point(82, 245);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 29);
            this.ButtonInsert.TabIndex = 72;
            this.ButtonInsert.Text = "Добавить";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderDate.ForeColor = System.Drawing.Color.Black;
            this.labelOrderDate.Location = new System.Drawing.Point(62, 206);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(99, 18);
            this.labelOrderDate.TabIndex = 71;
            this.labelOrderDate.Text = "Дата заказа:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Код сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Код оборудования:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(171, 136);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(122, 20);
            this.textBoxQuantity.TabIndex = 68;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(65, 135);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(96, 18);
            this.labelQuantity.TabIndex = 67;
            this.labelQuantity.Text = "Количество:";
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // FormInsertOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(349, 285);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.maskedTextBoxOrderDate);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInsertOrder";
            this.Text = "Добавить заказ";
            this.Load += new System.EventHandler(this.FormInsertOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOrderDate;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private EQUIPMENT_ACCOUNTINGDataSet eQUIPMENT_ACCOUNTINGDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
    }
}