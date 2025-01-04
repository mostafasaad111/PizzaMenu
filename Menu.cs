using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new PizzaOrder();
            frm1.ShowDialog();
        }
    }
}
