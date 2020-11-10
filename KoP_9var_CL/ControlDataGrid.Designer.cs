namespace KoP_9var_CL
{
    partial class ControlDataGrid
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGetIndex = new System.Windows.Forms.Button();
            this.buttonSetIndex = new System.Windows.Forms.Button();
            this.buttonConfigureRow = new System.Windows.Forms.Button();
            this.buttonSetCellValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(432, 286);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonGetIndex
            // 
            this.buttonGetIndex.Location = new System.Drawing.Point(443, 4);
            this.buttonGetIndex.Name = "buttonGetIndex";
            this.buttonGetIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonGetIndex.TabIndex = 1;
            this.buttonGetIndex.Text = "Get Index";
            this.buttonGetIndex.UseVisualStyleBackColor = true;
            this.buttonGetIndex.Click += new System.EventHandler(this.buttonGetIndex_Click);
            // 
            // buttonSetIndex
            // 
            this.buttonSetIndex.Location = new System.Drawing.Point(442, 33);
            this.buttonSetIndex.Name = "buttonSetIndex";
            this.buttonSetIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonSetIndex.TabIndex = 2;
            this.buttonSetIndex.Text = "Set Index";
            this.buttonSetIndex.UseVisualStyleBackColor = true;
            this.buttonSetIndex.Click += new System.EventHandler(this.buttonSetIndex_Click);
            // 
            // buttonConfigureRow
            // 
            this.buttonConfigureRow.Location = new System.Drawing.Point(442, 62);
            this.buttonConfigureRow.Name = "buttonConfigureRow";
            this.buttonConfigureRow.Size = new System.Drawing.Size(94, 23);
            this.buttonConfigureRow.TabIndex = 3;
            this.buttonConfigureRow.Text = "Configure row";
            this.buttonConfigureRow.UseVisualStyleBackColor = true;
            this.buttonConfigureRow.Click += new System.EventHandler(this.buttonConfigureRow_Click);
            // 
            // buttonSetCellValue
            // 
            this.buttonSetCellValue.Location = new System.Drawing.Point(442, 91);
            this.buttonSetCellValue.Name = "buttonSetCellValue";
            this.buttonSetCellValue.Size = new System.Drawing.Size(94, 23);
            this.buttonSetCellValue.TabIndex = 4;
            this.buttonSetCellValue.Text = "Set cell value";
            this.buttonSetCellValue.UseVisualStyleBackColor = true;
            this.buttonSetCellValue.Click += new System.EventHandler(this.buttonSetCellValue_Click);
            // 
            // ControlDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSetCellValue);
            this.Controls.Add(this.buttonConfigureRow);
            this.Controls.Add(this.buttonSetIndex);
            this.Controls.Add(this.buttonGetIndex);
            this.Controls.Add(this.dataGridView);
            this.Name = "ControlDataGrid";
            this.Size = new System.Drawing.Size(539, 293);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonGetIndex;
        private System.Windows.Forms.Button buttonSetIndex;
        private System.Windows.Forms.Button buttonConfigureRow;
        private System.Windows.Forms.Button buttonSetCellValue;
    }
}
