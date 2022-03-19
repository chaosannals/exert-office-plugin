using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ExcelAddInVSTOCS
{
    public partial class DemoTaskPaneWF : UserControl
    {
        private ElementHost wpfUserControl;

        public DemoTaskPaneWF()
        {
            InitializeComponent();
            wpfUserControl = InitWPFUserControl();
            wpfPanel.Controls.Add(wpfUserControl);
        }

        private ElementHost InitWPFUserControl()
        {
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;
            var dtpwpf = new DemoTaskPaneWPF();
            host.Child = dtpwpf;
            return host;
        }
    }
}
