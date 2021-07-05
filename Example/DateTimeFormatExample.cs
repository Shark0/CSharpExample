using System;

namespace Example
{
    public class DateTimeExample
    {
        public void run()
        {
            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            Console.Out.WriteLine(time);           
        }
    }
}