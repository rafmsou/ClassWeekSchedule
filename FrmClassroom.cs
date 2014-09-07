using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeekSchedule.AppData;

namespace WeekSchedule
{
    public partial class FrmClassroom : Form
    {
        private WeekScheduleEntities _entitiesDb;

        public FrmClassroom()
        {
            InitializeComponent();
            _entitiesDb = new WeekScheduleEntities();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classroom c = new Classroom();
            c.Name = txtName.Text;

            _entitiesDb.Classroom.Add(c);

            try
            {
                _entitiesDb.SaveChanges();
                lstClassrooms.Items.Add(c.Name);
                txtName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClassroom_Load(object sender, EventArgs e)
        {
            foreach (var item in _entitiesDb.Classroom.OrderBy(i => i.Name).ToList())
            {
                lstClassrooms.Items.Add(item.Name);
            }
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            lblGeneratingSchedule.Visible = true;

            foreach (ListViewItem item in lstClassrooms.Items)
            {
                if (item.Selected)
                {
                    //WeekSchedule2 schedule = new WeekSchedule2();
                    //schedule.WeekDay = DayOfWeek.Monday

                    ClassroomClasses classes = new ClassroomClasses();
                }
            }

            lblGeneratingSchedule.Visible = false;
        }
    }
}
