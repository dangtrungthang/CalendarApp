using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Lich
{
    public partial class Plan : Form
    {
        private DateTime date;
        private PlanData job;
        private DayJob kt;
      
        
        
        
        public DateTime Date { get => date; set => date = value; }
        public PlanData Job { get => job; set => job = value; }
        public DayJob Kt { get => kt; set => kt = value; }

        FlowLayoutPanel panel = new FlowLayoutPanel();

        
    
        public Plan(DateTime date, PlanData job)
        {
            InitializeComponent();
            
            this.Date = date;
            this.Job = job;
           
            panel.Width = pnlJos.Width;
            panel.Height = pnlJos.Height;
            pnlJos.Controls.Add(panel);
            panel.AutoScroll = true;
          


            dtpkDate.Value = Date;


            toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
            + JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
            + "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;
                
            
        }
        List<PlanItem> JobByDay(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }
        List<PlanItem> JobDoing(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.list.IndexOf(p.Status)==(int)ePlanItem.Doing).ToList();
        }
        List<PlanItem> JobDone(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.list.IndexOf(p.Status) == (int)ePlanItem.Done).ToList();
        }
        List<PlanItem> JobMissed(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.list.IndexOf(p.Status) == (int)ePlanItem.Missed).ToList();
        }
        List<PlanItem> JobComing(DateTime date)
        {
            return Job.ListJob.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month
            && p.Date.Day == date.Day && PlanItem.list.IndexOf(p.Status) == (int)ePlanItem.Coming).ToList();
        }



        void showJobByDate(DateTime date)
        {
            panel.Controls.Clear();
           
            if (job != null && Job.ListJob != null)
            {
                List<PlanItem> todayJob = JobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                    

                }
            }
        }
        void AddJob(PlanItem job)
        {
            DayJob ajob = new DayJob(job);
            ajob.Edited += Ajob_Edited;
            ajob.Deleted += Ajob_Deleted;

            panel.Controls.Add(ajob);

        }
        void DEleteJob(PlanItem job)
        {
            DayJob ajob = new DayJob(job);
            ajob.Edited += Ajob_Edited;
            ajob.Deleted += Ajob_Deleted;

            panel.Controls.Remove(ajob);

        }

        void DeleteAllJob(PlanItem job)
        {
            DayJob dayJob = new DayJob(job);
            dayJob.Edited += Ajob_Edited;
            dayJob.Deleted += Ajob_Deleted;

            panel.Controls.Remove(dayJob);
           
        }
        private void Ajob_Deleted(object sender, EventArgs e)
        {
            DayJob uc = sender as DayJob;
            PlanItem job = uc.Job;
            panel.Controls.Remove(uc);
            Job.ListJob.Remove(job);

            toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
            + JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
            + "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;
        }

        private void Ajob_Edited(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
             + JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
             + "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;
        }

        
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            showJobByDate((sender as DateTimePicker).Value);

            toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
            + JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
            + "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;

        }
        
        private void cmdNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void cmdPrevious_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void mnsAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dtpkDate.Value };
            Job.ListJob.Add(item);
            AddJob(item);

            toolStripStatusLabel1.Text = "Tổng: " + JobByDay(dtpkDate.Value).Count + " việc || Doing: "
            + JobDoing(dtpkDate.Value).Count + "|| Done: " + JobDone(dtpkDate.Value).Count
            + "|| Missed: " + JobMissed(dtpkDate.Value).Count + "|| Coming: " + JobComing(dtpkDate.Value).Count;
        }

        private void mnsToday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
            
        }

        private void Plan_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void mnsDeleteAll_Click(object sender, EventArgs e)
        {
            
           

        }
    }
}
