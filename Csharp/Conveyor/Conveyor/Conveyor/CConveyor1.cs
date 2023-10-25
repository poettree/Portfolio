using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Conveyor
{
    class CConveyor1:CDevice
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
                        bIsLReq = true;
                        
                        if(bIsSensorDetect1 == true)
                        {
                            statusCwConv = true;
                            bIsReady = true;
                            stepConv = 110;
                        }

                        break;

                    case 110:
                        if (bIsBusy)
                        {
                            bIsLReq = false;
                            stepConv = 0;
                        }
                        break;

                    case 120:
                        if (!bIsTrReq&&!bIsBusy&&bIsCompt)
                        {
                            bIsReady = false;
                            stepConv = 130;
                        }
                        break;

                    case 130:
                        if (!bIsCompt)
                        {
                            stepConv = 200;
                        }
                        break;

                    case 200:
                        if (!bIsSensorDetect1)
                        {
                            stepConv = 0;
                        }
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
                Console.WriteLine("Conveyor 1 step = {0}", stepConv);
            }
            oldStepConv = stepConv;
            bisTakeIn = false;
        }
    }
}