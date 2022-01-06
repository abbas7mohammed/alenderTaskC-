using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calender1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for(i = 1; i <= 12; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
            }
        }
        string month;
        Int32 d1;
        Int32 d2;
        Int32 d3;
        Int32 d4;
        Int32 d5;
        Int32 d6;
        Int32 d7;
        Int32 d8;
        Int32 d9;
        Int32 d10;
        Int32 d11;
        Int32 d12;
        Int32 d13;
        Int32 d14;
        Int32 d15;
        Int32 d16;
        Int32 d17;
        Int32 d18;
        Int32 d19;
        Int32 d20;
        Int32 d21;
        Int32 d22;
        Int32 d23;
        Int32 d24;
        Int32 d25;
        Int32 d26;
        Int32 d27;
        Int32 d28;
        Int32 d29;
        Int32 d30;
        Int32 d31;
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            Int32 no;
            Int32.TryParse(this.comboBox1.Text, out no);
            

            switch(no)
            {
                case 1:
                    month = "Junuary";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "Desember";
                    break;
            }
            this.label1.Text = month;


            //=============days===================



            Int32.TryParse(this._1.Text, out d1);
            Int32.TryParse(this._2.Text, out d1);
            Int32.TryParse(this._3.Text, out d1);
            Int32.TryParse(this._4.Text, out d1);
            Int32.TryParse(this._5.Text, out d1);
            Int32.TryParse(this._6.Text, out d1);
            Int32.TryParse(this._7.Text, out d1);
            Int32.TryParse(this._8.Text, out d1);
            Int32.TryParse(this._9.Text, out d1);
            Int32.TryParse(this._10.Text, out d1);
            Int32.TryParse(this._11.Text, out d1);
            Int32.TryParse(this._12.Text, out d1);
            Int32.TryParse(this._13.Text, out d1);
            Int32.TryParse(this._14.Text, out d1);
            Int32.TryParse(this._15.Text, out d1);
            Int32.TryParse(this._16.Text, out d1);
            Int32.TryParse(this._17.Text, out d1);
            Int32.TryParse(this._18.Text, out d1);
            Int32.TryParse(this._19.Text, out d1);
            Int32.TryParse(this._20.Text, out d1);
            Int32.TryParse(this._21.Text, out d1);
            Int32.TryParse(this._22.Text, out d1);
            Int32.TryParse(this._23.Text, out d1);
            Int32.TryParse(this._24.Text, out d1);
            Int32.TryParse(this._25.Text, out d1);
            Int32.TryParse(this._26.Text, out d1);
            Int32.TryParse(this._27.Text, out d1);
            Int32.TryParse(this._28.Text, out d1);
            Int32.TryParse(this._29.Text, out d1);
            Int32.TryParse(this._30.Text, out d1);
            Int32.TryParse(this._31.Text, out d1);


            switch(no)
            {
                case 1:
                    d1 = 1;
                    d2 = 2;
                    d3 = 3;
                    d4 = 4;
                    d5 = 5;
                    d6 = 6;
                    d7 = 7;
                    d8 = 8;
                    d9 = 9;
                    d10 = 10;
                    d11 = 11;
                    d12 = 12;
                    d13 = 13;
                    d14 = 14;
                    d15 = 15;
                    d16 = 16;
                    d17 = 17;
                    d18 = 18;
                    d19 = 19;
                    d20 = 20;
                    d21 = 21;
                    d22 = 22;
                    d23 = 23;
                    d24 = 24;
                    d25 = 25;
                    d26 = 26;
                    d27 = 27;
                    d28 = 28;
                    d29 = 29;
                    d30 = 30;
                    d31 = 31;
                    break;
                case 2:
                    d1 = 1;
                    d2 = 2;
                    d3 = 3;
                    d4 = 4;
                    d5 = 5;
                    d6 = 6;
                    d7 = 7;
                    d8 = 8;
                    d9 = 9;
                    d10 = 10;
                    d11 = 11;
                    d12 = 12;
                    d13 = 13;
                    d14 = 14;
                    d15 = 15;
                    d16 = 16;
                    d17 = 17;
                    d18 = 18;
                    d19 = 19;
                    d20 = 20;
                    d21 = 21;
                    d22 = 22;
                    d23 = 23;
                    d24 = 24;
                    d25 = 25;
                    d26 = 26;
                    d27 = 27;
                    d28 = 28;
                    break;
                case 3:
                    d1 = 1;
                    d2 = 2;
                    d3 = 3;
                    d4 = 4;
                    d5 = 5;
                    d6 = 6;
                    d7 = 7;
                    d8 = 8;
                    d9 = 9;
                    d10 = 10;
                    d11 = 11;
                    d12 = 12;
                    d13 = 13;
                    d14 = 14;
                    d15 = 15;
                    d16 = 16;
                    d17 = 17;
                    d18 = 18;
                    d19 = 19;
                    d20 = 20;
                    d21 = 21;
                    d22 = 22;
                    d23 = 23;
                    d24 = 24;
                    d25 = 25;
                    d26 = 26;
                    d27 = 27;
                    d28 = 28;
                    d29 = 29;
                    d30 = 30;
                    d31 = 31;
                    break;
                case 4:
                    d1 = 1;
                    d2 = 2;
                    d3 = 3;
                    d4 = 4;
                    d5 = 5;
                    d6 = 6;
                    d7 = 7;
                    d8 = 8;
                    d9 = 9;
                    d10 = 10;
                    d11 = 11;
                    d12 = 12;
                    d13 = 13;
                    d14 = 14;
                    d15 = 15;
                    d16 = 16;
                    d17 = 17;
                    d18 = 18;
                    d19 = 19;
                    d20 = 20;
                    d21 = 21;
                    d22 = 22;
                    d23 = 23;
                    d24 = 24;
                    d25 = 25;
                    d26 = 26;
                    d27 = 27;
                    d28 = 28;
                    d29 = 29;
                    d30 = 30;
                    break;
                case 5:
                    d1 = 1;
                    d2 = 2;
                    d3 = 3;
                    d4 = 4;
                    d5 = 5;
                    d6 = 6;
                    d7 = 7;
                    d8 = 8;
                    d9 = 9;
                    d10 = 10;
                    d11 = 11;
                    d12 = 12;
                    d13 = 13;
                    d14 = 14;
                    d15 = 15;
                    d16 = 16;
                    d17 = 17;
                    d18 = 18;
                    d19 = 19;
                    d20 = 20;
                    d21 = 21;
                    d22 = 22;
                    d23 = 23;
                    d24 = 24;
                    d25 = 25;
                    d26 = 26;
                    d27 = 27;
                    d28 = 28;
                    d29 = 29;
                    d30 = 30;
                    d31 = 31;
                    break;
            }
            this._1.Text = d1.ToString();
            this._2.Text = d2.ToString();
            this._3.Text = d3.ToString();
            this._4.Text = d4.ToString();
            this._5.Text = d5.ToString();
            this._6.Text = d6.ToString();
            this._7.Text = d7.ToString();
            this._8.Text = d8.ToString();
            this._9.Text = d9.ToString();
            this._10.Text = d10.ToString();
            this._11.Text = d11.ToString();
            this._12.Text = d12.ToString();
            this._13.Text = d13.ToString();
            this._14.Text = d14.ToString();
            this._15.Text = d15.ToString();
            this._16.Text = d16.ToString();
            this._17.Text = d17.ToString();
            this._18.Text = d18.ToString();
            this._19.Text = d19.ToString();
            this._20.Text = d20.ToString();
            this._21.Text = d21.ToString();
            this._22.Text = d22.ToString();
            this._23.Text = d23.ToString();
            this._24.Text = d24.ToString();
            this._25.Text = d25.ToString();
            this._26.Text = d26.ToString();
            this._27.Text = d27.ToString();
            this._28.Text = d28.ToString();
            this._29.Text = d29.ToString();
            this._30.Text = d30.ToString();
            this._31.Text = d31.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
