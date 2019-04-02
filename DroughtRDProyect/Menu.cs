using DroughtRDProyect.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DroughtRDProyect
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void droughtAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void earthlyDroughtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void animalDroughtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAnimalDrougth animal = new rAnimalDrougth();
            animal.MdiParent = this;
            animal.Show();
        }
    }
}
