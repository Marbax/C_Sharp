using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq; // linq parser for xml


namespace xml_goodsCatalogue
{
    class DataManager
    {
        private string _filePathCategories;
        public string FilePathCategories
        {
            get { return _filePathCategories; }
            set { _filePathCategories = value; }
        }

        private string _filePathGoods;
        public string FilePathGoods
        {
            get { return _filePathGoods; }
            set { _filePathGoods = value; }
        }

        XDocument _docCat, _docGood;

        public DataManager(string filePathCategories = @"../../Data/Categories.xml", string filePathGoods = @"../../Data/Goods.xml")
        {
            _filePathCategories = filePathCategories;
            _filePathGoods = filePathGoods;
            _docCat = XDocument.Load(_filePathCategories);
            _docGood = XDocument.Load(_filePathGoods);
        }

        public List<System.Xml.Linq.XElement> GetCategoriesList()
        {
            return _docCat.Element("categories").Elements("category").ToList();
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
            var new_id = int.Parse(categories.LastOrDefault().Attribute("id").Value);

            XElement new_elem = new XElement("category",
                new XAttribute("id", new_id != default ? (new_id + 1).ToString() : "1"),
                new XAttribute("name", category_name));

            _docCat.Element("categories").Add(new_elem);
            _docCat.Save(_filePathCategories);
        }

        public bool RemoveCategory(string category_name)
        {
            var to_remove = GetCategoriesList().Where(c => c.Attribute("name").Value == category_name).FirstOrDefault();

            if (to_remove != default)
            {
                to_remove.Remove();
                _docCat.Save(_filePathCategories);
                return true;
            }
            return false;
        }

        public List<System.Xml.Linq.XElement> GetGoodsList()
        {
            return _docGood.Element("goods").Elements("product").ToList();
        }

        public void PrintGoodsList()
        {
            foreach (var item in GetGoodsList())
            {
                Console.WriteLine($"{item.Attribute("id").Value}.{item.Attribute("name").Value} {item.Attribute("producer").Value} {item.Attribute("price").Value} {GetCategoriesList().First(x => x.Attribute("id").Value == item.Attribute("cid").Value).Attribute("name").Value }");
            }
        }

        public List<System.Xml.Linq.XElement> ListGoodsByCategory(string category_name)
        {
            var find_category = GetCategoriesList().Where(c => c.Attribute("name").Value.Contains(category_name)).FirstOrDefault();

            if (find_category != default)
            {
                string cid = find_category.Attribute("id").Value;
                return _docGood.Element("goods").Elements("product").Where(p => p.Attribute("cid").Value == cid).ToList();
            }

            return null;
        }

        public void PrintGoodsByCategory(string category_name)
        {
            if (ListGoodsByCategory(category_name) != null)
            {
                foreach (var item in ListGoodsByCategory(category_name))
                {
                    Console.WriteLine($"{item.Attribute("id").Value}.{item.Attribute("name").Value} {item.Attribute("producer").Value} {item.Attribute("price").Value} {GetCategoriesList().First(x => x.Attribute("id").Value == item.Attribute("cid").Value).Attribute("name").Value }");
                    /*
                    Console.WriteLine("{0,5}{1,20}{2,20}{3,20}",
                        item.Attribute("id").Value,
                        item.Attribute("name").Value,
                        item.Attribute("producer").Value,
                        item.Attribute("price").Value);
                    */
                }
            }
        }

        //добавление товара
        public void AddGood(string good_name, string good_producer, double good_price, int good_category)
        {
            var goods = GetGoodsList();
            var new_id = int.Parse(goods.LastOrDefault().Attribute("id").Value);

            XElement new_elem = new XElement("product",
                new XAttribute("id", new_id != default ? (new_id + 1).ToString() : "1"),
                new XAttribute("name", good_name),
                new XAttribute("producer", good_producer),
                new XAttribute("price", good_price.ToString().Replace('.',',')),
                new XAttribute("cid", good_category));

            _docGood.Element("goods").Add(new_elem);
            _docGood.Save(_filePathGoods);
            Console.WriteLine("\t\tCategory added");

        }
        //удаление товара
        public bool RemoveGood(string good_name)
        {
            var to_remove = GetGoodsList().Where(c => c.Attribute("name").Value == good_name).FirstOrDefault();

            if (to_remove != default)
            {
                to_remove.Remove();
                _docGood.Save(_filePathGoods);
                return true;
            }
            return false;

        }

        //выборка товаров по производителю
        public List<System.Xml.Linq.XElement> ListGoodsByProducer(string producer)
        {
            if (GetGoodsList().Exists(x => x.Attribute("producer").Value.Contains(producer)))
                return GetGoodsList().Where(p => p.Attribute("producer").Value.Contains(producer)).ToList();

            return null;
        }

        public void PrintGoodsByProducer(string producer)
        {
            if (ListGoodsByProducer(producer) != null)
                foreach (var item in ListGoodsByProducer(producer))
                    Console.WriteLine($"{item.Attribute("id").Value}.{item.Attribute("name").Value} {item.Attribute("producer").Value} {item.Attribute("price").Value} {GetCategoriesList().First(x => x.Attribute("id").Value == item.Attribute("cid").Value).Attribute("name").Value }");
        }

        //выборка товаров по цене
        public List<System.Xml.Linq.XElement> ListGoodsByPrice(double down_price, double up_price = default)
        {
            if (up_price == default)
                up_price = down_price;

            SortedList<string, double> prices = new SortedList<string, double>();
            GetGoodsList().ForEach(x => prices.Add(x.Attribute("id").Value, double.Parse(x.Attribute("price").Value)));
            List<string> ids = prices.Where(v => v.Value >= down_price && v.Value <= up_price).Select(v => v.Key).ToList();

            if (ids.Count > 0)
                return GetGoodsList().Where(p => ids.Contains(p.Attribute("id").Value)).ToList();

            return null;
        }
        public void PrintGoodsByPrice(double down_price, double up_price = default)
        {
            if (ListGoodsByPrice(down_price, up_price) != null)
                foreach (var item in ListGoodsByPrice(down_price, up_price))
                    Console.WriteLine($"{item.Attribute("id").Value}.{item.Attribute("name").Value} {item.Attribute("producer").Value} {item.Attribute("price").Value} {GetCategoriesList().First(x => x.Attribute("id").Value == item.Attribute("cid").Value).Attribute("name").Value }");
        }

        //поиск товара по наименованию.
        public List<System.Xml.Linq.XElement> ListGoodsByName(string goodName)
        {
            if (GetGoodsList().Exists(x => x.Attribute("name").Value.Contains(goodName)))
                return GetGoodsList().Where(p => p.Attribute("name").Value.Contains(goodName)).ToList();

            return null;
        }

        public void SearchByGoodName(string goodName)
        {
            if (ListGoodsByName(goodName) != null)
                foreach (var item in ListGoodsByName(goodName))
                    Console.WriteLine($"{item.Attribute("id").Value}.{item.Attribute("name").Value} {item.Attribute("producer").Value} {item.Attribute("price").Value} {GetCategoriesList().First(x => x.Attribute("id").Value == item.Attribute("cid").Value).Attribute("name").Value }");
        }

        
    }
}
