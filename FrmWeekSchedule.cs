using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeekSchedule.AppData;

namespace WeekSchedule
{
    public partial class FrmWeekSchedule : Form
    {
        private WeekScheduleEntities _entitiesDb;
        private List<Professor> _professorsList;
        private List<vWeeklyScheduleByClass> _weeklyScheduleByClass;


        public FrmWeekSchedule()
        {
            InitializeComponent();
            _entitiesDb = new WeekScheduleEntities();
        }

        private void FrmWeekSchedule_Load(object sender, EventArgs e)
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
            MessageBox.Show(cell.Value.ToString());
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
                    //cell.DataSource = professorsList.Where(p => p.AttendanceRules.Any(rule => rule.Id > 0)).ToList();
                    cell.DataSource = _professorsList.ToList();
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
                professor.NumberOfRemainingClasses--;
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
