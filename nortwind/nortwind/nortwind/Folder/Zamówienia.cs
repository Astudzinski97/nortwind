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
    public partial class Zamówienia : Form
    {
        public Zamówienia()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nORTHWNDDataSet);

        }

        private void Zamówienia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nORTHWNDDataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamówienie f = new Zamówienie(this.ordersBindingSource.Position);
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
