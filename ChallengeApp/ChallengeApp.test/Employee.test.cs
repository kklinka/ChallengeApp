namespace ChallengeApp.test
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectPoints_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Kasia", "Kowalska", 43);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(-2);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(10, result);

        }
    }
}