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
    public partial class FrmProfessor : Form
    {
        private List<KeyValuePair<DayOfWeek, int>> WeekAttendanceDict;
        private WeekScheduleEntities entitiesDb;
        private int _professorId = 0;

        public FrmProfessor()
        {
            InitializeComponent();
            WeekAttendanceDict = new List<KeyValuePair<DayOfWeek, int>>();
            entitiesDb = new WeekScheduleEntities();
        }

        public FrmProfessor(int professorId)
        {
            InitializeComponent();
            WeekAttendanceDict = new List<KeyValuePair<DayOfWeek, int>>();
            entitiesDb = new WeekScheduleEntities();

            var professor = entitiesDb.Professor.Where(p => p.Id == professorId).First();
            _professorId = professor.Id;
        }

        private void segundaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Monday, e.Index);
            WeekAttendanceDict.Add(entry);
        }

        private void tercaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Tuesday, e.Index);
            WeekAttendanceDict.Add(entry);
        }

        private void quartaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Wednesday, e.Index);
            WeekAttendanceDict.Add(entry);
        }

        private void quintaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Thursday, e.Index);
            WeekAttendanceDict.Add(entry);
        }

        private void sextaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Friday, e.Index);
            WeekAttendanceDict.Add(entry);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Professor professor;
            if (_professorId == 0)
                professor = new Professor();
            else
                professor = entitiesDb.Professor.Where(p => p.Id == _professorId).First();
            
            // fills professor data
            professor.Name = txtName.Text;
            professor.Subject = txtSubject.Text;
            professor.NumberOfClassesWeek = Convert.ToInt32(txtWeekClassesQty.Text);

            // fills attendance rules data
            foreach (var item in WeekAttendanceDict)
            {
                var attendanceRule = new AttendanceRules();
                attendanceRule.DayOfWeek = (int)item.Key;
                attendanceRule.ClassNumber = item.Value;
                attendanceRule.Professor = professor;

                entitiesDb.AttendanceRules.Add(attendanceRule);
            }
            entitiesDb.Professor.Add(professor);

            try
            {
                entitiesDb.SaveChanges();
                MessageBox.Show("Professor salvo com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < segundaCheckList.Items.Count; i++)
            {
                if (cbAll.Checked)
                    SetCheckedState(i, true);
                else
                    SetCheckedState(i, false);
            }
        }

        private void SetCheckedState(int i, bool isChecked)
        {
            segundaCheckList.SetItemChecked(i, isChecked);
            tercaCheckList.SetItemChecked(i, isChecked);
            quartaCheckList.SetItemChecked(i, isChecked);
            quintaCheckList.SetItemChecked(i, isChecked);
            sextaCheckList.SetItemChecked(i, isChecked);
        }
    }
}
