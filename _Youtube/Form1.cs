using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using CefSharp;
using CefSharp.WinForms;
using System.Drawing;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _Youtube
{
    public partial class Form1 : Form
    {
        public static ChromiumWebBrowser browser;
        List<Bunifu.Framework.UI.BunifuCheckbox> Checks = new List<Bunifu.Framework.UI.BunifuCheckbox>();
        public static Boolean isSearching = false;
        public static Boolean isSub = false;
        HttpListener _listener;
        public Form1()
        {
            InitializeComponent();
        }
         //the function uses the API
        private   void Form1_Load(object sender, EventArgs e)
        {
            //-----------setting _listener
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:60024/");
            _listener.Start();
            //-----------setting _listener
            Checks.Add(ChVDesc);
            Checks.Add(ChKeyword);
            Checks.Add(ChTag);
            Checks.Add(ChCdesc);
            timer1.Start();

            var Set = new CefSettings();
            Set.CefCommandLineArgs.Add("no-proxy-server", "1");
            Cef.Initialize(Set);
            
            browser = new ChromiumWebBrowser("https://www.youtube.com/channel/UCwRXb5dUK4cvsHbx-rGzSgw/about");
            
            browser.FrameLoadEnd += ActiveSearch;
            browser.Width = 150;
            browser.Height = 150;
            browser.Location = new Point(0, 0);
            pChrome.Controls.Add(browser);
            pChrome.SendToBack();
           // browser.Visible = true;
            browser.IsBrowserInitializedChanged += ( (s,d)=> {
                Console.WriteLine("GotInit!!!!");
                });

           
            //browser.Stop();

        }
        
        private void ActiveSearch(object sender ,FrameLoadEndEventArgs e)
        {
            btnSearch.Enabled = true;
            browser.FrameLoadEnd -= ActiveSearch;
            
        }


        private void uncheck(Bunifu.Framework.UI.BunifuCheckbox Check)
        {
            foreach (Bunifu.Framework.UI.BunifuCheckbox c in Checks)
            {
                if (c.Name == Check.Name)
                    continue;
                c.Checked = false;
            }
        }

        //Uncheck all
        private void bunifuCheckbox5_Click(object sender, EventArgs e)
        {
            uncheck((Bunifu.Framework.UI.BunifuCheckbox)sender);
        }
        [STAThread]
        private  async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Boolean allowed = false;
            foreach (Bunifu.Framework.UI.BunifuCheckbox c in Checks)
            {
                if (c.Checked) { allowed = true; break; }

            }
            if (!allowed)
            {
                MessageBox.Show("No Filter Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(SearchField.Text.Trim()))
            {
                MessageBox.Show("Nothing to search for", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (SubCheck.Checked)
            {
                if (Int64.Parse(SubMax.Text) < Int64.Parse(SubMin.Text))
                {
                    MessageBox.Show("Error in subscribers interval", "Logical error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                isSub = true;
            }
            else
            {
                isSub = false;
            }
            DataResponse.Rows.Clear();
            
            btnStop.Enabled = true;
            btnSearch.Enabled = false;
            Menu.Enabled = false;

            ProgressCircle.Visible = true;
            ProgressCircle.animated = true;
            isSearching = true;
            Total.Text ="0";

            if (ChKeyword.Checked)
                await API.ByKeyword(Int64.Parse(SubMin.Text),Int64.Parse(SubMax.Text),DataResponse, SearchField.Text, Total);
            if (ChVDesc.Checked)
                await API.ByItemDescription(Int64.Parse(SubMin.Text), Int64.Parse(SubMax.Text), DataResponse, SearchField.Text, Total);
            if (ChCdesc.Checked)
                await API.ByChannelDescription(Int64.Parse(SubMin.Text), Int64.Parse(SubMax.Text), DataResponse, SearchField.Text, Total);
            if (ChTag.Checked)
                await API.ByTag(Int64.Parse(SubMin.Text), Int64.Parse(SubMax.Text), DataResponse, SearchField.Text, Total);

            btnStop.Enabled = false;
            btnSearch.Enabled = true;
            ProgressCircle.animated = false;
            ProgressCircle.Visible = false;
            Menu.Enabled = true;
            
        }
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                MessageBox.Show("You have to stop the search first!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (Cef.IsInitialized)
                Cef.Shutdown();

           Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DataResponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2)
                return;
            if (e.RowIndex == -1)
                return;
            
            var url = DataResponse.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Process.Start(url);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            isSearching = false;
            btnStop.Enabled = false;
            btnSearch.Enabled = true;
            ProgressCircle.animated = false;
            ProgressCircle.Visible = false;
            Menu.Enabled = true;
        }

        private void SubMin_KeyUp(object sender, KeyEventArgs e)
        {
            Int64 x =0;
            if (!Int64.TryParse(SubMin.Text, out x))
                SubMin.Text = "";
        }

        private void SubMax_KeyUp(object sender, KeyEventArgs e)
        {
            Int64 x = 0;
            if (!Int64.TryParse(SubMax.Text, out x))
                SubMax.Text = "";
        }

        private void SubCheck_OnChange(object sender, EventArgs e)
        {
            if (!SubCheck.Checked) { 
                SubMin.Enabled = false;
                SubMax.Enabled = false;
                SubMax.Text = "5000";

            }
            else
            {
                SubMin.Enabled = true;
                SubMax.Enabled = true;
            }
        }

        private async  void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                
                HttpListenerContext context = await _listener.GetContextAsync();
                HttpListenerRequest request = context.Request;

                //Answer getCommand/get post data/do whatever
                string response;
                using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    response = reader.ReadToEnd();
                }
                Console.WriteLine(response);
                // Console.WriteLine(response);
                if (response.Contains("#"))
                {

                    string email=response.Split('#')[1], channel= response.Split('#')[0];
                    lock (DataResponse) { 
                        for(int i = 0; i < DataResponse.Rows.Count;i++)
                        {
                            if (DataResponse.Rows[i].Cells[0].Value.Equals(channel))
                                DataResponse.Rows[i].Cells[3].Value = email;

                        }
                    }
                }


                
            }
            catch (Exception z) { }
            finally {  }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (isSearching)
            {
                MessageBox.Show("You have to stop the search first!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SaveToCSV(DataResponse);


        }

        private void SaveToCSV(DataGridView DGV)
        {
            RegexUtilities ut = new RegexUtilities();
            
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data will be exported and you will be notified when it is ready.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                
                string[] output = new string[DGV.RowCount + 1];
                int k = 0;
                for (int i = 0; i < DGV.RowCount; i++)
                {

                    if (ut.IsValidEmail(DGV.Rows[i].Cells[3].Value.ToString())) { 
                            output[k] += DGV.Rows[i].Cells[3].Value.ToString();
                        k++;
                    }

                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Your file was generated and its ready for use.");
            }
        }

    }
    public class RegexUtilities
    {
        bool invalid = false;

        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid email format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
