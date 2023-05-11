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
        public object Result { get; set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            { 
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(string grade)
        { 
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public Statistics GetStatisties()
        {
            var statistics = new Statistics();
            statistics.Average= 0;
            statistics.Max= float.MinValue;
            statistics.Min= float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max (statistics.Max, grade);  
                statistics.Min = Math.Min (statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;    
            return statistics;
        }
    }

}
