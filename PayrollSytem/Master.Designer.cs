namespace PayrollSytem
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsPayroll = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::PayrollSytem.Properties.Resources.owl;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 34);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEmployee,
            this.tsPayroll,
            this.tsUser,
            this.tsReport,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1370, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsEmployee
            // 
            this.tsEmployee.Enabled = false;
            this.tsEmployee.Image = global::PayrollSytem.Properties.Resources.iconfinder_group_67300;
            this.tsEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(68, 53);
            this.tsEmployee.Text = "Employees";
            this.tsEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEmployee.Click += new System.EventHandler(this.tsEmployee_Click);
            // 
            // tsPayroll
            // 
            this.tsPayroll.Enabled = false;
            this.tsPayroll.Image = global::PayrollSytem.Properties.Resources.payroll;
            this.tsPayroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPayroll.Name = "tsPayroll";
            this.tsPayroll.Size = new System.Drawing.Size(54, 53);
            this.tsPayroll.Text = "Payroll";
            this.tsPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPayroll.Click += new System.EventHandler(this.tsPayroll_Click);
            // 
            // tsUser
            // 
            this.tsUser.Enabled = false;
            this.tsUser.Image = global::PayrollSytem.Properties.Resources.iconfinder_support_416400;
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(54, 53);
            this.tsUser.Text = "Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsReport
            // 
            this.tsReport.Enabled = false;
            this.tsReport.Image = ((System.Drawing.Image)(resources.GetObject("tsReport.Image")));
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(54, 53);
            this.tsReport.Text = "Reports";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Visible = false;
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::PayrollSytem.Properties.Resources.iconfinder_lock_safe_password_2992204;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(54, 53);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.BackgroundImage = global::PayrollSytem.Properties.Resources.Fedora;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheetah Services | Salary Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsEmployee;
        private System.Windows.Forms.ToolStripButton tsPayroll;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripButton tsLogin;
    }
}

