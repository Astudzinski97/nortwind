using nortwind.Folderek;
using System.Windows.Forms;

namespace nortwind
{
    public partial class Nortwind : Form
    {
        public Nortwind()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form f = null;
            switch (e.ClickedItem.Text)
            {
                case "Zamówienia":
                    f = new Zamówienia();
                    break;
                case "Produkty":
                    f = new Produkty();
                    break;
                case "Klienci":
                    f = new Klienci();
                    break;
                case "Pracownicy":
                    f = new Pracownicy();
                    break;
            }
            f.MdiParent = this;
            f.Show();
        }
    }
}
