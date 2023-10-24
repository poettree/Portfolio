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
        CConveyor1 conveyor1;
        CConveyor2 conveyor2;
        CConveyor3 conveyor3;
        CConveyor4 conveyor4;
        CConveyorS conveyorS;

        public Form1()
        {
            InitializeComponent();
            conveyor1 = new CConveyor1();
            conveyor2 = new CConveyor2();
            conveyor3 = new CConveyor3();
            conveyor4 = new CConveyor4();
            conveyorS = new CConveyorS();
        }

        

        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            conveyor1.takeIn = true;
            conveyor2.takeIn = true;
            conveyor3.takeIn = true;
            conveyor4.takeIn = true;
            conveyorS.takeIn = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            conveyor1.auto = false;
            conveyor2.auto = false;
            conveyor3.auto = false;
            conveyor4.auto = false;
            conveyorS.auto = false;
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            conveyor1.takeOut = true;
            conveyor2.takeOut = true;
            conveyor3.takeOut = true;
            conveyor4.takeOut = true;
            conveyorS.takeOut = true;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            conveyor1.auto = true;
            conveyor2.auto = true;
            conveyor3.auto = true;
            conveyor4.auto = true;
            conveyorS.auto = true;
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
                if (!conveyor1.statusCw && !conveyor1.statusCcw) btnConveyor1.Text = "";
                else if (conveyor1.statusCw) btnConveyor1.Text = "CW";
                else if (conveyor1.statusCcw) btnConveyor1.Text = "CCW";
                if (!conveyor2.statusCw && !conveyor2.statusCcw) btnConveyor2.Text = "";
                else if (conveyor2.statusCw) btnConveyor2.Text = "CW";
                else if (conveyor2.statusCcw) btnConveyor2.Text = "CCW";
                if (!conveyor3.statusCw && !conveyor3.statusCcw) btnConveyor3.Text = "";
                else if (conveyor3.statusCw) btnConveyor3.Text = "CW";
                else if (conveyor3.statusCcw) btnConveyor3.Text = "CCW";
                if (!conveyor4.statusCw && !conveyor4.statusCcw) btnConveyor4.Text = "";
                else if (conveyor4.statusCw) btnConveyor4.Text = "CW";
                else if (conveyor4.statusCcw) btnConveyor4.Text = "CCW";
                if (!conveyorS.statusCw && !conveyorS.statusCcw) btnConveyorS.Text = "";
                else if (conveyorS.statusCw) btnConveyorS.Text = "CW";
                else if (conveyorS.statusCcw) btnConveyorS.Text = "CCW";

                convMotionBlink = true;
            }
        }

        private void MainSchedulerProc_Tick(object sender, EventArgs e)
        {
            conveyor1.Process();
            conveyor2.Process();
            conveyor3.Process();
            conveyor4.Process();
            conveyorS.Process();
        }

    }
}
