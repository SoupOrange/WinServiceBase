using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceBase
{
    partial class ServiceExample : ServiceBase
    {
        public ServiceExample()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            using (FileStream aa = new FileStream("d://text.txt", FileMode.OpenOrCreate))
            {
                byte[] vs = new byte[200];
                vs = Encoding.UTF8.GetBytes("测试服务安装成功");
                aa.Write(vs, 0, vs.Length);
            }
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
        }
    }
}
