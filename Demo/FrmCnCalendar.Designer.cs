namespace Demo
{
    partial class FrmCnCalendar
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCnYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCnMonth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCnDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 29);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "年份：";
            // 
            // txtCnYear
            // 
            this.txtCnYear.Location = new System.Drawing.Point(72, 47);
            this.txtCnYear.Name = "txtCnYear";
            this.txtCnYear.ReadOnly = true;
            this.txtCnYear.Size = new System.Drawing.Size(140, 29);
            this.txtCnYear.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "月份：";
            // 
            // txtCnMonth
            // 
            this.txtCnMonth.Location = new System.Drawing.Point(72, 82);
            this.txtCnMonth.Name = "txtCnMonth";
            this.txtCnMonth.ReadOnly = true;
            this.txtCnMonth.Size = new System.Drawing.Size(140, 29);
            this.txtCnMonth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "日子：";
            // 
            // txtCnDay
            // 
            this.txtCnDay.Location = new System.Drawing.Point(72, 117);
            this.txtCnDay.Name = "txtCnDay";
            this.txtCnDay.ReadOnly = true;
            this.txtCnDay.Size = new System.Drawing.Size(140, 29);
            this.txtCnDay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "属相：";
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(72, 152);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.ReadOnly = true;
            this.txtAnimal.Size = new System.Drawing.Size(140, 29);
            this.txtAnimal.TabIndex = 2;
            // 
            // FrmCnCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 200);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCnDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCnMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCnYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCnCalendar";
            this.Text = "农历信息类测试窗体";
            this.Load += new System.EventHandler(this.FrmCnCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCnYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCnMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnimal;
    }
}

