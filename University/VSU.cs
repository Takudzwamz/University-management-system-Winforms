using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.EntityFramework.UniversityContext;
using University.EntityFramework.Entities;
using System.Data.Entity;
using System.Data.SqlClient;

namespace University
{
    public partial class VSUDb : Form
    {
        //Контекст БД как глобальное свойство класса для работы с БД
        UniversityContext context;

        public VSUDb()
        {
            InitializeComponent();
            context = new UniversityContext(); //Создаем экземпляр контекста
        }

        private void VSUDb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDbDataSet.DTOEmployees' table. You can move, or remove it, as needed.
            this.dTOEmployeesTableAdapter.Fill(this.universityDbDataSet.DTOEmployees);
            //Добавляем корень дерева - ВГУ
            TreeNode root = new TreeNode() { Name = "ВГУ", Text = "ВГУ" };

            //Перебираем все факультеты и добавляем их к корню
            foreach (var fac in context.Faculty.ToList())
            {
                TreeNode faculty = new TreeNode() { Name = fac.Name, Text = fac.Name };

                var cathedras = context.Cathedra.Where(s => s.FacultyId == fac.Id).ToList();
                //Перебираем все кафедры и добавляем их к факультету
                foreach (var cathedra in cathedras)
                {
                    TreeNode cath = new TreeNode() { Name = cathedra.Name, Text = cathedra.Name };

                    var groups = context.Group.Where(x => x.CathedraID == cathedra.Id).ToList();
                    //Перебираем все группы и добавляем их к кафедре
                    foreach (var group in groups)
                    {
                        TreeNode gr = new TreeNode() { Name = group.Name, Text = group.Name };

                        var courses = context.Course.Where(c => c.Id == group.CourseID).ToList();
                        //Перебираем все курсы и добавляем их к группе
                        foreach (var course in courses)
                        {
                            TreeNode cours = new TreeNode() { Name = course.Name, Text = course.Name + " курс" };

                            //Добавить курсы к группе
                            gr.Nodes.Add(cours);
                        }

                        //Добавить группы к кафедре
                        cath.Nodes.Add(gr);
                    }    
                    
                    //добавить кафедры к факультету
                    faculty.Nodes.Add(cath);
                }

                //Добавить факультеты к корню - ВГУ
                root.Nodes.Add(faculty);
            }

            //Добавить корень к treeView
            treeView1.Nodes.Add(root);
        }

        //При нажатии на узел дерева
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Заполняем DataSet данными о сотрудниках и студентах
            this.dTOStudentsTableAdapter.Fill(universityDbDataSet.DTOStudents);
            this.dTOEmployeesTableAdapter.Fill(universityDbDataSet.DTOEmployees);

