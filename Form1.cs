using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Очередь_вариант_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 1;
        int count1 = 0;
        int place = 0;
        int n = 0;
        Queue x = new Queue();
        Queue x2 = new Queue();
        Queue x3 = new Queue();
        Queue x5 = new Queue();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count1 = Convert.ToInt32(textBox1.Text)+1;
            x2.Enqeue(1);
            x3.Enqeue(1);
            x5.Enqeue(1);

            while (count < count1)
            {

                int y = 0;
                x2.Enqeue(count * 2);
                x3.Enqeue(count * 3);
                x5.Enqeue(count * 5);
                if (x2[0] <= x3[0])
                {
                    if (x2[0] == x3[0]) x3.Deqeue();
                    n = x2[0];
                    y = 1;
                    place = 2;
                }
                else if (x2[0] > x3[0])
                {
                    n = x3[0];
                    place = 3;
                    y = 1;
                   
                }
                
                if (x5[0] <= x2[0] && place == 2)
                {
                    if (x5[0] == x2[0]) x2.Deqeue();
                    n = x5[0];
                    x5.Deqeue();
                    place = 5;
                    y = 0;
                }
                if (x5[0] <= x3[0] && place == 3)
                {
                    if (x5[0] == x3[0]) x3.Deqeue();
                    n = x5[0];
                    x5.Deqeue();
                    place = 5;
                    y = 0;
                }
                if (y == 1)
                {
                    if (place == 2) x2.Deqeue();
                    if (place == 3) x3.Deqeue();
                }
                x.Enqeue(n);
                count++;

            }
            foreach(var i in x) listBox1.Items.Add(i);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
