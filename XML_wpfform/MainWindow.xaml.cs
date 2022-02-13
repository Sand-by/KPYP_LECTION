using ModernWpf;
using ModernWpf.Controls;
using System.Collections.ObjectModel;
using System.Media;
using System.Windows;
using System.Xml;
using XML_wpfform.Classes;
namespace XML_wpfform
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; set; }
        private readonly XmlDocument xDoc = new XmlDocument();

        public MainWindow()
        {
            this.People = new ObservableCollection<Person>();
            InitializeComponent();
            LoadXml();
            lvUsers.ItemsSource = People;

        }
        private void LoadXml()
        {
            xDoc.Load(@"D:\KPYP_LECTION\XML_wpfform\XML\Workers.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    Person user = new Person();
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    user.Name = attr.Value;
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "company")
                            user.Company = childnode.InnerText;
                        if (childnode.Name == "age")
                            user.Age = ushort.Parse(childnode.InnerText);
                    }
                    People.Add(user);
                }
            }
        }
        private void SaveXml(string name, string company, string age)
        {
            XmlElement xRoot = xDoc.DocumentElement;
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
            xDoc.Save(@"D:\KPYP_LECTION\XML_wpfform\XML\Workers.xml");
        }
        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            if (name_field.Text == string.Empty || company_field.Text == string.Empty || age_field.Text == string.Empty)
            {
                ModernWpf.MessageBox.Show("Ошибка добавления!", "Состояние", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SaveXml(name_field.Text, company_field.Text, age_field.Text);
                Person user = new Person(name_field.Text, company_field.Text, ushort.Parse(age_field.Text));
                People.Add(user);
            }
        }
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toogleTheme.IsOn)
            {
                ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
            }
            else
                ThemeManager.Current.ApplicationTheme = ApplicationTheme.Light;
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lvUsers.SelectedIndex != -1)
            {
                MessageBoxResult result = (MessageBoxResult)ModernWpf.MessageBox.Show("Вы уверены?", "Удалить запись", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    XmlElement xRoot = xDoc.DocumentElement;
                    XmlNode xmlNode = xRoot?.SelectSingleNode($"//user[@name='{People[lvUsers.SelectedIndex].Name}']");
                    xmlNode?.ParentNode?.RemoveChild(xmlNode);
                    xDoc.Save(@"D:\KPYP_LECTION\XML_wpfform\XML\Workers.xml");
                    People.RemoveAt(lvUsers.SelectedIndex);
                }
                else if (result == MessageBoxResult.No)
                {
                    e.Handled = true;
                }

            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            System.Windows.Forms.Application.Restart();
        }
        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                MainFrame.Visibility = Visibility.Collapsed;
                settingsFrame.Visibility = Visibility.Visible;
            }
            else if (args.InvokedItem.ToString() == "Главная")
            {
                MainFrame.Visibility = Visibility.Visible;
                settingsFrame.Visibility = Visibility.Collapsed;
            }
        }

        SoundPlayer player = new SoundPlayer(Resource1.Ring02);

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            player.PlayLooping();
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }
    }
}