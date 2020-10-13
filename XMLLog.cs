using System.Xml.Linq;
using System.IO;
namespace List_of_Storage_Media
{
    class XMLLog : ILog
    {
        private static bool first_run;
        private static XElement root;

        public XMLLog()
        {
            first_run = true;
        }

        public void Print(Storage value)
        {
            if (first_run)
            {
                File.Delete("Print.txt");

                XDocument xdoc = new XDocument();
                root = new XElement("List_of_Storage");
                xdoc.Add(root);
                first_run = false;
                xdoc.Save("Print.txt");
            }

            XElement storage = new XElement("Storage");
            XElement name = new XElement("Name", value.Name);
            XElement company = new XElement("Company_Name", value.Name_Company);
            XElement count = new XElement("Count", value.Count.ToString());
            XElement capacity = new XElement("Capacity", value.Capacity.ToString());
            XElement model = new XElement("Model", value.Model.ToString());
            XElement speed = new XElement("Speed", value.Speed.ToString());

            storage.Add(name);
            storage.Add(company);
            storage.Add(count);
            storage.Add(capacity);
            storage.Add(model);
            storage.Add(speed);
            root.Add(storage);
            root.Save("Print.txt");
        }
    }
}
