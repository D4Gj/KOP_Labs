using System;
using System.Collections.Generic;
using MainLogic.DataBase.Models;
using MainLogic.Logic;
using MainLogic.ViewModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IOrganizationUnitLogic unitLogic;
        public MainForm(IOrganizationUnitLogic unitLogic)
        {
            InitializeComponent();
            this.unitLogic = unitLogic;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           // var unit = unitLogic.Read(null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOrganizationUnit>();
            form.ShowDialog();
            var unit = unitLogic.Read(null);
        }
    }
}
