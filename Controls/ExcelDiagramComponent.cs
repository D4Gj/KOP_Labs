using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace components
{
    public partial class ExcelDiagramComponent : Component
    {
        public ExcelDiagramComponent()
        {
            InitializeComponent();
        }

        public ExcelDiagramComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
