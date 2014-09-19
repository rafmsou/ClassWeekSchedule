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
                _classroomList.Add(c);
                dgClassrooms.DataSource = null;
                dgClassrooms.DataSource = _classroomList;

                txtName.Text = string.Empty;
                txtClassNum.Text = string.Empty;
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmClassroom_Load(object sender, EventArgs e)
        {
            _classroomList = _entitiesDb.Classroom.OrderBy(i => i.Name).ToList();
            dgClassrooms.AutoGenerateColumns = false;
            dgClassrooms.DataSource = _classroomList;

            this.Height = this.MdiParent.Height;
            this.Width = this.MdiParent.Width;
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            lblGeneratingSchedule.Visible = true;
            lblDone.Visible = false;

            for (int i = 0; i < dgClassrooms.SelectedRows.Count; i++)
            {
                var classroomName = dgClassrooms.SelectedRows[i].Cells[0].Value.ToString();
                lblGeneratingSchedule.Text = lblGeneratingSchedule.Text.Replace("{class}", classroomName);
            }

            lblGeneratingSchedule.Visible = false;
            lblDone.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
