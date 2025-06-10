using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public static User LoadFromXml(string login, string password)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Кристина\\Desktop\\Project\\Project\\Users.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string trueLogin = node["login"].InnerText;
                string truePassword = node["password"].InnerText;
                if (login == trueLogin && password == truePassword)
                {
                    return new User
                    {
                        Name = node.Attributes["name"].Value,
                        Role = node["role"].InnerText
                    };
                }
                    
            }
            return null;
        }
    }
}
