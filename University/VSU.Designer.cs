namespace University
{
    partial class VSUDb
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кафедраDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTOStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDbDataSet = new University.UniversityDbDataSet();
            this.Сотрудники = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кафедраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTOEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dTOStudentsTableAdapter = new University.UniversityDbDataSetTableAdapters.DTOStudentsTableAdapter();
            this.dTOEmployeesTableAdapter = new University.UniversityDbDataSetTableAdapters.DTOEmployeesTableAdapter();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDbDataSet)).BeginInit();
            this.Сотрудники.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOEmployeesBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1072, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "ПОИСК";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.NewBtn);
            this.tabPage1.Controls.Add(this.DeleteBtn);
            this.tabPage1.Controls.Add(this.ChangeBtn);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Структура";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(536, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Оценки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(439, 431);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 11;
            this.NewBtn.Text = "Добавить";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(1083, 431);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Enabled = false;
            this.ChangeBtn.Location = new System.Drawing.Point(980, 431);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 9;
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.Сотрудники);
            this.tabControl2.Location = new System.Drawing.Point(418, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(750, 409);
            this.tabControl2.TabIndex = 8;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl2_Selected);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(742, 383);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Студенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.фИОDataGridViewTextBoxColumn1,
            this.возрастDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.кафедраDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.типОплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dTOStudentsBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(17, 15);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 362);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            this.возрастDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // факультетDataGridViewTextBoxColumn1
            // 
            this.факультетDataGridViewTextBoxColumn1.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn1.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn1.Name = "факультетDataGridViewTextBoxColumn1";
            this.факультетDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Курс";
            this.dataGridViewTextBoxColumn1.HeaderText = "Курс";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // кафедраDataGridViewTextBoxColumn1
            // 
            this.кафедраDataGridViewTextBoxColumn1.DataPropertyName = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn1.HeaderText = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn1.Name = "кафедраDataGridViewTextBoxColumn1";
            this.кафедраDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Группа";
            this.dataGridViewTextBoxColumn2.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // типОплатыDataGridViewTextBoxColumn
            // 
            this.типОплатыDataGridViewTextBoxColumn.DataPropertyName = "Тип оплаты";
            this.типОплатыDataGridViewTextBoxColumn.HeaderText = "Тип оплаты";
            this.типОплатыDataGridViewTextBoxColumn.Name = "типОплатыDataGridViewTextBoxColumn";
            this.типОплатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOStudentsBindingSource
            // 
            this.dTOStudentsBindingSource.DataMember = "DTOStudents";
            this.dTOStudentsBindingSource.DataSource = this.universityDbDataSet;
            // 
            // universityDbDataSet
            // 
            this.universityDbDataSet.DataSetName = "UniversityDbDataSet";
            this.universityDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Сотрудники
            // 
            this.Сотрудники.Controls.Add(this.dataGridView2);
            this.Сотрудники.Location = new System.Drawing.Point(4, 22);
            this.Сотрудники.Name = "Сотрудники";
            this.Сотрудники.Padding = new System.Windows.Forms.Padding(3);
            this.Сотрудники.Size = new System.Drawing.Size(742, 383);
            this.Сотрудники.TabIndex = 1;
            this.Сотрудники.Text = "Сотрудники";
            this.Сотрудники.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.кафедраDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dTOEmployeesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(719, 362);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кафедраDataGridViewTextBoxColumn
            // 
            this.кафедраDataGridViewTextBoxColumn.DataPropertyName = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.HeaderText = "Кафедра";
            this.кафедраDataGridViewTextBoxColumn.Name = "кафедраDataGridViewTextBoxColumn";
            this.кафедраDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // факультетDataGridViewTextBoxColumn
            // 
            this.факультетDataGridViewTextBoxColumn.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn.Name = "факультетDataGridViewTextBoxColumn";
            this.факультетDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTOEmployeesBindingSource
            // 
            this.dTOEmployeesBindingSource.DataMember = "DTOEmployees";
            this.dTOEmployeesBindingSource.DataSource = this.universityDbDataSet;
            // 
            // treeView1
            // 
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(6, 16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(395, 451);
            this.treeView1.TabIndex = 6;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 499);
            this.tabControl1.TabIndex = 7;
            // 
            // dTOStudentsTableAdapter
            // 
            this.dTOStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // dTOEmployeesTableAdapter
            // 
            this.dTOEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // VSUDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 597);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "VSUDb";
            this.Text = "База данных ВГУ";
            this.Load += new System.EventHandler(this.VSUDb_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDbDataSet)).EndInit();
            this.Сотрудники.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOEmployeesBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UniversityDbDataSet universityDbDataSet;
        private System.Windows.Forms.BindingSource dTOStudentsBindingSource;
        private UniversityDbDataSetTableAdapters.DTOStudentsTableAdapter dTOStudentsTableAdapter;
        private System.Windows.Forms.BindingSource dTOEmployeesBindingSource;
        private UniversityDbDataSetTableAdapters.DTOEmployeesTableAdapter dTOEmployeesTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кафедраDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Сотрудники;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кафедраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
    }
}

