namespace exam
{
    partial class MonthForm
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
            System.Windows.Forms.Label id_subjectLabel;
            System.Windows.Forms.Label id_weekLabel;
            System.Windows.Forms.Label count_hourLabel;
            System.Windows.Forms.Label lessonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthForm));
            this.examDBDataSet = new exam.ExamDBDataSet();
            this.monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthTableAdapter = new exam.ExamDBDataSetTableAdapters.MonthTableAdapter();
            this.tableAdapterManager = new exam.ExamDBDataSetTableAdapters.TableAdapterManager();
            this.monthBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.monthBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.monthDataGridView = new System.Windows.Forms.DataGridView();
            this.id_subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_weekComboBox = new System.Windows.Forms.ComboBox();
            this.weeksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.count_hourTextBox = new System.Windows.Forms.TextBox();
            this.lessonTextBox = new System.Windows.Forms.TextBox();
            this.examDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new exam.ExamDBDataSetTableAdapters.SubjectsTableAdapter();
            this.weeksTableAdapter = new exam.ExamDBDataSetTableAdapters.WeeksTableAdapter();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_subjectLabel = new System.Windows.Forms.Label();
            id_weekLabel = new System.Windows.Forms.Label();
            count_hourLabel = new System.Windows.Forms.Label();
            lessonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingNavigator)).BeginInit();
            this.monthBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_subjectLabel
            // 
            id_subjectLabel.AutoSize = true;
            id_subjectLabel.Location = new System.Drawing.Point(12, 138);
            id_subjectLabel.Name = "id_subjectLabel";
            id_subjectLabel.Size = new System.Drawing.Size(101, 16);
            id_subjectLabel.TabIndex = 4;
            id_subjectLabel.Text = "Код предмета:";
            // 
            // id_weekLabel
            // 
            id_weekLabel.AutoSize = true;
            id_weekLabel.Location = new System.Drawing.Point(12, 168);
            id_weekLabel.Name = "id_weekLabel";
            id_weekLabel.Size = new System.Drawing.Size(85, 16);
            id_weekLabel.TabIndex = 6;
            id_weekLabel.Text = "Код недели:";
            // 
            // count_hourLabel
            // 
            count_hourLabel.AutoSize = true;
            count_hourLabel.Location = new System.Drawing.Point(12, 198);
            count_hourLabel.Name = "count_hourLabel";
            count_hourLabel.Size = new System.Drawing.Size(96, 16);
            count_hourLabel.TabIndex = 8;
            count_hourLabel.Text = "Кол-во часов:";
            // 
            // lessonLabel
            // 
            lessonLabel.AutoSize = true;
            lessonLabel.Location = new System.Drawing.Point(12, 226);
            lessonLabel.Name = "lessonLabel";
            lessonLabel.Size = new System.Drawing.Size(42, 16);
            lessonLabel.TabIndex = 10;
            lessonLabel.Text = "Урок:";
            // 
            // examDBDataSet
            // 
            this.examDBDataSet.DataSetName = "ExamDBDataSet";
            this.examDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monthBindingSource
            // 
            this.monthBindingSource.DataMember = "Month";
            this.monthBindingSource.DataSource = this.examDBDataSet;
            // 
            // monthTableAdapter
            // 
            this.monthTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MonthTableAdapter = this.monthTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = exam.ExamDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WeeksTableAdapter = null;
            // 
            // monthBindingNavigator
            // 
            this.monthBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.monthBindingNavigator.BindingSource = this.monthBindingSource;
            this.monthBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.monthBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.monthBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.monthBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.monthBindingNavigatorSaveItem});
            this.monthBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.monthBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.monthBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.monthBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.monthBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.monthBindingNavigator.Name = "monthBindingNavigator";
            this.monthBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.monthBindingNavigator.Size = new System.Drawing.Size(987, 27);
            this.monthBindingNavigator.TabIndex = 0;
            this.monthBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // monthBindingNavigatorSaveItem
            // 
            this.monthBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.monthBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("monthBindingNavigatorSaveItem.Image")));
            this.monthBindingNavigatorSaveItem.Name = "monthBindingNavigatorSaveItem";
            this.monthBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.monthBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.monthBindingNavigatorSaveItem.Click += new System.EventHandler(this.monthBindingNavigatorSaveItem_Click);
            // 
            // monthDataGridView
            // 
            this.monthDataGridView.AutoGenerateColumns = false;
            this.monthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.monthDataGridView.DataSource = this.monthBindingSource;
            this.monthDataGridView.Location = new System.Drawing.Point(245, 43);
            this.monthDataGridView.Name = "monthDataGridView";
            this.monthDataGridView.RowHeadersWidth = 51;
            this.monthDataGridView.RowTemplate.Height = 24;
            this.monthDataGridView.Size = new System.Drawing.Size(720, 339);
            this.monthDataGridView.TabIndex = 1;
            // 
            // id_subjectComboBox
            // 
            this.id_subjectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monthBindingSource, "id_subject", true));
            this.id_subjectComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjectsBindingSource, "id_subject", true));
            this.id_subjectComboBox.DataSource = this.monthBindingSource;
            this.id_subjectComboBox.DisplayMember = "id_subject";
            this.id_subjectComboBox.FormattingEnabled = true;
            this.id_subjectComboBox.Location = new System.Drawing.Point(118, 135);
            this.id_subjectComboBox.Name = "id_subjectComboBox";
            this.id_subjectComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_subjectComboBox.TabIndex = 5;
            this.id_subjectComboBox.ValueMember = "id_subject";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.examDBDataSet;
            // 
            // id_weekComboBox
            // 
            this.id_weekComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monthBindingSource, "id_week", true));
            this.id_weekComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.weeksBindingSource, "id_week", true));
            this.id_weekComboBox.DataSource = this.monthBindingSource;
            this.id_weekComboBox.DisplayMember = "id_week";
            this.id_weekComboBox.FormattingEnabled = true;
            this.id_weekComboBox.Location = new System.Drawing.Point(118, 165);
            this.id_weekComboBox.Name = "id_weekComboBox";
            this.id_weekComboBox.Size = new System.Drawing.Size(121, 24);
            this.id_weekComboBox.TabIndex = 7;
            this.id_weekComboBox.ValueMember = "id_week";
            // 
            // weeksBindingSource
            // 
            this.weeksBindingSource.DataMember = "Weeks";
            this.weeksBindingSource.DataSource = this.examDBDataSet;
            // 
            // count_hourTextBox
            // 
            this.count_hourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monthBindingSource, "count_hour", true));
            this.count_hourTextBox.Location = new System.Drawing.Point(118, 195);
            this.count_hourTextBox.Name = "count_hourTextBox";
            this.count_hourTextBox.Size = new System.Drawing.Size(121, 22);
            this.count_hourTextBox.TabIndex = 9;
            // 
            // lessonTextBox
            // 
            this.lessonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monthBindingSource, "lesson", true));
            this.lessonTextBox.Location = new System.Drawing.Point(118, 223);
            this.lessonTextBox.Name = "lessonTextBox";
            this.lessonTextBox.Size = new System.Drawing.Size(121, 22);
            this.lessonTextBox.TabIndex = 11;
            // 
            // examDBDataSetBindingSource
            // 
            this.examDBDataSetBindingSource.DataSource = this.examDBDataSet;
            this.examDBDataSetBindingSource.Position = 0;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // weeksTableAdapter
            // 
            this.weeksTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 251);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(224, 24);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(15, 311);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(224, 24);
            this.delBtn.TabIndex = 16;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(15, 281);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(224, 24);
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
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_month";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код месяца";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_subject";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код предмета";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_week";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код недели";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "count_hour";
            this.dataGridViewTextBoxColumn4.HeaderText = "Часов в месяце";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lesson";
            this.dataGridViewTextBoxColumn5.HeaderText = "Урок";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // MonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(987, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(id_subjectLabel);
            this.Controls.Add(this.id_subjectComboBox);
            this.Controls.Add(id_weekLabel);
            this.Controls.Add(this.id_weekComboBox);
            this.Controls.Add(count_hourLabel);
            this.Controls.Add(this.count_hourTextBox);
            this.Controls.Add(lessonLabel);
            this.Controls.Add(this.lessonTextBox);
            this.Controls.Add(this.monthDataGridView);
            this.Controls.Add(this.monthBindingNavigator);
            this.Name = "MonthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.MonthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingNavigator)).EndInit();
            this.monthBindingNavigator.ResumeLayout(false);
            this.monthBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExamDBDataSet examDBDataSet;
        private System.Windows.Forms.BindingSource monthBindingSource;
        private ExamDBDataSetTableAdapters.MonthTableAdapter monthTableAdapter;
        private ExamDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator monthBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton monthBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView monthDataGridView;
        private System.Windows.Forms.ComboBox id_subjectComboBox;
        private System.Windows.Forms.BindingSource examDBDataSetBindingSource;
        private System.Windows.Forms.ComboBox id_weekComboBox;
        private System.Windows.Forms.TextBox count_hourTextBox;
        private System.Windows.Forms.TextBox lessonTextBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private ExamDBDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.BindingSource weeksBindingSource;
        private ExamDBDataSetTableAdapters.WeeksTableAdapter weeksTableAdapter;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}