namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();
        public event EmployeeBase.GradeAddedDelegate GradeAdded;

        public Employee ()
        {
        }
        public Employee(string name, string surname, string sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
        public object Result { get; set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            { 
                this.AddGrade(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
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
                throw new Exception ("String is not float");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade) 
            {
                case 'A':
                    this.AddGrade(100);
                    break;
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'C':
                    this.AddGrade(60);
                    break;
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception ("Wrong Letter");
            }
        }
        public Statistics GetStatisties()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
