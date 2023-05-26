namespace M2S6E00Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<int> list = new List<int>() { 2, -2, 0, 4, 6 };
            int result = Calculator.Sum(list);
            int resultExpeted = 10;
            Assert.AreEqual(resultExpeted, result);
        }

        [Test]
        public void Test2()
        {
            List<int> list = new List<int>() { 0, 3, 5, 10, 2 };
            List<int> result = Calculator.ReverseOrder(list);
            List<int> resultExpected = new List<int> { 2, 10, 5, 3, 0 };
            Assert.AreEqual(resultExpected, result);
        }

        [Test]
        public void Test3()
        {
            List<int> list = new List<int>() { 0, 3, 5, 10, 2 };
            List<int> result = Calculator.Order(list);
            List<int> resultExpected = new List<int> { 0, 2, 3, 5, 10 };
            Assert.AreEqual(resultExpected, result);
        }
    }
}