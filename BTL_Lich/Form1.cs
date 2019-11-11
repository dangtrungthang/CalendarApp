using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Threading;
using Microsoft.Win32;

namespace BTL_Lich
{
    public partial class Calender : Form
    {
        #region properties
        private List<List<Button>> matrix;
    

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private PlanData job;

        private PlanItem ajob;

        private int time;
        public PlanData Job { get => job; set => job = value; }
        public int Time { get => time; set => time = value; }
        public PlanItem Ajob { get => ajob; set => ajob = value; }

        private string filepath = "luutru.xml";

       
        #endregion

        public Calender()
        {
            InitializeComponent();

            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\Calendar");
            //mo registry khoi dong cung win
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            //string subkey = "Software\\ManhQuyen";
            try
            {
                //chen gia tri key
                regkey.SetValue("Index", keyvalue);
                //regstart.SetValue("taoregistrytronghethong", "E:\\Studing\\Bai Tap\\CSharp\\Channel 4\\bai temp\\tao registry trong he thong\\tao registry trong he thong\\bin\\Debug\\tao registry trong he thong.exe");
                regstart.SetValue("Calendar", Application.StartupPath + "\\BTL_Lich.exe");
                ////dong tien trinh ghi key
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }
            

            tmNotify.Start();
            Time = 0;
            LoadMtrix();
            try
            {
               Job= DeserializeFromXML(filepath) as PlanData;
            }
            catch {
                SetDefualData();

            }
            
        }
      
