using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Search
{
    public class Search
    {
        

        public Search()
        {
            //my_items= getMyXml();
        }

        //내 재고 리스트 받아오기
        //public static List<Dictionary<string, string>> getMyXml()
        //{
        //    List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

        //    XmlDocument xdoc = new XmlDocument();
        //    xdoc.Load(@"c:\users\administrator\documents\visual studio 2015\Projects\Inventory_mng\My_items.xml");
        //    XmlNodeList nodes = xdoc.SelectNodes("/root/item");

        //    foreach (XmlNode item in nodes)
        //    {
        //        list.Add(new Dictionary<string, string> {
        //            { "name", item.SelectSingleNode("name").InnerText },
        //            { "brand", item.SelectSingleNode("brand").InnerText },
        //            { "price", item.SelectSingleNode("price").InnerText },
        //            { "number", item.SelectSingleNode("number").InnerText },
        //            { "count", item.SelectSingleNode("count").InnerText },
        //            { "store", item.SelectSingleNode("store").InnerText },
        //            { "release", item.SelectSingleNode("release").InnerText }
        //        });
        //    }
        //    return list;
        //}

        //내 리스트에서 찾기
        public List<Dictionary<string, string>> Search_item(List<Dictionary<string, string>> my_items,string combo, string s)
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            string category = string.Empty;

            //콤보박스 내용 따라 카테고리 설정 - 추후 enum으로 시도
            switch (combo)
            {
                case "제품명":
                    category = "name";
                    break;
                case "제품번호":
                    category = "number";
                    break;
            }

            //찾기
            if (combo == "전체")
            {
                var searched = from item in my_items
                               where item["name"].Contains(s) ||
                               item["brand"].Contains(s) ||
                               item["number"].Contains(s)
                               select item;

                foreach (var item in searched)
                {
                    result.Add(item);
                }
            }
            else
            {
                var searched = from item in my_items
                               where item[category].Contains(s)
                               select item;

                foreach (var item in searched)
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}
