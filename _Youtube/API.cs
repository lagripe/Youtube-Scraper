using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using CefSharp.WinForms;
using CefSharp;

namespace _Youtube
{
    class API
    {
        
        static string _email = "";
        //static ManualResetEvent onSignal = new ManualResetEvent(false);
        public static async Task ByKeyword(Int64 Min,Int64 Max, Bunifu.Framework.UI.BunifuCustomDataGrid Grid,String Keyword, Bunifu.Framework.UI.BunifuCustomLabel Total)
        {
            Console.WriteLine(Form1.browser.IsBrowserInitialized);
            Console.WriteLine("Access");
            Int64 total=0;
            String PageToken="";
           
            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw",
                    ApplicationName = "_Youtube"
                });
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = Keyword; // Replace with your search term.
                searchListRequest.MaxResults = 50;
               // searchListRequest.Order = SearchResource.ListRequest.OrderEnum.ViewCount;


                while (PageToken != "null" ) {
                        searchListRequest.PageToken = PageToken;
                        var searchListResponse = await searchListRequest.ExecuteAsync();

                  foreach (var searchResult in searchListResponse.Items)
                  {
                        if (!Form1.isSearching)
                        {
                            //Form1.browser.CloseDevTools();
                            return;

                        }
                      using (var Webclient = new HttpClient())
                        {
                        Uri tempUrl = new Uri($"https://www.googleapis.com/youtube/v3/channels?part=statistics&id={searchResult.Snippet.ChannelId}&key=AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw");
                        String Subscribers = await Webclient.GetStringAsync(tempUrl);
                        if (Subscribers.Split('\n')[16].Contains("true"))
                            continue;

                        if (Form1.isSub)
                                if (Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) > Max || Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) < Min)
                                    continue;

                            //-------------------Fetching Email-------------------
                            Console.WriteLine("Fetching");
                            Form1.browser.Load($"www.youtube.com/channel/{searchResult.Snippet.ChannelId}/about");
                           // Form1.browser.LoadingStateChanged += getEmail;
                            
                            await _PageLoad(60);
                            Console.WriteLine($"Skiped PageLoad");
                            //-------------------Fetching Email-------------------

                            if (_email == "")
                                continue;

                            String[] tempX = { searchResult.Snippet.ChannelTitle, Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1], "https://www.youtube.com/channel/" + searchResult.Snippet.ChannelId+"/about", _email};
                            Grid.Rows.Add(tempX);
                            total++;
                            Total.Text = total.ToString();
                            _email = "";
                     }
                   }
                        PageToken = searchListResponse.NextPageToken;



                 }

               
            }
            catch(Exception z)
            {
               // MessageBox.Show(z.Message);
            }
            Form1.isSearching = false;

        }
        public static async Task ByTag(Int64 Min, Int64 Max, Bunifu.Framework.UI.BunifuCustomDataGrid Grid, String Keyword, Bunifu.Framework.UI.BunifuCustomLabel Total)
        {
            Console.WriteLine(Form1.browser.IsBrowserInitialized);
            Console.WriteLine("Access");
            Int64 total = 0;
            String PageToken = "";

            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw",
                    ApplicationName = "_Youtube"
                });
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = Keyword; // Replace with your search term.
                searchListRequest.MaxResults = 50;
                searchListRequest.Order = SearchResource.ListRequest.OrderEnum.ViewCount;

                Boolean exist = false;

                while (PageToken != "null")
                {
                    searchListRequest.PageToken = PageToken;
                    var searchListResponse = await searchListRequest.ExecuteAsync();

                    foreach (var searchResult in searchListResponse.Items)
                    {
                        if (!Form1.isSearching)
                        {
                            //Form1.browser.CloseDevTools();
                            return;

                        }
                        if (searchResult.Id.Kind != "youtube#video")
                            continue;
                        var searchTag = youtubeService.Videos.List("snippet");
                        searchTag.Id = searchResult.Id.VideoId;
                        var searchTagResponse = await searchTag.ExecuteAsync();
                        foreach(string tag in searchTagResponse.Items[0].Snippet.Tags)
                            foreach(string key in Keyword.Split(' '))
                                if (tag.Contains(key))
                                {
                                    exist = true;
                                    break;
                                }
                        if (!exist)
                            continue;
                        exist = true;
                        using (var Webclient = new HttpClient())
                        {
                            Uri tempUrl = new Uri($"https://www.googleapis.com/youtube/v3/channels?part=statistics&id={searchResult.Snippet.ChannelId}&key=AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw");
                            String Subscribers = await Webclient.GetStringAsync(tempUrl);
                            if (Subscribers.Split('\n')[16].Contains("true"))
                                continue;

                            if (Form1.isSub)
                                if (Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) > Max || Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) < Min)
                                    continue;


                            //-------------------Fetching Email-------------------
                            Console.WriteLine("Fetching");
                            Form1.browser.Load($"www.youtube.com/channel/{searchResult.Snippet.ChannelId}/about");
                            // Form1.browser.LoadingStateChanged += getEmail;

                            await _PageLoad(60);
                            Console.WriteLine($"Skiped PageLoad");
                            //-------------------Fetching Email-------------------

                            if (_email == "")
                                continue;

                            String[] tempX = { searchResult.Snippet.ChannelTitle, Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1], "https://www.youtube.com/channel/" + searchResult.Snippet.ChannelId + "/about", _email };
                            Grid.Rows.Add(tempX);
                            total++;
                            Total.Text = total.ToString();
                            _email = "";
                        }
                    }
                    PageToken = searchListResponse.NextPageToken;



                }


            }
            catch (Exception z)
            {
                // MessageBox.Show(z.Message);
            }
            Form1.isSearching = false;

        }
        public static async Task ByItemDescription(Int64 Min, Int64 Max, Bunifu.Framework.UI.BunifuCustomDataGrid Grid, String Keyword, Bunifu.Framework.UI.BunifuCustomLabel Total)
        {
            Console.WriteLine(Form1.browser.IsBrowserInitialized);
            Console.WriteLine("Access");
            Int64 total = 0;
            String PageToken = "";

            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw",
                    ApplicationName = "_Youtube"
                });
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = Keyword; // Replace with your search term.
                searchListRequest.MaxResults = 50;
                searchListRequest.Order = SearchResource.ListRequest.OrderEnum.ViewCount;

                Boolean exist =false;
                
                while (PageToken != "null")
                {
                    searchListRequest.PageToken = PageToken;
                    var searchListResponse = await searchListRequest.ExecuteAsync();

                    foreach (var searchResult in searchListResponse.Items)
                    {
                        if (!Form1.isSearching)
                        {
                            //Form1.browser.CloseDevTools();
                            return;

                        }
                       foreach(string k in Keyword.Split(' '))
                        {
                            if (searchResult.Snippet.Description.Contains(k))
                            { exist = true; break; }
                        }
                        if (!exist)
                            continue;
                        exist = false;
                        using (var Webclient = new HttpClient())
                        {
                            Uri tempUrl = new Uri($"https://www.googleapis.com/youtube/v3/channels?part=statistics&id={searchResult.Snippet.ChannelId}&key=AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw");
                            String Subscribers = await Webclient.GetStringAsync(tempUrl);
                            if (Subscribers.Split('\n')[16].Contains("true"))
                                continue;

                            if (Form1.isSub)
                                if (Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) > Max || Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) < Min)
                                    continue;

                            //-------------------Fetching Email-------------------
                            Console.WriteLine("Fetching");
                            Form1.browser.Load($"www.youtube.com/channel/{searchResult.Snippet.ChannelId}/about");
                            // Form1.browser.LoadingStateChanged += getEmail;

                            await _PageLoad(60);
                            Console.WriteLine($"Skiped PageLoad");
                            //-------------------Fetching Email-------------------

                            if (_email == "")
                                continue;

                            String[] tempX = { searchResult.Snippet.ChannelTitle, Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1], "https://www.youtube.com/channel/" + searchResult.Snippet.ChannelId + "/about", _email };
                            Grid.Rows.Add(tempX);
                            total++;
                            Total.Text = total.ToString();
                            _email = "";
                        }
                    }
                    PageToken = searchListResponse.NextPageToken;



                }


            }
            catch (Exception z)
            {
                // MessageBox.Show(z.Message);
            }
            Form1.isSearching = false;

        }

        public static async Task ByChannelDescription(Int64 Min, Int64 Max, Bunifu.Framework.UI.BunifuCustomDataGrid Grid, String Keyword, Bunifu.Framework.UI.BunifuCustomLabel Total)
        {
            Console.WriteLine(Form1.browser.IsBrowserInitialized);
            Console.WriteLine("Access");
            Int64 total = 0;
            String PageToken = "";

            try
            {
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw",
                    ApplicationName = "_Youtube"
                });
                var searchListRequest = youtubeService.Search.List("snippet");
                searchListRequest.Q = Keyword; // Replace with your search term.
                searchListRequest.MaxResults = 50;
                searchListRequest.Order = SearchResource.ListRequest.OrderEnum.ViewCount;

                Boolean exist = false;


                while (PageToken != "null")
                {
                    searchListRequest.PageToken = PageToken;
                    var searchListResponse = await searchListRequest.ExecuteAsync();

                    foreach (var searchResult in searchListResponse.Items)
                    {
                        if (!Form1.isSearching)
                        {
                            return;

                        }
                        //---------getting channel description---------------
                        var searchDescription = youtubeService.Channels.List("snippet");
                        searchDescription.Id = searchResult.Snippet.ChannelId;
                        var searchDEscResponse = await searchDescription.ExecuteAsync();

                        foreach (string k in Keyword.Split(' '))
                        {
                            if (searchDEscResponse.Items[0].Snippet.Description.Contains(k))
                            { exist = true; break; }
                        }
                        if (!exist)
                            continue;
                        exist = false;
                        //---------getting channel description--------------

                        using (var Webclient = new HttpClient())
                        {
                            Uri tempUrl = new Uri($"https://www.googleapis.com/youtube/v3/channels?part=statistics&id={searchResult.Snippet.ChannelId}&key=AIzaSyC3E-CwcboQuhV5qhAukGdYnFlONzmkJJw");
                            String Subscribers = await Webclient.GetStringAsync(tempUrl);
                            if (Subscribers.Split('\n')[16].Contains("true"))
                                continue;


                            if (Form1.isSub)
                                if (Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) > Max || Int64.Parse(Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1]) < Min)
                                    continue;

                            //-------------------Fetching Email-------------------
                            Console.WriteLine("Fetching");
                            Form1.browser.Load($"www.youtube.com/channel/{searchResult.Snippet.ChannelId}/about");
                            // Form1.browser.LoadingStateChanged += getEmail;

                            await _PageLoad(60);
                            Console.WriteLine($"Skiped PageLoad");
                            //-------------------Fetching Email-------------------

                            if (_email == "")
                                continue;

                            String[] tempX = { searchResult.Snippet.ChannelTitle, Subscribers.Split('\n')[15].Split(':')[1].Substring(1).Split('"')[1], "https://www.youtube.com/channel/" + searchResult.Snippet.ChannelId + "/about", _email };
                            Grid.Rows.Add(tempX);
                            total++;
                            Total.Text = total.ToString();
                            _email = "";
                        }
                    }
                    PageToken = searchListResponse.NextPageToken;



                }


            }
            catch (Exception z)
            {
                // MessageBox.Show(z.Message);
            }
            Form1.isSearching = false;

        }



        private static Boolean isCompleted;
        
        private async static Task _PageLoad(int TimeOut)
        {
            try { 
            isCompleted = false;
           
            int TimeElapsed = 0;
            Form1.browser.FrameLoadEnd += (s, e) =>
            {
                if (!Form1.isSearching)
                {
                   // Form1.browser.CloseDevTools();
                    return;
                }
                //------------------getEmail
                //Reccomended to use an anon closure
                const string script = @"document.getElementById('email-container').children.length";

                 Form1.browser.EvaluateScriptAsync(script).ContinueWith(x =>
                {
                    var response = x.Result;
                    if (!response.Success) { 
                        _email = "Server timeout";
                        isCompleted = true;
                        return;
                    }
                    int ChildLength = (int)response.Result;
                    Console.WriteLine(ChildLength);

                    if (ChildLength == 0)
                    {
                        //--------------To Check ----------
                        const string script3 = @"function myFunction() {var y=document.getElementsByTagName('yt-formatted-string');var i;for (i = 0; i < y.length; i++){if (y[i].textContent == 'View email address'){ return '1'; }}return '0';}myFunction();";
                        Form1.browser.EvaluateScriptAsync(script3).ContinueWith(z =>
                        {
                            var response3 = z.Result;
                            if (!response3.Success)
                            {
                                _email = "Server timeout";
                                isCompleted = true;
                                return;
                            }
                            String ChildLengthtag = (String)response3.Result;
                            Console.WriteLine( ChildLengthtag);
                            if (ChildLengthtag =="0")
                                _email = "Unavailable";
                            else
                                _email = "Get email manually";


                        });
                    }
                    // _email = "Get Email Manually";
                    else
                    {
                        const string script2 = @"document.getElementById('email-container').children[0].innerHTML";
                        Form1.browser.EvaluateScriptAsync(script2).ContinueWith(y =>
                         {
                             var response2 = y.Result;
                             _email = (String)response2.Result;
                         });
                    }
                       
                });




                isCompleted = true;
            };
            //
            while (!isCompleted && Form1.isSearching)
            {
                await Task.Delay(10);//interval of 10 ms worked good for me
                TimeElapsed++;
                
            }
                if (!Form1.isSearching)
                {
                    //Form1.browser.CloseDevTools();
                    return;

                }
                await Task.Delay(30);

            }
            catch (Exception z)
            {
                //MessageBox.Show(z.Message);
            }

        }

        
    }
}
