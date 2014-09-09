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
    public partial class FrmProfessor : Form
    {
        private List<KeyValuePair<DayOfWeek, int>> WeekAttendanceDict;
        private WeekClassScheduleEntities entitiesDb;
        private int _professorId = 0;

        public FrmProfessor()
        {
            InitializeComponent();
            WeekAttendanceDict = new List<KeyValuePair<DayOfWeek, int>>();
            entitiesDb = new WeekClassScheduleEntities();
        }

        public FrmProfessor(int professorId)
        {
            InitializeComponent();
            WeekAttendanceDict = new List<KeyValuePair<DayOfWeek, int>>();
            entitiesDb = new WeekClassScheduleEntities();

            var professor = entitiesDb.Professor.Where(p => p.Id == professorId).First();
            _professorId = professor.Id;

            this.txtName.Text = professor.Name;
            this.txtSubject.Text = professor.Subject;
            this.txtWeekClassesQty.Text = professor.NumberOfClassesWeek.ToString();
            this.FillAttendanceCheckBoxes(professor.AttendanceRules.ToList());
        }

        private void FillAttendanceCheckBoxes(List<AttendanceRules> rules)
        {
            var classesCount = segundaCheckList.Items.Count;
            for (int i = 0; i < classesCount; i++)
            {
                segundaCheckList.SetItemChecked(i, 
                    rules.Any(m => m.DayOfWeek == (int)DayOfWeek.Monday && m.ClassNumber == (i + 1)));
                tercaCheckList.SetItemChecked(i,
                    rules.Any(m => m.DayOfWeek == (int)DayOfWeek.Tuesday && m.ClassNumber == (i + 1)));
                quartaCheckList.SetItemChecked(i,
                    rules.Any(m => m.DayOfWeek == (int)DayOfWeek.Wednesday && m.ClassNumber == (i + 1)));
                quintaCheckList.SetItemChecked(i,
                    rules.Any(m => m.DayOfWeek == (int)DayOfWeek.Thursday && m.ClassNumber == (i + 1)));
                sextaCheckList.SetItemChecked(i,
                    rules.Any(m => m.DayOfWeek == (int)DayOfWeek.Friday && m.ClassNumber == (i + 1)));
            }
        }

        private void segundaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Monday, e.Index + 1);
            if (!segundaCheckList.GetItemChecked(e.Index))
                WeekAttendanceDict.Add(entry);
            else
                WeekAttendanceDict.Remove(entry);
        }

        private void tercaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Tuesday, e.Index + 1);
            if (!tercaCheckList.GetItemChecked(e.Index))
                WeekAttendanceDict.Add(entry);
            else
                WeekAttendanceDict.Remove(entry);
        }

        private void quartaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Wednesday, e.Index + 1);
            if (!quartaCheckList.GetItemChecked(e.Index))
                WeekAttendanceDict.Add(entry);
            else
                WeekAttendanceDict.Remove(entry);

        }

        private void quintaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Thursday, e.Index + 1);
            if (!quintaCheckList.GetItemChecked(e.Index))
                WeekAttendanceDict.Add(entry);
            else
                WeekAttendanceDict.Remove(entry);
        }

        private void sextaCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var entry = new KeyValuePair<DayOfWeek, int>(DayOfWeek.Friday, e.Index + 1);
            if (!sextaCheckList.GetItemChecked(e.Index))
                WeekAttendanceDict.Add(entry);
            else 
                WeekAttendanceDict.Remove(entry);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false;

            Professor professor;
            if (_professorId == 0)
                professor = new Professor();
            else
                professor = entitiesDb.Professor.Where(p => p.Id == _professorId).First();
            
            // fills professor data
            professor.Name = txtName.Text;
            professor.Subject = txtSubject.Text;
            professor.NumberOfClassesWeek = Convert.ToInt32(txtWeekClassesQty.Text);

            foreach(var rule in professor.AttendanceRules.ToList())
            {
                entitiesDb.AttendanceRules.Remove(rule);
            }

            // fills attendance rules data
            foreach (var item in WeekAttendanceDict)
            {
                var attendanceRule = new AttendanceRules();
                attendanceRule.DayOfWeek = (int)item.Key;
                attendanceRule.ClassNumber = item.Value;
                attendanceRule.Professor = professor;

                professor.AttendanceRules.Add(attendanceRule);
            }

            if(_professorId == 0)
                entitiesDb.Professor.Add(professor);

            try
            {
                entitiesDb.SaveChanges();
                lblMessage.Visible = true;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var professor = entitiesDb.Professor.Where(p => p.Id == _professorId).First();
            entitiesDb.Professor.Remove(professor);
            entitiesDb.SaveChanges();
            this.Close();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            this.txtName.Select();
            this.txtName.Focus();
        }
    }
}
