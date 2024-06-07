namespace Adbms
{
    partial class PatientsRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRecordsPatients = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.btnTotalInc = new System.Windows.Forms.Button();
            this.totalPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.disTotal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.avgIntialTotal = new System.Windows.Forms.Button();
            this.btnavgNetTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecordsPatients
            // 
            this.btnRecordsPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordsPatients.Location = new System.Drawing.Point(739, 57);
            this.btnRecordsPatients.Name = "btnRecordsPatients";
            this.btnRecordsPatients.Size = new System.Drawing.Size(322, 34);
            this.btnRecordsPatients.TabIndex = 0;
            this.btnRecordsPatients.Text = "Records";
            this.btnRecordsPatients.UseVisualStyleBackColor = true;
            this.btnRecordsPatients.Click += new System.EventHandler(this.btnRecordsPatients_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRecords.Location = new System.Drawing.Point(1, 114);
            this.dgvRecords.Name = "dgvRecords";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRecords.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(1068, 435);
            this.dgvRecords.TabIndex = 1;
            // 
            // btnTotalInc
            // 
            this.btnTotalInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalInc.Location = new System.Drawing.Point(3, 74);
            this.btnTotalInc.Name = "btnTotalInc";
            this.btnTotalInc.Size = new System.Drawing.Size(215, 34);
            this.btnTotalInc.TabIndex = 2;
            this.btnTotalInc.Text = "Net Total";
            this.btnTotalInc.UseVisualStyleBackColor = true;
            this.btnTotalInc.Click += new System.EventHandler(this.btnTotalInc_Click);
            // 
            // totalPatient
            // 
            this.totalPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPatient.Location = new System.Drawing.Point(3, 34);
            this.totalPatient.Name = "totalPatient";
            this.totalPatient.Size = new System.Drawing.Size(215, 34);
            this.totalPatient.TabIndex = 3;
            this.totalPatient.Text = "Total Patient Count";
            this.totalPatient.UseVisualStyleBackColor = true;
            this.totalPatient.Click += new System.EventHandler(this.totalPatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Functions";
            // 
            // disTotal
            // 
            this.disTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disTotal.Location = new System.Drawing.Point(245, 72);
            this.disTotal.Name = "disTotal";
            this.disTotal.Size = new System.Drawing.Size(215, 34);
            this.disTotal.TabIndex = 5;
            this.disTotal.Text = "Total Discount(%)";
            this.disTotal.UseVisualStyleBackColor = true;
            this.disTotal.Click += new System.EventHandler(this.disTotal_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Initial Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avgIntialTotal
            // 
            this.avgIntialTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgIntialTotal.Location = new System.Drawing.Point(490, 34);
            this.avgIntialTotal.Name = "avgIntialTotal";
            this.avgIntialTotal.Size = new System.Drawing.Size(215, 34);
            this.avgIntialTotal.TabIndex = 7;
            this.avgIntialTotal.Text = "Avarage Initial Total";
            this.avgIntialTotal.UseVisualStyleBackColor = true;
            this.avgIntialTotal.Click += new System.EventHandler(this.avgIntialTotal_Click);
            // 
            // btnavgNetTotal
            // 
            this.btnavgNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavgNetTotal.Location = new System.Drawing.Point(490, 74);
            this.btnavgNetTotal.Name = "btnavgNetTotal";
            this.btnavgNetTotal.Size = new System.Drawing.Size(215, 34);
            this.btnavgNetTotal.TabIndex = 8;
            this.btnavgNetTotal.Text = "Avarage Net Total";
            this.btnavgNetTotal.UseVisualStyleBackColor = true;
            this.btnavgNetTotal.Click += new System.EventHandler(this.btnavgNetTotal_Click);
            // 
            // PatientsRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1073, 549);
            this.Controls.Add(this.btnavgNetTotal);
            this.Controls.Add(this.avgIntialTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.disTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPatient);
            this.Controls.Add(this.btnTotalInc);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.btnRecordsPatients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PatientsRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientsRecord";
            this.Load += new System.EventHandler(this.PatientsRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecordsPatients;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnTotalInc;
        private System.Windows.Forms.Button totalPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button disTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button avgIntialTotal;
        private System.Windows.Forms.Button btnavgNetTotal;
    }
}