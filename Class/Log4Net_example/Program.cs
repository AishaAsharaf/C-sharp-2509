using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Here is the once-per-application setup information
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4Net_example
{
    public class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Info("Info logging");
            log.Debug("This is a debug message."); // This should now log if filters are removed or adjusted.
            log.Error("Error logged");
            log.Fatal("Fatal");
            log.Warn("Warn");

        }
    }
}
