using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Management;



namespace Laba4._3
{

    class Program
    {
private static List<string> GetHardwareInfo(string WIN32_Class, string ClassItemField)
        {
            List<string> result = new List<string>();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    result.Add(obj[ClassItemField].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
        private static void OutputResult(string info, List<string> result)
        {
            if (info.Length > 0)
                Console.WriteLine(info);

            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; ++i)
                    Console.WriteLine(result[i]);
            }
        }
        static void Main(string[] args)
        {
            OutputResult("Процессор:", GetHardwareInfo("Win32_Processor", "Name"));
            OutputResult("Производитель процессора:", GetHardwareInfo("Win32_Processor", "Manufacturer"));
            OutputResult("Описание процессора:", GetHardwareInfo("Win32_Processor", "Description"));
            OutputResult("Видеокарта:", GetHardwareInfo("Win32_VideoController", "Name"));
            OutputResult("Описание видеокарты:", GetHardwareInfo("Win32_Processor", "Description"));
            Console.ReadKey();
        }
    }
}
