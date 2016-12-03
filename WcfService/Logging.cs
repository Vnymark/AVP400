using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    public static class Logging
    {
        public static void log(string message)
        {
            
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Wezno\Documents\Skola\AVP400\log.txt", true);
                file.WriteLine(message + " - " + DateTime.Now);
                file.Close();
            }
            catch (Exception)
            {

                
            }
            
            

        }
    }
    
}
