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
        private bool _scheduleIsModified = false;
        private long _scheduleCellOldValue = 0;
        private long _scheduleCellNewValue = 0;


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

                    var currentValue = Convert.ToInt32(cell.Value);
                    if (!filteredProfessors.Any(p => p.Id == currentValue))
                    {
                        var currentProfessor = _professorsList.Where(p => p.Id == currentValue).Single();
                        filteredProfessors.Add(currentProfessor);
                    }

                    cell.DataSource = filteredProfessors;
                    cell.DisplayMember = "Name";
                    cell.ValueType = typeof(long);
                    cell.ValueMember = "Id";
                }
            }
        }

        private void lstClassrooms_DoubleClick(object sender, EventArgs e)
        {
            lblLoadingSchedule.Visible = true;
            loading.Visible = true;

            dgClassSchedule.DataSource = null;
            dgClassSchedule.DataSource = _scheduleDatalayer.ScheduleViewByClass(Convert.ToInt64(lstClassrooms.SelectedValue));

            loading.Visible = false;
            lblLoadingSchedule.Visible = false;
            this.btnSaveSchedule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            lblClassroom.Text = lstClassrooms.Text;
        }

        private async void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            loading.Visible = true;

            if (dgClassSchedule.DataSource == null)
                return;

            var scheduleView = (List<vWeeklyScheduleByClass>)dgClassSchedule.DataSource;
            await _scheduleDatalayer.SaveWeekSchedulesAsync(scheduleView);
            await _professorDatalayer.SaveChangesAsync();

            loading.Visible = false;
            lblScheduleSaved.Visible = true;
            this.btnSaveSchedule.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        }

        private void FrmWeekClassSchedule_Click(object sender, EventArgs e)
        {
            lblScheduleSaved.Visible = false;
        }

        private void dgClassSchedule_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var value = (long)dgClassSchedule[e.ColumnIndex, e.RowIndex].Value;
                this._scheduleCellOldValue = value;

                if (value > 0)
                {
                    var professor = _professorsList.Where(p => p.Id == value).FirstOrDefault();

                    //return the class to the professor
                    professor.NumberOfRemainingClasses++;
                    dgProfessors.DataSource = null;
                    dgProfessors.DataSource = _professorsList;
                }
            }
        }

        private void dgClassSchedule_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var value = (long)dgClassSchedule[e.ColumnIndex, e.RowIndex].Value;
                this._scheduleCellNewValue = value;

                if (value > 0)
                {
                    var professor = _professorsList.Where(p => p.Id == value).FirstOrDefault();

                    if (professor.NumberOfRemainingClasses > 0)
                    {
                        //subtract the class from the professor
                        professor.NumberOfRemainingClasses--;
                        dgProfessors.DataSource = null;
                        dgProfessors.DataSource = _professorsList;
                    }
                    else
                    { 
                        MessageBox.Show(string.Format("O professor {0} não possui mais aulas disponíveis.", dgClassSchedule[e.ColumnIndex, e.RowIndex].FormattedValue), 
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgClassSchedule[e.ColumnIndex, e.RowIndex].Value = this._scheduleCellOldValue;
                    }
                }

                this._scheduleIsModified = (this._scheduleCellOldValue != this._scheduleCellNewValue);
                if(this._scheduleIsModified) this.btnSaveSchedule.BackColor = System.Drawing.Color.DarkSalmon;
            }
        }

        private void lstClassrooms_Click(object sender, EventArgs e)
        {
            lblScheduleSaved.Visible = false;
        }

        private void dgClassSchedule_Click(object sender, EventArgs e)
        {
            lblScheduleSaved.Visible = false;
        }

        private void dgProfessors_Click(object sender, EventArgs e)
        {
            lblScheduleSaved.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var frmWeekClassSchedule = new FrmWeekClassSchedule();
            frmWeekClassSchedule.MdiParent = this.MdiParent;
            frmWeekClassSchedule.Show();

            this.Close();
        }

        private void dgProfessors_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cell = dgProfessors[0, e.RowIndex];
            var professorId = Convert.ToInt64(cell.Value);

            if (professorId > 0)
            {
                var frmProfessor = new FrmProfessor(professorId);
                frmProfessor.MdiParent = this.MdiParent;
                frmProfessor.Show();

                this.Close();
            }
        }
    }
}
