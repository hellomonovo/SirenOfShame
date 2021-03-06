﻿namespace SirenOfShame
{
    partial class TimeboxEnforcer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeboxEnforcer));
            this._close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._duration = new System.Windows.Forms.TrackBar();
            this._durationText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._timeboxAudio = new System.Windows.Forms.ComboBox();
            this._timeboxLights = new System.Windows.Forms.ComboBox();
            this._start = new System.Windows.Forms.Button();
            this._countdown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._timeboxLightDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._timeboxAudioDuration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._warningAudioDuration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._warningLightDuration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._warningAudio = new System.Windows.Forms.ComboBox();
            this._warningLights = new System.Windows.Forms.ComboBox();
            this._warningDuration = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this._fullScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._duration)).BeginInit();
            this.SuspendLayout();
            // 
            // _close
            // 
            this._close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._close.Location = new System.Drawing.Point(684, 214);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(75, 23);
            this._close.TabIndex = 0;
            this._close.Text = "Close";
            this._close.UseVisualStyleBackColor = true;
            this._close.Click += new System.EventHandler(this.CloseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Countdown From:";
            // 
            // _duration
            // 
            this._duration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._duration.Location = new System.Drawing.Point(105, 16);
            this._duration.Maximum = 90;
            this._duration.Minimum = 1;
            this._duration.Name = "_duration";
            this._duration.Size = new System.Drawing.Size(654, 45);
            this._duration.TabIndex = 3;
            this._duration.Value = 30;
            this._duration.ValueChanged += new System.EventHandler(this.DurationValueChanged);
            // 
            // _durationText
            // 
            this._durationText.AutoSize = true;
            this._durationText.Location = new System.Drawing.Point(102, 48);
            this._durationText.Name = "_durationText";
            this._durationText.Size = new System.Drawing.Size(54, 13);
            this._durationText.TabIndex = 4;
            this._durationText.Text = "X Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "At Zero show:";
            // 
            // _timeboxAudio
            // 
            this._timeboxAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._timeboxAudio.FormattingEnabled = true;
            this._timeboxAudio.Location = new System.Drawing.Point(393, 128);
            this._timeboxAudio.Name = "_timeboxAudio";
            this._timeboxAudio.Size = new System.Drawing.Size(121, 21);
            this._timeboxAudio.TabIndex = 12;
            // 
            // _timeboxLights
            // 
            this._timeboxLights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._timeboxLights.FormattingEnabled = true;
            this._timeboxLights.Location = new System.Drawing.Point(106, 128);
            this._timeboxLights.Name = "_timeboxLights";
            this._timeboxLights.Size = new System.Drawing.Size(121, 21);
            this._timeboxLights.TabIndex = 11;
            // 
            // _start
            // 
            this._start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._start.Location = new System.Drawing.Point(603, 214);
            this._start.Name = "_start";
            this._start.Size = new System.Drawing.Size(75, 23);
            this._start.TabIndex = 13;
            this._start.Text = "Start";
            this._start.UseVisualStyleBackColor = true;
            this._start.Click += new System.EventHandler(this.StartClick);
            // 
            // _countdown
            // 
            this._countdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._countdown.AutoSize = true;
            this._countdown.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._countdown.Location = new System.Drawing.Point(12, 165);
            this._countdown.Name = "_countdown";
            this._countdown.Size = new System.Drawing.Size(161, 75);
            this._countdown.TabIndex = 14;
            this._countdown.Text = "0:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "for";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "for";
            // 
            // _timeboxLightDuration
            // 
            this._timeboxLightDuration.Location = new System.Drawing.Point(260, 128);
            this._timeboxLightDuration.Name = "_timeboxLightDuration";
            this._timeboxLightDuration.Size = new System.Drawing.Size(29, 20);
            this._timeboxLightDuration.TabIndex = 17;
            this._timeboxLightDuration.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "seconds; and play";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "seconds";
            // 
            // _timeboxAudioDuration
            // 
            this._timeboxAudioDuration.Location = new System.Drawing.Point(547, 128);
            this._timeboxAudioDuration.Name = "_timeboxAudioDuration";
            this._timeboxAudioDuration.Size = new System.Drawing.Size(29, 20);
            this._timeboxAudioDuration.TabIndex = 19;
            this._timeboxAudioDuration.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "At:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "seconds";
            // 
            // _warningAudioDuration
            // 
            this._warningAudioDuration.Location = new System.Drawing.Point(624, 82);
            this._warningAudioDuration.Name = "_warningAudioDuration";
            this._warningAudioDuration.Size = new System.Drawing.Size(29, 20);
            this._warningAudioDuration.TabIndex = 28;
            this._warningAudioDuration.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "seconds and";
            // 
            // _warningLightDuration
            // 
            this._warningLightDuration.Location = new System.Drawing.Point(361, 82);
            this._warningLightDuration.Name = "_warningLightDuration";
            this._warningLightDuration.Size = new System.Drawing.Size(29, 20);
            this._warningLightDuration.TabIndex = 26;
            this._warningLightDuration.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(598, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "for";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "for";
            // 
            // _warningAudio
            // 
            this._warningAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._warningAudio.FormattingEnabled = true;
            this._warningAudio.Location = new System.Drawing.Point(470, 82);
            this._warningAudio.Name = "_warningAudio";
            this._warningAudio.Size = new System.Drawing.Size(121, 21);
            this._warningAudio.TabIndex = 23;
            // 
            // _warningLights
            // 
            this._warningLights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._warningLights.FormattingEnabled = true;
            this._warningLights.Location = new System.Drawing.Point(207, 82);
            this._warningLights.Name = "_warningLights";
            this._warningLights.Size = new System.Drawing.Size(121, 21);
            this._warningLights.TabIndex = 22;
            // 
            // _warningDuration
            // 
            this._warningDuration.DisplayMember = "Value";
            this._warningDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._warningDuration.FormattingEnabled = true;
            this._warningDuration.Location = new System.Drawing.Point(50, 82);
            this._warningDuration.Name = "_warningDuration";
            this._warningDuration.Size = new System.Drawing.Size(106, 21);
            this._warningDuration.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Show:";
            // 
            // _fullScreen
            // 
            this._fullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._fullScreen.Enabled = false;
            this._fullScreen.Location = new System.Drawing.Point(524, 214);
            this._fullScreen.Name = "_fullScreen";
            this._fullScreen.Size = new System.Drawing.Size(75, 23);
            this._fullScreen.TabIndex = 32;
            this._fullScreen.Text = "Full Screen";
            this._fullScreen.UseVisualStyleBackColor = true;
            this._fullScreen.Click += new System.EventHandler(this.FullScreenClick);
            // 
            // TimeboxEnforcer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 249);
            this.Controls.Add(this._fullScreen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this._warningDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._warningAudioDuration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._warningLightDuration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this._warningAudio);
            this.Controls.Add(this._warningLights);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._timeboxAudioDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._timeboxLightDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._countdown);
            this.Controls.Add(this._start);
            this.Controls.Add(this._timeboxAudio);
            this.Controls.Add(this._timeboxLights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._durationText);
            this.Controls.Add(this._duration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeboxEnforcer";
            this.Text = "The Enforcer";
            ((System.ComponentModel.ISupportInitialize)(this._duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar _duration;
        private System.Windows.Forms.Label _durationText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _timeboxAudio;
        private System.Windows.Forms.ComboBox _timeboxLights;
        private System.Windows.Forms.Button _start;
        private System.Windows.Forms.Label _countdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _timeboxLightDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _timeboxAudioDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _warningAudioDuration;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _warningLightDuration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox _warningAudio;
        private System.Windows.Forms.ComboBox _warningLights;
        private System.Windows.Forms.ComboBox _warningDuration;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button _fullScreen;
    }
}