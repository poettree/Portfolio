using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveyor
{
    abstract class CDevice : IProcess
    {
        protected bool bIsTrReq;
        protected bool bIsBusy;
        protected bool bIsCompt;
        protected bool bIsUReq;
        protected bool bIsLReq;
        protected bool bIsReady;

        public bool TrReq
        {
            get { return bIsTrReq; }
            set { bIsTrReq = value; }
        }

        public bool Busy
        {
            get { return bIsBusy; }
        }

        public bool Compt
        {
            get { return bIsCompt; }
            set { bIsCompt = value; }
        }

        public bool UReq
        {
            get { return bIsUReq; }
        }

        public bool LReq
        {
            get { return bIsLReq; }
        }
        public bool Ready
        {
            get { return bIsReady; }
        }

        protected bool statusCwConv;
        protected bool statusCcwConv;
        public bool statusCw
        {
            get { return statusCwConv; }
        }
        public bool statusCcw
        {
            get { return statusCcwConv; }
        }

        protected int stepConv;
        protected int oldStepConv;
        protected int countConv;
        public int step
        {
            get { return stepConv; }
            set { stepConv = value; }
        }
        public int oldStep
        {
            get { return oldStepConv; }
            set { oldStepConv = value; }
        }
        public int count
        {
            get { return countConv; }
            set { countConv = value; }
        }


        protected bool bisAutoConv;
        protected bool bisTakeIn, bisTakeOut;

        public bool auto
        {
            get { return bisAutoConv; }
            set { bisAutoConv = value; }
        }
        public bool takeIn
        {
            get { return bisTakeIn; }
            set { bisTakeIn = value; }
        }
        public bool takeOut
        {
            get { return bisTakeOut; }
            set { bisTakeOut = value; }
        }

        public abstract void Process();
        protected bool bIsSensorDetect1, bIsSensorDetect2;
        public bool sensor1
        {
            get { return bIsSensorDetect1; }
            set { bIsSensorDetect1 = value; }
        }
        public bool sensor2
        {
            get { return bIsSensorDetect2; }
            set { bIsSensorDetect2 = value; }
        }
    }
}
