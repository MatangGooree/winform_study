using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxNine.Lib.WS;
using System.IO;
using Store;
using Grid;
using System.Xml;
using MaxNine.Forms;
using System.Collections.ObjectModel;

namespace Main
{
    public partial class Form1 : Form
    {//
        public Grid.Grid inven_Grid { get; set; }
        public Grid.Grid store_inven_Grid { get; set; }
        public Grid.Grid store_now_Grid { get; set; }
        public Grid.Grid release_inven_Grid { get; set; }
        public Grid.Grid release_now_Grid { get; set; }
        public List<StringGrid> Whole_grids { get; set; } = new List<StringGrid>();
        public ObservableCollection<StringRow> Whole_rows { get; set; } = new ObservableCollection<StringRow>();

        delegate void UpdateAll();
        UpdateAll update;
        delegate void Edit_row(StringRow row, string name, string brand, string price, string count, string number);


        private Point mousePoint;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Edit_data.Xml_to_rows(Whole_rows);
            this.inven_Grid = new Grid.Grid(Grid_inven, Whole_rows, Grid_inven_pages, this, 10);
            this.store_inven_Grid = new Grid.Grid(Grid_store_inven, Whole_rows, Grid_store_inven_pages, this, 6);
            this.store_now_Grid = new Grid.Grid(Grid_store_now, Grid_store_now_pages, this, 6);
            this.release_inven_Grid = new Grid.Grid(Grid_release_inven, Whole_rows, Grid_release_inven_pages, this, 6);
            this.release_now_Grid = new Grid.Grid(Grid_release_now, Grid_release_now_pages, this, 6);


            Refresh_all();

            Select_search.SelectedIndex = 0;
            Store_combo.SelectedIndex = 0;
            Release_combo.SelectedIndex = 0;


            //대리자 메서드 체인
            update += new UpdateAll(inven_Grid.Update_grid);
            update += new UpdateAll(release_inven_Grid.Update_grid);
            update += new UpdateAll(store_inven_Grid.Update_grid);
            update += new UpdateAll(inven_Grid.Update_row);
            update += new UpdateAll(release_inven_Grid.Update_row);
            update += new UpdateAll(store_inven_Grid.Update_row);

            Whole_rows.CollectionChanged += (ss, ee) =>
              {
                  update();
              };
      
        }
        //-------------------------------로드--------------------------------------------//



        //-------------------------------함수--------------------------------------------//
        //모든 그리드 초기화
        private void Refresh_all()
        {
            inven_Grid.Print_grid(0);

            store_inven_Grid.Print_grid(0);

            release_inven_Grid.Print_grid(0);
        }


        //-------------------------------이벤트--------------------------------------------//
        //재고관리 탭 버튼
        private void Manage_tap_Click(object sender, EventArgs e)
        {
            Store_panel.Visible = false;
            Inven_mng_panel.Visible = true;
            Release_panel.Visible = false;
        }

        //입고관리 탭 버튼
        private void Store_tap_Click(object sender, EventArgs e)
        {
            Store_panel.Visible = true;
            Inven_mng_panel.Visible = false;
            Release_panel.Visible = false;
        }

        //출고관리 탭 버튼
        private void Release_tap_Click(object sender, EventArgs e)
        {
            Store_panel.Visible = false;
            Inven_mng_panel.Visible = false;
            Release_panel.Visible = true;
        }

        //재고관리 검색 버튼
        private void Store_shearch_btn_Click(object sender, EventArgs e)
        {
            //엔터 기능 추가
            inven_Grid.Search_item(Select_search.Text, Inven_search_box.Text);
        }

        //입고관리 검색 버튼
        private void Store_search_btn_Click(object sender, EventArgs e)
        {
            store_inven_Grid.Search_item(Store_combo.Text, Store_search_text.Text);
        }

        //출고관리 검색 버튼
        private void Release_search_btn_Click(object sender, EventArgs e)
        {
            release_inven_Grid.Search_item(Release_combo.Text, Release_search_text.Text);
        }

