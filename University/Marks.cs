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
using System.Data.Entity;
using System.Data.SqlClient;

namespace University
{
    public partial class Marks : Form
    {
        UniversityContext context;
        int Id;

        public Marks(int _Id)
        {
            InitializeComponent();
            context = new UniversityContext();
            this.Id = _Id;

        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            var student = context.Student.Where(s => s.Id == Id).FirstOrDefault();
            label6.Text = student.FullName;
            label9.Text = student.Age.ToString();

            label14.Text = DateTime.Now.ToShortDateString();

            var group = context.Group.Where(g => g.Id == student.GroupId).FirstOrDefault();
            label12.Text = group.Name;

            var Cath = context.Cathedra.Where(c => c.Id == group.CathedraID).FirstOrDefault();
            label11.Text = Cath.Name;

            var Fac = context.Faculty.Where(f => f.Id == Cath.FacultyId).FirstOrDefault();
            label10.Text = Fac.Name;

            var Payment = context.PaymentType.Where(p => p.Id == student.PaymentTypeId).FirstOrDefault();
            label13.Text = Payment.Name;

            var marks = context.Mark.Where(m => m.StudentId == student.Id).ToList();

            if (marks == null)
                return;
            foreach(var mark in marks)
            {
                var stat = context.Statement.Where(s => s.Id == mark.StatementId).FirstOrDefault();
                var discipline = context.Discipline.Where(d => d.Id == stat.DisciplineId).FirstOrDefault();
                richTextBox1.Text += $"{discipline.Name} : {mark.Value.ToString()} \n\r";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
