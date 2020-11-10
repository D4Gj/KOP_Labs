namespace KoP_9var_View
{
    partial class Form
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.controlDataGrid = new KoP_9var_CL.ControlDataGrid();
            this.controlDatePicker = new KoP_9var_CL.ControlDatePicker();
            this.controlListBox = new KoP_9var_CL.ControlListBox();
            this.SuspendLayout();
            // 
            // controlDataGrid
            // 
            this.controlDataGrid.List = ((System.Collections.Generic.List<object>)(resources.GetObject("controlDataGrid.List")));
            this.controlDataGrid.Location = new System.Drawing.Point(12, 151);
            this.controlDataGrid.Name = "controlDataGrid";
            this.controlDataGrid.Size = new System.Drawing.Size(546, 175);
            this.controlDataGrid.TabIndex = 2;
            // 
            // controlDatePicker
            // 
            this.controlDatePicker.Date = "";
            this.controlDatePicker.isNull = false;
            this.controlDatePicker.Location = new System.Drawing.Point(147, 36);
            this.controlDatePicker.Name = "controlDatePicker";
            this.controlDatePicker.Size = new System.Drawing.Size(174, 109);
            this.controlDatePicker.TabIndex = 1;
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(327, 24);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.SelectedIntex = 0;
            this.controlListBox.Size = new System.Drawing.Size(212, 121);
            this.controlListBox.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 330);
            this.Controls.Add(this.controlDataGrid);
            this.Controls.Add(this.controlDatePicker);
            this.Controls.Add(this.controlListBox);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private KoP_9var_CL.ControlListBox controlListBox;
        private KoP_9var_CL.ControlDatePicker controlDatePicker;
        private KoP_9var_CL.ControlDataGrid controlDataGrid;
    }
}

