namespace exam
{
    partial class WeeksFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label week_nameLabel;
            System.Windows.Forms.Label hours_per_weekLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeeksFrom));
            this.examDBDataSet = new exam.ExamDBDataSet();
            this.weeksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weeksTableAdapter = new exam.ExamDBDataSetTableAdapters.WeeksTableAdapter();
            this.tableAdapterManager = new exam.ExamDBDataSetTableAdapters.TableAdapterManager();
            this.weeksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.weeksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.week_nameTextBox = new System.Windows.Forms.TextBox();
            this.hours_per_weekTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.weeksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            week_nameLabel = new System.Windows.Forms.Label();
            hours_per_weekLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksBindingNavigator)).BeginInit();
            this.weeksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // week_nameLabel
            // 
            week_nameLabel.AutoSize = true;
            week_nameLabel.Location = new System.Drawing.Point(12, 147);
            week_nameLabel.Name = "week_nameLabel";
            week_nameLabel.Size = new System.Drawing.Size(127, 16);
            week_nameLabel.TabIndex = 3;
            week_nameLabel.Text = "Название недели:";
            // 
            // hours_per_weekLabel
            // 
            hours_per_weekLabel.AutoSize = true;
            hours_per_weekLabel.Location = new System.Drawing.Point(12, 175);
            hours_per_weekLabel.Name = "hours_per_weekLabel";
            hours_per_weekLabel.Size = new System.Drawing.Size(114, 16);
            hours_per_weekLabel.TabIndex = 5;
            hours_per_weekLabel.Text = "Часов в неделю:";
            // 
            // examDBDataSet
            // 
            this.examDBDataSet.DataSetName = "ExamDBDataSet";
            this.examDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // weeksBindingSource
            // 
            this.weeksBindingSource.DataMember = "Weeks";
            this.weeksBindingSource.DataSource = this.examDBDataSet;
            // 
            // weeksTableAdapter
            // 
            this.weeksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MonthTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = exam.ExamDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeeksTableAdapter = this.weeksTableAdapter;
            // 
            // weeksBindingNavigator
            // 
            this.weeksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.weeksBindingNavigator.BindingSource = this.weeksBindingSource;
            this.weeksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.weeksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.weeksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.weeksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.weeksBindingNavigatorSaveItem});
            this.weeksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.weeksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.weeksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.weeksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.weeksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.weeksBindingNavigator.Name = "weeksBindingNavigator";
            this.weeksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.weeksBindingNavigator.Size = new System.Drawing.Size(828, 27);
            this.weeksBindingNavigator.TabIndex = 0;
            this.weeksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // weeksBindingNavigatorSaveItem
            // 
            this.weeksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.weeksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("weeksBindingNavigatorSaveItem.Image")));
            this.weeksBindingNavigatorSaveItem.Name = "weeksBindingNavigatorSaveItem";
            this.weeksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.weeksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.weeksBindingNavigatorSaveItem.Click += new System.EventHandler(this.weeksBindingNavigatorSaveItem_Click);
            // 
            // week_nameTextBox
            // 
            this.week_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.weeksBindingSource, "week_name", true));
            this.week_nameTextBox.Location = new System.Drawing.Point(143, 141);
            this.week_nameTextBox.Name = "week_nameTextBox";
            this.week_nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.week_nameTextBox.TabIndex = 4;
            // 
            // hours_per_weekTextBox
            // 
            this.hours_per_weekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.weeksBindingSource, "hours_per_week", true));
            this.hours_per_weekTextBox.Location = new System.Drawing.Point(143, 169);
            this.hours_per_weekTextBox.Name = "hours_per_weekTextBox";
            this.hours_per_weekTextBox.Size = new System.Drawing.Size(100, 22);
            this.hours_per_weekTextBox.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 197);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(228, 24);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(15, 257);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(228, 24);
            this.delBtn.TabIndex = 15;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(15, 227);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(228, 24);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // weeksDataGridView
            // 
            this.weeksDataGridView.AutoGenerateColumns = false;
            this.weeksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weeksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.weeksDataGridView.DataSource = this.weeksBindingSource;
            this.weeksDataGridView.Location = new System.Drawing.Point(249, 31);
            this.weeksDataGridView.Name = "weeksDataGridView";
            this.weeksDataGridView.RowHeadersWidth = 51;
            this.weeksDataGridView.RowTemplate.Height = 24;
            this.weeksDataGridView.Size = new System.Drawing.Size(567, 368);
            this.weeksDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_week";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер недели";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "week_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название недели";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hours_per_week";
            this.dataGridViewTextBoxColumn3.HeaderText = "Часов в неделю";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // WeeksFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(828, 411);
            this.Controls.Add(this.weeksDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(week_nameLabel);
            this.Controls.Add(this.week_nameTextBox);
            this.Controls.Add(hours_per_weekLabel);
            this.Controls.Add(this.hours_per_weekTextBox);
            this.Controls.Add(this.weeksBindingNavigator);
            this.Name = "WeeksFrom";
            this.Text = "Недели";
            this.Load += new System.EventHandler(this.WeeksFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksBindingNavigator)).EndInit();
            this.weeksBindingNavigator.ResumeLayout(false);
            this.weeksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExamDBDataSet examDBDataSet;
        private System.Windows.Forms.BindingSource weeksBindingSource;
        private ExamDBDataSetTableAdapters.WeeksTableAdapter weeksTableAdapter;
        private ExamDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator weeksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton weeksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox week_nameTextBox;
        private System.Windows.Forms.TextBox hours_per_weekTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView weeksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}