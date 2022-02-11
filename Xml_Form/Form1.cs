using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace Xml_Form
{
    public partial class Form1 : MaterialForm
    {
        private BindingList<User> users = new();
        private XmlDocument xDoc = new();

        public Form1()
        {
            InitializeComponent();
            InitializeVariables();
            LoadXml();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange200, Primary.Orange100, Accent.Orange400, TextShade.BLACK);
        }
        public void InitializeVariables()
        {
            user_listbox1.DisplayMember = "FullInfo";
            user_listbox1.DataSource = users;
        }
        private void LoadXml()
        {
            xDoc.Load(@"D:\KPYP_LECTION\Xml_Form\XML\Workers.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    User user = new();
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");

                    user.Name = attr.Value;

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "company")
                            user.Company = childnode.InnerText;

                        if (childnode.Name == "age")
                            user.Age = int.Parse(childnode.InnerText);
                    }
                    users.Add(user);
                }
            }
        }
        private void SaveXml(string name, string company, string age)
        {
            XmlElement? xRoot = xDoc.DocumentElement;

            XmlElement userElem = xDoc.CreateElement("user");

            XmlAttribute nameAttr = xDoc.CreateAttribute("name");

            XmlElement companyElem = xDoc.CreateElement("company");
            XmlElement ageElem = xDoc.CreateElement("age");

            XmlText nameText = xDoc.CreateTextNode(name);
            XmlText companyText = xDoc.CreateTextNode(company);
            XmlText ageText = xDoc.CreateTextNode(age);
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(companyElem);
            userElem.AppendChild(ageElem);

            xRoot?.AppendChild(userElem);
            xDoc.Save(@"D:\KPYP_LECTION\Xml_Form\XML\Workers.xml");
        }
        private void Add_button_Click(object sender, EventArgs e)
        {

            if (name_field.Text == string.Empty || company_field.Text == string.Empty || age_field.Text == string.Empty)
            {
                MessageBox.Show("Ошибка добавления!", "Состояние", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveXml(name_field.Text, company_field.Text, age_field.Text);
                User user = new User(name_field.Text, Convert.ToInt32(age_field.Text), company_field.Text);
                users.Add(user);

                MaterialListBoxItem item = new MaterialListBoxItem(user.FullInfo);
            }

        }
        private void Age_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;

        }
        private void Delete_user_Click(object sender, EventArgs e)
        {

            XmlElement? xRoot = xDoc.DocumentElement;
            if (user_listbox1.SelectedIndex >= 0)
            {
                XmlNode? xmlNode = xRoot?.SelectSingleNode($"//user[@name='{users[user_listbox1.SelectedIndex].Name}']");
                xmlNode?.ParentNode?.RemoveChild(xmlNode);
                xDoc.Save(@"D:\KPYP_LECTION\Xml_Form\XML\Workers.xml");
                users.RemoveAt(user_listbox1.SelectedIndex);
            }

        }
        private void Restart_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        MaterialSkinManager Tmanager = MaterialSkinManager.Instance;

        private void materialSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!materialSwitch1.Checked)
            {
                Tmanager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSwitch1.Text = "Светлая";
            }
            else
            {
                Tmanager.Theme = MaterialSkinManager.Themes.DARK;
                materialSwitch1.Text = "Темная";
            }
        }
    }

    
}

