using E94106012_practice_4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E94106012_practice_4_1
{
    internal static class Program
    {
        /// <summary>
        /// ���ó�ʽ����Ҫ�M���c��
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
