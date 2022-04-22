using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openSubjectBtn_Click(object sender, EventArgs e)
        {
            var form = new SubjectsForm();
            form.Show();
        }

        private void openDaysShow_Click(object sender, EventArgs e)
        {
            var form = new WeeksFrom();
            form.Show();
        }

        private void openMonthForm_Click(object sender, EventArgs e)
        {
            var form = new MonthForm();
            form.Show();
        }

      
    }
}
