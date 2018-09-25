﻿using System;
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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie();

            //Name is required
            movie.Name = _txtName.Text;
            if (String.IsNullOrEmpty(_txtName.Text))
                return;

            movie.Description = _txtDescirption.Text;

            //Release year is numeric, if set
            var releaseYear = GetInt32(_txtReleasa);
            if (releaseYear < 0)
                return;

            //Run length, if set 
            var runLength = GetInt32(_txtRunLength);
            if (runLength < 0)
                return;

            DialogResult = DialogResult.OK;
            Close();
        }
        private int GetInt32( TextBox textBox )
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;
            return -1;
        }


    }
}       
        
        

        
    


