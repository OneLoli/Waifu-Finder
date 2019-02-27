using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace InfoWaifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebRequest wrGETURL;
            string url = "https://api.jikan.moe/v3/search/character?q=" + in1.Text.ToLower() + "+" + in2.Text.ToLower() + "&limit=1";
            wrGETURL = WebRequest.Create(url);
            Stream objStream;
            try
            {
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(objStream);
                var json = sr.ReadToEnd();
                var jo = JObject.Parse(json);
                string image="";
                string name = "";
                foreach (var value in jo["results"])
                {
                    image = (string)value["image_url"];
                    name = (string)value["name"];
                };
                //var str = jo["results"].ToString();
                Form2 result = new Form2(image, name);
                result.Visible = true;
            }
            catch
            {
                Console.Write("Problemas de conexion");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dialogo de "acerca de"
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by TheLoliMaster." +
                "Contact mail: onelolikawaii@gmail.com");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
