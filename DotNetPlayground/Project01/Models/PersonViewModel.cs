namespace Project01.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MaritalStatus { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsWorking { get; set; }
        public bool IsSelected { get; set; }
    }

    public class PersonViewModel
    {
        public List<Person> Persons { get; set; }
        public List<string> SelectedName { get; set; }
    }
}
