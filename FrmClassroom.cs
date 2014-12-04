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
using WeekClassSchedule.AppDatalayer;

namespace WeekClassSchedule
{
    public partial class FrmClassroom : Form
    {
        private ClassroomDatalayer _classroomDatalayer;
        private long _classroomId = 0;

        public FrmClassroom()
        {
            InitializeComponent();
            _classroomDatalayer = new ClassroomDatalayer();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Classroom c = new Classroom();

            c.Id = _classroomId;
            c.Name = txtName.Text;
            c.NumberOfClasses = Convert.ToInt16(txtClassNum.Text);

            try
            {
                _classroomDatalayer.Save(c);
                RefreshClassroomGridView();

                // clear fields and variables
                txtName.Text = string.Empty;
                txtClassNum.Text = string.Empty;
                txtClassNum.ReadOnly = false;
                lblNumberOfClassesWarning.Visible = false;

                _classroomId = 0;

                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshClassroomGridView()
        {
            dgClassrooms.DataSource = null;
            dgClassrooms.DataSource = _classroomDatalayer.ClassroomList;

        }

        private async void FrmClassroom_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            loading.Visible = true;

            this.Height = this.MdiParent.Height;
            this.Width = this.MdiParent.Width;
            dgClassrooms.AutoGenerateColumns = false;

            var classrooms = await _classroomDatalayer.GetClassroomListAsync();

            if (classrooms.Count() > 0)
            {
                dgClassrooms.DataSource = classrooms;
                _classroomDatalayer.ClassroomList = classrooms;
            }

            btnSave.Enabled = true;
            loading.Visible = false;
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            lblGeneratingSchedule.Visible = true;
            lblDone.Visible = false;
            loading.Visible = true;

            for (int i = 0; i < dgClassrooms.SelectedRows.Count; i++)
            {
                var classroomId = Convert.ToInt64(dgClassrooms.SelectedRows[i].Cells["ClassroomId"].Value);
                var classroomName = dgClassrooms.SelectedRows[i].Cells["ClassroomName"].Value.ToString();
                _classroomDatalayer.GenerateWeekSchedule(classroomId);
                lblGeneratingSchedule.Text = lblGeneratingSchedule.Text.Replace("{class}", classroomName);
            }

            lblGeneratingSchedule.Visible = false;
            lblDone.Visible = true;
            loading.Visible = false;
        }

        private void dgClassrooms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                DialogResult result = MessageBox.Show("Deseja excluir as salas selecionadas?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    for (var i = 0; i < dgClassrooms.SelectedRows.Count; i++)
                    {
                        var classroomId = Convert.ToInt64(dgClassrooms.SelectedRows[i].Cells["ClassroomId"].Value);
                        _classroomDatalayer.Remove(classroomId);
                    }

                    this.RefreshClassroomGridView();
                }
            }
        }

        private void dgClassrooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCells = dgClassrooms.Rows[e.RowIndex].Cells;
            _classroomId = Convert.ToInt64(selectedCells["ClassroomId"].Value);
            txtName.Text = Convert.ToString(selectedCells["ClassroomName"].Value);
            txtClassNum.Text = Convert.ToString(selectedCells["ClassroomNumberOfClasses"].Value);
            
            var classroom = _classroomDatalayer.ClassroomList.Where(c => c.Id == _classroomId).Single();

            txtClassNum.ReadOnly = false;
            lblNumberOfClassesWarning.Visible = false;

            // o número de aulas não pode ser alterado se já houver programação
            if (classroom.WeekSchedule.Any())
            {
                txtClassNum.ReadOnly = true;
                lblNumberOfClassesWarning.Visible = true;
            }
        }

        private void dgClassrooms_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}
