namespace EquipmentInventory
{
    partial class FormBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBalance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxBalanceDate = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewBalance = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelBalance = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExite = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBalance)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxBalanceDate);
            this.panel1.Controls.Add(this.dataGridViewBalance);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 455);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBoxBalanceDate
            // 
            this.maskedTextBoxBalanceDate.Location = new System.Drawing.Point(170, 9);
            this.maskedTextBoxBalanceDate.Mask = "00/00/0000";
            this.maskedTextBoxBalanceDate.Name = "maskedTextBoxBalanceDate";
            this.maskedTextBoxBalanceDate.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBoxBalanceDate.TabIndex = 13;
            this.maskedTextBoxBalanceDate.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridViewBalance
            // 
            this.dataGridViewBalance.AllowUserToAddRows = false;
            this.dataGridViewBalance.AllowUserToDeleteRows = false;
            this.dataGridViewBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBalance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(156)))));
            this.dataGridViewBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBalance.Location = new System.Drawing.Point(0, 38);
            this.dataGridViewBalance.Name = "dataGridViewBalance";
            this.dataGridViewBalance.ReadOnly = true;
            this.dataGridViewBalance.Size = new System.Drawing.Size(824, 417);
            this.dataGridViewBalance.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelBalance,
            this.toolStripButtonExite,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 38);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelBalance
            // 
            this.toolStripLabelBalance.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelBalance.Image")));
            this.toolStripLabelBalance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabelBalance.Name = "toolStripLabelBalance";
            this.toolStripLabelBalance.Size = new System.Drawing.Size(157, 35);
            this.toolStripLabelBalance.Text = "Дата фиксации остатка:";
            this.toolStripLabelBalance.Click += new System.EventHandler(this.toolStripLabelBalance_Click);
            // 
            // toolStripButtonExite
            // 
            this.toolStripButtonExite.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonExite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExite.Image")));
            this.toolStripButtonExite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExite.Name = "toolStripButtonExite";
            this.toolStripButtonExite.Size = new System.Drawing.Size(57, 35);
            this.toolStripButtonExite.Text = "Закрыть";
            this.toolStripButtonExite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExite.Click += new System.EventHandler(this.toolStripButtonExite_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 35);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButtonRebut_Click);
            // 
            // FormBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 455);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBalance";
            this.Text = "Остаток за период";
            this.Load += new System.EventHandler(this.FormBalance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBalance)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExite;
        private System.Windows.Forms.DataGridView dataGridViewBalance;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBalanceDate;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripLabelBalance;
    }
}