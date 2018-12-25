using Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Core
{
    public class ReWriteTools
    {
        public delegate void UpdateUI(string code, string value);
        public UpdateUI updateui;

        public delegate void AccomplishTask();
        public AccomplishTask TaskCallBack;

        private static ReWriteTools _instance;
        public static ReWriteTools Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReWriteTools();

                return _instance;
            }
        }

        public void DoTask(object param)
        {
            var insP = (Param)param;

            string txtopenurl = (string)insP.selecturl;
            string txtsaveurl = (string)insP.saveurl;
            string txtparam = (string)insP.param;

            DirectoryInfo d = new DirectoryInfo(txtopenurl);
            ArrayList FileList = new ArrayList();
            ArrayList Flst = Dao.Instance.GetAll(d, FileList);

            // 先将文件目录中包含关键字的进行替换，然后再将文件进行保存
            foreach (string v in Flst)
            {
                // 一、过滤不需要替换的文件
                // 无

                // 二、保存
                string newurl = txtsaveurl + MultiReplace(v.Replace(txtopenurl, ""), txtparam);

                // 三、如果文件中包含内容引用的dll（例如：lib文件夹中或自己定义的文件）
                if (v.ToLower().EndsWith(".dll"))
                {
                    if (!File.Exists(newurl))
                        System.IO.Directory.CreateDirectory(newurl);

                    // 直接将文件从原位置拷贝过来
                    File.Copy(v, newurl, true);
                    continue;
                }

                // 四、执行
                var html = Open(v);
                html = MultiReplace(html, txtparam);

                // 五、打印
                if (Save(html, newurl))
                    updateui(newurl, $"---> success");
            }
            TaskCallBack();
        }

        public string Open(string url)
        {
            string str;
            using (StreamReader sr = new StreamReader(url, Encoding.UTF8))
            {
                str = Convert.ToString(sr.ReadToEnd());
                sr.Close();
                return str;///读取
            }
        }

        public bool Save(string html, string url)
        {
            if (!File.Exists(url))
                System.IO.Directory.CreateDirectory(url);
            System.IO.File.WriteAllText(url, html, Encoding.UTF8);
            return true;
        }

        public string MultiReplace(string content, string param)
        {
            string[] striparr = param.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (var p in striparr)
            {
                if (string.IsNullOrEmpty(p) || p.IndexOf("=") == -1)
                    continue;
                List<string> p_list = p.Split('=').ToList();
                if (p_list.Count != 2 || p_list.Count(q => string.IsNullOrWhiteSpace(q)) > 0)
                    continue;
                content = content.Replace(p_list[0], p_list[1]);
            }
            return content;
        }
    }
}
