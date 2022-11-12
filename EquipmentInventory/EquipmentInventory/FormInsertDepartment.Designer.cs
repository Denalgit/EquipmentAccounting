namespace EquipmentInventory
{
    partial class FormInsertDepartment
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
            this.maskedTextBoxDepartmentPhone = new System.Windows.Forms.MaskedTextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelEquipName = new System.Windows.Forms.Label();
            this.textBoxDepartNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedTextBoxDepartmentPhone
            // 
            this.maskedTextBoxDepartmentPhone.Location = new System.Drawing.Point(170, 66);
            this.maskedTextBoxDepartmentPhone.Mask = "00-00";
            this.maskedTextBoxDepartmentPhone.Name = "maskedTextBoxDepartmentPhone";
            this.maskedTextBoxDepartmentPhone.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxDepartmentPhone.TabIndex = 33;
            this.maskedTextBoxDepartmentPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxDepartmentPhone_KeyPress);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel.Location = new System.Drawing.Point(188, 110);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(90, 29);
            this.ButtonCancel.TabIndex = 31;
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
            this.ButtonInsert.Location = new System.Drawing.Point(66, 110);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(90, 29);
            this.ButtonInsert.TabIndex = 30;
            this.ButtonInsert.Text = "Добавить";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(34, 65);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(130, 18);
            this.labelPrice.TabIndex = 28;
            this.labelPrice.Text = "Телефон отдела:";
            // 
            // labelEquipName
            // 
            this.labelEquipName.AutoSize = true;
            this.labelEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEquipName.ForeColor = System.Drawing.Color.Black;
            this.labelEquipName.Location = new System.Drawing.Point(31, 23);
            this.labelEquipName.Name = "labelEquipName";
            this.labelEquipName.Size = new System.Drawing.Size(133, 18);
            this.labelEquipName.TabIndex = 27;
            this.labelEquipName.Text = "Название отдела:";
            // 
            // textBoxDepartNumber
            // 
            this.textBoxDepartNumber.Location = new System.Drawing.Point(169, 24);
            this.textBoxDepartNumber.Name = "textBoxDepartNumber";
            this.textBoxDepartNumber.Size = new System.Drawing.Size(122, 20);
            this.textBoxDepartNumber.TabIndex = 26;
            // 
            // FormInsertDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(322, 160);
            this.ControlBox = false;
            this.Controls.Add(this.maskedTextBoxDepartmentPhone);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelEquipName);
            this.Controls.Add(this.textBoxDepartNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInsertDepartment";
            this.Text = "Добавить отдел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxDepartmentPhone;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelEquipName;
        private System.Windows.Forms.TextBox textBoxDepartNumber;
    }
}