using System;
using System.IO;
using System.Text;

namespace Console_TestCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.Split(@"\bin\")[0] + @"\File";//文件生成路径

            string fileName = Path.Combine(path, "log.txt");
            string fileNameCopy = Path.Combine(path, "logCopy.txt");
            string fileNameMove = Path.Combine(path, "logMove.txt");
            bool isExists = File.Exists(fileName);
            if (!isExists)
            {
                //覆盖式
                Directory.CreateDirectory(path);//创建了文件夹才能创建文件
            }
            using (FileStream fileStream = File.Create(fileName))//打开文件流（创建文件并写入）
            {
                string name = "测试自动编译";
                byte[] bytes = Encoding.Default.GetBytes(name);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Flush();
            }

        }
    }
}
