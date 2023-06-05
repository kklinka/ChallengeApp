namespace ChallengeApp.test
{
    public class TypeTest
    {
        [Test]
        public void GetEmployeeShouldDifferentString()
        {
            //arrange
            string number1 = "Kasia";
            string number2 = "Bartek";

            //assert
            Assert.AreNotEqual(number1, number2);
        }
        
        [Test]
        public void GetEmpoloyeeShouldDifferentInt()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetEmployeeShouldDifferentVar()
        {
            //arrange
            var employee1 = GetEmployee("Kasia","Kowalska", "K", 43);
            var employee2 = GetEmployee("Bartek", "Nowak", "K", 44);

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, string sex, int age) 
        {
            return new Employee(name, surname, sex, age);
        }
    }
}
