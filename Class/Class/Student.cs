namespace Class
{
    class Student
    {
        public string name;
        public string surname;
        public int age;

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            this.surname = surname;
        }

        public Student(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
    }
}
