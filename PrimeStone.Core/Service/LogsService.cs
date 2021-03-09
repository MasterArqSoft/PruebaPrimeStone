using PrimeStone.Core.Interfaces;
using System;
using System.Diagnostics;
using System.IO;

namespace PrimeStone.Core.Service
{
    public class LogsService : ILogsService
    {
        public void Save(string url, Exception ex)
        {
            string fecha = System.DateTime.Now.ToString("yyyyMMdd");
            string hora = System.DateTime.Now.ToString("HH:mm:ss");
            string path = Path.GetFullPath("logs/" + fecha + ".txt");

            StreamWriter sw = new(path, true);

            sw.WriteLine($"{url} - Capa {ex.Source} | {ex.Message} {hora}");
            sw.WriteLine($"{ex.TargetSite.DeclaringType.FullName}");

            sw.WriteLine("");
            sw.Flush();
            sw.Close();
        }
    }
}
