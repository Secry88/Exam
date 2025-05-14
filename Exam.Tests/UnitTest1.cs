namespace Exam.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectFrom16thTo10()
        {
            Perevod perevod = new Perevod();
            int a = perevod.FromSixteenth("A");

            Assert.Equal(10, a);
        }

        [Fact]
        public void CorrectFrom10thTo16th()
        {
            Perevod perevod = new Perevod();
            string a = perevod.FromTen(10);

            Assert.Equal("A", a);
        }
    }
} 