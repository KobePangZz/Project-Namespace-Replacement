using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.Core;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate void AsynUpdateUI();

        private void UpdateUIStatus(string text, string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new AsynUpdateUI(delegate ()
                {
                    this.txtinfo.AppendText("\r\n" + text + "--->" + value);
                }));
            }
        }

        private void Accomplish()
        {
            MessageBox.Show("任务完成");
            thread.Abort();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dddd = "dddDDD";
            dddd = dddd.Replace("d", "t");
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txtopen.Text = foldPath;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                txtsave.Text = foldPath;
            }
        }

        private Thread thread;
        private void txtbegin_Click(object sender, EventArgs e)
        {
            var open = txtopen.Text;
            var save = txtsave.Text;
            var param = txtparam.Text;

            if (string.IsNullOrEmpty(open) || string.IsNullOrEmpty(save) || string.IsNullOrEmpty(param))
            {
                MessageBox.Show("参数错误");
                return;
            }

            ReWriteTools.Instance.updateui += UpdateUIStatus;
            ReWriteTools.Instance.TaskCallBack += Accomplish;

            Param p = new Param();
            p.selecturl = this.txtopen.Text;
            p.saveurl = this.txtsave.Text;
            p.param = param;

            thread = new Thread(new ParameterizedThreadStart(ReWriteTools.Instance.DoTask));
            thread.Start(p);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (thread != null)
                thread.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thread != null)
                thread.Abort();
        }
    }

    public class Param
    {
        public string selecturl { get; set; }
        public string saveurl { get; set; }
        public string param { get; set; }
    }
}
