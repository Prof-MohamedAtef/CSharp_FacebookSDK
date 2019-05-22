using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;

namespace FaceBookSDKAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            string OAuthUrl = @"https://www.facebook.com/dialog/oauth?client_id=962659580413555&&redirect_uri=https://www.facebook.com/connect/login_success.html&response_type=token&scope=user_groups";//we can add more permissions here in addition to "user_groups" using comma "," ...
            WebFaceBook.Navigate(OAuthUrl);

        }
        string access_token;
        private void WebFaceBook_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (WebFaceBook.Url.AbsoluteUri.Contains("access_token"))
            {
                string Url1 = WebFaceBook.Url.AbsoluteUri;
                string Url2 = Url1.Substring(Url1.IndexOf("access_token") + 13);
                access_token = Url2.Substring(0, Url2.IndexOf("&"));
                MessageBox.Show("access_token = "+access_token);

                FacebookClient fb = new FacebookClient(access_token);

                dynamic data = fb.Get("/me");

                MessageBox.Show("id=" + data.id + Environment.NewLine + "name=" + data.name + Environment.NewLine + "link=" + data.link);


            }
        }

        private void Btn_GetFriendList_Click(object sender, EventArgs e)
        {
            FacebookClient fb2 = new FacebookClient(access_token);
            dynamic FriendList = fb2.Get("/me/friends");//or we can view groups by exchangeing the word "friends" with "groups"...
            
            int count = (int)FriendList.data.Count;

            for (int i = 0; i < count; i++)
            {
                listBox_FriendList.Items.Add(FriendList.data[i].name);


            }

        }
    }
}
