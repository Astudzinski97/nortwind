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
    public partial class Zamówienie : Form
    {
        int poz = 0;
        public Zamówienie()
        {
            InitializeComponent();
        }
        public Zamówienie(int x)
        {
            InitializeComponent();
            poz = x;
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nORTHWNDDataSet);

        }

        private void Zamówienie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.nORTHWNDDataSet.Order_Details);
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nORTHWNDDataSet.Orders);
            this.ordersBindingSource.Position = poz;
        }
    }
}
