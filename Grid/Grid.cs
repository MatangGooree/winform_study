using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxNine.Lib.WS;
using System.IO;
using System.Windows.Forms;
using MaxNine.Forms;
using System.Drawing;
using System.Xml;
using System.Collections.ObjectModel;

namespace Grid
{
    public class Grid
    {
        public StringGrid Grid_ { get; set; }
        public MaxNine.Forms.mxImgPanel Panel { get; set; }
        public Form Form { get; set; }
        public int Max_row { get; set; }
        public ObservableCollection<StringRow> Whole_rows { get; set; }
        public ObservableCollection<StringRow> My_rows { get; set; } = new ObservableCollection<StringRow>();
        public int Page_count
        {
            get { return (int)Math.Ceiling((double)My_rows.Count / Max_row); }

        }

        //기본 생성자
        public Grid(StringGrid grid, ObservableCollection<StringRow> W_r, MaxNine.Forms.mxImgPanel panel, Form form, int max_row)
        {
            this.Whole_rows = W_r;
            foreach (StringRow r in W_r)
            {
                My_rows.Add(r);
            }

            //foreach (StringRow r in W_r)
            //{
            //    My_rows.Add(r);
            //}

            this.Panel = panel;
            this.Form = form;
            this.Max_row = max_row;
            this.Grid_ = grid;
            Load_Grid_Layout();
            Print_grid(0);
           
        }

        //현황 그리드 생성자
        public Grid(StringGrid grid, MaxNine.Forms.mxImgPanel panel, Form form, int max_row)
        {
            this.Panel = panel;
            this.Form = form;
            this.Max_row = max_row;
            this.Grid_ = grid;
            Load_Grid_Layout();
        }

        //그리드 레이아웃 로드
        private void Load_Grid_Layout()
        {
            Grid_.AutoGenerateColumns = false;
            DataLayout layout = new DataLayout();

            string styleFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                          "Style\\Inven_Grid_Style.xml");

            Grid_.ReadStyleXml(styleFilePath);

            string layoutFilePath =
            Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                               "Layout\\Inven_Grid_Layout.layout");

            Grid_.SetLayout(new DataLayout().OpenFile(layoutFilePath));

