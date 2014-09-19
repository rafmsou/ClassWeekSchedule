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
using WeekClassSchedule.Helpers;

namespace WeekClassSchedule
{
    public partial class FrmClassroom : Form
    {
        private ClassroomDatalayer _classroomDatalayer;
        private List<Classroom> _classroomList;

        public FrmClassroom()
        {
            InitializeComponent();
            _classroomDatalayer = new ClassroomDatalayer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classroom c = new Classroom();
            c.Name = txtName.Text;
            c.NumberOfClasses = Convert.ToInt16(txtClassNum.Text);

            try
            {
                _classroomDatalayer.Save(c);
                dgClassrooms.DataSource = null;
                dgClassrooms.DataSource = _classroomDatalayer.GetClassroomList();

                txtName.Text = string.Empty;
                txtClassNum.Text = string.Empty;
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FrmClassroom_Load(object sender, EventArgs e)
        {
            dgClassrooms.AutoGenerateColumns = false;
            dgClassrooms.DataSource = await _classroomDatalayer.GetClassroomListAsync();

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
                _classroomDatalayer.GenerateWeekSchedule(classroomName);
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
