using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeekClassSchedule.AppData;

namespace WeekClassSchedule
{
    public partial class FrmWeekClassSchedule : Form
    {
        private WeekClassScheduleEntities _entitiesDb;
        private List<Professor> _professorsList;
        private List<vWeeklyScheduleByClass> _weeklyScheduleByClass;
        private List<WeekSchedule> _weekScheduleList;


        public FrmWeekClassSchedule()
        {
            InitializeComponent();
            _entitiesDb = new WeekClassScheduleEntities();
        }

        private void FrmWeekClassSchedule_Load(object sender, EventArgs e)
        {
            dgProfessors.AutoGenerateColumns = false;
            _professorsList = _entitiesDb.Professor.ToList();
            dgProfessors.DataSource = _professorsList;

            dgClassSchedule.AutoGenerateColumns = false;
            _weeklyScheduleByClass = _entitiesDb.vWeeklyScheduleByClass.ToList();

            if (!_professorsList.Any(p => p.Id == 0))
                _professorsList.Add(new Professor() { Id = 0, Name = "Vaga" });

            lstClassrooms.DataSource = _entitiesDb.Classroom.ToList();
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

        private void dgClassSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    cell.DataSource = _professorsList
                        .Where(p => p.Id.Equals(0) || p.AttendanceRules.Any(rule => rule.ClassNumber == classNumber && rule.DayOfWeek == weekDay)).ToList();
                    //cell.DataSource = _professorsList.ToList();
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
            dgClassSchedule.DataSource = _weeklyScheduleByClass.Where(ws => ws.Classe == Convert.ToInt32(lstClassrooms.SelectedValue)).ToList();
            lblLoadingSchedule.Visible = false;
        }
    }
}
