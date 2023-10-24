using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SignalLight
{
    public partial class Form1 : Form
    {
        //Initialize
        private Thread thread; // 클래스 레벨로 쓰레드 선언
        private bool stopThreadRequested = false; // 쓰레드 멈춤 변수


        public Form1()
        {
            InitializeComponent();
        }

        void SignalTower()
        {
            int D100 = 0;
            
            while(true)
            {
                if (stopThreadRequested)
                {
                    LampRed.BackColor = SystemColors.AppWorkspace;
                    LampYellow.BackColor = SystemColors.AppWorkspace;
                    LampGreen.BackColor = SystemColors.AppWorkspace;
                    break;
                }

                switch(D100)
                {
                    case 0:
                        LampRed.BackColor = Color.Red;
                        LampYellow.BackColor = SystemColors.AppWorkspace;
                        LampGreen.BackColor = SystemColors.AppWorkspace;
                        Thread.Sleep(1000);
                        D100 = 100;
                        break;

                    case 100:
                        LampYellow.BackColor = Color.Yellow;
                        LampRed.BackColor = SystemColors.AppWorkspace;
                        LampGreen.BackColor = SystemColors.AppWorkspace;
                        Thread.Sleep(1000);
                        D100 = 200;
                        break;

                    case 200:
                        LampGreen.BackColor = Color.Green;
                        LampYellow.BackColor = SystemColors.AppWorkspace;
                        LampRed.BackColor = SystemColors.AppWorkspace;
                        Thread.Sleep(1000);
                        D100 = 0;
                        break;

                    default:
                        D100 = 0;
                        break;

                }
            }
        }

        private void LampRed_Click(object sender, EventArgs e)
        {
            //쓰레드 생성 및 실행
            thread = new Thread(SignalTower);
            stopThreadRequested = false;
            thread.Start();
        }

        private void LampGreen_Click(object sender, EventArgs e)
        {
            //쓰레드 멈춤(변수로)
            stopThreadRequested = true;
        }
    }
}
