namespace ChallengeApp.test
{
    public class EmployeeTest
    {

        [Test]
        public void WhenEmployeeCollectPoints_ShouldCorrectResult()
        {
            //arrange
            var employee1 = new Employee("Kasia", "Kowalska", 43);
            employee1.AddGrade(2);
            employee1.AddGrade(2);
            employee1.AddGrade(5); ;

            //act
            var result = employee1.AddGrade;

            //assert
            Assert.AreEqual(result);

        }
    }
}