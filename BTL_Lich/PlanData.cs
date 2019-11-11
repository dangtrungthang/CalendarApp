using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_Lich
{
    [Serializable]
   public class PlanData
    {
        private List<PlanItem> listJob;

        public List<PlanItem> ListJob { get => listJob; set => listJob = value; }
    }
}
