using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneAddress
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> phoneBook;
        public Form1()
        {
            InitializeComponent();
            this.phoneBook = new Dictionary<string, string>();

            //ファイルからデータを読み込む
            ReadFromFile();

            //Listに名前を表示する
            foreach (KeyValuePair<string, string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }
        }

        private void ReadFromFile()
        {
            using (System.IO.StreamReader file =
                   new System.IO.StreamReader(@"..\..\data.txt"))
            {
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');
                    this.phoneBook.Add(data[0], data[1]);
                }
            }
        }

        private void NameSelected(object sender, EventArgs e)
        {
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name];
        }
    }
}
