namespace XML_wpfform.Classes
{
    public class Person
    {
        public string Name { get; set; } = "noname";
        public string Company { get; set; } = "none";
        public ushort Age { get; set; } = 5;

        public Person()
        {

        }
        public Person(string n, string c, ushort a)
        {
           Name = n;
           Company = c;
           Age = a;
        }
    }
}
