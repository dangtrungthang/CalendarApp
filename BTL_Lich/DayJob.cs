using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lich
{
    public partial class DayJob : UserControl
    {
        private PlanItem job;
        
        public PlanItem Job { get => job; set => job = value; }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        public DayJob(PlanItem job)
        {
            InitializeComponent();
            this.Job = job;
            cbStatus.DataSource = PlanItem.list;

            ShowInfo();
                               

        }


        void ShowInfo()
        {
            txtJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanItem.list.IndexOf(Job.Status);
            ckbDone.Checked = PlanItem.list.IndexOf(Job.Status) == (int)ePlanItem.Done ? true : false;
        }

       

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txtJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            if (cbStatus.SelectedItem==null)
            {
                return;
            }
            else
            Job.Status = cbStatus.SelectedItem.ToString();
            if (edited != null)
                edited(this, new EventArgs());
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());

        }

        private void ckbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = ckbDone.Checked ? (int)ePlanItem.Done : (int)ePlanItem.Doing;
            cmdEdit.PerformClick();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
            if (cbStatus.SelectedIndex ==(int)ePlanItem.Doing)
                this.BackColor = Color.Yellow;
            if (cbStatus.SelectedIndex == (int)ePlanItem.Done)
                this.BackColor = Color.Green;
            if (cbStatus.SelectedIndex == (int)ePlanItem.Missed)
                this.BackColor = Color.Purple;
            if (cbStatus.SelectedIndex == (int)ePlanItem.Coming)
                this.BackColor = Color.Red;
        }
    }
}
