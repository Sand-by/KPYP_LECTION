using ModernWpf;
using ModernWpf.Controls;
using Sample_NAudio;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Windows;
using System.Xml;
using XML_wpfform.Classes;
namespace XML_wpfform
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; set; }
        private XmlDocument xDoc;
        SoundPlayer player;

        public MainWindow()
        {
            InitializeComponent();
            InitializeVariables();
            LoadXml();
            RegisterAudio();
            LoadSettings();
        }
        private void InitializeVariables()
        {
            this.People = new ObservableCollection<Person>();//Если возникнет ошибка ->поместить перед инициализацией компонентов
            lvUsers.ItemsSource = People;
            xDoc = new XmlDocument();
            player = new SoundPlayer(Resource1.Ring02);

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
                MessageBoxResult result = ModernWpf.MessageBox.Show("Вы уверены?", "Удалить запись", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
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
        private void Restart_button_Click(object sender, RoutedEventArgs e)
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
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //Авторазмер столбцов
            double remainingSpace = lvUsers.ActualWidth;
            if (remainingSpace > 0)
            {
                Column1.Width = System.Math.Ceiling(remainingSpace / 3);
                Column2.Width = System.Math.Ceiling(remainingSpace / 3);
                Column3.Width = System.Math.Ceiling(remainingSpace / 3);
            }
        }
        private void LoadSettings()
        {
            if (Settings1.Default.Theme)
            {
                ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
                toogleTheme.IsOn = true;
            }

            if (Settings1.Default.SoundPlay)
            {
                //NAudioEngine.Instance.Play();//Раскомментировать для воспроизведения после загрузки приложения
                player.PlayLooping();
                playMusic.IsChecked = true;
            }
        }
        private void SaveSettings_Click_1(object sender, RoutedEventArgs e)
        {
            _ = (bool)toogleTheme.IsOn? Settings1.Default.Theme = true : Settings1.Default.Theme = false; // Сохранить тему
            _ = (bool)playMusic.IsChecked ? Settings1.Default.SoundPlay = true : Settings1.Default.SoundPlay = false;// Сохранить музыку
            Settings1.Default.Save();
        }
        private void RegisterAudio()
        {
            NAudioEngine soundEngine = NAudioEngine.Instance;
            string respath = @"D:\KPYP_LECTION\XML_wpfform\Resources\Alternate Realities.mp3";
            NAudioEngine.Instance.OpenFile(respath);
            Spectrum.RegisterSoundPlayer(soundEngine);
        }
        private void PlayMusic_Checked(object sender, RoutedEventArgs e)
        {
            //Пример с аудио визуалайзером
            if(NAudioEngine.Instance.CanPlay)
                NAudioEngine.Instance.Play();
            //Аудио ресурс (wav)
            //player.PlayLooping();
        }
        private void PlayMusic_Unchecked(object sender, RoutedEventArgs e)
        {
            //Пример с аудиоспектром
            NAudioEngine.Instance.Stop();

            player.Stop();
        }
    }
}