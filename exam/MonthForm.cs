using System;
using System.Windows.Forms;

namespace exam
{
    public partial class MonthForm : Form
    {
        public MonthForm()
        {
            InitializeComponent();
        }

        private void monthBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.monthBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDBDataSet);

        }

        private void MonthForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDBDataSet.Weeks". При необходимости она может быть перемещена или удалена.
            this.weeksTableAdapter.Fill(this.examDBDataSet.Weeks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDBDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.examDBDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDBDataSet.Month". При необходимости она может быть перемещена или удалена.
            this.monthTableAdapter.Fill(this.examDBDataSet.Month);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                monthBindingSource.AddNew();
            }
            catch
            {
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Update();
                monthBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(examDBDataSet);
            }
            catch
            {
                MessageBox.Show("Что-то не выбрано!!!");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                monthBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Не выбран элемент для удаления!");
            }
        }

        
    }
}
