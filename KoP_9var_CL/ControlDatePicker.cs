using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KoP_9var_CL
{
    public partial class ControlDatePicker : UserControl
    {
        private DateTime _dt;
        private string _savedInput;
        private string _example = "Ex: 16/05/2001";
        private CultureInfo _ci = new CultureInfo("en-US");

        private bool isValid
        {
            get 
            {
                bool b = DateTime.TryParseExact(textBoxDatePicker.Text, "dd/M/yyyy", _ci, DateTimeStyles.None, out _dt);
                //Console.WriteLine("Converted '{0}' to {1} ({2}).", textBoxDatePicker.Text, _dt, _dt.Kind); //debug
                return b; 
            }
        }

        public string Date { 
            get { return isValid ? textBoxDatePicker.Text : ""; }
            set { textBoxDatePicker.Text = value; }
        }

        public bool isNull { get; set; } = false;

        public ControlDatePicker()
        {
            InitializeComponent();
            checkBoxNull.Checked = isNull;
            labelInfo.Text = _example;
        }

        private void checkBoxNull_CheckedChanged(object sender, EventArgs e)
        {
            isNull = checkBoxNull.Checked;
            textBoxDatePicker.Enabled = !isNull;
            if (isNull)
            {
                _savedInput = textBoxDatePicker.Text;
                Date = "";
            }
            else
            {
                Date = _savedInput;
            }
        }

        private void textBoxDatePicker_TextChanged(object sender, EventArgs e)
        {
            if (!isValid)
            {
                labelInfo.Text = _example;
            } 
            else
            {
                labelInfo.Text = "nice";
            }
        }
    }
}
