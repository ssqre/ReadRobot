namespace SimpleSpeechReco
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLeft = new System.Windows.Forms.Button();
            this.rdoVoiceControl = new System.Windows.Forms.RadioButton();
            this.rdoHandControl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelStateShow = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnVoiceControl = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtYeShu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(79, 55);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(89, 31);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "向左翻";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // rdoVoiceControl
            // 
            this.rdoVoiceControl.AutoSize = true;
            this.rdoVoiceControl.Location = new System.Drawing.Point(32, 29);
            this.rdoVoiceControl.Name = "rdoVoiceControl";
            this.rdoVoiceControl.Size = new System.Drawing.Size(71, 16);
            this.rdoVoiceControl.TabIndex = 1;
            this.rdoVoiceControl.Text = "语音控制";
            this.rdoVoiceControl.UseVisualStyleBackColor = true;
            this.rdoVoiceControl.CheckedChanged += new System.EventHandler(this.rdoVoiceControl_CheckedChanged);
            // 
            // rdoHandControl
            // 
            this.rdoHandControl.AutoSize = true;
            this.rdoHandControl.Checked = true;
            this.rdoHandControl.Location = new System.Drawing.Point(32, 70);
            this.rdoHandControl.Name = "rdoHandControl";
            this.rdoHandControl.Size = new System.Drawing.Size(71, 16);
            this.rdoHandControl.TabIndex = 1;
            this.rdoHandControl.TabStop = true;
            this.rdoHandControl.Text = "手动控制";
            this.rdoHandControl.UseVisualStyleBackColor = true;
            this.rdoHandControl.CheckedChanged += new System.EventHandler(this.rdoHandControl_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHandControl);
            this.groupBox1.Controls.Add(this.rdoVoiceControl);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制选择";
            // 
            // labelStateShow
            // 
            this.labelStateShow.AutoSize = true;
            this.labelStateShow.Location = new System.Drawing.Point(15, 13);
            this.labelStateShow.Name = "labelStateShow";
            this.labelStateShow.Size = new System.Drawing.Size(41, 12);
            this.labelStateShow.TabIndex = 3;
            this.labelStateShow.Text = "label1";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(79, 96);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(89, 31);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "向右翻";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnVoiceControl
            // 
            this.btnVoiceControl.Enabled = false;
            this.btnVoiceControl.Location = new System.Drawing.Point(160, 62);
            this.btnVoiceControl.Name = "btnVoiceControl";
            this.btnVoiceControl.Size = new System.Drawing.Size(89, 31);
            this.btnVoiceControl.TabIndex = 0;
            this.btnVoiceControl.Text = "语音控制";
            this.btnVoiceControl.UseVisualStyleBackColor = true;
            this.btnVoiceControl.Click += new System.EventHandler(this.btnVoiceControl_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(79, 144);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 31);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停翻";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtYeShu
            // 
            this.txtYeShu.Location = new System.Drawing.Point(79, 21);
            this.txtYeShu.Name = "txtYeShu";
            this.txtYeShu.Size = new System.Drawing.Size(89, 21);
            this.txtYeShu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "翻页数目";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtYeShu);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Location = new System.Drawing.Point(262, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 187);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "手动控制";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelStateShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoiceControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RobotControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.RadioButton rdoVoiceControl;
        private System.Windows.Forms.RadioButton rdoHandControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStateShow;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnVoiceControl;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtYeShu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

