namespace TestProject_9
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            Calculator_9 example = new Calculator_9();
            var result = example.Add(10, 20);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void Test2()
        {
            Calculator_9 example = new Calculator_9();
            var result = example.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test3()
        {
            Calculator_9 example = new Calculator_9();
            Assert.Throws<DivideByZeroException>(() => example.Divide(6, 0));   //when throw an exception
        }
    }
}