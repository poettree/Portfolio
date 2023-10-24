using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conveyor
{
    class CConveyor2:CDevice
    {
        public override void Process()
        {
            if (bisAutoConv == true)
            {
                switch (stepConv)
                {
                    case 0:
                        bIsUReq = false;
                        bIsLReq = false;
                        bIsReady = false;
                        statusCwConv = false;
                        statusCcwConv = false;

                        stepConv = 100;
                        break;

                    case 100:
                        if (bIsSensorDetect1 == true)
                        {
                            stepConv = 200;
                        }
                        else
                        {
                            if (bisTakeIn == true)
                            {
                                stepConv = 110;
                                countConv = 0;
                            }
                        }
                        break;

                    case 110:
                        statusCcwConv = true;
                        if (bIsSensorDetect2 == true)
                        {
                            statusCcwConv = false;
                            bIsUReq = true;
                            stepConv = 200;
                        }
                        break;

                    case 200:
                        if (bIsSensorDetect2 == true)
                        {
                            stepConv = 100;
                        }
                        else if (bIsTrReq)
                        {
                            stepConv = 210;
                            bIsReady = true;
                        }
                        break;

                    case 210:
                        if (bIsBusy)
                        {
                            bIsUReq = true;
                            stepConv = 220;
                        }
                        break;

                    case 220:
                        statusCcwConv = true;
                        if (!bIsTrReq && !bIsBusy && bIsCompt)
                        {
                            bIsUReq = false;
                            statusCcwConv = false;
                            stepConv = 230;
                        }
                        break;

                    case 230:
                        if (!bIsCompt)
                            stepConv = 100;
                        break;

                    default:
                        stepConv = 0;
                        break;

                }
            }
            else
            {
                stepConv = 0;
            }
            if (oldStepConv != stepConv)
            {
                Console.WriteLine("Conveyor  step = {0}", stepConv);
            }
            oldStepConv = stepConv;
            bisTakeIn = false;
        }
    }
}
