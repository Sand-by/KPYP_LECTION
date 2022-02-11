namespace Xml_Form
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }

        public string FullInfo // Свойство для получения полной информации
        {
            get
            {
                return Name + " (" + Company + ") " + Age.ToString();
            }
        }
        public User()
        {
            Name = "none";
            Age = 0;
            Company = "none";
        }
        public User(string n, int a, string c)
        {
            Name = n;
            Age = a;
            Company = c;
        }
    }
}
