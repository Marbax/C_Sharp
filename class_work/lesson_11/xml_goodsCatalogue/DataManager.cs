using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq; // linq parser for xml

namespace xml_goodsCatalogue
{
    class DataManager
    {
        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _filePath1;

        public string FilePath1
        {
            get { return _filePath1; }
            set { _filePath1 = value; }
        }

        XDocument _doc, _doc1;

        public DataManager(string filePath = @"../../Data/Categories.xml", string filePath1 = @"../../Data/Goods.xml")
        {
            _filePath = filePath;
            _filePath1 = filePath1;
            _doc = XDocument.Load(_filePath);
            _doc1 = XDocument.Load(_filePath1);
        }

        public List<System.Xml.Linq.XElement> GetCategoriesList()
        {
            return _doc.Element("categories").Elements("category").ToList();
        }

        public void PrintCategoriesList()
        {
            foreach (var item in GetCategoriesList())
            {
                Console.WriteLine($"{item.Attribute("id").Value}.{item.Attribute("name").Value}");
            }
        }

        public void AddCategory(string category_name)
        {
            var categories = GetCategoriesList();
            var new_id = categories.LastOrDefault().Attribute("id").Value;

            XElement new_elem = new XElement("category",
                new XAttribute("id", new_id != null ? (new_id + 1).ToString() : "1"),
                new XAttribute("name", category_name));

            _doc.Element("categories").Add(new_elem);
            _doc.Save(_filePath);
            Console.WriteLine("\t\tCategory added");
        }

        public bool RemoveCategory(string category_name)
        {
            var to_remove = GetCategoriesList().Where(c => c.Attribute("name").Value == category_name).FirstOrDefault();

            if (to_remove != null)
            {
                to_remove.Remove();
                _doc.Save(_filePath);
                Console.WriteLine("\t\tCategory removed");
                return true;
            }
            Console.WriteLine("\t\tNothing to remove");
            return false;
        }

        public List<System.Xml.Linq.XElement> ListGoodsByCategory(string category_name)
        {
            var find_category = GetCategoriesList().Where(c => c.Attribute("name").Value == category_name).FirstOrDefault();

            if (find_category != null)
            {
                string cid = find_category.Attribute("id").Value;
                return _doc1.Element("goods").Elements("product").Where(p => p.Attribute("cid").Value == cid).ToList();
            }

            return null;
        }

        public void SelectGoodsByCategory(string category_name)
        {
            if (ListGoodsByCategory(category_name) != null)
            {
                foreach (var item in ListGoodsByCategory(category_name))
                {
                    Console.WriteLine($"{item.Attribute("id").Value}. {item.Attribute("name").Value} {item.Attribute("peoducer").Value} {item.Attribute("price").Value}");

                    /*
                    Console.WriteLine("{0,5}{1,20}{2,20}{3,20}",
                        item.Attribute("id").Value,
                        item.Attribute("name").Value,
                        item.Attribute("peoducer").Value,
                        item.Attribute("price").Value);
                    */
                }
            }

        }
    }
}
