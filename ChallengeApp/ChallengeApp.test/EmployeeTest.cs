namespace ChallengeApp.test
{
    public class EmployeeTest
    {

        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMax()
        {
            //arrange
            var employee1 = new Employee("Kasia", "Kowalska", 43);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(5); ;

            //act
            var statistics = employee1.GetStatisties();

            //assert
            Assert.AreEqual(5, statistics.Max);

        }
        public void WhenGetStatistics_ShouldReturnCorrectMin()
        {
            //arrange
            var employee1 = new Employee("Kasia", "Kowalska", 43);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(5); ;

            //act
            var statistics = employee1.GetStatisties();

            //assert
            Assert.AreEqual(2, statistics.Min);

        }
        public void WhenGetStatistics_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee1 = new Employee("Kasia", "Kowalska", 43);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(5); ;

            //act
            var statistics = employee1.GetStatisties();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2),Math.Round(statistics.Average, 2));

        }
    }
}