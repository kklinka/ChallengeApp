namespace ChallengeApp.test
{
    public class EmployeeTest
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(5); ;

            //act
            var statistics = employee.GetStatisties();

            //assert
            Assert.AreEqual(5, statistics.Max);
        }
        public void WhenGetStatistics_ShouldReturnCorrectMin()
        {
            var employee = new Employee("Kasia", "Kowalska", 43);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(5); ;

            var statistics = employee.GetStatisties();

            Assert.AreEqual(2, statistics.Min);
        }
        public void WhenGetStatistics_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Kasia", "Kowalska", 43);
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(5); ;

            var statistics = employee.GetStatisties();

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectLetterMax()
        {
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade('C');
            employee.AddGrade('D');

            var statistics = employee.GetStatisties();

            Assert.AreEqual(100, statistics.Max);
        }
        public void WhenGetStatistics_ShouldReturnCorrectLetterMin()
        {
            var employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade('C');
            employee.AddGrade('D');

            var statistics = employee.GetStatisties();

            Assert.AreEqual(40, statistics.Min);
        }
        public void WhenGetStatistics_ShouldReturnCorrectLetterAverage()
        {
            var employee = new Employee();
            employee.AddGrade(54);
            employee.AddGrade(12);
            employee.AddGrade(36);

            var statistics = employee.GetStatisties();

            Assert.AreEqual('D', statistics.AverageLetter);
        }
    }
}