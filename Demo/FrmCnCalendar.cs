using System;
using System.Windows.Forms;
using HailinLib;

namespace Demo
{
    public partial class FrmCnCalendar : Form
    {
        public FrmCnCalendar()
        {
            InitializeComponent();
        }


        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowValue();
        }

        private void ShowValue()
        {
            CnCalendar cnCalendar = new CnCalendar(dtpDate.Value);
            txtCnYear.Text = cnCalendar.GetYearName();
            txtCnMonth.Text = cnCalendar.GetMonthName();
            txtCnDay.Text = cnCalendar.GetDayName();
            txtAnimal.Text = cnCalendar.GetAnimalName();
        }

        private void FrmCnCalendar_Load(object sender, EventArgs e)
        {
            ShowValue();
        }
    }
}
