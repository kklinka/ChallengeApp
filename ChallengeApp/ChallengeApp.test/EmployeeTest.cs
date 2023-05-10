namespace ChallengeApp.test
{
    public class EmployeeTest
    {

        [Test]
        public void WhenEmployeeCollectPoints_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Kasia", "Kowalska", 43);
            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(-2);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(10, result);

        }
    }
}