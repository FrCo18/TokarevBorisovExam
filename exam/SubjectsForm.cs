using System;
using System.Windows.Forms;

namespace exam
{
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.examDBDataSet);

        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "examDBDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.examDBDataSet.Subjects);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                subjectsBindingSource.AddNew();
            }
            catch { }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Update();
                subjectsBindingSource.EndEdit();
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
                subjectsBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Не выбран элемент для удаления!");
            }
        }
    }
}