            Grid_.AutoGenerateColumns = false;
        }

        // 마이 리스트를 그리드에 출력
        public void Print_grid(int from)
        {
            //row 청소
            Grid_.EditBegin();
            for (int i = 0; i < Grid_.RowCount; i++)
            {
                Grid_.DeleteRow(i);
            }
            Grid_.EditOk();

            //최대 페이지 보다 row가 적을 때 설정
            int to = Max_row;
            if (My_rows.Count - 1 - from < Max_row)
            {
                to = My_rows.Count - from;
            }

            //출력
            Grid_.EditBegin();
            for (int i = from; i < from + to; i++)
            {
                Grid_.AddRow(My_rows[i]);
            }
            Grid_.EditOk();
            Load_page_panel();         
        }

        //리스트에서 검색 완료 후 다시 리스트로 반환
        public void Search_item(string combo, string s)
        {
            string category = string.Empty;
            My_rows.Clear();
            //콤보박스 내용 따라 카테고리 설정 - 추후 enum으로 시도
            switch (combo)
            {
                case "제품명":
                    category = "NAME";
                    break;
                case "제품번호":
                    category = "NUMBER";
                    break;
            }
            //찾기
            if (combo == "전체")
            {
                var searched = from item in Whole_rows
                               where item["NAME"].Contains(s) ||
                               item["BRAND"].Contains(s) ||
                               item["NUMBER"].Contains(s)
                               select item;

                foreach (var item in searched)
                {
                    My_rows.Add(item);
                }
            }
            else
            {
                var searched = from item in Whole_rows
                               where item[category].Contains(s)
                               select item;

                foreach (var item in searched)
                {
                    My_rows.Add(item);
                }
            }
            Print_grid(0);
        }

        //페이지 패널에 라벨 업데이트
        public void Load_page_panel()
        {
            //row 페이지 출력 - 전체 로드 혹은 검색했을때만 작동하면 됨

            Panel.Controls.Clear();

            //버튼 추가
            for (int k = 1; k <= Page_count; k++)
            {
                MaxNine.Forms.mxImgLabel page = new MaxNine.Forms.mxImgLabel();

                page.Dock = System.Windows.Forms.DockStyle.Right;
                page.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
                page.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
                page.ImageCount = 4;
                page.ImageInFontInfo = true;
                page.ImagePos = 0;
                page.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
                page.Location = new System.Drawing.Point(18, 0);
                page.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
                page.Size = new System.Drawing.Size(21, 24);
                page.StyleCount = 1;
                page.StyleNum = 0;
                page.TabIndex = 14;
                page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                page.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
                page.TextSubVOffset = 0;
                page.WordWrap = false;
                page.Text = k.ToString();
                page.Name = $"{k}";
                page.Image = global::Grid.Properties.Resource.label_etc;


                Panel.Left = (Form.Width - Panel.Width) / 2;
                Panel.Controls.Add(page);
            }

            //이벤트 추가
            foreach (mxImgLabel item in Panel.Controls)
            {
                item.MouseClick += (sender, e) => Print_grid((int.Parse(item.Name) - 1) * Max_row);
            }
        }

        //row 한줄 추가(입고 출고관리에만 사용될 듯)
        public void Add_row(StringRow row, string count, string oper)
        {

            if (int.Parse(row["COUNT"]) - int.Parse(count) < 0)
            {
                MessageBox.Show("출고 할 재고가 부족합니다");
                return;
            }

            My_rows.Add(row);

            for (int i = 0; i < Grid_.RowCount; i++)
            {
                if (Grid_.GetRow(i)["NUMBER"] == row["NUMBER"])
                {
                    Grid_.EditBegin();
                    StringRow new_row = Grid_.GetRow(i);
                    new_row["COUNT"] = (int.Parse(count) + int.Parse(new_row["COUNT"])).ToString();
                    new_row[oper] = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
                    Grid_.UpdateRow(i, new_row);
                    Grid_.EditOk();
                    return;
                }
            }

            row["INDEX"] = (Grid_.RowCount + 1).ToString();
            row["COUNT"] = count;
            row[oper] = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            Grid_.EditBegin();
            Grid_.AddRow(row);
            Grid_.EditOk();

            //페이지 로드
            if (Grid_.RowCount > Max_row)
            {
                Load_page_panel();
            }
        }

        //whole_rows와 My_list를 비교하여 변동사항을 My_List에 반영 후 다시 프린트 
        //혹은 해당 로우만 변경
        public void Update_grid()
        {
            
            var changed = from m_row in My_rows
                          from w_row in Whole_rows
                          where m_row["SERIAL"] == w_row["SERIAL"] && (
                          m_row["NUMBER"] != w_row["NUMBER"] ||
                          m_row["COUNT"] != w_row["COUNT"] ||
                          m_row["PRICE"] != w_row["PRICE"] ||
                          m_row["BRAND"] != w_row["BRAND"] ||
                          m_row["NAME"] != w_row["NAME"])
                          select w_row;

            System.Diagnostics.Debug.WriteLine(changed.Count());

            //마이로우 리스트를 바꾸고, 그리드의 해당 로우를 업데이트

            //마이로우 리스트 업데이트

            if (changed.Count() > 0)
            {
              
                //그리드 업데이트
                Grid_.EditBegin();
                foreach (var item in changed)
                {

                    for (int i = 0; i < Grid_.RowCount; i++)
                    {
                        if (Grid_.GetRow(i)["SERIAL"] == item["SERIAL"])
                        {
                            Grid_.UpdateRow(i, item);
                        }
                    }
                }

                Grid_.EditOk();

                //처음 값이 My_rows에 담겨있기 때문에 처음 값으로 변경을 시도하면 같은 값으로 인식함
                //변경 때 마다 값을 My_rows를 변경해주면 My_rows는 얕은 복사이므로 처음 변경값을 적용 후 같은값으로 인식함



                //foreach (var item in changed)
                //{
                //    for (int i = 0; i < My_rows.Count; i++)
                //    {
                //        if (My_rows[i]["SERIAL"] == item["SERIAL"])
                //        {
                //            My_rows[i]["NUMBER"] = item["NUMBER"].ToString();
                //            My_rows[i]["NAME"] = item["NAME"].ToString();
                //            My_rows[i]["BRAND"] = item["BRAND"].ToString();
                //            My_rows[i]["PRICE"] = item["PRICE"].ToString();
                //            My_rows[i]["COUNT"] = item["COUNT"].ToString();
                //            //My_rows.Add(item);
                //        }
                //    }
                //}

            }


        }

        public void Update_row()
        {

            var changed = from m_row in My_rows
                          from w_row in Whole_rows
                          where m_row["SERIAL"] == w_row["SERIAL"] && (
                          m_row["NUMBER"] != w_row["NUMBER"] ||
                          m_row["COUNT"] != w_row["COUNT"] ||
                          m_row["PRICE"] != w_row["PRICE"] ||
                          m_row["BRAND"] != w_row["BRAND"] ||
                          m_row["NAME"] != w_row["NAME"])
                          select w_row;

            System.Diagnostics.Debug.WriteLine(changed.Count());

            //마이로우 리스트를 바꾸고, 그리드의 해당 로우를 업데이트

            //마이로우 리스트 업데이트

            if (changed.Count() > 0)
            {

                foreach (var item in changed)
                {
                    for (int i = 0; i < My_rows.Count; i++)
                    {
                        if (My_rows[i]["SERIAL"] == item["SERIAL"])
                        {
                            My_rows[i]["NUMBER"] = item["NUMBER"].ToString();
                            My_rows[i]["NAME"] = item["NAME"].ToString();
                            My_rows[i]["BRAND"] = item["BRAND"].ToString();
                            My_rows[i]["PRICE"] = item["PRICE"].ToString();
                            My_rows[i]["COUNT"] = item["COUNT"].ToString();
                        }
                    }
                }

            }


        }
    }
}
