using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Nov_4
{
    public class Events
    {
        public static int Total=0;
        public event EventHandler<ColourSpectrum> TestEventHandler;

        public void Update()
        {
            Total++;
            if (Total == 3)
            {   ColourSpectrum spectrum1 = new ColourSpectrum();
                spectrum1.spectrum = "Visible";
                TestEventHandler?.Invoke(this, spectrum1);
            }
        }

       
    }
    public class ColourSpectrum : EventArgs
    {
        public string spectrum;
    }
}
