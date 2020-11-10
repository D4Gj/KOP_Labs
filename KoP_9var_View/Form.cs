using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoP_9var_View
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<object> _list = new List<object>();

        public Form()
        {
            InitializeComponent();

            controlListBox.loadList = typeof(TestEnum);

            DateTime date = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                date = date.AddDays(1);
                _list.Add(new TestClass()
                {
                    id = i,
                    Name = "IT" + i.ToString(),
                    Date = date
                });
            }

            controlDataGrid.List = _list;
        }
    }
}
