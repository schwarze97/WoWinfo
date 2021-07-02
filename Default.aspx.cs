using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;
using WoWinfo.Models;

namespace WoWinfo
{
    public partial class _Default : Page
    {
        WebClient client = new WebClient();
        character myCharacter = new character();
        string Info;
        

        public _Default()
        {

            this.Info = client.DownloadString("https://eu.api.blizzard.com/profile/wow/character/zuljin/animarc?namespace=profile-eu&locale=en_GB&access_token=US8AA3p6Gca6sqTncc4Ml6IQW8O75lecGo");
            myCharacter = JsonConvert.DeserializeObject<character>(Info);

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnInfo_Click(object sender, EventArgs e)
        {
            TextBox1.Text = myCharacter.name;
            TextBox2.Text = myCharacter.level.ToString();
            TextBox3.Text = myCharacter.id.ToString();
        }
    }
}