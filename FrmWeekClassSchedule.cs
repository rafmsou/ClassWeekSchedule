using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeekClassSchedule.AppData;
using WeekClassSchedule.AppDatalayer;

namespace WeekClassSchedule
{
    public partial class FrmWeekClassSchedule : Form
    {
        private ProfessorDatalayer _professorDatalayer;
        private ClassroomDatalayer _classroomDatalayer;
        private ScheduleDatalayer _scheduleDatalayer;

        private List<Professor> _professorsList;

        public FrmWeekClassSchedule()
        {
            InitializeComponent();
            _professorDatalayer = new ProfessorDatalayer();
            _classroomDatalayer = new ClassroomDatalayer();
            _scheduleDatalayer = new ScheduleDatalayer();
        }

        private void FrmWeekClassSchedule_Load(object sender, EventArgs e)
        {
            dgProfessors.AutoGenerateColumns = false;
            _professorsList = _professorDatalayer.GetProfessorList();
            dgProfessors.DataSource = _professorsList;

            dgClassSchedule.AutoGenerateColumns = false;

            if (!_professorsList.Any(p => p.Id == 0))
                _professorsList.Add(new Professor() { Id = 0, Name = "Vaga" });

            lstClassrooms.DataSource = _classroomDatalayer.ClassroomList;

            this.Height = this.MdiParent.Height;
            this.Width = this.MdiParent.Width;
        }

        private void dgProfessors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgProfessors[0, e.RowIndex];
            var professorId = Convert.ToInt32(cell.Value);

            if (professorId > 0)
            {
                var frmProfessor = new FrmProfessor(professorId);
                frmProfessor.MdiParent = this.MdiParent;
                frmProfessor.Show();
            }
        }

        private void dgSala1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine(e.Exception.Message);
        }

        private void dgClassSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgClassSchedule.Rows.Count; i++)
            {
                var classNumber = i + 1;
                var weekDay = 0;
                foreach (DataGridViewComboBoxCell cell in dgClassSchedule.Rows[i].Cells.OfType<DataGridViewComboBoxCell>())
                {
                    weekDay++;

                    var filteredProfessors = _professorDatalayer.GetForScheduling((DayOfWeek)weekDay, classNumber, Convert.ToInt32(lstClassrooms.SelectedValue));

                    if (!filteredProfessors.Any(p => p.Id == 0))
                        filteredProfessors.Add(new Professor() { Id = 0, Name = "Vaga" });

                    cell.DataSource = filteredProfessors;
                    cell.DisplayMember = "Name";
                    cell.ValueType = typeof(int);
                    cell.ValueMember = "Id";
                }
            }
        }

        private void dgClassSchedule_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                var value = (int)dgClassSchedule[e.ColumnIndex, e.RowIndex].Value;
                var professor = _professorsList.Where(p => p.Id == value).FirstOrDefault();
                //professor.NumberOfRemainingClasses = _weeklyScheduleByClass.Count(ws =;
                dgProfessors.Refresh();
            }
        }

        private void lstClassrooms_DoubleClick(object sender, EventArgs e)
        {
            lblLoadingSchedule.Visible = true;
            dgClassSchedule.DataSource = null;
            dgClassSchedule.DataSource = _scheduleDatalayer.ScheduleViewByClass(Convert.ToInt32(lstClassrooms.SelectedValue));
            lblLoadingSchedule.Visible = false;
        }

        private async void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            loading.Visible = true;

            if (dgClassSchedule.DataSource == null)
                return;

            var scheduleView = (List<vWeeklyScheduleByClass>)dgClassSchedule.DataSource;
            await _scheduleDatalayer.SaveWeekSchedulesAsync(scheduleView);

            loading.Visible = false;
            lblScheduleSaved.Visible = true;
        }

        private void FrmWeekClassSchedule_Click(object sender, EventArgs e)
        {
            lblScheduleSaved.Visible = false;
        }
    }
}
