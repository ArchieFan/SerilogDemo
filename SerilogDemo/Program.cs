using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace SerilogDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Workspace_C#_4.8\SerilogDemo\SerilogDemo\bin\Debug\LogFile.log").CreateLogger();
            Log.Information("This is a sample information");
            try
            {
                int a = 2;
                int b = 0;
                Log.Debug($"The value are {a} amd {b}");
                int c = a / b;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Some error occured");
            }
            Log.CloseAndFlush();
        }
    }
}
