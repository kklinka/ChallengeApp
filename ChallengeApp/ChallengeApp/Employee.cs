namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
       
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
         public Statistics GetStatisties()
        {
            var statisties = new Statistics();
            statisties.Average= 0;
            statisties.Max= float.MinValue;
            statisties.Min= float.MaxValue;

            foreach(var grade in this.grades)
            {
                statisties.Max = Math.Max (statisties.Max, grade);  
                statisties.Min = Math.Min (statisties.Min, grade);
                statisties.Average += grade;
            }

            statisties.Average /= this.grades.Count;    
            return statisties;
        }
    }

}
