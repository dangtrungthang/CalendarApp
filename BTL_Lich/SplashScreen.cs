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
    public partial class SplashScreen : Form
    {
        private int time = 0;
        public SplashScreen()
        {
            InitializeComponent();
            
        }

        private void timerScreen_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 5)
            {
                timerScreen.Stop();
                this.Hide();

                Calender form1 = new Calender();
                form1.ShowDialog();
               
            }
        }
    }
}
