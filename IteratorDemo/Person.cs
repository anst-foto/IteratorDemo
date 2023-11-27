namespace IteratorDemo;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateTime { get; set; }

    private int Age { get; set; } = 10;
    
    public class Memento
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime DateTime { get; set; }

        private int Age { get; set; } = 10;

        public Memento(int id, string name, DateTime dateTime, int age)
        {
            Id = id;
            Name = name;
            DateTime = dateTime;
            Age = age;
        }

        public Memento(Person person)
        {
            Id = person.Id;
            Name = person.Name;
            DateTime = person.DateTime;
            Age = person.Age;
        }

        public Person GetState()
        {
            return new Person()
            {
                Id = this.Id,
                Name = this.Name,
                DateTime = this.DateTime,
                Age = this.Age
            };
        }
    }
}