        //입고 버튼
        private void Store_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if(!int.TryParse(Count_to_store_combo.Text, out i))
            {
                MessageBox.Show("숫자만 입력하세요");
                Count_to_store_combo.Text = "1";
                return;
            }

            Store.Edit_data store = new Store.Edit_data(Grid_store_inven, Whole_rows);
            store_now_Grid.Add_row(Grid_store_inven.SelectedRow, Count_to_store_combo.Text, "STORE");
            store.Store_Release("STORE", Count_to_store_combo.Text);
        }

        //출고 버튼
        private void Release_btn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (!int.TryParse(Count_to_release_combo.Text, out i))
            {
                MessageBox.Show("숫자만 입력하세요");
                Count_to_release_combo.Text = "1";
                return;
            }

            Store.Edit_data store = new Store.Edit_data(Grid_release_inven, Whole_rows);

            release_now_Grid.Add_row(Grid_release_inven.SelectedRow, Count_to_release_combo.Text, "RELEASE");

            store.Store_Release("RELEASE", Count_to_release_combo.Text);
        }

        //상단 바 누르기
        private void Top_bar_MouseDown(object sender, MouseEventArgs e)
        {
            {
                mousePoint = new Point(e.X, e.Y); //현재 마우스 좌표 저장
            }
        }

        //드래그
        private void Top_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
            {
                //폼의 위치를 드래그중인 마우스의 좌표로 이동 
                this.Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }

        //닫기버튼
        private void Form_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //엑셀,CSV 저장
        private void Inven_print_excel_Click(object sender, EventArgs e)
        {
            Edit_data.Save_as_CSV(inven_Grid.My_rows);
            Edit_data.Save_as_Excel(inven_Grid.My_rows);
        }

        private void Store_print_excel_Click(object sender, EventArgs e)
        {
            Edit_data.Save_as_CSV(store_inven_Grid.My_rows);
            Edit_data.Save_as_Excel(store_inven_Grid.My_rows);
        }

        private void Release_print_excel_Click(object sender, EventArgs e)
        {
            Edit_data.Save_as_CSV(release_inven_Grid.My_rows);
            Edit_data.Save_as_Excel(release_inven_Grid.My_rows);
        }

        //셀 더블클릭으로 수정 창 띄우기
        private void Grid_inven_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_panel.Visible = true;
            

            Edit_name.Text = Grid_inven.SelectedRow["NAME"];
            Edit_brand.Text = Grid_inven.SelectedRow["BRAND"];
            Edit_price.Text = Grid_inven.SelectedRow["PRICE"];
            Edit_count.Text = Grid_inven.SelectedRow["COUNT"];
            Edit_number.Text = Grid_inven.SelectedRow["NUMBER"];
            
        }

        //수정 창 닫기
        private void mxImgLabel1_Click(object sender, EventArgs e)
        {
            Edit_panel.Visible = false;
        }

        //수정 버튼
        private void mxImgButton1_Click(object sender, EventArgs e)
        {
            string count = "";
            count= Edit_count.Text.Replace(",", "");
            string price = "";
            price= Edit_price.Text.Replace(",","");

            int c = 0;

            if (!int.TryParse(count, out c))
            {
                MessageBox.Show("갯수는 숫자만 입력하세요");
                return;
            }

            int p = 0;
            if (!int.TryParse(price, out p))
            {
                MessageBox.Show("가격은 숫자만 입력하세요");
                return;
            }

            Store.Edit_data e_d = new Store.Edit_data(Grid_inven,Whole_rows);

            Edit_row edit_row = new Edit_row(e_d.Edit_xml);

            edit_row(Grid_inven.SelectedRow,  Edit_name.Text, Edit_brand.Text, string.Format("{0:N0}", p), string.Format("{0:N0}", c), Edit_number.Text);
            
        }
    }
}
