using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Xml_Form
{
    public partial class Form1 : Form
    {
        List<User> users;
        XmlDocument xDoc;

#nullable enable
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Form1()
        {
            InitializeComponent();
            InitializeVariables();

        }
        public void InitializeVariables()
        {
            users = new List<User>();
            xDoc = new XmlDocument();
            xDoc.Load(@"D:\KPYP_LECTION\xml_class\Workers.xml");

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    User user = new();
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");

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
                {

                    //user_listbox.Items.Add($"{u.Name} ({u.Company}) - {u.Age}");
                }
                user_listbox.DrawMode = DrawMode.Normal;
                List<KeyValuePair<string, string>> KeyValueList = new List<KeyValuePair<string, string>>();
                foreach (User Curritem in users)
                {
                    KeyValueList.Add(
                        new KeyValuePair<string, string>(Curritem.Name + "(" + Curritem.Company + ")",
                                        Curritem.Age.ToString()));
                }
                user_listbox.DisplayMember = "Key";
                user_listbox.ValueMember = "Value";
                user_listbox.DataSource = KeyValueList;
                user_listbox.Refresh();

                /*user_listbox.DisplayMember = "Name";
                user_listbox.DataSource = users;*/

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement userElem = xDoc.CreateElement("user");
            // создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            // создаем элементы company и age
            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");
            // создаем текстовые значения для элементов и атрибута

            XmlText nameText;
            XmlText companyText;
            XmlText ageText;

            if (name_field.Text != "" && company_field.Text != "" && age_field.Text != "")
            {
                nameText = xDoc.CreateTextNode($"{name_field.Text}");
                companyText = xDoc.CreateTextNode($"{company_field.Text}");
                ageText = xDoc.CreateTextNode($"{age_field.Text}");

                nameAttr.AppendChild(nameText);
                companyElem.AppendChild(companyText);
                ageElem.AppendChild(ageText);

                userElem.Attributes.Append(nameAttr);
                userElem.AppendChild(companyElem);
                userElem.AppendChild(ageElem);

                xRoot.AppendChild(userElem);
                xDoc.Save(@"D:\KPYP_LECTION\xml_class\Workers.xml");

                MessageBox.Show("Успешно добавлено!", "Состояние", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ошибка добавления!", "Состояние", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //добавляем узлы



        }

        private void age_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) ) e.Handled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlElement xRoot = xDoc.DocumentElement;

            XmlNode xmlNode = xRoot.SelectSingleNode($"//user[@name='{users[user_listbox.SelectedIndex].Name}']");
            xmlNode.ParentNode.RemoveChild(xmlNode);
            xDoc.Save(@"D:\KPYP_LECTION\xml_class\Workers.xml");
            MessageBox.Show("Успешно удалено!","Состояние",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);

        }

        private void user_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(users[user_listbox.SelectedIndex].Company);
        }
    }
}

