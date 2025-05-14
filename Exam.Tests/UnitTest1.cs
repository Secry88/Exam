namespace Exam.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Perevod perevod = new Perevod();
            int a = perevod.FromSixteenth("4E");

            Assert.Equal(78, a);
        }

        [Fact]
        public void Test2()
        {
            Perevod perevod = new Perevod();
            string a = perevod.FromTen(78);

            Assert.Equal("4E", a);
        }
    }
} 