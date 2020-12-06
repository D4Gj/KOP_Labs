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
using DataLabelType = MigraDoc.DocumentObjectModel.Shapes.Charts.DataLabelType;

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
            var units = unitLogic.Read(null);
            var cl = new ClassAmountEmployes();
            var amount = new List<List<int>>();
            var name = new List<string>();
            foreach(var unit in units)
            {
                amount.Add(new List<int> { unit.AmountEmployes});
                name.Add(unit.Name);
            }
            var top = new string[] { "Name", "amount" };
            exelTable.Create<int>("D:/table.pdf",false, name, amount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCreateOrganizationUnit>();
            form.ShowDialog();
            var unit = unitLogic.Read(null);
        }

        private void controlListBox1_Load(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);
            controlListBox1.Items.AddRange(new string[] { "Имя\t" + "Колво работников\t\t" + "Тип" });
            foreach (var unit in units)
            {
                var list = new List<String>();
                list.Add(unit.Name + "\t" + unit.AmountEmployes.ToString() + "\t\t " + unit.professionType.ToString());
                controlListBox1.Items.AddRange(list.ToArray());
            }
        }

        [Obsolete]
        private void buttonPdfDiagram_Click(object sender, EventArgs e)
        {
            var units = unitLogic.Read(null);
            
            pdfDiagrammComponent.createPdfDeiagram("D:/diagramm.pdf", units[0], DataLabelType.Percent);
        }

        private void buttonPdfTable_Click(object sender, EventArgs e)
        {

        }
    }
}
