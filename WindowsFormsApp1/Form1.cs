using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.100 Safari/537.36";
            
            foreach (var item in userAgent.Split(' '))
            {
                if (item.Contains("/"))
                {
                    string arananVersion = "76.0";
                    string browser = item.Substring(0, item.IndexOf("/"));
                    string version = item.Replace(browser, "").Remove(0,1);
                    if (version.StartsWith(arananVersion))
                    {
                        listBox1.Items.Add($"======Browser:{browser}-Versiyon:{version}");
                    }
                    else
                    {
                        listBox1.Items.Add($"Browser:{browser}-Versiyon:{version}");
                    }
                    
                }
            }
        }
    }
}
