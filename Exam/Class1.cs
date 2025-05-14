namespace Exam
{
    public class Perevod
    {
        public int FromSixteenth(string value)
        {
            int a = Convert.ToInt32(value, 16);
            return a;

        }

        public string FromTen(int value)
        {
            string s = Convert.ToString(value, 16);
            return s.ToUpper();


        }


    }
}
