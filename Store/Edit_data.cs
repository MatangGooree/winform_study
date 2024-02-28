using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxNine.Lib.WS;
using System.IO;
using System.Collections.ObjectModel;
using System.Xml;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Store
{
    public class Edit_data
    {
        private StringGrid grid_now;
        private ObservableCollection<StringRow> Whole_rows = new ObservableCollection<StringRow>();


        //생성자
        public Edit_data(StringGrid g_now, ObservableCollection<StringRow> w_r)
        {
            this.grid_now = g_now;
            this.Whole_rows = w_r;
        }

        //xml불러와 whole_rows 에 저장
        public static void Xml_to_rows(ObservableCollection<StringRow> w_r)
        {

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"c:\users\administrator\documents\visual studio 2015\Projects\Inventory_mng\My_items.xml");
            XmlNodeList nodes = xdoc.SelectNodes("/root/item");

            StringGrid new_grid = new StringGrid();


            new_grid.AutoGenerateColumns = false;
            DataLayout layout = new DataLayout();

            string styleFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                          "Style\\Inven_Grid_Style.xml");

            new_grid.ReadStyleXml(styleFilePath);

            string layoutFilePath =
            Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                               "Layout\\Inven_Grid_Layout.layout");

            new_grid.SetLayout(new DataLayout().OpenFile(layoutFilePath));
            
            new_grid.AutoGenerateColumns = false;


            w_r.Clear();

            new_grid.EditBegin();

            Random random = new Random();

            int count = 1;
            foreach (XmlNode item in nodes)
            {
                StringRow row = new_grid.NewRow();
                row["SERIAL"] =item.SelectSingleNode("serial").InnerText;
                row["INDEX"] = count.ToString();

                row["NAME"] = item.SelectSingleNode("name").InnerText;
                row["PRICE"] = item.SelectSingleNode("price").InnerText;
                row["BRAND"] = item.SelectSingleNode("brand").InnerText;
                row["COUNT"] = item.SelectSingleNode("count").InnerText;
                row["NUMBER"] = item.SelectSingleNode("number").InnerText;
                row["STORE"] = item.SelectSingleNode("store").InnerText;
                row["RELEASE"] = item.SelectSingleNode("release").InnerText;
                
                w_r.Add(row);
                count++;
            }
            new_grid.EditOk();
            
        }

        //입,출고 
        public void Store_Release(string oper,string count)
        {

            //Xml파일 수정
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"c:\users\administrator\documents\visual studio 2015\Projects\Inventory_mng\My_items.xml");
            XmlNodeList nodes = xdoc.SelectNodes("/root/item");


            var node = from XmlNode n in nodes
                       where n["serial"].InnerText == grid_now.SelectedRow["SERIAL"]
                       select n;

            if (oper == "STORE")
            {
                foreach (XmlNode n in node)
                {
                    n["count"].InnerText = (int.Parse(grid_now.SelectedRow["COUNT"]) + int.Parse(count)).ToString();
                    n["store"].InnerText = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                }
            }
            else if (oper == "RELEASE")
            {
                if ((int.Parse(grid_now.SelectedRow["COUNT"]) - int.Parse(count)) >= 0)
                {
                    foreach (XmlNode n in node)
                    {
                        n["count"].InnerText = (int.Parse(grid_now.SelectedRow["COUNT"]) - int.Parse(count)).ToString();
                        n["release"].InnerText = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    }
                }
            }
            xdoc.Save(@"c:\users\administrator\documents\visual studio 2015\Projects\Inventory_mng\My_items.xml");

            Xml_to_rows(Whole_rows);
        }

        //로우 자체 수정
        public void Edit_xml(StringRow row, string name, string brand, string price, string count, string number)
        {

            //로우를 가져와 입력받은 데이터로 모두 수정한 뒤 다시 xml로 저장, Xml_to_rows 
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@"c:\users\administrator\documents\visual studio 2015\Projects\Inventory_mng\My_items.xml");
            XmlNodeList nodes = xdoc.SelectNodes("/root/item");

            var target = from XmlNode n in nodes
                         where n["number"].InnerText == row["NUMBER"]
                         select n;


            foreach (XmlNode node in target)
            {
                node["name"].InnerText = name;
                node["brand"].InnerText = brand;
                node["price"].InnerText = price;
                node["count"].InnerText = count;
                node["number"].InnerText = number;
            }

            xdoc.Save(@"c:\users\administrator\documents\visual studio 2015\Projects\Inventory_mng\My_items.xml");

            Xml_to_rows(Whole_rows);

        }

        //그리드 내용 CSV 출력
        public static void Save_as_CSV(ObservableCollection<StringRow> list)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Inventory_mng\test.csv"))
            {
                //헤더
                string header = "NAME , BRAND , PRICE , COUNT , NUMBER , STORE , RELEASE";
                file.WriteLine(header + "\n");

                //본문
                string content = "";
                foreach (var row in list)
                {
                    string[] temp = { row["NAME"], row["BRAND"], row["PRICE"], row["COUNT"], row["NUMBER"], row["STORE"], row["RELEASE"] };
                    content += String.Join(" , ", temp) + "\n";
                }

                file.Write(content);

            }

        }

        //그리드 내용 excel 출력
        public static void Save_as_Excel(ObservableCollection<StringRow> list)
        {
            Excel.Application application ;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;


            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "xlsx files|*.xlsx";
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            application = new Excel.Application();
            application.Visible = true;

            workbook = application.Workbooks.Add();
            //특정 경로에 엑셀 파일로 저장
    


            worksheet = workbook.Worksheets.get_Item(1);

            worksheet.Cells[1, 1] = "INDEX";
            worksheet.Cells[1, 2] = "NAME";
            worksheet.Cells[1, 3] = "BRAND";
            worksheet.Cells[1, 4] = "PRICE";
            worksheet.Cells[1, 5] = "COUNT";
            worksheet.Cells[1, 6] = "NUMBER";
            worksheet.Cells[1, 7] = "STORE";
            worksheet.Cells[1, 8] = "RELEASE";

            for (int i = 0; i < list.Count; i++)
            {
                for (int k = 0; k < list.Count; k++)
                {
                    worksheet.Cells[i + 2, k + 1] = list[i][k].ToString();
                }
                
            }

            workbook.SaveAs(dlg.FileName, Excel.XlFileFormat.xlWorkbookDefault);
            workbook.Close(true);
            application.Quit();

            ReleaseObject(worksheet);
            ReleaseObject(workbook);
            ReleaseObject(application);
        }

        static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);  // 액셀 객체 해제
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();   // 가비지 수집
            }
        }
    }
}
