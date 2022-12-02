using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace System_Application
{
    internal class ManagementXML
    {
        public const string FileName = "Data.xml";

        public enum Values
        {
            name = 1,
            email,
            number,
            age,
            cpf
        }
        public static void Init()
        {
            if (!File.Exists(FileName))
            {
                XDocument xDocument = new XDocument();
                XElement root = new XElement("users");
                xDocument.Add(root);

                xDocument.Save(FileName);
            }
        }

        public static void AddUser(string id, string name, string email, string number, string age, string cpf)
        {
            if (File.Exists(FileName))
            {
                XDocument xmlDocument = XDocument.Load(FileName);

                XElement element = new XElement("user");
                element.SetAttributeValue("id", id);
                element.SetAttributeValue("nome", name);
                element.SetAttributeValue("email", email);
                element.SetAttributeValue("número", number);
                element.SetAttributeValue("idade", age);
                element.SetAttributeValue("cpf", cpf);

                xmlDocument.Root?.Add(element);
                xmlDocument.Save(FileName);
            }
        }

        public static int GetCount()
        {
            if (File.Exists(FileName))
            {
                XDocument xdoc = XDocument.Load(FileName);

                return xdoc.Root!.Elements().Count();
            }
            return 0;
        }

        public static List<User> GetAllUsers()
        {
            if (!File.Exists(FileName)) return new List<User>();

            List<User> users = new List<User>();

            XDocument xdoc = XDocument.Load(FileName);

            foreach(XElement element in xdoc.Root!.Elements())
            {
                string id = element.Attribute("id")!.Value;
                string name = element.Attribute("nome")!.Value;
                string email = element.Attribute("email")!.Value;
                string number = element.Attribute("número")!.Value;
                string age = element.Attribute("idade")!.Value;
                string cpf = element.Attribute("cpf")!.Value;

                User user = new User(id, name, email, number, age, cpf);
                users.Add(user);
            }

            return users;
        }

        public static void RestartIDs()
        {
            if (!File.Exists(FileName)) return;

            XDocument xdoc = XDocument.Load(FileName);

            for(int count = 0; count < xdoc.Root!.Elements().Count(); count++)
            {
                xdoc.Root.Elements().ElementAt(count).Attribute("id")!.Value = (count + 1).ToString();
            }

            xdoc.Save(FileName);
        }

        public static void ChangeValueFromType(int id, string value, Values type)
        {
            if (value == null || !File.Exists(FileName)) return;

            XDocument xdoc = XDocument.Load(FileName);

            switch (type)
            {
                case Values.name:
                    xdoc.Root!.Elements().ElementAt(id).Attribute("nome")!.Value = value;
                    break;

                case Values.email:
                    xdoc.Root!.Elements().ElementAt(id).Attribute("email")!.Value = value;
                    break;

                case Values.number:
                    xdoc.Root!.Elements().ElementAt(id).Attribute("número")!.Value = value;
                    break;

                case Values.age:
                    xdoc.Root!.Elements().ElementAt(id).Attribute("idade")!.Value = value;
                    break;

                case Values.cpf:
                    xdoc.Root!.Elements().ElementAt(id).Attribute("cpf")!.Value = value;
                    break;
            }

            xdoc.Save(FileName);
        }
    }
}
