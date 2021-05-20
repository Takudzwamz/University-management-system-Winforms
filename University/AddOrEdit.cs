using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.EntityFramework.Entities;
using University.EntityFramework.UniversityContext;

namespace University
{
    public partial class AddOrEdit : Form
    {
        UniversityContext context;
        Student student;
        int? Id;
        

        public AddOrEdit(int? Id)
        {
            InitializeComponent();
            context = new UniversityContext();
            if (Id != null)
            {
                this.Id = Id;
                this.Text = "Редактирование";
                student = context.Student.Where(s => s.Id == Id).FirstOrDefault();
            }               
            else
            {
                this.Id = null;
                this.Text = "Создание";
                student = new Student();
            }
                
        }

        //Закрытие формы при нажатии кнопки "Отмена"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Сохранение данных при нажатии кнокпи "Сохранить"
        private void button1_Click(object sender, EventArgs e)
        {
            //Очищаем текст ошибок
            label8.Text = "";

            int Age = 0;

            //Проверяем данные на заполненность
            if (String.IsNullOrWhiteSpace(textBox1.Text))
               label8.Text +="*Необходимо заполнить ФИО студента \n\r";
            if (String.IsNullOrWhiteSpace(textBox2.Text) || !Int32.TryParse(textBox2.Text, out Age))
                label8.Text += "*Необходимо верно заполнить возраст студента \n\r";
            if (!radioButton1.Checked && !radioButton2.Checked)
                label8.Text += "*Необходимо выбрать тип оплаты обучения \n\r";

           //Если текст ошибок пустой, сохраняем данные
            if (String.IsNullOrWhiteSpace(label8.Text))
            {              
                student.FullName = textBox1.Text;
                student.Age = Age;
                student.GroupId = Convert.ToInt32(comboBox3.SelectedValue);
                student.PaymentTypeId = radioButton1.Checked ? 1 : 2;

                try
                {
                    if (Id == null)
                        context.Student.Add(student);

                    context.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Сохранение отменено. Проверьте корректность данных \n\r");
                }


                
                this.Close();
            }

            
        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Fill(this.universityDbDataSet.Groups);
            this.coursesTableAdapter.Fill(this.universityDbDataSet.Courses);
            this.cathedrasTableAdapter.Fill(this.universityDbDataSet.Cathedras);
            this.facultiesTableAdapter.Fill(this.universityDbDataSet.Faculties);

            if (Id != null)
            {
                textBox1.Text = student.FullName;
                textBox2.Text = student.Age.ToString();
                if (student.PaymentTypeId == 1)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

                var group = context.Group.Where(g => g.Id == student.GroupId).FirstOrDefault();
                comboBox3.SelectedValue = group.Id;

                var course = context.Course.Where(c => c.Id == group.CourseID).FirstOrDefault();
                comboBox4.SelectedValue = course.Id;

                var Cath = context.Cathedra.Where(c => c.Id == group.CathedraID).FirstOrDefault();
                comboBox2.SelectedValue = Cath.Id;

                var Fac = context.Faculty.Where(f => f.Id == Cath.FacultyId).FirstOrDefault();
                comboBox1.SelectedValue = Fac.Id;

            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                cathedrasBindingSource.Filter = $"FacultyId = {comboBox1.SelectedValue}";

                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupsBindingSource.Filter = $"CathedraId = {comboBox2.SelectedValue}";
            comboBox4.Enabled = true;
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupsBindingSource.Filter = $"CathedraId = {comboBox2.SelectedValue} AND CourseID = {comboBox4.SelectedValue}";
            comboBox3.Enabled = true;
        }
    }
}
