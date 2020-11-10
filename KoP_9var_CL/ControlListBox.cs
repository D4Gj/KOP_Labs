using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace KoP_9var_CL
{
    public partial class ControlListBox : UserControl
    {
        private int _selectedIndex;

        private event EventHandler _listBoxSelectedElementChange;

        public int SelectedIntex
        {
            get { return _selectedIndex; }
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndex = value; 
                    listBox.SelectedIndex = _selectedIndex;
                }
            }
        }

        public string SelectedText
        {
            get { return listBox.Text; }
            private set { if (_selectedIndex > 0) listBox.Items[SelectedIntex] = value; }
        }

        public event EventHandler ListBoxSelectedElementChange
        {
            add { _listBoxSelectedElementChange += value; }
            remove { _listBoxSelectedElementChange -= value; }
        }

        public ControlListBox()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) =>
            {
                _listBoxSelectedElementChange?.Invoke(sender, e);
            };
        }

        public Type loadList
        {
            set
            {
                foreach (var item in Enum.GetValues(value))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void buttonSetIndex_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("Введите индекс: ");
            try
            {
                int ind = Convert.ToInt32(res);
                if (ind >= listBox.Items.Count)
                {
                    MessageBox.Show("За границами диапазона");
                    return;
                }
                if (SelectedIntex >= 0)
                {
                    var temp = listBox.Items[SelectedIntex];
                    listBox.Items.RemoveAt(SelectedIntex);
                    listBox.Items.Insert(ind, temp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Это не число");
            }
        }

        private void buttonGetIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedIntex.ToString());
        }

        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            string res = Interaction.InputBox("Введите значение: ");
            SelectedText = res;
        }

        private void buttonGetValue_Click(object sender, EventArgs e)
        {
            if (SelectedText != "")
            {
                MessageBox.Show(SelectedText);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIntex = listBox.SelectedIndex;
        }
    }
}
