using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 登陆界面
{
    class Record
    {
        private string account;
        private string key;
        public Record(string account1, string key1)
        {
            account = account1;
            key = key1;
        }
        public void Writefile(StreamWriter f)
        {
            f.WriteLine(account + "," + key);
        }

    }
}
