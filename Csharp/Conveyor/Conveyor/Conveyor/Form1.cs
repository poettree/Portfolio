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
using Google.Cloud.Firestore;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Conveyor
{

    public partial class Form1 : Form
    {

        FirestoreDb db;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "BmfbGneP3u7fy4SK7MfWpDiqgU7nZpDF6xhbxdtt",
            BasePath = "https://test-59f8d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        CConveyor1 conveyor1;
        CConveyor2 conveyor2;

        public Form1()
        {
            InitializeComponent();
            conveyor1 = new CConveyor1();
            conveyor2 = new CConveyor2();


            string path = AppDomain.CurrentDomain.BaseDirectory + @"test-59f8d-firebase-adminsdk-9qsxs-a85d21ac67.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            db = FirestoreDb.Create("default");



        }


        void Add_Document_with_AutoID()
        {
            
        }





        private void btnTakeIn_Click(object sender, EventArgs e)
        {
            conveyor1.takeIn = true;
            conveyor2.takeIn = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            conveyor1.auto = false;
            conveyor2.auto = false;
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            conveyor1.takeOut = true;
            conveyor2.takeOut = true;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            conveyor1.auto = true;
            conveyor2.auto = true;
        }

        bool convMotionBlink;

        private void ConvMotionProc_Tick(object sender, EventArgs e)
        {
            if (convMotionBlink == true)
            {
                btnConveyor1.Text = "";
                btnConveyor2.Text = "";
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

                convMotionBlink = true;
            }
        }

        private void MainSchedulerProc_Tick(object sender, EventArgs e)
        {
            conveyor1.Process();
            conveyor2.Process();
            //conveyor3.Process();
            //conveyor4.Process();
            //conveyorS.Process();
        }

        private async void cbSensor1_1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void cbSensor2_1_CheckedChanged(object sender, EventArgs e)
        {
        }
        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if(client != null)
            {
                MessageBox.Show("database connected");
            }
        }

        private async void cbSensor1_1_Click(object sender, EventArgs e)
        {
            var datalayer = new Data
            {
                Id = "Sensor1",
                Value = true
            };

            conveyor1.sensor1 = true;

            datalayer.Value = true;
            FirebaseResponse resp = client.Update("/Conveyors/Sensors/" + "Sensor1", datalayer);
            Data result = resp.ResultAs<Data>();

            Delay(1000);
            cbSensor1_1.Checked = false;
            conveyor1.sensor1 = false;

            datalayer.Value = false;
            resp = client.Update("/Conveyors/Sensors/" + "Sensor1", datalayer);
        }

        private async void cbSensor2_1_Click(object sender, EventArgs e)
        {

            var datalayer = new Data
            {
                Id = "Sensor2",
                Value = true
            };

            conveyor2.sensor1 = true;

            datalayer.Value = true;
            FirebaseResponse resp = client.Update("/Conveyors/Sensors/" + "Sensor2", datalayer);
            Data result = resp.ResultAs<Data>();

            Delay(1000);
            cbSensor2_1.Checked = false;
            conveyor2.sensor1 = false;

            datalayer.Value = false;

            resp = client.Update("/Conveyors/Sensors/" + "Sensor2", datalayer);
        }
    }
}
