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
    public partial class FrmApplication : Form
    {
        public FrmApplication()
        {
            InitializeComponent();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseActiveWindow();

            var frmProfessor = new FrmProfessor();
            frmProfessor.MdiParent = this;
            frmProfessor.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseActiveWindow();

            var frmClasses = new FrmClassroom();
            frmClasses.MdiParent = this;
            frmClasses.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseActiveWindow();

            var frmWeekClassSchedule = new FrmWeekClassSchedule();
            frmWeekClassSchedule.MdiParent = this;
            frmWeekClassSchedule.Show();

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.CloseActiveWindow())
            { 
                this.Close();
            }
        }

        private bool CloseActiveWindow()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
                return true;
            }

            return false;
        }

    }
}
