using System;
using System.Collections.Generic;
using System.Xml;

namespace xml_class
{
    internal class Program
    {
        static void Main()
        {

            List<User> users = new();

            XmlDocument xDoc = new();
            xDoc.Load(@"D:\KPYP_LECTION\xml_class\Workers.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    User user = new();
#nullable enable
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");
#nullable enable

                    user.Name = attr?.Value;

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "company")
                            user.Company = childnode.InnerText;

                        if (childnode.Name == "age")
                            user.Age = int.Parse(childnode.InnerText);
                    }
                    users.Add(user);
                }
                foreach (User u in users)
                    Console.WriteLine($"{u.Name} ({u.Company}) - {u.Age}");
            }
        }
        class User
        {
            public string? Name { get; set; }
            public int Age { get; set; }
            public string? Company { get; set; }
        }
    }
}
