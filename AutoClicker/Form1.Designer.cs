namespace AutoClicker
{
    partial class Fo_Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fo_Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_str = new System.Windows.Forms.Button();
            this.btn_rec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key to start";
            // 
            // btn_str
            // 
            this.btn_str.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(137)))), ((int)(((byte)(141)))));
            this.btn_str.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(137)))), ((int)(((byte)(141)))));
            this.btn_str.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_str.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_str.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_str.ForeColor = System.Drawing.Color.White;
            this.btn_str.Location = new System.Drawing.Point(200, 8);
            this.btn_str.Name = "btn_str";
            this.btn_str.Size = new System.Drawing.Size(80, 136);
            this.btn_str.TabIndex = 2;
            this.btn_str.Text = "Start";
            this.btn_str.UseVisualStyleBackColor = false;
            this.btn_str.Click += new System.EventHandler(this.button1_Click);
            this.btn_str.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_str_KeyDown);
            // 
            // btn_rec
            // 
            this.btn_rec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rec.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_rec.ForeColor = System.Drawing.Color.GreenYellow;
            this.btn_rec.Location = new System.Drawing.Point(8, 88);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(184, 51);
            this.btn_rec.TabIndex = 3;
            this.btn_rec.Text = "Record";
            this.btn_rec.UseVisualStyleBackColor = true;
            this.btn_rec.Click += new System.EventHandler(this.button2_Click);
            this.btn_rec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Fo_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(64)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(288, 150);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.btn_str);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fo_Main";
            this.Text = "Clicker.exe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fo_Main_FormClosing);
            this.Load += new System.EventHandler(this.Fo_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fo_Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_str;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.Label label2;
    }
}

