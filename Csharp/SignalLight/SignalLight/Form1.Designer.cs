
namespace SignalLight
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
            this.LampRed = new System.Windows.Forms.Button();
            this.LampYellow = new System.Windows.Forms.Button();
            this.LampGreen = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LampRed
            // 
            this.LampRed.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LampRed.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LampRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LampRed.Location = new System.Drawing.Point(44, 167);
            this.LampRed.Name = "LampRed";
            this.LampRed.Size = new System.Drawing.Size(170, 170);
            this.LampRed.TabIndex = 0;
            this.LampRed.Text = "Red";
            this.LampRed.UseVisualStyleBackColor = false;
            this.LampRed.Click += new System.EventHandler(this.LampRed_Click);
            // 
            // LampYellow
            // 
            this.LampYellow.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LampYellow.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LampYellow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LampYellow.Location = new System.Drawing.Point(313, 167);
            this.LampYellow.Name = "LampYellow";
            this.LampYellow.Size = new System.Drawing.Size(170, 170);
            this.LampYellow.TabIndex = 1;
            this.LampYellow.Text = "Yellow";
            this.LampYellow.UseVisualStyleBackColor = false;
            // 
            // LampGreen
            // 
            this.LampGreen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LampGreen.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LampGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LampGreen.Location = new System.Drawing.Point(586, 167);
            this.LampGreen.Name = "LampGreen";
            this.LampGreen.Size = new System.Drawing.Size(170, 170);
            this.LampGreen.TabIndex = 2;
            this.LampGreen.Text = "Green";
            this.LampGreen.UseVisualStyleBackColor = false;
            this.LampGreen.Click += new System.EventHandler(this.LampGreen_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(44, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 34);
            this.label.TabIndex = 3;
            this.label.Text = "신호등";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.LampGreen);
            this.Controls.Add(this.LampYellow);
            this.Controls.Add(this.LampRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LampRed;
        private System.Windows.Forms.Button LampYellow;
        private System.Windows.Forms.Button LampGreen;
        private System.Windows.Forms.Label label;
    }
}

