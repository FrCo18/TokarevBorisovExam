using System;
using System.Windows.Forms;

namespace exam
{
    public partial class WeeksFrom : Form
    {
        public WeeksFrom()
        {
            InitializeComponent();
        }

        private void weeksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.weeksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDBDataSet);

        }

        private void WeeksFrom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDBDataSet.Weeks". При необходимости она может быть перемещена или удалена.
            this.weeksTableAdapter.Fill(this.examDBDataSet.Weeks);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                weeksBindingSource.AddNew();

            }
            catch { }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                weeksBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Не выбран элемент для удаления!");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Update();
                weeksBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(examDBDataSet);
            }
            catch
            {
                MessageBox.Show("Что-то не выбрано!!!");
            }
        }

        
    }
}
