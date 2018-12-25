namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbegin = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtopen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtparam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtparam);
            this.groupBox1.Controls.Add(this.txtbegin);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtsave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnopen);
            this.groupBox1.Controls.Add(this.txtopen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 230);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // txtbegin
            // 
            this.txtbegin.Location = new System.Drawing.Point(379, 98);
            this.txtbegin.Name = "txtbegin";
            this.txtbegin.Size = new System.Drawing.Size(75, 23);
            this.txtbegin.TabIndex = 21;
            this.txtbegin.Text = "开始";
            this.txtbegin.UseVisualStyleBackColor = true;
            this.txtbegin.Click += new System.EventHandler(this.txtbegin_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(379, 62);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "选择";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsave
            // 
            this.txtsave.Location = new System.Drawing.Point(78, 64);
            this.txtsave.Name = "txtsave";
            this.txtsave.Size = new System.Drawing.Size(294, 21);
            this.txtsave.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "保存至";
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(379, 27);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 13;
            this.btnopen.Text = "选择";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txtopen
            // 
            this.txtopen.Location = new System.Drawing.Point(78, 29);
            this.txtopen.Name = "txtopen";
            this.txtopen.Size = new System.Drawing.Size(294, 21);
            this.txtopen.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "选择项目";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtinfo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 130);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细";
            // 
            // txtinfo
            // 
            this.txtinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtinfo.Location = new System.Drawing.Point(3, 17);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(474, 110);
            this.txtinfo.TabIndex = 0;
            // 
            // txtparam
            // 
            this.txtparam.Location = new System.Drawing.Point(78, 98);
            this.txtparam.Multiline = true;
            this.txtparam.Name = "txtparam";
            this.txtparam.Size = new System.Drawing.Size(294, 85);
            this.txtparam.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "替换文本";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "格式：原内容=替换内容；说明：回车换行，一行一个";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "停止";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtbegin;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtopen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtparam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

