using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeekClassSchedule.AppData;

namespace WeekClassSchedule
{
    public partial class FrmClassroom : Form
    {
        private WeekClassScheduleEntities _entitiesDb;
        private List<Classroom> _classroomList;

        public FrmClassroom()
        {
            InitializeComponent();
            _entitiesDb = new WeekClassScheduleEntities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classroom c = new Classroom();
            c.Name = txtName.Text;
            c.NumberOfClasses = Convert.ToInt16(txtClassNum.Text);

            _entitiesDb.Classroom.Add(c);

            try
            {
                _entitiesDb.SaveChanges();

                lstClassrooms.Items.Add(c.Name);
                _classroomList.Add(c);
                txtName.Text = string.Empty;
                txtClassNum.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClassroom_Load(object sender, EventArgs e)
        {
            _classroomList = _entitiesDb.Classroom.OrderBy(i => i.Name).ToList();
            foreach (var item in _classroomList)
            {
                lstClassrooms.Items.Add(item.Name);
            }
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            lblGeneratingSchedule.Visible = true;
            lblDone.Visible = false;

            foreach (ListViewItem item in lstClassrooms.Items)
            {
                if (item.Selected)
                {
                    var classroom = _classroomList.Where(c => c.Name.Equals(item.Text)).FirstOrDefault();
                    if (classroom != null)
                    {
                        ClassroomClasses classes;
                        lblGeneratingSchedule.Text = lblGeneratingSchedule.Text.Replace("{class}", classroom.Name);

                        for (short i = 1; i <= classroom.NumberOfClasses; i++)
                        {
                            classes = new ClassroomClasses();
                            classes.ClassromId = classroom.Id;
                            classes.ClassNumber = i;
                            _entitiesDb.ClassroomClasses.Add(classes);

                            WeekSchedule weekSchedule;
                            for (short w = (short)DayOfWeek.Monday; w <= (short)DayOfWeek.Friday; w++)
                            {
                                weekSchedule = new WeekSchedule();
                                weekSchedule.ClassroomId = (short)classroom.Id;
                                weekSchedule.ClassNumber = i;
                                weekSchedule.ProfessorId = 0;
                                weekSchedule.WeekDay = w;

                                _entitiesDb.WeekSchedule.Add(weekSchedule);
                            }
                        }
                        _entitiesDb.SaveChanges();
                    }
                }
            }

            lblGeneratingSchedule.Visible = false;
            lblDone.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
