using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLib.UI
{
    public partial class MovieForm : Form
    {
        #region Construction
        public MovieForm()
        {
            InitializeComponent();
        }
        #endregion

        public Movie Movie { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            //aboutToolStripMenuItem.
            MessageBox.Show(this,"Sorry", "Help", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var form = new AddMovie();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            MessageBox.Show("Adding movie");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
