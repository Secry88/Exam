using System.Diagnostics;


namespace Exam
{
    public class Perevod
    {

        public int FromSixteenth(string value)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
            Trace.AutoFlush = true;
            Trace.WriteLine($"Trace: Передаваемое значение в метод из шестнадцатиричного в десятичое: {value}");
            Debug.WriteLine($"Debug: Передаваемое значение в метод из шестнадцатиричного в десятичое: {value}");
            return Convert.ToInt32(value, 16);
        }

        public string FromTen(int value)
        {
            Trace.WriteLine($"Trace: Передаваемое значение в метод из десятичного в шестнадцатиричное: {value}");
            Debug.WriteLine($"Debug: Передаваемое значение в метод из десятичного в шестнадцатиричное: {value}");
            return Convert.ToString(value, 16).ToUpper();
        }


    }
}
