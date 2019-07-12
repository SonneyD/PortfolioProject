using ConsoleGenerator;
using DestinyEndpints.ClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BungieAPI_Project
{
    public partial class Form1 : Form
    {
        private DestinyApi api;
        public Form1()
        {
            InitializeComponent();
            api = new DestinyApi("76de47aca6f44fc48272d98aab6b6e26");
            

            //var temp = api.Destiny2_SearchDestinyPlayer("SonneyD", 2);
            Console.WriteLine(api.CommunityContent_GetCommunityContent(1,1,1));
            
        }
    }
}
