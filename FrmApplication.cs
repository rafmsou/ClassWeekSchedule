using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekSchedule
{
    public partial class FrmApplication : Form
    {
        public FrmApplication()
        {
            InitializeComponent();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProfessor = new FrmProfessor();
            frmProfessor.MdiParent = this;
            frmProfessor.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClasses = new FrmClassroom();
            frmClasses.MdiParent = this;
            frmClasses.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmWeekSchedule = new FrmWeekSchedule();
            frmWeekSchedule.MdiParent = this;
            frmWeekSchedule.Show();

        }
    }
}