        void SetDefualData()
        {
            /*Job = new PlanData();
            Job.ListJob = new List<PlanItem>();
            Job.ListJob.Add(new PlanItem() {
                Date = DateTime.Now,
                FromTime=new Point(4,0),
                ToTime=new Point(5,0),
                Job = "test",
                Status = PlanItem.list[(int)ePlanItem.Coming]
            });*/
          
        }
        void LoadMtrix()
        {
     
            Matrix = new List<List<Button>>();
            Button preBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.Row; i++)
            {

                Matrix.Add(new List<Button>());
               
                for (int j = 0; j < Cons.Column; j++)
                {
                   
                    Button button = new Button() { Width = Cons.sizeBtnWidth, Height = Cons.sizeBtnHeight };
                    button.Location = new Point(preBtn.Location.X + preBtn.Width + Cons.margin, preBtn.Location.Y);

                    pnlMaTrixNgay.Controls.Add(button);
                    button.Click += Button_Click;

                    Matrix[i].Add(button);

                    preBtn = button;
                }
                preBtn = new Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-Cons.margin, preBtn.Location.Y + Cons.sizeBtnHeight)
                };
            }
            DefualtDate();
          // AddNunmberMatrixByDate(dtpkDate.Value);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            Plan daily = new Plan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            daily.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:               
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                  
                default:
                    return 30;

            }

        }
        void DefualtDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        bool cmpDate(DateTime a, DateTime b)
        {
            return a.Year == b.Year && a.Month == b.Month && a.Day == b.Day;
        }
        void AddNunmberMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button button = Matrix[line][column];
                button.Text = i.ToString();
                if (cmpDate(useDate, DateTime.Now))
                {
                    button.BackColor = Color.DeepPink;
                }
                if(cmpDate(useDate,date))
                {
                    button.BackColor = Color.Aqua;
                }
                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
            
        }
        
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.Silver;
                    //btn.BackgroundImage = Image.FromFile(@"E:\explosion_5-wallpaper-1920x1080.jpg");
                   // btn.BackgroundImageLayout = ImageLayout.Stretch;
                }

            }
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNunmberMatrixByDate((sender as DateTimePicker).Value);
        }       

        private void cmdToDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }


        private void SerializeToXML(object data,string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(PlanData));

            xml.Serialize(file, data);


            file.Close();
        }
        private object DeserializeFromXML(string filepath)
        {
            FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(PlanData));

                object result = xml.Deserialize(file);
                file.Close();
                return result;
            }
            catch
            {
                file.Close();
                throw new NotImplementedException();
            }           
            
        }

        private void cmpNextMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void cmpPreMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job,filepath);
            
        }

            
        
        

        private void tmNotify_Tick(object sender, EventArgs e)
        {

            if (!ckbTB.Checked)
                return;
            Time++;
            if (time < Cons.notifyTime)
                return;
            if (Job == null || Job.ListJob == null || Job.ListJob.Count==0 )
                return;
            DateTime current = DateTime.Now;
            DateTime tomorrow = DateTime.Now.AddDays(1);
            //MessageBox.Show(current.Minute.ToString());
            if (dtpkDate.Value.Year != current.Year || dtpkDate.Value.Month != current.Month || dtpkDate.Value.Day != current.Day)
                return;
            for (int i = 0; i < Job.ListJob.Count; i++)
            {
                //if (  current.Hour >= Job.ListJob[i].ToTime.X && current.Minute >= Job.ListJob[i].ToTime.Y)
                if (Job.ListJob[i].ToTime.X * 3600 + Job.ListJob[i].ToTime.Y * 60 < current.Hour * 3600 + current.Minute * 60
                    && Job.ListJob[i].Status != "Done" && Job.ListJob[i].Date.Year == current.Year
                    && Job.ListJob[i].Date.Month == current.Month && Job.ListJob[i].Date.Day == current.Day
                    && Job.ListJob[i].Job!=null)
                {
                    Job.ListJob[i].Status = "Missed";


                }                             
            }

            int dem = 0;
            for (int i = 0; i < Job.ListJob.Count; i++)
            {
                if (Job.ListJob[i].Status=="Doing")
                {
                    dem++;
                }

            }
            if (dem==0)
            {
                return;
            }
            

           /* List<PlanItem> listTodayDone = Job.ListJob.Where
            (p => p.Date.Year == current.Year && p.Date.Month == current.Month
            && p.Date.Day == current.Day && PlanItem.list.IndexOf(p.Status) == (int)ePlanItem.Done).ToList();

            List<PlanItem> listTodayMissed = Job.ListJob.Where
            (p => p.Date.Year == current.Year && p.Date.Month == current.Month
            && p.Date.Day == current.Day && PlanItem.list.IndexOf(p.Status) == (int)ePlanItem.Missed).ToList();

            List<PlanItem> listTomorrow = Job.ListJob.Where
            (p => p.Date.Year == tomorrow.Year && p.Date.Month == tomorrow.Month
            && p.Date.Day == tomorrow.Day).ToList();*/

            //List<PlanItem> listTen = Job.ListJob.Where(p=>p.Date.Year)

            //////////////////////////////////////////////////////////////////////////////////
            List<PlanItem> listTodayDoing = Job.ListJob.Where
            (p => p.Date.Year == current.Year && p.Date.Month == current.Month
            && p.Date.Day == current.Day && PlanItem.list.IndexOf(p.Status) == (int)ePlanItem.Doing
            && p.FromTime.X * 3600 + p.FromTime.Y * 60 <= current.Hour * 3600 + current.Minute * 60
            && p.ToTime.X * 3600 + p.ToTime.Y * 60 >= current.Hour * 3600 + current.Minute * 60).ToList();

            string tam = "";
            for (int i = 0; i < listTodayDoing.Count; i++)
            {
                tam += "- "+listTodayDoing[i].Job +"\n";
            }
            
            notifyIcon1.ShowBalloonTip(Cons.timeOut, "Lịch công việc", 
           string.Format("Bạn đang có {0} công việc cần làm: \n", listTodayDoing.Count) + tam, ToolTipIcon.Info);



            /* notifyIcon1.ShowBalloonTip
             (Cons.timeOut, "Lịch công việc",
             string.Format("Bạn có {0} công việc đang làm, {1} đã hoàn thành," +
             " {2} bỏ lỡ trong ngày hôm nay \n" +
             "Ngày mai bạn có {3} công việc cần làm", 
             listTodayDoing.Count,listTodayDone.Count,listTodayMissed.Count,listTomorrow.Count),
             ToolTipIcon.Info);*/

        }

        private void nmTB_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)nmNotify.Value;
        }

        private void ckbTB_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = ckbTB.Checked;
        }

        private void Calender_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show( MousePosition,ToolStripDropDownDirection.AboveRight);
        }

        private void tsmnJob_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            Plan plan = new Plan(dtpkDate.Value, Job);
            plan.Show();
           
        }

        private void tsmnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
