﻿using components;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            ClassT[] arr = new ClassT[10];
            ClassT cl = new ClassT();
            cl.name = "1";
            ClassT cl2 = new ClassT();
            cl2.name = "2";
            ClassT cl3 = new ClassT();
            cl3.name = "3";
            arr[1] = cl;
            arr[2] = cl2;
            arr[9] = cl3;
            backupComponent1.saveData<ClassT>("C:/123/2", arr);
        }
              
        [Obsolete]
        private void buttonDiagramm_Click(object sender, EventArgs e)
        {
            var cl = new ClassT();
            cl.ID = 55;
            cl.name = "ТestClass";
            cl.number1 = 30;
            cl.number2 = 20;
            cl.number3 = 10;
            cl.number4 = 40;
           // pdfDiagrammComponent.createPdfDeiagram<ClassT>("D:/diagramm.pdf", cl, DataLabelType.Percent);
        }

        private void buttonHistogramm_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<Setting>();
                for (int i = 0; i < 12; i++)
                {
                    list.Add(new Setting());
                }
                componentExcelDiagram1.BuiltChart(list, @"C:\123\fileGraph.xlsx");
                MessageBox.Show("Всё хорошо");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            ClassT[] arr = new ClassT[10];
            ClassT cl = new ClassT();
            cl.name = "1";
            ClassT cl2 = new ClassT();
            cl2.name = "2";
            ClassT cl3 = new ClassT();
            cl3.name = "3";
            arr[1] = cl;
            arr[2] = cl2;
            arr[9] = cl3;
            //componentWordSummary1.saveData<ClassT>("C:/123/2", false, arr);
        }
    }
}
