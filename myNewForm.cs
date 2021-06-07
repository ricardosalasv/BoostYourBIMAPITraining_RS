using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoostYourBIMAPITraining
{
    public partial class myNewForm : Form
    {
        public myNewForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool isHorizontal()
        {
            if (radioBtnHorizontal.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double getDistance()
        {
            double d;
            Double.TryParse(textBoxDistance.Text, out d);

            return d;
        }
    }
}
