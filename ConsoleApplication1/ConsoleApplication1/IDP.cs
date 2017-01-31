using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IDP
    {
        int IDP_SK;
        int RtgSet_SK;
        int startMoment;
        int stopMoment;
        String code;

        public IDP()
        {

        }

        public IDP(int IDP, int rtgSet, int startMoment, int stopMoment, String code)
        {
            this.IDP_SK = IDP;
            this.RtgSet_SK = rtgSet;
            this.startMoment = startMoment;
            this.stopMoment = stopMoment;
        }
    }
    
}
