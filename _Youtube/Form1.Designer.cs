namespace _Youtube
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChVDesc = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SubMax = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SubMin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.l1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChCdesc = new Bunifu.Framework.UI.BunifuCheckbox();
            this.l4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChTag = new Bunifu.Framework.UI.BunifuCheckbox();
            this.l3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChKeyword = new Bunifu.Framework.UI.BunifuCheckbox();
            this.l2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataResponse = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProgressCircle = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Total = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pChrome = new System.Windows.Forms.Panel();
            this.SubCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ChannelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscribers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.BorderColorFocused = System.Drawing.Color.White;
            this.SearchField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchField.BorderColorMouseHover = System.Drawing.Color.White;
            this.SearchField.BorderThickness = 2;
            this.SearchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchField.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchField.ForeColor = System.Drawing.Color.White;
            this.SearchField.isPassword = false;
            this.SearchField.Location = new System.Drawing.Point(362, 29);
            this.SearchField.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(290, 33);
            this.SearchField.TabIndex = 0;
            this.SearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(217, 29);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(145, 26);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "SEARCH FOR ";
            // 
            // ChVDesc
            // 
            this.ChVDesc.BackColor = System.Drawing.Color.White;
            this.ChVDesc.ChechedOffColor = System.Drawing.Color.White;
            this.ChVDesc.Checked = false;
            this.ChVDesc.CheckedOnColor = System.Drawing.Color.Black;
            this.ChVDesc.ForeColor = System.Drawing.Color.White;
            this.ChVDesc.Location = new System.Drawing.Point(23, 325);
            this.ChVDesc.Name = "ChVDesc";
            this.ChVDesc.Size = new System.Drawing.Size(20, 20);
            this.ChVDesc.TabIndex = 2;
            this.ChVDesc.Click += new System.EventHandler(this.bunifuCheckbox5_Click);
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu.Controls.Add(this.SubCheck);
            this.Menu.Controls.Add(this.SubMax);
            this.Menu.Controls.Add(this.SubMin);
            this.Menu.Controls.Add(this.bunifuCustomLabel10);
            this.Menu.Controls.Add(this.bunifuCustomLabel9);
            this.Menu.Controls.Add(this.bunifuCustomLabel8);
            this.Menu.Controls.Add(this.bunifuCustomLabel7);
            this.Menu.Controls.Add(this.l1);
            this.Menu.Controls.Add(this.ChCdesc);
            this.Menu.Controls.Add(this.l4);
            this.Menu.Controls.Add(this.ChTag);
            this.Menu.Controls.Add(this.l3);
            this.Menu.Controls.Add(this.ChKeyword);
            this.Menu.Controls.Add(this.l2);
            this.Menu.Controls.Add(this.ChVDesc);
            this.Menu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Menu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(250)))));
            this.Menu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(250)))));
            this.Menu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(250)))));
            this.Menu.Location = new System.Drawing.Point(0, -3);
            this.Menu.Name = "Menu";
            this.Menu.Quality = 10;
            this.Menu.Size = new System.Drawing.Size(200, 473);
            this.Menu.TabIndex = 7;
            // 
            // SubMax
            // 
            this.SubMax.BorderColorFocused = System.Drawing.Color.White;
            this.SubMax.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubMax.BorderColorMouseHover = System.Drawing.Color.White;
            this.SubMax.BorderThickness = 2;
            this.SubMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubMax.Enabled = false;
            this.SubMax.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMax.ForeColor = System.Drawing.Color.White;
            this.SubMax.isPassword = false;
            this.SubMax.Location = new System.Drawing.Point(23, 152);
            this.SubMax.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SubMax.Name = "SubMax";
            this.SubMax.Size = new System.Drawing.Size(126, 33);
            this.SubMax.TabIndex = 18;
            this.SubMax.Text = "5000";
            this.SubMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubMax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SubMax_KeyUp);
            // 
            // SubMin
            // 
            this.SubMin.BorderColorFocused = System.Drawing.Color.White;
            this.SubMin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubMin.BorderColorMouseHover = System.Drawing.Color.White;
            this.SubMin.BorderThickness = 2;
            this.SubMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubMin.Enabled = false;
            this.SubMin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMin.ForeColor = System.Drawing.Color.White;
            this.SubMin.isPassword = false;
            this.SubMin.Location = new System.Drawing.Point(23, 78);
            this.SubMin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SubMin.Name = "SubMin";
            this.SubMin.Size = new System.Drawing.Size(126, 33);
            this.SubMin.TabIndex = 10;
            this.SubMin.Text = "0";
            this.SubMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubMin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SubMin_KeyUp);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Montserrat Thin", 12F);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(19, 125);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(42, 22);
            this.bunifuCustomLabel10.TabIndex = 17;
            this.bunifuCustomLabel10.Text = "Max";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Montserrat Thin", 12F);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(19, 54);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(40, 22);
            this.bunifuCustomLabel9.TabIndex = 16;
            this.bunifuCustomLabel9.Text = "Min";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(8, 23);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(141, 29);
            this.bunifuCustomLabel8.TabIndex = 13;
            this.bunifuCustomLabel8.Text = "Subscribers :";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(8, 240);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(105, 29);
            this.bunifuCustomLabel7.TabIndex = 12;
            this.bunifuCustomLabel7.Text = "Filter By :";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.Black;
            this.l1.Location = new System.Drawing.Point(48, 276);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(154, 29);
            this.l1.TabIndex = 11;
            this.l1.Text = "Channel Desc";
            // 
            // ChCdesc
            // 
            this.ChCdesc.BackColor = System.Drawing.Color.White;
            this.ChCdesc.ChechedOffColor = System.Drawing.Color.White;
            this.ChCdesc.Checked = false;
            this.ChCdesc.CheckedOnColor = System.Drawing.Color.Black;
            this.ChCdesc.ForeColor = System.Drawing.Color.White;
            this.ChCdesc.Location = new System.Drawing.Point(23, 282);
            this.ChCdesc.Name = "ChCdesc";
            this.ChCdesc.Size = new System.Drawing.Size(20, 20);
            this.ChCdesc.TabIndex = 10;
            this.ChCdesc.Click += new System.EventHandler(this.bunifuCheckbox5_Click);
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.Color.Transparent;
            this.l4.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.ForeColor = System.Drawing.Color.Black;
            this.l4.Location = new System.Drawing.Point(54, 405);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(50, 29);
            this.l4.TabIndex = 7;
            this.l4.Text = "Tag";
            // 
            // ChTag
            // 
            this.ChTag.BackColor = System.Drawing.Color.White;
            this.ChTag.ChechedOffColor = System.Drawing.Color.White;
            this.ChTag.Checked = false;
            this.ChTag.CheckedOnColor = System.Drawing.Color.Black;
            this.ChTag.ForeColor = System.Drawing.Color.White;
            this.ChTag.Location = new System.Drawing.Point(23, 411);
            this.ChTag.Name = "ChTag";
            this.ChTag.Size = new System.Drawing.Size(20, 20);
            this.ChTag.TabIndex = 6;
            this.ChTag.Click += new System.EventHandler(this.bunifuCheckbox5_Click);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.ForeColor = System.Drawing.Color.Black;
            this.l3.Location = new System.Drawing.Point(52, 362);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(103, 29);
            this.l3.TabIndex = 5;
            this.l3.Text = "Keyword";
            // 
            // ChKeyword
            // 
            this.ChKeyword.BackColor = System.Drawing.Color.White;
            this.ChKeyword.ChechedOffColor = System.Drawing.Color.White;
            this.ChKeyword.Checked = false;
            this.ChKeyword.CheckedOnColor = System.Drawing.Color.Black;
            this.ChKeyword.ForeColor = System.Drawing.Color.White;
            this.ChKeyword.Location = new System.Drawing.Point(23, 368);
            this.ChKeyword.Name = "ChKeyword";
            this.ChKeyword.Size = new System.Drawing.Size(20, 20);
            this.ChKeyword.TabIndex = 4;
            this.ChKeyword.Click += new System.EventHandler(this.bunifuCheckbox5_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("Montserrat Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.ForeColor = System.Drawing.Color.Black;
            this.l2.Location = new System.Drawing.Point(49, 319);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(125, 29);
            this.l2.TabIndex = 3;
            this.l2.Text = "Video Desc";
            // 
            // DataResponse
            // 
            this.DataResponse.AllowUserToAddRows = false;
            this.DataResponse.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataResponse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataResponse.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataResponse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Montserrat Thin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataResponse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataResponse.ColumnHeadersHeight = 30;
            this.DataResponse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChannelName,
            this.Subscribers,
            this.Link,
            this.Email});
            this.DataResponse.DoubleBuffered = true;
            this.DataResponse.EnableHeadersVisualStyles = false;
            this.DataResponse.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.DataResponse.HeaderForeColor = System.Drawing.Color.Black;
            this.DataResponse.Location = new System.Drawing.Point(222, 75);
            this.DataResponse.Name = "DataResponse";
            this.DataResponse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataResponse.RowHeadersWidth = 4;
            this.DataResponse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataResponse.Size = new System.Drawing.Size(648, 330);
            this.DataResponse.TabIndex = 8;
            this.DataResponse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataResponse_CellContentClick);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Export";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(712, 411);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(158, 47);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Export";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = false;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(661, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(93, 33);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Textcolor = System.Drawing.Color.Black;
            this.btnSearch.TextFont = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.animated = false;
            this.ProgressCircle.animationIterval = 8;
            this.ProgressCircle.animationSpeed = 5;
            this.ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressCircle.BackgroundImage")));
            this.ProgressCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ProgressCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(250)))));
            this.ProgressCircle.LabelVisible = false;
            this.ProgressCircle.LineProgressThickness = 8;
            this.ProgressCircle.LineThickness = 8;
            this.ProgressCircle.Location = new System.Drawing.Point(506, 405);
            this.ProgressCircle.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgressCircle.MaxValue = 100;
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressCircle.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(250)))));
            this.ProgressCircle.Size = new System.Drawing.Size(67, 67);
            this.ProgressCircle.TabIndex = 11;
            this.ProgressCircle.Value = 20;
            this.ProgressCircle.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Montserrat Thin", 12F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(223, 408);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(54, 22);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Total :";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Montserrat Thin", 12F);
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(275, 409);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(20, 22);
            this.Total.TabIndex = 20;
            this.Total.Text = "0";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_Youtube.Properties.Resources.off;
            this.pictureBox1.Location = new System.Drawing.Point(864, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::_Youtube.Properties.Resources.on;
            this.pictureBox2.Location = new System.Drawing.Point(838, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnStop
            // 
            this.btnStop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.BorderRadius = 0;
            this.btnStop.ButtonText = "Stop";
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.DisabledColor = System.Drawing.Color.Gray;
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStop.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStop.Iconimage")));
            this.btnStop.Iconimage_right = null;
            this.btnStop.Iconimage_right_Selected = null;
            this.btnStop.Iconimage_Selected = null;
            this.btnStop.IconMarginLeft = 0;
            this.btnStop.IconMarginRight = 0;
            this.btnStop.IconRightVisible = true;
            this.btnStop.IconRightZoom = 0D;
            this.btnStop.IconVisible = false;
            this.btnStop.IconZoom = 90D;
            this.btnStop.IsTab = false;
            this.btnStop.Location = new System.Drawing.Point(773, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(233)))), ((int)(((byte)(250)))));
            this.btnStop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btnStop.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnStop.selected = false;
            this.btnStop.Size = new System.Drawing.Size(97, 33);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStop.Textcolor = System.Drawing.Color.Black;
            this.btnStop.TextFont = new System.Drawing.Font("Montserrat Thin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pChrome
            // 
            this.pChrome.Location = new System.Drawing.Point(752, 418);
            this.pChrome.Name = "pChrome";
            this.pChrome.Size = new System.Drawing.Size(59, 37);
            this.pChrome.TabIndex = 24;
            // 
            // SubCheck
            // 
            this.SubCheck.BackColor = System.Drawing.Color.White;
            this.SubCheck.ChechedOffColor = System.Drawing.Color.White;
            this.SubCheck.Checked = false;
            this.SubCheck.CheckedOnColor = System.Drawing.Color.Black;
            this.SubCheck.ForeColor = System.Drawing.Color.White;
            this.SubCheck.Location = new System.Drawing.Point(154, 29);
            this.SubCheck.Name = "SubCheck";
            this.SubCheck.Size = new System.Drawing.Size(20, 20);
            this.SubCheck.TabIndex = 19;
            this.SubCheck.OnChange += new System.EventHandler(this.SubCheck_OnChange);
            // 
            // ChannelName
            // 
            this.ChannelName.HeaderText = "Channel Name";
            this.ChannelName.Name = "ChannelName";
            this.ChannelName.Width = 154;
            // 
            // Subscribers
            // 
            this.Subscribers.HeaderText = "Subscribers";
            this.Subscribers.Name = "Subscribers";
            this.Subscribers.Width = 105;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Link.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 185;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(885, 470);
            this.Controls.Add(this.pChrome);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.ProgressCircle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.DataResponse);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.SearchField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox SearchField;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox ChVDesc;
        private Bunifu.Framework.UI.BunifuGradientPanel Menu;
        private Bunifu.Framework.UI.BunifuCustomLabel l4;
        private Bunifu.Framework.UI.BunifuCheckbox ChTag;
        private Bunifu.Framework.UI.BunifuCustomLabel l3;
        private Bunifu.Framework.UI.BunifuCheckbox ChKeyword;
        private Bunifu.Framework.UI.BunifuCustomLabel l2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel l1;
        private Bunifu.Framework.UI.BunifuCheckbox ChCdesc;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox SubMax;
        private Bunifu.Framework.UI.BunifuMetroTextbox SubMin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataResponse;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgressCircle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnStop;
        private System.Windows.Forms.Panel pChrome;
        private Bunifu.Framework.UI.BunifuCheckbox SubCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscribers;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Timer timer1;
    }
}

