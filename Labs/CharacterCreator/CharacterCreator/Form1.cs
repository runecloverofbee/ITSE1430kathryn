using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                 "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Kathryn Bessent\nIntorduction to C#\nCharacter Creator","About", MessageBoxButtons.OK);
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
