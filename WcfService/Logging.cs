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
            //The logging writes a line containing the string sent to the function(the message created through altering data).
            //It also adds the current date and time from the local machine it runs from, to the same line of text.
            //The parameter "true" is added so that new logs are added to the file, instead of overwriting it.
            //I added put it into a try-catch just in case something goes wrong. 
            //But I really don't want to log a logging error, in case that would case an infinite loop.
            //You could how ever add a function to send an email to an administrator for if/when there is a logging error. 
            //Inspiration from: http://stackoverflow.com/questions/5057567/how-to-do-logging-in-c
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
