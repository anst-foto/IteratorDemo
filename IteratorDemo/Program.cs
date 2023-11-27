using IteratorDemo;

var person = new Person()
{
    Id = 0,
    Name = "Andrey",
    DateTime = DateTime.Now
};

/*var properties = new PropertyIterator(person);
foreach (var prop in properties)
{
    Console.WriteLine($"{prop.Name} [{prop.Type.Name}] {prop.Value}");
}*/

foreach (var prop in person.GetProperties())
{
    Console.WriteLine($"{prop.Name} [{prop.Type.Name}] {prop.Value}");
}

var person2 = new Person.Memento(person).GetState();
foreach (var prop in person2.GetProperties())
{
    Console.WriteLine($"{prop.Name} [{prop.Type.Name}] {prop.Value}");
}