
namespace Conveyor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSensor3_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor3_1 = new System.Windows.Forms.CheckBox();
            this.btnConveyor3 = new System.Windows.Forms.Button();
            this.cbSensor1_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor1_1 = new System.Windows.Forms.CheckBox();
            this.btnConveyor1 = new System.Windows.Forms.Button();
            this.cbSensorS_2 = new System.Windows.Forms.CheckBox();
            this.cbSensorS_1 = new System.Windows.Forms.CheckBox();
            this.btnConveyorS = new System.Windows.Forms.Button();
            this.cbSensor4_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor4_1 = new System.Windows.Forms.CheckBox();
            this.btnConveyor4 = new System.Windows.Forms.Button();
            this.cbSensor2_2 = new System.Windows.Forms.CheckBox();
            this.cbSensor2_1 = new System.Windows.Forms.CheckBox();
            this.btnConveyor2 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTakeIn = new System.Windows.Forms.Button();
            this.ConvMotionProc = new System.Windows.Forms.Timer(this.components);
            this.MainSchedulerProc = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbSensor3_2
            // 
            this.cbSensor3_2.AutoSize = true;
            this.cbSensor3_2.Location = new System.Drawing.Point(40, 33);
            this.cbSensor3_2.Name = "cbSensor3_2";
            this.cbSensor3_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor3_2.TabIndex = 0;
            this.cbSensor3_2.Text = "3-2";
            this.cbSensor3_2.UseVisualStyleBackColor = true;
            // 
            // cbSensor3_1
            // 
            this.cbSensor3_1.AutoSize = true;
            this.cbSensor3_1.Location = new System.Drawing.Point(40, 110);
            this.cbSensor3_1.Name = "cbSensor3_1";
            this.cbSensor3_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor3_1.TabIndex = 1;
            this.cbSensor3_1.Text = "3-1";
            this.cbSensor3_1.UseVisualStyleBackColor = true;
            // 
            // btnConveyor3
            // 
            this.btnConveyor3.BackColor = System.Drawing.Color.Lime;
            this.btnConveyor3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyor3.FlatAppearance.BorderSize = 2;
            this.btnConveyor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyor3.Location = new System.Drawing.Point(88, 33);
            this.btnConveyor3.Name = "btnConveyor3";
            this.btnConveyor3.Size = new System.Drawing.Size(140, 90);
            this.btnConveyor3.TabIndex = 2;
            this.btnConveyor3.UseVisualStyleBackColor = false;
            // 
            // cbSensor1_2
            // 
            this.cbSensor1_2.AutoSize = true;
            this.cbSensor1_2.Location = new System.Drawing.Point(40, 321);
            this.cbSensor1_2.Name = "cbSensor1_2";
            this.cbSensor1_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor1_2.TabIndex = 0;
            this.cbSensor1_2.Text = "1-2";
            this.cbSensor1_2.UseVisualStyleBackColor = true;
            // 
            // cbSensor1_1
            // 
            this.cbSensor1_1.AutoSize = true;
            this.cbSensor1_1.Location = new System.Drawing.Point(40, 398);
            this.cbSensor1_1.Name = "cbSensor1_1";
            this.cbSensor1_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor1_1.TabIndex = 1;
            this.cbSensor1_1.Text = "1-1";
            this.cbSensor1_1.UseVisualStyleBackColor = true;
            // 
            // btnConveyor1
            // 
            this.btnConveyor1.BackColor = System.Drawing.Color.Lime;
            this.btnConveyor1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyor1.FlatAppearance.BorderSize = 2;
            this.btnConveyor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyor1.Location = new System.Drawing.Point(88, 321);
            this.btnConveyor1.Name = "btnConveyor1";
            this.btnConveyor1.Size = new System.Drawing.Size(140, 90);
            this.btnConveyor1.TabIndex = 2;
            this.btnConveyor1.UseVisualStyleBackColor = false;
            // 
            // cbSensorS_2
            // 
            this.cbSensorS_2.AutoSize = true;
            this.cbSensorS_2.Location = new System.Drawing.Point(226, 178);
            this.cbSensorS_2.Name = "cbSensorS_2";
            this.cbSensorS_2.Size = new System.Drawing.Size(44, 16);
            this.cbSensorS_2.TabIndex = 0;
            this.cbSensorS_2.Text = "S-2";
            this.cbSensorS_2.UseVisualStyleBackColor = true;
            // 
            // cbSensorS_1
            // 
            this.cbSensorS_1.AutoSize = true;
            this.cbSensorS_1.Location = new System.Drawing.Point(226, 255);
            this.cbSensorS_1.Name = "cbSensorS_1";
            this.cbSensorS_1.Size = new System.Drawing.Size(44, 16);
            this.cbSensorS_1.TabIndex = 1;
            this.cbSensorS_1.Text = "S-1";
            this.cbSensorS_1.UseVisualStyleBackColor = true;
            // 
            // btnConveyorS
            // 
            this.btnConveyorS.BackColor = System.Drawing.Color.Lime;
            this.btnConveyorS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyorS.FlatAppearance.BorderSize = 2;
            this.btnConveyorS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyorS.Location = new System.Drawing.Point(276, 178);
            this.btnConveyorS.Name = "btnConveyorS";
            this.btnConveyorS.Size = new System.Drawing.Size(140, 90);
            this.btnConveyorS.TabIndex = 2;
            this.btnConveyorS.UseVisualStyleBackColor = false;
            // 
            // cbSensor4_2
            // 
            this.cbSensor4_2.AutoSize = true;
            this.cbSensor4_2.Location = new System.Drawing.Point(423, 33);
            this.cbSensor4_2.Name = "cbSensor4_2";
            this.cbSensor4_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor4_2.TabIndex = 0;
            this.cbSensor4_2.Text = "4-2";
            this.cbSensor4_2.UseVisualStyleBackColor = true;
            // 
            // cbSensor4_1
            // 
            this.cbSensor4_1.AutoSize = true;
            this.cbSensor4_1.Location = new System.Drawing.Point(423, 110);
            this.cbSensor4_1.Name = "cbSensor4_1";
            this.cbSensor4_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor4_1.TabIndex = 1;
            this.cbSensor4_1.Text = "4-1";
            this.cbSensor4_1.UseVisualStyleBackColor = true;
            // 
            // btnConveyor4
            // 
            this.btnConveyor4.BackColor = System.Drawing.Color.Lime;
            this.btnConveyor4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyor4.FlatAppearance.BorderSize = 2;
            this.btnConveyor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyor4.Location = new System.Drawing.Point(471, 33);
            this.btnConveyor4.Name = "btnConveyor4";
            this.btnConveyor4.Size = new System.Drawing.Size(140, 90);
            this.btnConveyor4.TabIndex = 2;
            this.btnConveyor4.UseVisualStyleBackColor = false;
            // 
            // cbSensor2_2
            // 
            this.cbSensor2_2.AutoSize = true;
            this.cbSensor2_2.Location = new System.Drawing.Point(423, 321);
            this.cbSensor2_2.Name = "cbSensor2_2";
            this.cbSensor2_2.Size = new System.Drawing.Size(42, 16);
            this.cbSensor2_2.TabIndex = 0;
            this.cbSensor2_2.Text = "2-2";
            this.cbSensor2_2.UseVisualStyleBackColor = true;
            // 
            // cbSensor2_1
            // 
            this.cbSensor2_1.AutoSize = true;
            this.cbSensor2_1.Location = new System.Drawing.Point(423, 398);
            this.cbSensor2_1.Name = "cbSensor2_1";
            this.cbSensor2_1.Size = new System.Drawing.Size(42, 16);
            this.cbSensor2_1.TabIndex = 1;
            this.cbSensor2_1.Text = "2-1";
            this.cbSensor2_1.UseVisualStyleBackColor = true;
            // 
            // btnConveyor2
            // 
            this.btnConveyor2.BackColor = System.Drawing.Color.Lime;
            this.btnConveyor2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyor2.FlatAppearance.BorderSize = 2;
            this.btnConveyor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyor2.Location = new System.Drawing.Point(471, 321);
            this.btnConveyor2.Name = "btnConveyor2";
            this.btnConveyor2.Size = new System.Drawing.Size(140, 90);
            this.btnConveyor2.TabIndex = 2;
            this.btnConveyor2.UseVisualStyleBackColor = false;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(639, 33);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(140, 90);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "자동";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Location = new System.Drawing.Point(639, 129);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(140, 90);
            this.btnTakeOut.TabIndex = 2;
            this.btnTakeOut.Text = "반출";
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(639, 225);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 90);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "정지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTakeIn
            // 
            this.btnTakeIn.Location = new System.Drawing.Point(639, 321);
            this.btnTakeIn.Name = "btnTakeIn";
            this.btnTakeIn.Size = new System.Drawing.Size(140, 90);
            this.btnTakeIn.TabIndex = 2;
            this.btnTakeIn.Text = "입고";
            this.btnTakeIn.UseVisualStyleBackColor = true;
            this.btnTakeIn.Click += new System.EventHandler(this.btnTakeIn_Click);
            // 
            // ConvMotionProc
            // 
            this.ConvMotionProc.Enabled = true;
            this.ConvMotionProc.Interval = 1000;
            this.ConvMotionProc.Tick += new System.EventHandler(this.ConvMotionProc_Tick);
            // 
            // MainSchedulerProc
            // 
            this.MainSchedulerProc.Enabled = true;
            this.MainSchedulerProc.Tick += new System.EventHandler(this.MainSchedulerProc_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTakeIn);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnConveyor2);
            this.Controls.Add(this.cbSensor2_1);
            this.Controls.Add(this.btnConveyor4);
            this.Controls.Add(this.cbSensor4_1);
            this.Controls.Add(this.btnConveyorS);
            this.Controls.Add(this.cbSensorS_1);
            this.Controls.Add(this.cbSensor2_2);
            this.Controls.Add(this.btnConveyor1);
            this.Controls.Add(this.cbSensor4_2);
            this.Controls.Add(this.cbSensor1_1);
            this.Controls.Add(this.cbSensorS_2);
            this.Controls.Add(this.btnConveyor3);
            this.Controls.Add(this.cbSensor1_2);
            this.Controls.Add(this.cbSensor3_1);
            this.Controls.Add(this.cbSensor3_2);
            this.Name = "Form1";
            this.Text = "Conveyor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSensor3_2;
        private System.Windows.Forms.CheckBox cbSensor3_1;
        private System.Windows.Forms.Button btnConveyor3;
        private System.Windows.Forms.CheckBox cbSensor1_2;
        private System.Windows.Forms.CheckBox cbSensor1_1;
        private System.Windows.Forms.Button btnConveyor1;
        private System.Windows.Forms.CheckBox cbSensorS_2;
        private System.Windows.Forms.CheckBox cbSensorS_1;
        private System.Windows.Forms.Button btnConveyorS;
        private System.Windows.Forms.CheckBox cbSensor4_2;
        private System.Windows.Forms.CheckBox cbSensor4_1;
        private System.Windows.Forms.Button btnConveyor4;
        private System.Windows.Forms.CheckBox cbSensor2_2;
        private System.Windows.Forms.CheckBox cbSensor2_1;
        private System.Windows.Forms.Button btnConveyor2;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnTakeOut;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTakeIn;
        private System.Windows.Forms.Timer ConvMotionProc;
        private System.Windows.Forms.Timer MainSchedulerProc;
    }
}

