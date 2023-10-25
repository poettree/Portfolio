
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
            this.cbSensor2_1 = new System.Windows.Forms.CheckBox();
            this.cbSensor1_1 = new System.Windows.Forms.CheckBox();
            this.btnConveyor1 = new System.Windows.Forms.Button();
            this.btnConveyor2 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTakeIn = new System.Windows.Forms.Button();
            this.ConvMotionProc = new System.Windows.Forms.Timer(this.components);
            this.MainSchedulerProc = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbSensor2_1
            // 
            this.cbSensor2_1.AutoSize = true;
            this.cbSensor2_1.Location = new System.Drawing.Point(103, 76);
            this.cbSensor2_1.Name = "cbSensor2_1";
            this.cbSensor2_1.Size = new System.Drawing.Size(70, 16);
            this.cbSensor2_1.TabIndex = 0;
            this.cbSensor2_1.Text = "Sensor2";
            this.cbSensor2_1.UseVisualStyleBackColor = true;
            this.cbSensor2_1.CheckedChanged += new System.EventHandler(this.cbSensor2_1_CheckedChanged);
            this.cbSensor2_1.Click += new System.EventHandler(this.cbSensor2_1_Click);
            // 
            // cbSensor1_1
            // 
            this.cbSensor1_1.AutoSize = true;
            this.cbSensor1_1.Location = new System.Drawing.Point(527, 76);
            this.cbSensor1_1.Name = "cbSensor1_1";
            this.cbSensor1_1.Size = new System.Drawing.Size(70, 16);
            this.cbSensor1_1.TabIndex = 1;
            this.cbSensor1_1.Text = "Sensor1";
            this.cbSensor1_1.UseVisualStyleBackColor = true;
            this.cbSensor1_1.CheckedChanged += new System.EventHandler(this.cbSensor1_1_CheckedChanged);
            this.cbSensor1_1.Click += new System.EventHandler(this.cbSensor1_1_Click);
            // 
            // btnConveyor1
            // 
            this.btnConveyor1.BackColor = System.Drawing.Color.Lime;
            this.btnConveyor1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyor1.FlatAppearance.BorderSize = 2;
            this.btnConveyor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyor1.Location = new System.Drawing.Point(30, 98);
            this.btnConveyor1.Name = "btnConveyor1";
            this.btnConveyor1.Size = new System.Drawing.Size(581, 90);
            this.btnConveyor1.TabIndex = 2;
            this.btnConveyor1.UseVisualStyleBackColor = false;
            // 
            // btnConveyor2
            // 
            this.btnConveyor2.BackColor = System.Drawing.Color.Lime;
            this.btnConveyor2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnConveyor2.FlatAppearance.BorderSize = 2;
            this.btnConveyor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConveyor2.Location = new System.Drawing.Point(103, 194);
            this.btnConveyor2.Name = "btnConveyor2";
            this.btnConveyor2.Size = new System.Drawing.Size(140, 244);
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
            this.ConvMotionProc.Interval = 500;
            this.ConvMotionProc.Tick += new System.EventHandler(this.ConvMotionProc_Tick);
            // 
            // MainSchedulerProc
            // 
            this.MainSchedulerProc.Enabled = true;
            this.MainSchedulerProc.Interval = 1;
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
            this.Controls.Add(this.btnConveyor1);
            this.Controls.Add(this.cbSensor1_1);
            this.Controls.Add(this.cbSensor2_1);
            this.Name = "Form1";
            this.Text = "Conveyor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbSensor1_1;
        private System.Windows.Forms.Button btnConveyor1;
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

