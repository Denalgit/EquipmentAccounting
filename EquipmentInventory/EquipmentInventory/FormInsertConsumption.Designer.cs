namespace EquipmentInventory
{
    partial class FormInsertConsumption
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
            this.comboBoxApplication = new System.Windows.Forms.ComboBox();
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPMENT_ACCOUNTINGDataSet = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSet();
            this.labelApplication = new System.Windows.Forms.Label();
            this.maskedTextBoxConsumptionDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.applicationTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.ApplicationTableAdapter();
            this.employeeTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EmployeeTableAdapter();
            this.equipmentTableAdapter = new EquipmentInventory.EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxApplication
            // 
            this.comboBoxApplication.DataSource = this.applicationBindingSource;
            this.comboBoxApplication.DisplayMember = "IdApplication";
            this.comboBoxApplication.FormattingEnabled = true;
            this.comboBoxApplication.Location = new System.Drawing.Point(168, 31);
            this.comboBoxApplication.Name = "comboBoxApplication";
            this.comboBoxApplication.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApplication.TabIndex = 80;
            this.comboBoxApplication.ValueMember = "IdApplication";
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataMember = "Application";
            this.applicationBindingSource.DataSource = this.eQUIPMENT_ACCOUNTINGDataSet;
            // 
            // eQUIPMENT_ACCOUNTINGDataSet
            // 
            this.eQUIPMENT_ACCOUNTINGDataSet.DataSetName = "EQUIPMENT_ACCOUNTINGDataSet";
            this.eQUIPMENT_ACCOUNTINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelApplication.ForeColor = System.Drawing.Color.Black;
            this.labelApplication.Location = new System.Drawing.Point(70, 30);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(92, 18);
            this.labelApplication.TabIndex = 79;
            this.labelApplication.Text = "Код заявки:";
            // 
            // maskedTextBoxConsumptionDate
            // 
            this.maskedTextBoxConsumptionDate.Location = new System.Drawing.Point(168, 172);
            this.maskedTextBoxConsumptionDate.Mask = "00/00/0000";
            this.maskedTextBoxConsumptionDate.Name = "maskedTextBoxConsumptionDate";
            this.maskedTextBoxConsumptionDate.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxConsumptionDate.TabIndex = 76;
            this.maskedTextBoxConsumptionDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxConsumptionDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxConsumptionDate_KeyPress);
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.DataSource = this.equipmentBindingSource;
            this.comboBoxEquipment.DisplayMember = "IdEquipment";
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(170, 103);
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
            this.comboBoxEmployee.Location = new System.Drawing.Point(170, 67);
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
            this.ButtonCancel.Location = new System.Drawing.Point(200, 210);
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
            this.ButtonInsert.Location = new System.Drawing.Point(78, 210);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 29);
            this.ButtonInsert.TabIndex = 72;
            this.ButtonInsert.Text = "Добавить";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeliveryDate.ForeColor = System.Drawing.Color.Black;
            this.labelDeliveryDate.Location = new System.Drawing.Point(54, 171);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(108, 18);
            this.labelDeliveryDate.TabIndex = 71;
            this.labelDeliveryDate.Text = "Дата расхода:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 66);
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
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Код оборудования:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(168, 137);
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
            this.labelQuantity.Location = new System.Drawing.Point(66, 136);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(96, 18);
            this.labelQuantity.TabIndex = 67;
            this.labelQuantity.Text = "Количество:";
            // 
            // applicationTableAdapter
            // 
            this.applicationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // FormInsertConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(332, 251);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxApplication);
            this.Controls.Add(this.labelApplication);
            this.Controls.Add(this.maskedTextBoxConsumptionDate);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.labelDeliveryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInsertConsumption";
            this.Text = "Новый расход";
            this.Load += new System.EventHandler(this.FormInsertConsumption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPMENT_ACCOUNTINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxApplication;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConsumptionDate;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Label labelDeliveryDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private EQUIPMENT_ACCOUNTINGDataSet eQUIPMENT_ACCOUNTINGDataSet;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.ApplicationTableAdapter applicationTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private EQUIPMENT_ACCOUNTINGDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
    }
}