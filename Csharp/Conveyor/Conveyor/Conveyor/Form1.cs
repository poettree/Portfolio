using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conveyor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct P10
        {
            public bool bIsTrReq;
            public bool bIsBusy;
            public bool bIsCompt;
            public bool bIsUReq;
            public bool bIsLReq;
            public bool bIsReady;
        }

        P10 pioConv1, pioConv2, pioConv3, pioConv4;

        bool statusCwConv1, statusCwConv2, statusCwConv3, statusCwConv4, statusCwConvS;
        bool statusCcwConv1, statusCcwConv2, statusCcwConv3, statusCcwConv4, statusCcwConvS;

        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            bisTakeIn = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bisAutoConv1 = false;
            bisAutoConv2 = false;
            bisAutoConv3 = false;
            bisAutoConv4 = false;
            bisAutoConvS = false;
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {

            bisTakeOut = true;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            bisAutoConv1 = true;
            bisAutoConv2 = true;
            bisAutoConv3 = true;
            bisAutoConv4 = true;
            bisAutoConvS = true;
        }

        bool convMotionBlink;

        private void ConvMotionProc_Tick(object sender, EventArgs e)
        {
            if (convMotionBlink == true)
            {
                btnConveyor1.Text = "";
                btnConveyor2.Text = "";
                btnConveyor3.Text = "";
                btnConveyor4.Text = "";
                btnConveyorS.Text = "";
                convMotionBlink = false;

            }
            else 
            {
                if (!statusCwConv1 && !statusCcwConv1) btnConveyor1.Text = "";
                else if (statusCwConv1) btnConveyor1.Text = "CW";
                else if (statusCcwConv1) btnConveyor1.Text = "CCW";
                if (!statusCwConv2 && !statusCcwConv2) btnConveyor2.Text = "";
                else if (statusCwConv2) btnConveyor2.Text = "CW";
                else if (statusCcwConv2) btnConveyor2.Text = "CCW";
                if (!statusCwConv3 && !statusCcwConv3) btnConveyor3.Text = "";
                else if (statusCwConv3) btnConveyor3.Text = "CW";
                else if (statusCcwConv3) btnConveyor3.Text = "CCW";
                if (!statusCwConv4 && !statusCcwConv4) btnConveyor4.Text = "";
                else if (statusCwConv4) btnConveyor4.Text = "CW";
                else if (statusCcwConv4) btnConveyor4.Text = "CCW";
                if (!statusCwConvS && !statusCcwConvS) btnConveyorS.Text = "";
                else if (statusCwConvS) btnConveyorS.Text = "CW";
                else if (statusCcwConvS) btnConveyorS.Text = "CCW";
            }
        }

        int stepConv1, stepConv2, stepConv3, stepConv4, stepConvS;
        int oldStepConv1, oldStepConv2, oldStepConv3, oldStepConv4, oldStepConvS;
        int countConv1, countConv2, countConv3, countConv4, countConvS;

        bool bisAutoConv1, bisAutoConv2, bisAutoConv3, bisAutoConv4, bisAutoConvS;
        bool bisTakeIn, bisTakeOut;

        private void MainSchedulerProc_Tick(object sender, EventArgs e)
        {
            ProcConv1();
            ProcConv2();
            ProcConv3();
            ProcConv4();
            ProcConvS();
        }

        void ProcConv1()
        {

        }
        void ProcConv2()
        {
            if(bisAutoConv2 == true)
            {
                switch(stepConv2)
                {
                    case 0:
                        pioConv2.bIsUReq = false;
                        pioConv2.bIsLReq = false;
                        pioConv2.bIsReady = false;
                        statusCwConv2 = false;
                        statusCcwConv2 = false;

                        stepConv2 = 100;
                        break;

                    case 100:
                        if(cbSensor2_2.Checked == true)
                        {
                            stepConv2 = 200;
                        }
                        else
                        {
                            if(bisTakeIn == true)
                            {
                                stepConv2 = 110;
                                countConv2 = 0;
                            }
                        }
                        break;

                    case 110:
                        statusCcwConv2 = true;
                        if(cbSensor2_2.Checked == true)
                        {
                            statusCcwConv2 = false;
                            pioConv2.bIsUReq = true;
                            stepConv2 = 200;
                        }
                        break;

                    case 200:
                        if(cbSensor2_2.Checked == true)
                        {
                            stepConv2 = 100;
                        }
                        else if(pioConv2.bIsTrReq)
                        {
                            stepConv2 = 210;
                            pioConv2.bIsReady = true;
                        }
                        break;

                    case 210:
                        if(pioConv2.bIsBusy)
                        {
                            pioConv2.bIsUReq = true;
                            stepConv2 = 220;
                        }
                        break;

                    case 220:
                        statusCcwConv2 = true;
                        if(!pioConv2.bIsTrReq && !pioConv2.bIsBusy && pioConv2.bIsCompt)
                        {
                            pioConv2.bIsUReq = false;
                            statusCcwConv2 = false;
                            stepConv2 = 230;
                        }
                        break;

                    case 230:
                        if (!pioConv2.bIsCompt)
                            stepConv2 = 100;
                        break;

                    default:
                        stepConv2 = 0;
                        break;

                }
            }
            else
            {
                stepConv2 = 0;
            }
            if(oldStepConv2 != stepConv2)
            {
                Console.WriteLine("Conveyor 2 step = {0}", stepConv2);
            }
            oldStepConv2 = stepConv2;
            bisTakeIn = false;
        }
        void ProcConv3()
        {

        }
        void ProcConv4()
        {

        }
        void ProcConvS()
        {

        }
    }
}