            //Определяем уровень узла для фильтрации
            switch (e.Node.Level)
            {
                //Если корень дерева - отображаем всех сотрудников/студентов
                case 0:
                    {   
                        //Убираем фильтры
                        this.dTOStudentsBindingSource.Filter = "";
                        this.dTOEmployeesBindingSource.Filter = "";
                    }; break;
                
                //Если узел уровня факультетов
                case 1:
                    {
                        //Фильтруем сотрудников/студентов по названию узла, т.е. факультета
                        this.dTOStudentsBindingSource.Filter = $"Факультет = '{e.Node.Text}'";
                        this.dTOEmployeesBindingSource.Filter = $"Факультет = '{e.Node.Text}'";
                    };break;
                
                //Если узел уровня кафедры
                case 2:
                    {
                        //Фильтруем сотрудников/студентов по названию узла, т.е. кафедры
                        this.dTOStudentsBindingSource.Filter = $"Кафедра = '{e.Node.Text}'";
                        this.dTOEmployeesBindingSource.Filter = $"Кафедра = '{e.Node.Text}'";
                    }; break;

                //Если узел уровня группы
                case 3:
                    {
                        //Фильтруем студентов по названию узла, т.е. группы
                        this.dTOStudentsBindingSource.Filter = $"Группа = '{e.Node.Text}'";
                    }; break;

                //Если узел уровня курса        
                case 4:
                    {
                        //Фильтруем студентов по названию узла, т.е. курса и группы
                        this.dTOStudentsBindingSource.Filter = $"Курс = '{e.Node.Name}' AND Группа = '{e.Node.Parent.Text}'";
                    }; break;

                default: break;
            }
        }

        //Добавление новой сущности
        private void NewBtn_Click(object sender, EventArgs e)
        {
            AddOrEdit aoe = new AddOrEdit(null);
            aoe.FormClosed += Form_closing;
            aoe.Show();

        }

        //Удаление записи из DGV
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Если активна первая вкладка со студентами
            if (tabControl2.SelectedIndex == 0)
            {
                //Вызываем предупреждающее окно
                DialogResult dialogResult =  MessageBox.Show( "Вы действительно хотите удалить данную запись о студенте?","Удаление", MessageBoxButtons.YesNo);

                //Если пользователь нажал OK
                if (dialogResult == DialogResult.Yes)
                {
                    //Получаем ID студента из DGV
                    int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    //Находим студента в БД
                    var stud = context.Student.Include(c => c.Marks).Where(x => x.Id == Id).FirstOrDefault();
                    //Удаляем студента из БД
                    context.Student.Remove(stud);
                    //Сохраняем результат
                    context.SaveChanges();
                }
                this.dTOStudentsTableAdapter.Fill(universityDbDataSet.DTOStudents);
            }
            else  //Если активна вторая вкладка
            {
                //Вызываем предупреждающее окно
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить данную запись о сотруднике?", "Удаление", MessageBoxButtons.YesNo);

                //Если пользователь нажал OK
                if (dialogResult == DialogResult.Yes)
                {
                    //Получаем ID сотрудника из DGV
                    int Id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    //Находим сотрудника в БД
                    var emp = context.Employee.Where(x => x.Id == Id).FirstOrDefault();
                    //Удаляем сотрудника из БД
                    context.Employee.Remove(emp);
                    //Сохраняем результат
                    context.SaveChanges();
                }
                this.dTOEmployeesTableAdapter.Fill(universityDbDataSet.DTOEmployees);
            }
        }

        //Если выбрали строку в DGV, делаем ее редактируемой
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];  
            AddOrEdit aoe = new AddOrEdit(Convert.ToInt32(row.Cells[0].Value));
            aoe.FormClosed += Form_closing;
            aoe.Show();
        } 

        //Кнопка глобального поиска по фамилии
        private void button2_Click(object sender, EventArgs e)
        {
            //Строка из textBox поиска
            string value = textBox1.Text;

            //Ищем воспадения по фамилии среди студентов/сотрудников
            this.dTOStudentsBindingSource.Filter =  $"ФИО LIKE '%{value}%'";
            this.dTOEmployeesBindingSource.Filter = $"ФИО LIKE '%{value}%'";

            //Если результат совпадения не пустой - активируем вкладку по стунедтам
            if (this.dTOStudentsBindingSource.Count > 0)
                tabControl2.SelectedIndex = 0;
            
            //Если результат совпадения не пустой по сотрудникам - активируем вкладку по сотрудникам
            if (this.dTOEmployeesBindingSource.Count > 0)
            {
                tabControl2.SelectedIndex = 1;
            }
            
            //Если совпадений не найдено - показываем сообщение
            if (this.dTOEmployeesBindingSource.Count == 0 && this.dTOStudentsBindingSource.Count == 0)
                MessageBox.Show("Совпадений не найдено!");
                          
        }

        //Включение кнопок "Оценки, изменить, удалить" при выборе студента
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
            ChangeBtn.Enabled = true;
            NewBtn.Enabled = true;
            DeleteBtn.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Marks aoe = new Marks(Id);
            aoe.Show();
            
        }

        //Включение кнопки "Удалить" при выборе сотрудника из dgv2
        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DeleteBtn.Enabled = true;
        }

        private void Form_closing(object sender, FormClosedEventArgs e)
        {
            this.dTOEmployeesTableAdapter.Fill(universityDbDataSet.DTOEmployees);
            this.dTOStudentsTableAdapter.Fill(universityDbDataSet.DTOStudents);
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            button3.Enabled = false;
            NewBtn.Enabled = false;
            ChangeBtn.Enabled = false;
        }
    }

    
}
