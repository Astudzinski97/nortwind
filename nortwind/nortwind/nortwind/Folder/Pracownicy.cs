using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nortwind
{
    public partial class Pracownicy : Form
    {
        public Pracownicy()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nORTHWNDDataSet);

        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.nORTHWNDDataSet.Employees);

        }
    }
}
