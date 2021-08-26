using NUnit.Framework;
using LambdaExpressionUsingList;

namespace UnitTesting
{
    public class Tests
    {
        Operations operation;

        [SetUp]
        public void Setup()
        {
            operation = new Operations();
        }

        [Test]
        public void FindAllTest()
        {
            bool output = operation.Findall();
            Assert.IsTrue(output);
        }

        [Test]
        public void TestTeenager()
        {
            bool output = operation.TeenagerorNot();
            Assert.IsTrue(output);
        }
        [Test]
        
        public void TestAverage()
        {
            double output = operation.GetAverage();
            Assert.AreEqual(output, operation.GetAverage());
        }
        [Test]
        public void TestFindName()
        {
            bool output = operation.GetName();
            Assert.IsTrue(output);
        }

    }
}