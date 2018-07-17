using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> phoneBook;

        public Form1()
        {
            InitializeComponent();

            //電話帳に名前を登録する
            this.phoneBook = new Dictionary<string, string>();
            this.phoneBook.Add("長谷　澪", "xxx-5321-1125");
            this.phoneBook.Add("服部　楓", "xxx-8458-3694");
            this.phoneBook.Add("戸田　文", "xxx-9881-3211");
            this.phoneBook.Add("村尾　将", "xxx-1147-0150");

            //リストに名前を表示する
            foreach(KeyValuePair<string, string> data in phoneBook)
            {
                this.nameList.Items.Add(data.Key);
            }
        }

        private void NameSelected(object sender, EventArgs e)
        {
            //選択した名前に対応する電話番号を表示する
            string name = this.nameList.Text;
            this.phoneNumber.Text = this.phoneBook[name];
        }
    }
}
