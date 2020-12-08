using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnythingCanHappen
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)

            {
                if (page == 1)
                {
                    page = 2;
                }
                else if (page == 2)
                {
                    page = 23;
                }
                else if (page == 23)
                {
                    page = 24;
                }
                else if (page == 20)
                {
                    page = 22;
                }
                else if (page == 18)
                {
                    page = 20;
                }
                else if (page == 10)
                {
                    page = 11;
                }
                else if (page == 12)
                {
                    page = 15;
                }
                else if (page == 15)
                {
                    page = 17;
                }
                else if (page == 13)
                {
                    page = 11;
                }
                else if (page == 3)
                {
                    page = 4;
                }
                else if (page == 4)
                {
                    page = 5;
                }
                else if (page == 7)
                {
                    page = 9;
                }

            }
            if (e.KeyCode == Keys.D)
            {
                if (page == 1)
                {
                    page = 3;
                }
                else if (page == 3)
                {
                    page = 7;
                }
                else if (page == 7)
                {
                    page = 8;
                }
                else if (page == 4)
                {
                    page = 6;
                }
                else if (page == 10)
                {
                    page = 12;
                }
                else if (page == 12)
                {
                    page = 13;
                }
                else if (page == 13)
                {
                    page = 3;
                }
                else if (page == 15)
                {
                    page = 16;
                }
                else if (page == 2)
                {
                    page = 18;
                }
                else if (page == 18)
                {
                    page = 19;
                }
                else if (page == 20)
                {
                    page = 21;
                }
                else if (page == 23)
                {
                    page = 25;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (page == 1)
                {
                    page = 10;
                }

            }
            switch (page)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 11:

                    break;
                case 12:

                    break;
                case 13:

                    break;
                case 15:

                    break;
                case 16:

                    break;
                case 17:

                    break;
                case 18:

                    break;
                case 19:

                    break;
                case 20:

                    break;
                case 21:

                    break;
                case 22:

                    break;
                case 23:

                    break;
                case 24:

                    break;
                case 25:

                    break;
            }
        }
    }
}
