using System.Xml;

namespace Xml_Form.Classes
{
    public class Settings
    {
        public XmlDocument XmlSettings = new();
        public string? Theme { get; set; }

        public string? ColorScheme { get; set; }

        public Settings(string XmlPath)
        {
            XmlSettings.Load(XmlPath);
        }
    }
}
