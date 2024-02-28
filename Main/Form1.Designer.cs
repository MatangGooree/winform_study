namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackGround = new MaxNine.Forms.mxImgPanel(this.components);
            this.Top_bar = new MaxNine.Forms.mxImgPanel(this.components);
            this.Form_setting = new MaxNine.Forms.mxImgLabel(this.components);
            this.Form_Mini = new MaxNine.Forms.mxImgLabel(this.components);
            this.Form_Maxi = new MaxNine.Forms.mxImgLabel(this.components);
            this.Form_Close = new MaxNine.Forms.mxImgLabel(this.components);
            this.Release_tap = new MaxNine.Forms.mxImgButton(this.components);
            this.Store_tap = new MaxNine.Forms.mxImgButton(this.components);
            this.Manage_tap = new MaxNine.Forms.mxImgButton(this.components);
            this.Inven_mng_panel = new MaxNine.Forms.mxImgPanel(this.components);
            this.Edit_panel = new MaxNine.Forms.mxImgPanel(this.components);
            this.mxImgLabel1 = new MaxNine.Forms.mxImgLabel(this.components);
            this.mxImgButton1 = new MaxNine.Forms.mxImgButton(this.components);
            this.Edit_count = new MaxNine.Forms.mxComboBox(this.components);
            this.Edit_number = new MaxNine.Forms.mxTextBox(this.components);
            this.Edit_price = new MaxNine.Forms.mxTextBox(this.components);
            this.Edit_brand = new MaxNine.Forms.mxTextBox(this.components);
            this.Edit_name = new MaxNine.Forms.mxTextBox(this.components);
            this.Inven_print_excel = new MaxNine.Forms.mxImgButton(this.components);
            this.Grid_inven_pages = new MaxNine.Forms.mxImgPanel(this.components);
            this.Select_search = new MaxNine.Forms.mxComboBox(this.components);
            this.Store_shearch_btn = new MaxNine.Forms.mxImgButton(this.components);
            this.Inven_search_box = new MaxNine.Forms.mxTextBox(this.components);
            this.Grid_inven = new MaxNine.Lib.WS.StringGrid(this.components);
            this.Store_panel = new MaxNine.Forms.mxImgPanel(this.components);
            this.Store_print_excel = new MaxNine.Forms.mxImgButton(this.components);
            this.Grid_store_now_pages = new MaxNine.Forms.mxImgPanel(this.components);
            this.Grid_store_inven_pages = new MaxNine.Forms.mxImgPanel(this.components);
            this.Grid_store_now = new MaxNine.Lib.WS.StringGrid(this.components);
            this.Store_combo = new MaxNine.Forms.mxComboBox(this.components);
            this.Store_search_btn = new MaxNine.Forms.mxImgButton(this.components);
            this.Store_search_text = new MaxNine.Forms.mxTextBox(this.components);
            this.Count_to_store_combo = new MaxNine.Forms.mxComboBox(this.components);
            this.Store_btn = new MaxNine.Forms.mxImgButton(this.components);
            this.Grid_store_inven = new MaxNine.Lib.WS.StringGrid(this.components);
            this.Release_panel = new MaxNine.Forms.mxImgPanel(this.components);
            this.Release_print_excel = new MaxNine.Forms.mxImgButton(this.components);
            this.Grid_release_now_pages = new MaxNine.Forms.mxImgPanel(this.components);
            this.Grid_release_inven_pages = new MaxNine.Forms.mxImgPanel(this.components);
            this.Grid_release_now = new MaxNine.Lib.WS.StringGrid(this.components);
            this.Release_combo = new MaxNine.Forms.mxComboBox(this.components);
            this.Release_search_btn = new MaxNine.Forms.mxImgButton(this.components);
            this.Release_search_text = new MaxNine.Forms.mxTextBox(this.components);
            this.Count_to_release_combo = new MaxNine.Forms.mxComboBox(this.components);
            this.Release_btn = new MaxNine.Forms.mxImgButton(this.components);
            this.Grid_release_inven = new MaxNine.Lib.WS.StringGrid(this.components);
            this.BackGround.SuspendLayout();
            this.Top_bar.SuspendLayout();
            this.Inven_mng_panel.SuspendLayout();
            this.Edit_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_inven)).BeginInit();
            this.Store_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_store_now)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_store_inven)).BeginInit();
            this.Release_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_release_now)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_release_inven)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Controls.Add(this.Top_bar);
            this.BackGround.Controls.Add(this.Release_tap);
            this.BackGround.Controls.Add(this.Store_tap);
            this.BackGround.Controls.Add(this.Manage_tap);
            this.BackGround.Controls.Add(this.Inven_mng_panel);
            this.BackGround.Controls.Add(this.Store_panel);
            this.BackGround.Controls.Add(this.Release_panel);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Image = global::Main.Properties.Resources.back;
            this.BackGround.ImageCount = 4;
            this.BackGround.ImageHScroll = null;
            this.BackGround.ImageInFontInfo = false;
            this.BackGround.ImagePos = 0;
            this.BackGround.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.BackGround.ImageVScroll = null;
            this.BackGround.LineBottom = false;
            this.BackGround.LineColor = System.Drawing.Color.Black;
            this.BackGround.LineLeft = false;
            this.BackGround.LineRight = false;
            this.BackGround.LineTop = false;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackGround.Name = "BackGround";
            this.BackGround.ShadowColor = System.Drawing.Color.White;
            this.BackGround.Size = new System.Drawing.Size(1224, 589);
            this.BackGround.StyleCount = 1;
            this.BackGround.StyleNum = 0;
            this.BackGround.TabIndex = 0;
            this.BackGround.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.BackGround.VScrollImageDown = null;
            this.BackGround.VScrollImageUp = null;
            this.BackGround.VScrollShowUpDown = false;
            // 
            // Top_bar
            // 
            this.Top_bar.Controls.Add(this.Form_setting);
            this.Top_bar.Controls.Add(this.Form_Mini);
            this.Top_bar.Controls.Add(this.Form_Maxi);
            this.Top_bar.Controls.Add(this.Form_Close);
            this.Top_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Top_bar.Image = global::Main.Properties.Resources.back;
            this.Top_bar.ImageCount = 4;
            this.Top_bar.ImageHScroll = null;
            this.Top_bar.ImageInFontInfo = true;
            this.Top_bar.ImagePos = 0;
            this.Top_bar.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Top_bar.ImageVScroll = null;
            this.Top_bar.LineBottom = false;
            this.Top_bar.LineColor = System.Drawing.Color.Black;
            this.Top_bar.LineLeft = false;
            this.Top_bar.LineRight = false;
            this.Top_bar.LineTop = false;
            this.Top_bar.Location = new System.Drawing.Point(0, 0);
            this.Top_bar.Name = "Top_bar";
            this.Top_bar.Padding = new System.Windows.Forms.Padding(1);
            this.Top_bar.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Top_bar.Size = new System.Drawing.Size(1224, 24);
            this.Top_bar.StyleCount = 1;
            this.Top_bar.StyleNum = 0;
            this.Top_bar.TabIndex = 4;
            this.Top_bar.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Top_bar.VScrollImageDown = null;
            this.Top_bar.VScrollImageUp = null;
            this.Top_bar.VScrollShowUpDown = false;
            this.Top_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_bar_MouseDown);
            this.Top_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_bar_MouseMove);
            // 
            // Form_setting
            // 
            this.Form_setting.Dock = System.Windows.Forms.DockStyle.Left;
            this.Form_setting.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Form_setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_setting.Image = global::Main.Properties.Resources.top_icon_setting;
            this.Form_setting.ImageCount = 4;
            this.Form_setting.ImageInFontInfo = true;
            this.Form_setting.ImagePos = 0;
            this.Form_setting.ImageSplitType = MaxNine.Forms.mxImgSplitType.SplitNo;
            this.Form_setting.Location = new System.Drawing.Point(1, 1);
            this.Form_setting.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.Form_setting.Name = "Form_setting";
            this.Form_setting.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_setting.Size = new System.Drawing.Size(25, 22);
            this.Form_setting.StyleCount = 1;
            this.Form_setting.StyleNum = 0;
            this.Form_setting.TabIndex = 3;
            this.Form_setting.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Form_setting.TextSub = "";
            this.Form_setting.TextSubVOffset = 0;
            this.Form_setting.WordWrap = false;
            // 
            // Form_Mini
            // 
            this.Form_Mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.Form_Mini.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Form_Mini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_Mini.Image = global::Main.Properties.Resources.top_icon_mini;
            this.Form_Mini.ImageCount = 4;
            this.Form_Mini.ImageInFontInfo = true;
            this.Form_Mini.ImagePos = 0;
            this.Form_Mini.ImageSplitType = MaxNine.Forms.mxImgSplitType.SplitNo;
            this.Form_Mini.Location = new System.Drawing.Point(1148, 1);
            this.Form_Mini.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.Form_Mini.Name = "Form_Mini";
            this.Form_Mini.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_Mini.Size = new System.Drawing.Size(25, 22);
            this.Form_Mini.StyleCount = 1;
            this.Form_Mini.StyleNum = 0;
            this.Form_Mini.TabIndex = 2;
            this.Form_Mini.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Form_Mini.TextSub = "";
            this.Form_Mini.TextSubVOffset = 0;
            this.Form_Mini.WordWrap = false;
            // 
            // Form_Maxi
            // 
            this.Form_Maxi.Dock = System.Windows.Forms.DockStyle.Right;
            this.Form_Maxi.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Form_Maxi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_Maxi.Image = global::Main.Properties.Resources.top_icon_maxi;
            this.Form_Maxi.ImageCount = 4;
            this.Form_Maxi.ImageInFontInfo = true;
            this.Form_Maxi.ImagePos = 0;
            this.Form_Maxi.ImageSplitType = MaxNine.Forms.mxImgSplitType.SplitNo;
            this.Form_Maxi.Location = new System.Drawing.Point(1173, 1);
            this.Form_Maxi.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.Form_Maxi.Name = "Form_Maxi";
            this.Form_Maxi.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_Maxi.Size = new System.Drawing.Size(25, 22);
            this.Form_Maxi.StyleCount = 1;
            this.Form_Maxi.StyleNum = 0;
            this.Form_Maxi.TabIndex = 1;
            this.Form_Maxi.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Form_Maxi.TextSub = "";
            this.Form_Maxi.TextSubVOffset = 0;
            this.Form_Maxi.WordWrap = false;
            // 
            // Form_Close
            // 
            this.Form_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Form_Close.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Form_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_Close.Image = global::Main.Properties.Resources.top_icon_close;
            this.Form_Close.ImageCount = 4;
            this.Form_Close.ImageInFontInfo = true;
            this.Form_Close.ImagePos = 0;
            this.Form_Close.ImageSplitType = MaxNine.Forms.mxImgSplitType.SplitNo;
            this.Form_Close.Location = new System.Drawing.Point(1198, 1);
            this.Form_Close.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.Form_Close.Name = "Form_Close";
            this.Form_Close.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Form_Close.Size = new System.Drawing.Size(25, 22);
            this.Form_Close.StyleCount = 1;
            this.Form_Close.StyleNum = 0;
            this.Form_Close.TabIndex = 0;
            this.Form_Close.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Form_Close.TextSub = "";
            this.Form_Close.TextSubVOffset = 0;
            this.Form_Close.WordWrap = false;
            this.Form_Close.Click += new System.EventHandler(this.Form_Close_Click);
            // 
            // Release_tap
            // 
            this.Release_tap.ButtonDown = false;
            this.Release_tap.ClickOfToggle = false;
            this.Release_tap.DownImage = null;
            this.Release_tap.EnableKeyCtrl = false;
            this.Release_tap.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Release_tap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Release_tap.GroupIndex = 0;
            this.Release_tap.Icon = null;
            this.Release_tap.IconSpace = 4;
            this.Release_tap.Image = global::Main.Properties.Resources.button;
            this.Release_tap.ImageCount = 4;
            this.Release_tap.ImageInFontInfo = true;
            this.Release_tap.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Release_tap.IsBackPanel = false;
            this.Release_tap.Location = new System.Drawing.Point(254, 44);
            this.Release_tap.Margin = new System.Windows.Forms.Padding(0);
            this.Release_tap.Name = "Release_tap";
            this.Release_tap.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Release_tap.Size = new System.Drawing.Size(127, 54);
            this.Release_tap.StyleCount = 1;
            this.Release_tap.StyleNum = 0;
            this.Release_tap.TabIndex = 6;
            this.Release_tap.Text = "출고관리";
            this.Release_tap.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Release_tap.TextSub = "";
            this.Release_tap.TextSubVOffset = 0;
            this.Release_tap.UseVisualStyleBackColor = true;
            this.Release_tap.Click += new System.EventHandler(this.Release_tap_Click);
            // 
            // Store_tap
            // 
            this.Store_tap.ButtonDown = false;
            this.Store_tap.ClickOfToggle = false;
            this.Store_tap.DownImage = null;
            this.Store_tap.EnableKeyCtrl = false;
            this.Store_tap.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Store_tap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Store_tap.GroupIndex = 0;
            this.Store_tap.Icon = null;
            this.Store_tap.IconSpace = 4;
            this.Store_tap.Image = global::Main.Properties.Resources.button;
            this.Store_tap.ImageCount = 4;
            this.Store_tap.ImageInFontInfo = true;
            this.Store_tap.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Store_tap.IsBackPanel = false;
            this.Store_tap.Location = new System.Drawing.Point(127, 44);
            this.Store_tap.Margin = new System.Windows.Forms.Padding(0);
            this.Store_tap.Name = "Store_tap";
            this.Store_tap.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Store_tap.Size = new System.Drawing.Size(127, 54);
            this.Store_tap.StyleCount = 1;
            this.Store_tap.StyleNum = 0;
            this.Store_tap.TabIndex = 5;
            this.Store_tap.Text = "입고관리";
            this.Store_tap.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Store_tap.TextSub = "";
            this.Store_tap.TextSubVOffset = 0;
            this.Store_tap.UseVisualStyleBackColor = true;
            this.Store_tap.Click += new System.EventHandler(this.Store_tap_Click);
            // 
            // Manage_tap
            // 
            this.Manage_tap.ButtonDown = false;
            this.Manage_tap.ClickOfToggle = false;
            this.Manage_tap.DownImage = null;
            this.Manage_tap.EnableKeyCtrl = false;
            this.Manage_tap.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Manage_tap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Manage_tap.GroupIndex = 0;
            this.Manage_tap.Icon = null;
            this.Manage_tap.IconSpace = 4;
            this.Manage_tap.Image = global::Main.Properties.Resources.button;
            this.Manage_tap.ImageCount = 4;
            this.Manage_tap.ImageInFontInfo = true;
            this.Manage_tap.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Manage_tap.IsBackPanel = false;
            this.Manage_tap.Location = new System.Drawing.Point(0, 44);
            this.Manage_tap.Margin = new System.Windows.Forms.Padding(0);
            this.Manage_tap.Name = "Manage_tap";
            this.Manage_tap.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Manage_tap.Size = new System.Drawing.Size(127, 54);
            this.Manage_tap.StyleCount = 1;
            this.Manage_tap.StyleNum = 0;
            this.Manage_tap.TabIndex = 4;
            this.Manage_tap.Text = "재고관리";
            this.Manage_tap.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Manage_tap.TextSub = "";
            this.Manage_tap.TextSubVOffset = 0;
            this.Manage_tap.UseVisualStyleBackColor = true;
            this.Manage_tap.Click += new System.EventHandler(this.Manage_tap_Click);
            // 
            // Inven_mng_panel
            // 
            this.Inven_mng_panel.Controls.Add(this.Edit_panel);
            this.Inven_mng_panel.Controls.Add(this.Inven_print_excel);
            this.Inven_mng_panel.Controls.Add(this.Grid_inven_pages);
            this.Inven_mng_panel.Controls.Add(this.Select_search);
            this.Inven_mng_panel.Controls.Add(this.Store_shearch_btn);
            this.Inven_mng_panel.Controls.Add(this.Inven_search_box);
            this.Inven_mng_panel.Controls.Add(this.Grid_inven);
            this.Inven_mng_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Inven_mng_panel.Image = global::Main.Properties.Resources.back;
            this.Inven_mng_panel.ImageCount = 4;
            this.Inven_mng_panel.ImageHScroll = null;
            this.Inven_mng_panel.ImageInFontInfo = true;
            this.Inven_mng_panel.ImagePos = 3;
            this.Inven_mng_panel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Inven_mng_panel.ImageVScroll = null;
            this.Inven_mng_panel.LineBottom = false;
            this.Inven_mng_panel.LineColor = System.Drawing.Color.Black;
            this.Inven_mng_panel.LineLeft = false;
            this.Inven_mng_panel.LineRight = false;
            this.Inven_mng_panel.LineTop = false;
            this.Inven_mng_panel.Location = new System.Drawing.Point(0, 98);
            this.Inven_mng_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Inven_mng_panel.Name = "Inven_mng_panel";
            this.Inven_mng_panel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Inven_mng_panel.Size = new System.Drawing.Size(1224, 491);
            this.Inven_mng_panel.StyleCount = 1;
            this.Inven_mng_panel.StyleNum = 0;
            this.Inven_mng_panel.TabIndex = 7;
            this.Inven_mng_panel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Inven_mng_panel.VScrollImageDown = null;
            this.Inven_mng_panel.VScrollImageUp = null;
            this.Inven_mng_panel.VScrollShowUpDown = false;
            // 
            // Edit_panel
            // 
            this.Edit_panel.Controls.Add(this.mxImgLabel1);
            this.Edit_panel.Controls.Add(this.mxImgButton1);
            this.Edit_panel.Controls.Add(this.Edit_count);
            this.Edit_panel.Controls.Add(this.Edit_number);
            this.Edit_panel.Controls.Add(this.Edit_price);
            this.Edit_panel.Controls.Add(this.Edit_brand);
            this.Edit_panel.Controls.Add(this.Edit_name);
            this.Edit_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Edit_panel.Image = global::Main.Properties.Resources.back;
            this.Edit_panel.ImageCount = 4;
            this.Edit_panel.ImageHScroll = null;
            this.Edit_panel.ImageInFontInfo = false;
            this.Edit_panel.ImagePos = 0;
            this.Edit_panel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Edit_panel.ImageVScroll = null;
            this.Edit_panel.LineBottom = false;
            this.Edit_panel.LineColor = System.Drawing.Color.Black;
            this.Edit_panel.LineLeft = false;
            this.Edit_panel.LineRight = false;
            this.Edit_panel.LineTop = false;
            this.Edit_panel.Location = new System.Drawing.Point(0, 406);
            this.Edit_panel.Name = "Edit_panel";
            this.Edit_panel.ShadowColor = System.Drawing.Color.White;
            this.Edit_panel.Size = new System.Drawing.Size(1224, 85);
            this.Edit_panel.StyleCount = 1;
            this.Edit_panel.StyleNum = 0;
            this.Edit_panel.TabIndex = 15;
            this.Edit_panel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Edit_panel.Visible = false;
            this.Edit_panel.VScrollImageDown = null;
            this.Edit_panel.VScrollImageUp = null;
            this.Edit_panel.VScrollShowUpDown = false;
            // 
            // mxImgLabel1
            // 
            this.mxImgLabel1.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.mxImgLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.mxImgLabel1.Image = global::Main.Properties.Resources.top_icon_close;
            this.mxImgLabel1.ImageCount = 4;
            this.mxImgLabel1.ImageInFontInfo = true;
            this.mxImgLabel1.ImagePos = 0;
            this.mxImgLabel1.ImageSplitType = MaxNine.Forms.mxImgSplitType.SplitNo;
            this.mxImgLabel1.Location = new System.Drawing.Point(1198, 1);
            this.mxImgLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.mxImgLabel1.Name = "mxImgLabel1";
            this.mxImgLabel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.mxImgLabel1.Size = new System.Drawing.Size(25, 22);
            this.mxImgLabel1.StyleCount = 1;
            this.mxImgLabel1.StyleNum = 0;
            this.mxImgLabel1.TabIndex = 4;
            this.mxImgLabel1.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.mxImgLabel1.TextSub = "";
            this.mxImgLabel1.TextSubVOffset = 0;
            this.mxImgLabel1.WordWrap = false;
            this.mxImgLabel1.Click += new System.EventHandler(this.mxImgLabel1_Click);
            // 
            // mxImgButton1
            // 
            this.mxImgButton1.ButtonDown = false;
            this.mxImgButton1.ClickOfToggle = false;
            this.mxImgButton1.DownImage = null;
            this.mxImgButton1.EnableKeyCtrl = false;
            this.mxImgButton1.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.mxImgButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.mxImgButton1.GroupIndex = 0;
            this.mxImgButton1.Icon = null;
            this.mxImgButton1.IconSpace = 4;
            this.mxImgButton1.Image = global::Main.Properties.Resources.button;
            this.mxImgButton1.ImageCount = 4;
            this.mxImgButton1.ImageInFontInfo = true;
            this.mxImgButton1.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.mxImgButton1.IsBackPanel = false;
            this.mxImgButton1.Location = new System.Drawing.Point(968, 22);
            this.mxImgButton1.Name = "mxImgButton1";
            this.mxImgButton1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.mxImgButton1.Size = new System.Drawing.Size(120, 38);
            this.mxImgButton1.StyleCount = 1;
            this.mxImgButton1.StyleNum = 0;
            this.mxImgButton1.TabIndex = 16;
            this.mxImgButton1.Text = "수정";
            this.mxImgButton1.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.mxImgButton1.TextSub = "";
            this.mxImgButton1.TextSubVOffset = 0;
            this.mxImgButton1.UseVisualStyleBackColor = true;
            this.mxImgButton1.Click += new System.EventHandler(this.mxImgButton1_Click);
            // 
            // Edit_count
            // 
            this.Edit_count.Active = false;
            this.Edit_count.BackColor = System.Drawing.SystemColors.Window;
            this.Edit_count.Font = new System.Drawing.Font("맑은 고딕", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit_count.FormattingEnabled = true;
            this.Edit_count.ImgColor = null;
            this.Edit_count.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Edit_count.Location = new System.Drawing.Point(660, 26);
            this.Edit_count.Name = "Edit_count";
            this.Edit_count.Size = new System.Drawing.Size(101, 33);
            this.Edit_count.StyleNum = 0;
            this.Edit_count.TabIndex = 16;
            this.Edit_count.UseNULL_STRING = false;
            // 
            // Edit_number
            // 
            this.Edit_number.Active = false;
            this.Edit_number.AutoCompleteField = "";
            this.Edit_number.AutoCompleteItemDelete = false;
            this.Edit_number.AutoCompleteltemDisplayCount = 8;
            this.Edit_number.AutoCompleteltemHeight = 18;
            this.Edit_number.AutoCompleteMultiWord = true;
            this.Edit_number.AutoCompleteType = "";
            this.Edit_number.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit_number.ImgColor = null;
            this.Edit_number.ImgVScroll = null;
            this.Edit_number.Location = new System.Drawing.Point(769, 25);
            this.Edit_number.Margin = new System.Windows.Forms.Padding(5);
            this.Edit_number.Name = "Edit_number";
            this.Edit_number.Size = new System.Drawing.Size(191, 34);
            this.Edit_number.StyleNum = 0;
            this.Edit_number.TabIndex = 19;
            this.Edit_number.UseNULL_STRING = false;
            // 
            // Edit_price
            // 
            this.Edit_price.Active = false;
            this.Edit_price.AutoCompleteField = "";
            this.Edit_price.AutoCompleteItemDelete = false;
            this.Edit_price.AutoCompleteltemDisplayCount = 8;
            this.Edit_price.AutoCompleteltemHeight = 18;
            this.Edit_price.AutoCompleteMultiWord = true;
            this.Edit_price.AutoCompleteType = "";
            this.Edit_price.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit_price.ImgColor = null;
            this.Edit_price.ImgVScroll = null;
            this.Edit_price.Location = new System.Drawing.Point(461, 26);
            this.Edit_price.Margin = new System.Windows.Forms.Padding(5);
            this.Edit_price.Name = "Edit_price";
            this.Edit_price.Size = new System.Drawing.Size(191, 34);
            this.Edit_price.StyleNum = 0;
            this.Edit_price.TabIndex = 18;
            this.Edit_price.UseNULL_STRING = false;
            // 
            // Edit_brand
            // 
            this.Edit_brand.Active = false;
            this.Edit_brand.AutoCompleteField = "";
            this.Edit_brand.AutoCompleteItemDelete = false;
            this.Edit_brand.AutoCompleteltemDisplayCount = 8;
            this.Edit_brand.AutoCompleteltemHeight = 18;
            this.Edit_brand.AutoCompleteMultiWord = true;
            this.Edit_brand.AutoCompleteType = "";
            this.Edit_brand.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit_brand.ImgColor = null;
            this.Edit_brand.ImgVScroll = null;
            this.Edit_brand.Location = new System.Drawing.Point(260, 27);
            this.Edit_brand.Margin = new System.Windows.Forms.Padding(5);
            this.Edit_brand.Name = "Edit_brand";
            this.Edit_brand.Size = new System.Drawing.Size(191, 34);
            this.Edit_brand.StyleNum = 0;
            this.Edit_brand.TabIndex = 17;
            this.Edit_brand.UseNULL_STRING = false;
            // 
            // Edit_name
            // 
            this.Edit_name.Active = false;
            this.Edit_name.AutoCompleteField = "";
            this.Edit_name.AutoCompleteItemDelete = false;
            this.Edit_name.AutoCompleteltemDisplayCount = 8;
            this.Edit_name.AutoCompleteltemHeight = 18;
            this.Edit_name.AutoCompleteMultiWord = true;
            this.Edit_name.AutoCompleteType = "";
            this.Edit_name.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Edit_name.ImgColor = null;
            this.Edit_name.ImgVScroll = null;
            this.Edit_name.Location = new System.Drawing.Point(59, 27);
            this.Edit_name.Margin = new System.Windows.Forms.Padding(5);
            this.Edit_name.Name = "Edit_name";
            this.Edit_name.Size = new System.Drawing.Size(191, 34);
            this.Edit_name.StyleNum = 0;
            this.Edit_name.TabIndex = 16;
            this.Edit_name.UseNULL_STRING = false;
            // 
            // Inven_print_excel
            // 
            this.Inven_print_excel.ButtonDown = false;
            this.Inven_print_excel.ClickOfToggle = false;
            this.Inven_print_excel.DownImage = null;
            this.Inven_print_excel.EnableKeyCtrl = false;
            this.Inven_print_excel.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Inven_print_excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Inven_print_excel.GroupIndex = 0;
            this.Inven_print_excel.Icon = null;
            this.Inven_print_excel.IconSpace = 4;
            this.Inven_print_excel.Image = global::Main.Properties.Resources.button;
            this.Inven_print_excel.ImageCount = 4;
            this.Inven_print_excel.ImageInFontInfo = true;
            this.Inven_print_excel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Inven_print_excel.IsBackPanel = false;
            this.Inven_print_excel.Location = new System.Drawing.Point(12, 463);
            this.Inven_print_excel.Name = "Inven_print_excel";
            this.Inven_print_excel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Inven_print_excel.Size = new System.Drawing.Size(85, 22);
            this.Inven_print_excel.StyleCount = 1;
            this.Inven_print_excel.StyleNum = 0;
            this.Inven_print_excel.TabIndex = 14;
            this.Inven_print_excel.Text = "엑셀로 출력";
            this.Inven_print_excel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Inven_print_excel.TextSub = "";
            this.Inven_print_excel.TextSubVOffset = 0;
            this.Inven_print_excel.UseVisualStyleBackColor = true;
            this.Inven_print_excel.Click += new System.EventHandler(this.Inven_print_excel_Click);
            // 
            // Grid_inven_pages
            // 
            this.Grid_inven_pages.AutoSize = true;
            this.Grid_inven_pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_inven_pages.Image = global::Main.Properties.Resources.back;
            this.Grid_inven_pages.ImageCount = 4;
            this.Grid_inven_pages.ImageHScroll = null;
            this.Grid_inven_pages.ImageInFontInfo = true;
            this.Grid_inven_pages.ImagePos = 3;
            this.Grid_inven_pages.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Grid_inven_pages.ImageVScroll = null;
            this.Grid_inven_pages.LineBottom = false;
            this.Grid_inven_pages.LineColor = System.Drawing.Color.Black;
            this.Grid_inven_pages.LineLeft = false;
            this.Grid_inven_pages.LineRight = false;
            this.Grid_inven_pages.LineTop = false;
            this.Grid_inven_pages.Location = new System.Drawing.Point(595, 463);
            this.Grid_inven_pages.Name = "Grid_inven_pages";
            this.Grid_inven_pages.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_inven_pages.Size = new System.Drawing.Size(39, 24);
            this.Grid_inven_pages.StyleCount = 1;
            this.Grid_inven_pages.StyleNum = 0;
            this.Grid_inven_pages.TabIndex = 13;
            this.Grid_inven_pages.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Grid_inven_pages.VScrollImageDown = null;
            this.Grid_inven_pages.VScrollImageUp = null;
            this.Grid_inven_pages.VScrollShowUpDown = false;
            // 
            // Select_search
            // 
            this.Select_search.Active = false;
            this.Select_search.BackColor = System.Drawing.SystemColors.Window;
            this.Select_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_search.Font = new System.Drawing.Font("맑은 고딕", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Select_search.FormattingEnabled = true;
            this.Select_search.ImgColor = null;
            this.Select_search.Items.AddRange(new object[] {
            "전체",
            "제품번호",
            "제품명"});
            this.Select_search.Location = new System.Drawing.Point(712, 6);
            this.Select_search.Name = "Select_search";
            this.Select_search.Size = new System.Drawing.Size(177, 33);
            this.Select_search.StyleNum = 0;
            this.Select_search.TabIndex = 3;
            this.Select_search.UseNULL_STRING = false;
            // 
            // Store_shearch_btn
            // 
            this.Store_shearch_btn.ButtonDown = false;
            this.Store_shearch_btn.ClickOfToggle = false;
            this.Store_shearch_btn.DownImage = null;
            this.Store_shearch_btn.EnableKeyCtrl = false;
            this.Store_shearch_btn.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Store_shearch_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Store_shearch_btn.GroupIndex = 0;
            this.Store_shearch_btn.Icon = null;
            this.Store_shearch_btn.IconSpace = 4;
            this.Store_shearch_btn.Image = global::Main.Properties.Resources.button;
            this.Store_shearch_btn.ImageCount = 4;
            this.Store_shearch_btn.ImageInFontInfo = true;
            this.Store_shearch_btn.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Store_shearch_btn.IsBackPanel = false;
            this.Store_shearch_btn.Location = new System.Drawing.Point(1092, 4);
            this.Store_shearch_btn.Name = "Store_shearch_btn";
            this.Store_shearch_btn.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Store_shearch_btn.Size = new System.Drawing.Size(120, 38);
            this.Store_shearch_btn.StyleCount = 1;
            this.Store_shearch_btn.StyleNum = 0;
            this.Store_shearch_btn.TabIndex = 1;
            this.Store_shearch_btn.Text = "검색";
            this.Store_shearch_btn.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Store_shearch_btn.TextSub = "";
            this.Store_shearch_btn.TextSubVOffset = 0;
            this.Store_shearch_btn.UseVisualStyleBackColor = true;
            this.Store_shearch_btn.Click += new System.EventHandler(this.Store_shearch_btn_Click);
            // 
            // Inven_search_box
            // 
            this.Inven_search_box.Active = false;
            this.Inven_search_box.AutoCompleteField = "";
            this.Inven_search_box.AutoCompleteItemDelete = false;
            this.Inven_search_box.AutoCompleteltemDisplayCount = 8;
            this.Inven_search_box.AutoCompleteltemHeight = 18;
            this.Inven_search_box.AutoCompleteMultiWord = true;
            this.Inven_search_box.AutoCompleteType = "";
            this.Inven_search_box.BackColor = System.Drawing.SystemColors.Window;
            this.Inven_search_box.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Inven_search_box.ImgColor = null;
            this.Inven_search_box.ImgVScroll = null;
            this.Inven_search_box.Location = new System.Drawing.Point(897, 6);
            this.Inven_search_box.Margin = new System.Windows.Forms.Padding(5);
            this.Inven_search_box.Name = "Inven_search_box";
            this.Inven_search_box.Size = new System.Drawing.Size(191, 34);
            this.Inven_search_box.StyleNum = 0;
            this.Inven_search_box.TabIndex = 0;
            this.Inven_search_box.UseNULL_STRING = false;
            // 
            // Grid_inven
            // 
            this.Grid_inven.AutoAllChecked = true;
            this.Grid_inven.AutoFocusSelect = false;
            this.Grid_inven.CheckBoxImage = null;
            this.Grid_inven.CheckedCtrl = false;
            this.Grid_inven.CheckedEec = false;
            this.Grid_inven.CheckedSelected = false;
            this.Grid_inven.CheckedSheft = false;
            this.Grid_inven.DefaultSortColumn = "";
            this.Grid_inven.EnableAutoSort = true;
            this.Grid_inven.EnableInputControl = true;
            this.Grid_inven.EnablePaint = true;
            this.Grid_inven.FocusSelect = true;
            this.Grid_inven.HeaderBackImage = global::Main.Properties.Resources.list_header_arrow_small;
            this.Grid_inven.HeaderClickCheckedAllRow = true;
            this.Grid_inven.ImageHScroll = null;
            this.Grid_inven.ImageVScroll = null;
            this.Grid_inven.ImgList = new System.Drawing.Image[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.Grid_inven.Location = new System.Drawing.Point(0, 48);
            this.Grid_inven.Name = "Grid_inven";
            this.Grid_inven.RowTemplate.Height = 23;
            this.Grid_inven.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid_inven.Size = new System.Drawing.Size(1224, 409);
            this.Grid_inven.SortMode = MaxNine.Lib.WS.StringGridBase.SortModeValue.Normal;
            this.Grid_inven.StyleCount = 1;
            this.Grid_inven.StyleNum = 0;
            this.Grid_inven.TabIndex = 2;
            this.Grid_inven.TopRowIndex = -1;
            this.Grid_inven.VScrollImageDown = null;
            this.Grid_inven.VScrollImageUp = null;
            this.Grid_inven.VScrollShowUpDown = false;
            this.Grid_inven.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_inven_CellContentDoubleClick);
            // 
            // Store_panel
            // 
            this.Store_panel.Controls.Add(this.Store_print_excel);
            this.Store_panel.Controls.Add(this.Grid_store_now_pages);
            this.Store_panel.Controls.Add(this.Grid_store_inven_pages);
            this.Store_panel.Controls.Add(this.Grid_store_now);
            this.Store_panel.Controls.Add(this.Store_combo);
            this.Store_panel.Controls.Add(this.Store_search_btn);
            this.Store_panel.Controls.Add(this.Store_search_text);
            this.Store_panel.Controls.Add(this.Count_to_store_combo);
            this.Store_panel.Controls.Add(this.Store_btn);
            this.Store_panel.Controls.Add(this.Grid_store_inven);
            this.Store_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Store_panel.Image = global::Main.Properties.Resources.back;
            this.Store_panel.ImageCount = 4;
            this.Store_panel.ImageHScroll = null;
            this.Store_panel.ImageInFontInfo = true;
            this.Store_panel.ImagePos = 3;
            this.Store_panel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Store_panel.ImageVScroll = null;
            this.Store_panel.LineBottom = false;
            this.Store_panel.LineColor = System.Drawing.Color.Black;
            this.Store_panel.LineLeft = false;
            this.Store_panel.LineRight = false;
            this.Store_panel.LineTop = false;
            this.Store_panel.Location = new System.Drawing.Point(0, 98);
            this.Store_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Store_panel.Name = "Store_panel";
            this.Store_panel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Store_panel.Size = new System.Drawing.Size(1224, 491);
            this.Store_panel.StyleCount = 1;
            this.Store_panel.StyleNum = 0;
            this.Store_panel.TabIndex = 8;
            this.Store_panel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Store_panel.VScrollImageDown = null;
            this.Store_panel.VScrollImageUp = null;
            this.Store_panel.VScrollShowUpDown = false;
            // 
            // Store_print_excel
            // 
            this.Store_print_excel.ButtonDown = false;
            this.Store_print_excel.ClickOfToggle = false;
            this.Store_print_excel.DownImage = null;
            this.Store_print_excel.EnableKeyCtrl = false;
            this.Store_print_excel.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Store_print_excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Store_print_excel.GroupIndex = 0;
            this.Store_print_excel.Icon = null;
            this.Store_print_excel.IconSpace = 4;
            this.Store_print_excel.Image = global::Main.Properties.Resources.button;
            this.Store_print_excel.ImageCount = 4;
            this.Store_print_excel.ImageInFontInfo = true;
            this.Store_print_excel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Store_print_excel.IsBackPanel = false;
            this.Store_print_excel.Location = new System.Drawing.Point(12, 449);
            this.Store_print_excel.Name = "Store_print_excel";
            this.Store_print_excel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Store_print_excel.Size = new System.Drawing.Size(85, 22);
            this.Store_print_excel.StyleCount = 1;
            this.Store_print_excel.StyleNum = 0;
            this.Store_print_excel.TabIndex = 15;
            this.Store_print_excel.Text = "엑셀로 출력";
            this.Store_print_excel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Store_print_excel.TextSub = "";
            this.Store_print_excel.TextSubVOffset = 0;
            this.Store_print_excel.UseVisualStyleBackColor = true;
            this.Store_print_excel.Click += new System.EventHandler(this.Store_print_excel_Click);
            // 
            // Grid_store_now_pages
            // 
            this.Grid_store_now_pages.AutoSize = true;
            this.Grid_store_now_pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_store_now_pages.Image = global::Main.Properties.Resources.back;
            this.Grid_store_now_pages.ImageCount = 4;
            this.Grid_store_now_pages.ImageHScroll = null;
            this.Grid_store_now_pages.ImageInFontInfo = true;
            this.Grid_store_now_pages.ImagePos = 3;
            this.Grid_store_now_pages.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Grid_store_now_pages.ImageVScroll = null;
            this.Grid_store_now_pages.LineBottom = false;
            this.Grid_store_now_pages.LineColor = System.Drawing.Color.Black;
            this.Grid_store_now_pages.LineLeft = false;
            this.Grid_store_now_pages.LineRight = false;
            this.Grid_store_now_pages.LineTop = false;
            this.Grid_store_now_pages.Location = new System.Drawing.Point(579, 442);
            this.Grid_store_now_pages.Name = "Grid_store_now_pages";
            this.Grid_store_now_pages.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_store_now_pages.Size = new System.Drawing.Size(39, 24);
            this.Grid_store_now_pages.StyleCount = 1;
            this.Grid_store_now_pages.StyleNum = 0;
            this.Grid_store_now_pages.TabIndex = 13;
            this.Grid_store_now_pages.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Grid_store_now_pages.VScrollImageDown = null;
            this.Grid_store_now_pages.VScrollImageUp = null;
            this.Grid_store_now_pages.VScrollShowUpDown = false;
            // 
            // Grid_store_inven_pages
            // 
            this.Grid_store_inven_pages.AutoSize = true;
            this.Grid_store_inven_pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_store_inven_pages.Image = global::Main.Properties.Resources.back;
            this.Grid_store_inven_pages.ImageCount = 4;
            this.Grid_store_inven_pages.ImageHScroll = null;
            this.Grid_store_inven_pages.ImageInFontInfo = true;
            this.Grid_store_inven_pages.ImagePos = 3;
            this.Grid_store_inven_pages.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Grid_store_inven_pages.ImageVScroll = null;
            this.Grid_store_inven_pages.LineBottom = false;
            this.Grid_store_inven_pages.LineColor = System.Drawing.Color.Black;
            this.Grid_store_inven_pages.LineLeft = false;
            this.Grid_store_inven_pages.LineRight = false;
            this.Grid_store_inven_pages.LineTop = false;
            this.Grid_store_inven_pages.Location = new System.Drawing.Point(579, 226);
            this.Grid_store_inven_pages.Name = "Grid_store_inven_pages";
            this.Grid_store_inven_pages.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_store_inven_pages.Size = new System.Drawing.Size(39, 24);
            this.Grid_store_inven_pages.StyleCount = 1;
            this.Grid_store_inven_pages.StyleNum = 0;
            this.Grid_store_inven_pages.TabIndex = 12;
            this.Grid_store_inven_pages.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Grid_store_inven_pages.VScrollImageDown = null;
            this.Grid_store_inven_pages.VScrollImageUp = null;
            this.Grid_store_inven_pages.VScrollShowUpDown = false;
            // 
            // Grid_store_now
            // 
            this.Grid_store_now.AutoAllChecked = true;
            this.Grid_store_now.AutoFocusSelect = false;
            this.Grid_store_now.CheckBoxImage = null;
            this.Grid_store_now.CheckedCtrl = false;
            this.Grid_store_now.CheckedEec = false;
            this.Grid_store_now.CheckedSelected = false;
            this.Grid_store_now.CheckedSheft = false;
            this.Grid_store_now.DefaultSortColumn = "";
            this.Grid_store_now.EnableAutoSort = true;
            this.Grid_store_now.EnableInputControl = false;
            this.Grid_store_now.EnablePaint = true;
            this.Grid_store_now.FocusSelect = true;
            this.Grid_store_now.HeaderBackImage = global::Main.Properties.Resources.list_header_arrow_small;
            this.Grid_store_now.HeaderClickCheckedAllRow = true;
            this.Grid_store_now.ImageHScroll = null;
            this.Grid_store_now.ImageVScroll = null;
            this.Grid_store_now.ImgList = new System.Drawing.Image[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.Grid_store_now.Location = new System.Drawing.Point(0, 256);
            this.Grid_store_now.Name = "Grid_store_now";
            this.Grid_store_now.RowTemplate.Height = 23;
            this.Grid_store_now.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid_store_now.Size = new System.Drawing.Size(1224, 172);
            this.Grid_store_now.SortMode = MaxNine.Lib.WS.StringGridBase.SortModeValue.Normal;
            this.Grid_store_now.StyleCount = 1;
            this.Grid_store_now.StyleNum = 0;
            this.Grid_store_now.TabIndex = 11;
            this.Grid_store_now.TopRowIndex = -1;
            this.Grid_store_now.VScrollImageDown = null;
            this.Grid_store_now.VScrollImageUp = null;
            this.Grid_store_now.VScrollShowUpDown = false;
            // 
            // Store_combo
            // 
            this.Store_combo.Active = false;
            this.Store_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Store_combo.Font = new System.Drawing.Font("맑은 고딕", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Store_combo.FormattingEnabled = true;
            this.Store_combo.ImgColor = null;
            this.Store_combo.Items.AddRange(new object[] {
            "전체",
            "제품번호",
            "제품명"});
            this.Store_combo.Location = new System.Drawing.Point(712, 6);
            this.Store_combo.Name = "Store_combo";
            this.Store_combo.Size = new System.Drawing.Size(177, 33);
            this.Store_combo.StyleNum = 0;
            this.Store_combo.TabIndex = 10;
            this.Store_combo.UseNULL_STRING = false;
            // 
            // Store_search_btn
            // 
            this.Store_search_btn.ButtonDown = false;
            this.Store_search_btn.ClickOfToggle = false;
            this.Store_search_btn.DownImage = null;
            this.Store_search_btn.EnableKeyCtrl = false;
            this.Store_search_btn.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Store_search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Store_search_btn.GroupIndex = 0;
            this.Store_search_btn.Icon = null;
            this.Store_search_btn.IconSpace = 4;
            this.Store_search_btn.Image = global::Main.Properties.Resources.button;
            this.Store_search_btn.ImageCount = 4;
            this.Store_search_btn.ImageInFontInfo = true;
            this.Store_search_btn.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Store_search_btn.IsBackPanel = false;
            this.Store_search_btn.Location = new System.Drawing.Point(1092, 4);
            this.Store_search_btn.Name = "Store_search_btn";
            this.Store_search_btn.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Store_search_btn.Size = new System.Drawing.Size(120, 38);
            this.Store_search_btn.StyleCount = 1;
            this.Store_search_btn.StyleNum = 0;
            this.Store_search_btn.TabIndex = 9;
            this.Store_search_btn.Text = "검색";
            this.Store_search_btn.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Store_search_btn.TextSub = "";
            this.Store_search_btn.TextSubVOffset = 0;
            this.Store_search_btn.UseVisualStyleBackColor = true;
            this.Store_search_btn.Click += new System.EventHandler(this.Store_search_btn_Click);
            // 
            // Store_search_text
            // 
            this.Store_search_text.Active = false;
            this.Store_search_text.AutoCompleteField = "";
            this.Store_search_text.AutoCompleteItemDelete = false;
            this.Store_search_text.AutoCompleteltemDisplayCount = 8;
            this.Store_search_text.AutoCompleteltemHeight = 18;
            this.Store_search_text.AutoCompleteMultiWord = true;
            this.Store_search_text.AutoCompleteType = "";
            this.Store_search_text.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Store_search_text.ImgColor = null;
            this.Store_search_text.ImgVScroll = null;
            this.Store_search_text.Location = new System.Drawing.Point(897, 6);
            this.Store_search_text.Margin = new System.Windows.Forms.Padding(5);
            this.Store_search_text.Name = "Store_search_text";
            this.Store_search_text.Size = new System.Drawing.Size(191, 34);
            this.Store_search_text.StyleNum = 0;
            this.Store_search_text.TabIndex = 8;
            this.Store_search_text.UseNULL_STRING = false;
            // 
            // Count_to_store_combo
            // 
            this.Count_to_store_combo.Active = false;
            this.Count_to_store_combo.Font = new System.Drawing.Font("맑은 고딕", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Count_to_store_combo.FormattingEnabled = true;
            this.Count_to_store_combo.ImgColor = null;
            this.Count_to_store_combo.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Count_to_store_combo.Location = new System.Drawing.Point(1009, 442);
            this.Count_to_store_combo.Name = "Count_to_store_combo";
            this.Count_to_store_combo.Size = new System.Drawing.Size(77, 33);
            this.Count_to_store_combo.StyleNum = 0;
            this.Count_to_store_combo.TabIndex = 7;
            this.Count_to_store_combo.Text = "1";
            this.Count_to_store_combo.UseNULL_STRING = false;
            // 
            // Store_btn
            // 
            this.Store_btn.ButtonDown = false;
            this.Store_btn.ClickOfToggle = false;
            this.Store_btn.DownImage = null;
            this.Store_btn.EnableKeyCtrl = false;
            this.Store_btn.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Store_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Store_btn.GroupIndex = 0;
            this.Store_btn.Icon = null;
            this.Store_btn.IconSpace = 4;
            this.Store_btn.Image = global::Main.Properties.Resources.button;
            this.Store_btn.ImageCount = 4;
            this.Store_btn.ImageInFontInfo = true;
            this.Store_btn.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Store_btn.IsBackPanel = false;
            this.Store_btn.Location = new System.Drawing.Point(1092, 441);
            this.Store_btn.Name = "Store_btn";
            this.Store_btn.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Store_btn.Size = new System.Drawing.Size(120, 38);
            this.Store_btn.StyleCount = 1;
            this.Store_btn.StyleNum = 0;
            this.Store_btn.TabIndex = 1;
            this.Store_btn.Text = "입고";
            this.Store_btn.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Store_btn.TextSub = "";
            this.Store_btn.TextSubVOffset = 0;
            this.Store_btn.UseVisualStyleBackColor = true;
            this.Store_btn.Click += new System.EventHandler(this.Store_btn_Click);
            // 
            // Grid_store_inven
            // 
            this.Grid_store_inven.AutoAllChecked = true;
            this.Grid_store_inven.AutoFocusSelect = false;
            this.Grid_store_inven.CheckBoxImage = null;
            this.Grid_store_inven.CheckedCtrl = false;
            this.Grid_store_inven.CheckedEec = false;
            this.Grid_store_inven.CheckedSelected = false;
            this.Grid_store_inven.CheckedSheft = false;
            this.Grid_store_inven.DefaultSortColumn = "";
            this.Grid_store_inven.EnableAutoSort = true;
            this.Grid_store_inven.EnableInputControl = false;
            this.Grid_store_inven.EnablePaint = true;
            this.Grid_store_inven.FocusSelect = true;
            this.Grid_store_inven.HeaderBackImage = global::Main.Properties.Resources.list_header_arrow_small;
            this.Grid_store_inven.HeaderClickCheckedAllRow = true;
            this.Grid_store_inven.ImageHScroll = null;
            this.Grid_store_inven.ImageVScroll = null;
            this.Grid_store_inven.ImgList = new System.Drawing.Image[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.Grid_store_inven.Location = new System.Drawing.Point(0, 48);
            this.Grid_store_inven.Name = "Grid_store_inven";
            this.Grid_store_inven.RowTemplate.Height = 23;
            this.Grid_store_inven.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid_store_inven.Size = new System.Drawing.Size(1224, 172);
            this.Grid_store_inven.SortMode = MaxNine.Lib.WS.StringGridBase.SortModeValue.Normal;
            this.Grid_store_inven.StyleCount = 1;
            this.Grid_store_inven.StyleNum = 0;
            this.Grid_store_inven.TabIndex = 2;
            this.Grid_store_inven.TopRowIndex = -1;
            this.Grid_store_inven.VScrollImageDown = null;
            this.Grid_store_inven.VScrollImageUp = null;
            this.Grid_store_inven.VScrollShowUpDown = false;
            // 
            // Release_panel
            // 
            this.Release_panel.Controls.Add(this.Release_print_excel);
            this.Release_panel.Controls.Add(this.Grid_release_now_pages);
            this.Release_panel.Controls.Add(this.Grid_release_inven_pages);
            this.Release_panel.Controls.Add(this.Grid_release_now);
            this.Release_panel.Controls.Add(this.Release_combo);
            this.Release_panel.Controls.Add(this.Release_search_btn);
            this.Release_panel.Controls.Add(this.Release_search_text);
            this.Release_panel.Controls.Add(this.Count_to_release_combo);
            this.Release_panel.Controls.Add(this.Release_btn);
            this.Release_panel.Controls.Add(this.Grid_release_inven);
            this.Release_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Release_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Release_panel.Image = global::Main.Properties.Resources.back;
            this.Release_panel.ImageCount = 4;
            this.Release_panel.ImageHScroll = null;
            this.Release_panel.ImageInFontInfo = true;
            this.Release_panel.ImagePos = 3;
            this.Release_panel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Release_panel.ImageVScroll = null;
            this.Release_panel.LineBottom = false;
            this.Release_panel.LineColor = System.Drawing.Color.Black;
            this.Release_panel.LineLeft = false;
            this.Release_panel.LineRight = false;
            this.Release_panel.LineTop = false;
            this.Release_panel.Location = new System.Drawing.Point(0, 98);
            this.Release_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Release_panel.Name = "Release_panel";
            this.Release_panel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Release_panel.Size = new System.Drawing.Size(1224, 491);
            this.Release_panel.StyleCount = 1;
            this.Release_panel.StyleNum = 0;
            this.Release_panel.TabIndex = 12;
            this.Release_panel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Release_panel.VScrollImageDown = null;
            this.Release_panel.VScrollImageUp = null;
            this.Release_panel.VScrollShowUpDown = false;
            // 
            // Release_print_excel
            // 
            this.Release_print_excel.ButtonDown = false;
            this.Release_print_excel.ClickOfToggle = false;
            this.Release_print_excel.DownImage = null;
            this.Release_print_excel.EnableKeyCtrl = false;
            this.Release_print_excel.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Release_print_excel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Release_print_excel.GroupIndex = 0;
            this.Release_print_excel.Icon = null;
            this.Release_print_excel.IconSpace = 4;
            this.Release_print_excel.Image = global::Main.Properties.Resources.button;
            this.Release_print_excel.ImageCount = 4;
            this.Release_print_excel.ImageInFontInfo = true;
            this.Release_print_excel.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Release_print_excel.IsBackPanel = false;
            this.Release_print_excel.Location = new System.Drawing.Point(12, 449);
            this.Release_print_excel.Name = "Release_print_excel";
            this.Release_print_excel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Release_print_excel.Size = new System.Drawing.Size(85, 22);
            this.Release_print_excel.StyleCount = 1;
            this.Release_print_excel.StyleNum = 0;
            this.Release_print_excel.TabIndex = 16;
            this.Release_print_excel.Text = "엑셀로 출력";
            this.Release_print_excel.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Release_print_excel.TextSub = "";
            this.Release_print_excel.TextSubVOffset = 0;
            this.Release_print_excel.UseVisualStyleBackColor = true;
            this.Release_print_excel.Click += new System.EventHandler(this.Release_print_excel_Click);
            // 
            // Grid_release_now_pages
            // 
            this.Grid_release_now_pages.AutoSize = true;
            this.Grid_release_now_pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_release_now_pages.Image = global::Main.Properties.Resources.back;
            this.Grid_release_now_pages.ImageCount = 4;
            this.Grid_release_now_pages.ImageHScroll = null;
            this.Grid_release_now_pages.ImageInFontInfo = true;
            this.Grid_release_now_pages.ImagePos = 3;
            this.Grid_release_now_pages.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Grid_release_now_pages.ImageVScroll = null;
            this.Grid_release_now_pages.LineBottom = false;
            this.Grid_release_now_pages.LineColor = System.Drawing.Color.Black;
            this.Grid_release_now_pages.LineLeft = false;
            this.Grid_release_now_pages.LineRight = false;
            this.Grid_release_now_pages.LineTop = false;
            this.Grid_release_now_pages.Location = new System.Drawing.Point(576, 451);
            this.Grid_release_now_pages.Name = "Grid_release_now_pages";
            this.Grid_release_now_pages.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_release_now_pages.Size = new System.Drawing.Size(39, 24);
            this.Grid_release_now_pages.StyleCount = 1;
            this.Grid_release_now_pages.StyleNum = 0;
            this.Grid_release_now_pages.TabIndex = 15;
            this.Grid_release_now_pages.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Grid_release_now_pages.VScrollImageDown = null;
            this.Grid_release_now_pages.VScrollImageUp = null;
            this.Grid_release_now_pages.VScrollShowUpDown = false;
            // 
            // Grid_release_inven_pages
            // 
            this.Grid_release_inven_pages.AutoSize = true;
            this.Grid_release_inven_pages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_release_inven_pages.Image = global::Main.Properties.Resources.back;
            this.Grid_release_inven_pages.ImageCount = 4;
            this.Grid_release_inven_pages.ImageHScroll = null;
            this.Grid_release_inven_pages.ImageInFontInfo = true;
            this.Grid_release_inven_pages.ImagePos = 3;
            this.Grid_release_inven_pages.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Grid_release_inven_pages.ImageVScroll = null;
            this.Grid_release_inven_pages.LineBottom = false;
            this.Grid_release_inven_pages.LineColor = System.Drawing.Color.Black;
            this.Grid_release_inven_pages.LineLeft = false;
            this.Grid_release_inven_pages.LineRight = false;
            this.Grid_release_inven_pages.LineTop = false;
            this.Grid_release_inven_pages.Location = new System.Drawing.Point(576, 226);
            this.Grid_release_inven_pages.Name = "Grid_release_inven_pages";
            this.Grid_release_inven_pages.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.Grid_release_inven_pages.Size = new System.Drawing.Size(39, 24);
            this.Grid_release_inven_pages.StyleCount = 1;
            this.Grid_release_inven_pages.StyleNum = 0;
            this.Grid_release_inven_pages.TabIndex = 14;
            this.Grid_release_inven_pages.TextShadowStyle = MaxNine.Forms.mxShadowStyle.OutLine;
            this.Grid_release_inven_pages.VScrollImageDown = null;
            this.Grid_release_inven_pages.VScrollImageUp = null;
            this.Grid_release_inven_pages.VScrollShowUpDown = false;
            // 
            // Grid_release_now
            // 
            this.Grid_release_now.AutoAllChecked = true;
            this.Grid_release_now.AutoFocusSelect = false;
            this.Grid_release_now.CheckBoxImage = null;
            this.Grid_release_now.CheckedCtrl = false;
            this.Grid_release_now.CheckedEec = false;
            this.Grid_release_now.CheckedSelected = false;
            this.Grid_release_now.CheckedSheft = false;
            this.Grid_release_now.DefaultSortColumn = "";
            this.Grid_release_now.EnableAutoSort = true;
            this.Grid_release_now.EnableInputControl = false;
            this.Grid_release_now.EnablePaint = true;
            this.Grid_release_now.FocusSelect = true;
            this.Grid_release_now.HeaderBackImage = global::Main.Properties.Resources.list_header_arrow_small;
            this.Grid_release_now.HeaderClickCheckedAllRow = true;
            this.Grid_release_now.ImageHScroll = null;
            this.Grid_release_now.ImageVScroll = null;
            this.Grid_release_now.ImgList = new System.Drawing.Image[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.Grid_release_now.Location = new System.Drawing.Point(0, 256);
            this.Grid_release_now.Name = "Grid_release_now";
            this.Grid_release_now.RowTemplate.Height = 23;
            this.Grid_release_now.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid_release_now.Size = new System.Drawing.Size(1224, 172);
            this.Grid_release_now.SortMode = MaxNine.Lib.WS.StringGridBase.SortModeValue.Normal;
            this.Grid_release_now.StyleCount = 1;
            this.Grid_release_now.StyleNum = 0;
            this.Grid_release_now.TabIndex = 11;
            this.Grid_release_now.TopRowIndex = -1;
            this.Grid_release_now.VScrollImageDown = null;
            this.Grid_release_now.VScrollImageUp = null;
            this.Grid_release_now.VScrollShowUpDown = false;
            // 
            // Release_combo
            // 
            this.Release_combo.Active = false;
            this.Release_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Release_combo.Font = new System.Drawing.Font("맑은 고딕", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Release_combo.FormattingEnabled = true;
            this.Release_combo.ImgColor = null;
            this.Release_combo.Items.AddRange(new object[] {
            "전체",
            "제품번호",
            "제품명"});
            this.Release_combo.Location = new System.Drawing.Point(712, 6);
            this.Release_combo.Name = "Release_combo";
            this.Release_combo.Size = new System.Drawing.Size(177, 33);
            this.Release_combo.StyleNum = 0;
            this.Release_combo.TabIndex = 10;
            this.Release_combo.UseNULL_STRING = false;
            // 
            // Release_search_btn
            // 
            this.Release_search_btn.ButtonDown = false;
            this.Release_search_btn.ClickOfToggle = false;
            this.Release_search_btn.DownImage = null;
            this.Release_search_btn.EnableKeyCtrl = false;
            this.Release_search_btn.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Release_search_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Release_search_btn.GroupIndex = 0;
            this.Release_search_btn.Icon = null;
            this.Release_search_btn.IconSpace = 4;
            this.Release_search_btn.Image = global::Main.Properties.Resources.button;
            this.Release_search_btn.ImageCount = 4;
            this.Release_search_btn.ImageInFontInfo = true;
            this.Release_search_btn.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Release_search_btn.IsBackPanel = false;
            this.Release_search_btn.Location = new System.Drawing.Point(1092, 4);
            this.Release_search_btn.Name = "Release_search_btn";
            this.Release_search_btn.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Release_search_btn.Size = new System.Drawing.Size(120, 38);
            this.Release_search_btn.StyleCount = 1;
            this.Release_search_btn.StyleNum = 0;
            this.Release_search_btn.TabIndex = 9;
            this.Release_search_btn.Text = "검색";
            this.Release_search_btn.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Release_search_btn.TextSub = "";
            this.Release_search_btn.TextSubVOffset = 0;
            this.Release_search_btn.UseVisualStyleBackColor = true;
            this.Release_search_btn.Click += new System.EventHandler(this.Release_search_btn_Click);
            // 
            // Release_search_text
            // 
            this.Release_search_text.Active = false;
            this.Release_search_text.AutoCompleteField = "";
            this.Release_search_text.AutoCompleteItemDelete = false;
            this.Release_search_text.AutoCompleteltemDisplayCount = 8;
            this.Release_search_text.AutoCompleteltemHeight = 18;
            this.Release_search_text.AutoCompleteMultiWord = true;
            this.Release_search_text.AutoCompleteType = "";
            this.Release_search_text.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Release_search_text.ImgColor = null;
            this.Release_search_text.ImgVScroll = null;
            this.Release_search_text.Location = new System.Drawing.Point(897, 6);
            this.Release_search_text.Margin = new System.Windows.Forms.Padding(5);
            this.Release_search_text.Name = "Release_search_text";
            this.Release_search_text.Size = new System.Drawing.Size(191, 34);
            this.Release_search_text.StyleNum = 0;
            this.Release_search_text.TabIndex = 8;
            this.Release_search_text.UseNULL_STRING = false;
            // 
            // Count_to_release_combo
            // 
            this.Count_to_release_combo.Active = false;
            this.Count_to_release_combo.Font = new System.Drawing.Font("맑은 고딕", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Count_to_release_combo.FormattingEnabled = true;
            this.Count_to_release_combo.ImgColor = null;
            this.Count_to_release_combo.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Count_to_release_combo.Location = new System.Drawing.Point(1009, 442);
            this.Count_to_release_combo.Name = "Count_to_release_combo";
            this.Count_to_release_combo.Size = new System.Drawing.Size(77, 33);
            this.Count_to_release_combo.StyleNum = 0;
            this.Count_to_release_combo.TabIndex = 7;
            this.Count_to_release_combo.Text = "1";
            this.Count_to_release_combo.UseNULL_STRING = false;
            // 
            // Release_btn
            // 
            this.Release_btn.ButtonDown = false;
            this.Release_btn.ClickOfToggle = false;
            this.Release_btn.DownImage = null;
            this.Release_btn.EnableKeyCtrl = false;
            this.Release_btn.FontSub = new System.Drawing.Font("맑은 고딕", 9F);
            this.Release_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(216)))), ((int)(((byte)(238)))));
            this.Release_btn.GroupIndex = 0;
            this.Release_btn.Icon = null;
            this.Release_btn.IconSpace = 4;
            this.Release_btn.Image = global::Main.Properties.Resources.button;
            this.Release_btn.ImageCount = 4;
            this.Release_btn.ImageInFontInfo = true;
            this.Release_btn.ImageSplitType = MaxNine.Forms.mxImgSplitType.Split9;
            this.Release_btn.IsBackPanel = false;
            this.Release_btn.Location = new System.Drawing.Point(1092, 441);
            this.Release_btn.Name = "Release_btn";
            this.Release_btn.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.Release_btn.Size = new System.Drawing.Size(120, 38);
            this.Release_btn.StyleCount = 1;
            this.Release_btn.StyleNum = 0;
            this.Release_btn.TabIndex = 1;
            this.Release_btn.Text = "출고";
            this.Release_btn.TextShadowStyle = MaxNine.Forms.mxShadowStyle.None;
            this.Release_btn.TextSub = "";
            this.Release_btn.TextSubVOffset = 0;
            this.Release_btn.UseVisualStyleBackColor = true;
            this.Release_btn.Click += new System.EventHandler(this.Release_btn_Click);
            // 
            // Grid_release_inven
            // 
            this.Grid_release_inven.AutoAllChecked = true;
            this.Grid_release_inven.AutoFocusSelect = false;
            this.Grid_release_inven.CheckBoxImage = null;
            this.Grid_release_inven.CheckedCtrl = false;
            this.Grid_release_inven.CheckedEec = false;
            this.Grid_release_inven.CheckedSelected = false;
            this.Grid_release_inven.CheckedSheft = false;
            this.Grid_release_inven.DefaultSortColumn = "";
            this.Grid_release_inven.EnableAutoSort = true;
            this.Grid_release_inven.EnableInputControl = false;
            this.Grid_release_inven.EnablePaint = true;
            this.Grid_release_inven.FocusSelect = true;
            this.Grid_release_inven.HeaderBackImage = global::Main.Properties.Resources.list_header_arrow_small;
            this.Grid_release_inven.HeaderClickCheckedAllRow = true;
            this.Grid_release_inven.ImageHScroll = null;
            this.Grid_release_inven.ImageVScroll = global::Main.Properties.Resources.mxImgVScrollBar_17px;
            this.Grid_release_inven.ImgList = new System.Drawing.Image[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.Grid_release_inven.Location = new System.Drawing.Point(0, 48);
            this.Grid_release_inven.Name = "Grid_release_inven";
            this.Grid_release_inven.RowTemplate.Height = 23;
            this.Grid_release_inven.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grid_release_inven.Size = new System.Drawing.Size(1224, 172);
            this.Grid_release_inven.SortMode = MaxNine.Lib.WS.StringGridBase.SortModeValue.Normal;
            this.Grid_release_inven.StyleCount = 1;
            this.Grid_release_inven.StyleNum = 0;
            this.Grid_release_inven.TabIndex = 2;
            this.Grid_release_inven.TopRowIndex = -1;
            this.Grid_release_inven.VScrollImageDown = null;
            this.Grid_release_inven.VScrollImageUp = null;
            this.Grid_release_inven.VScrollShowUpDown = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1224, 589);
            this.ControlBox = false;
            this.Controls.Add(this.BackGround);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackGround.ResumeLayout(false);
            this.Top_bar.ResumeLayout(false);
            this.Inven_mng_panel.ResumeLayout(false);
            this.Inven_mng_panel.PerformLayout();
            this.Edit_panel.ResumeLayout(false);
            this.Edit_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_inven)).EndInit();
            this.Store_panel.ResumeLayout(false);
            this.Store_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_store_now)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_store_inven)).EndInit();
            this.Release_panel.ResumeLayout(false);
            this.Release_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_release_now)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_release_inven)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaxNine.Forms.mxImgPanel BackGround;
        private MaxNine.Forms.mxImgButton Manage_tap;
        private MaxNine.Forms.mxImgLabel Form_setting;
        private MaxNine.Forms.mxImgLabel Form_Mini;
        private MaxNine.Forms.mxImgLabel Form_Maxi;
        private MaxNine.Forms.mxImgLabel Form_Close;
        private MaxNine.Forms.mxImgButton Release_tap;
        private MaxNine.Forms.mxImgButton Store_tap;
        private MaxNine.Forms.mxImgPanel Inven_mng_panel;
        private MaxNine.Lib.WS.StringGrid Grid_inven;
        private MaxNine.Forms.mxImgButton Store_shearch_btn;
        private MaxNine.Forms.mxTextBox Inven_search_box;
        private MaxNine.Forms.mxComboBox Select_search;
        private MaxNine.Forms.mxImgPanel Store_panel;
        private MaxNine.Lib.WS.StringGrid Grid_store_inven;
        private MaxNine.Forms.mxImgButton Store_btn;
        private MaxNine.Forms.mxComboBox Count_to_store_combo;
        private MaxNine.Forms.mxComboBox Store_combo;
        private MaxNine.Forms.mxImgButton Store_search_btn;
        private MaxNine.Forms.mxTextBox Store_search_text;
        private MaxNine.Lib.WS.StringGrid Grid_store_now;
        private MaxNine.Forms.mxImgPanel Release_panel;
        private MaxNine.Lib.WS.StringGrid Grid_release_now;
        private MaxNine.Forms.mxComboBox Release_combo;
        private MaxNine.Forms.mxImgButton Release_search_btn;
        private MaxNine.Forms.mxTextBox Release_search_text;
        private MaxNine.Forms.mxComboBox Count_to_release_combo;
        private MaxNine.Forms.mxImgButton Release_btn;
        private MaxNine.Lib.WS.StringGrid Grid_release_inven;
        private MaxNine.Forms.mxImgPanel Top_bar;
        private MaxNine.Forms.mxImgPanel Grid_store_inven_pages;
        private MaxNine.Forms.mxImgPanel Grid_inven_pages;
        private MaxNine.Forms.mxImgPanel Grid_store_now_pages;
        private MaxNine.Forms.mxImgPanel Grid_release_now_pages;
        private MaxNine.Forms.mxImgPanel Grid_release_inven_pages;
        private MaxNine.Forms.mxImgButton Inven_print_excel;
        private MaxNine.Forms.mxImgButton Release_print_excel;
        private MaxNine.Forms.mxImgButton Store_print_excel;
        private MaxNine.Forms.mxImgPanel Edit_panel;
        private MaxNine.Forms.mxTextBox Edit_name;
        private MaxNine.Forms.mxComboBox Edit_count;
        private MaxNine.Forms.mxTextBox Edit_number;
        private MaxNine.Forms.mxTextBox Edit_price;
        private MaxNine.Forms.mxTextBox Edit_brand;
        private MaxNine.Forms.mxImgButton mxImgButton1;
        private MaxNine.Forms.mxImgLabel mxImgLabel1;
    }
}

