using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core
{
    public class Dao
    {
        public delegate void UpdateUI(string code, string before, string after, string fromurl);
        public UpdateUI updateui;

        public delegate void AccomplishTask();//声明一个在完成任务时通知主线程的委托
        public AccomplishTask TaskCallBack;

        private static Dao _instance;
        public static Dao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dao();

                return _instance;
            }
        }

        public void DoExprot(object fromurl)
        {
            DirectoryInfo d = new DirectoryInfo((string)fromurl);
            ArrayList FileList = new ArrayList();
            ArrayList Flst = Core.Dao.Instance.GetAll(d, FileList);
            foreach (string v in Flst)
            {
                string ext = v.ToLower();
                if (!ext.EndsWith(".html")
                    && !ext.EndsWith(".cshtml")
                    && !ext.EndsWith(".js")
                    && !ext.EndsWith(".json")
                    && !ext.EndsWith(".cs")
                    && !ext.EndsWith(".config")
                    && !ext.EndsWith(".xml")
                    && !ext.EndsWith(".htm"))
                {
                    continue;
                }

                var html = Open(v);
                Gl(html, v);
            }

            TaskCallBack();
        }

        public ArrayList GetAll(DirectoryInfo dir, ArrayList FileList)//搜索文件夹中的文件
        {
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                FileList.Add(fi.FullName);
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                if (d.Name == ".svn"
                    || d.Name.ToLower() == ".vs"
                    || d.Name.ToLower() == "bin"
                    || d.Name.ToLower() == ".nuget"
                    || d.Name.ToLower() == "packages"
                    || d.Name.ToLower() == "obj"
                    )
                    continue;
                GetAll(d, FileList);
            }
            return FileList;
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

        public void Gl(string html, string url)
        {
            if (html == null)
                return;

            // 将html过滤掉
            //var textnohtml = html;
            var textnohtml = Core.Dao.Instance.Html2Text(html);

            Regex reg = new Regex("[\u4e00-\u9fa5]+");
            int find_start_index = 0;

            foreach (Match v in reg.Matches(html))
            {
                ///
                /// 获取 v 的上下文环境
                ///
                var index = textnohtml.IndexOf(v.Value, find_start_index);

                // 设置下一次查询的位置
                find_start_index = index + v.Value.Length;

                // 获取前后的字节长度
                int setlen = 100;
                int get_start_index = (index < setlen ? 0 : index - setlen);

                // 前文环境
                string before_text = textnohtml.Substring(get_start_index, Math.Min(index, setlen));
                string after_text = textnohtml.Substring(index + v.Value.Length, Math.Min(setlen, textnohtml.Length - index - v.Value.Length));

                // 设置输出格式
                string output = "关键字：" + v + " --->>> 上下文（" + setlen + "个字）：" + before_text + "{" + v.Value + "}" + after_text;

                updateui(v.ToString(), before_text, after_text, url);
            }
        }

        public string Html2Text(string htmlStr)
        {
            if (String.IsNullOrEmpty(htmlStr))
            {
                return "";
            }
            // 只要内容和标点符号
            string strRegex = @"[\u4e00-\u9fa5]|[\（\）\《\》\——\；\，\,\:\：\。\“\”\！]";
            string newstr = "";
            Regex reg = new Regex(strRegex);
            foreach (Match v in reg.Matches(htmlStr))
            {
                newstr += v.Value;
            }
            return newstr;
        }
    }
}
