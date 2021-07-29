using Gittest1;
using NUnit.Framework;
using Moq;
namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {

        
        
        Class1 obj = new Class1();
        BankingClass b1 = new();
        [Test]
        public void Testadd()
        {
            int actual = obj.add(2, 3);
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void TestGreet()
        {
            string actual = obj.Greet("Ram");
            string expected = "Hello Ram";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestBalancewithdrawal()
        {
            int actual = b1.withdrawal(5000,1000);
            Assert.AreEqual(4000, actual);
        }

        public void calculateamounttest()
        {
            float f = obj.calculateamount(3, 5);
            Assert.AreEqual(15, f);
        }
    }
}
