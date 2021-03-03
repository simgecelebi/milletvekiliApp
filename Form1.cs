using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milletvekiliApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxil.Items.Add("İstanbul");
            comboBoxil.Items.Add("İzmir");
            comboBoxil.Items.Add("Ankara");
            comboBoxil.Items.Add("Zonguldak");
            comboBoxil.Items.Add("Konya");
        }

        private void comboBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxil.SelectedItem == "İstanbul")
            {
                ilnufustextBox.Text = "15000000";
            }
            else if (comboBoxil.SelectedItem == "İzmir")
            {
                ilnufustextBox.Text = "4000000";
            }
            else if (comboBoxil.SelectedItem == "Ankara")
            {
                ilnufustextBox.Text = "5000000";
            }
            else if (comboBoxil.SelectedItem == "Zonguldak")
            {
                ilnufustextBox.Text = "213000";
            }
            else if (comboBoxil.SelectedItem == "Konya")
            {
                ilnufustextBox.Text = "2000000";
            }

            partibilgigroupBox.Enabled = true;
            secimistatistikgroupBox.Enabled = true;
            msgroupBox.Enabled = true;
        }
        public string a, b, c, ms;
        
        private void buttonmilletvekilihesapla_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBoxApartioy.Text);
            float b = float.Parse(textBoxBpartioy.Text);
            float c = float.Parse(textBoxCpartioy.Text);
            float ms = float.Parse(textBoxmilletvekilisayi.Text);
            int asayac = 0;
            int bsayac = 0;
            int csayac = 0;
            int x = 1;
            float tmp;
            int i = 2, j = 2, k = 2;

            while (ms >= x)
            {
                x++;

                if ((c > a) && (c > b))
                {
                    float csonuc = c / k;
                    tmp = csonuc;
                    c = tmp;
                    csayac++;
                    k++;
                }
                else if ((b > a) && (b > c))
                {
                    float bsonuc = b / j;
                    tmp = bsonuc;
                    b = tmp;
                    bsayac++;
                    j++;
                }
                else if ((a > b) && (a > c))
                {
                    float asonuc = a / i;
                    tmp = asonuc;
                    a = tmp;
                    asayac++;
                    i++;
                }
            }

            textBoxAmilletvekilisayisi.Text = asayac.ToString();
            textBoxBmilletvekilisayisi.Text = bsayac.ToString();
            textBoxCmilletvekilisayisi.Text = csayac.ToString();

        }

        private void buttonoyoranihesapla_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBoxAmilletvekilisayisi.Text);
            float b = float.Parse(textBoxBmilletvekilisayisi.Text);
            float c = float.Parse(textBoxCmilletvekilisayisi.Text);
            float ms = float.Parse(textBoxmilletvekilisayi.Text);

            float aoran = (a * 100) / ms;
            float boran = (b * 100) / ms;
            float coran = (c * 100) / ms;

            textBoxApartioyorani.Text = "%"+aoran.ToString();
            textBoxBpartioyorani.Text = "%"+boran.ToString();
            textBoxCpartioyorani.Text = "%"+coran.ToString();


        }
    }
}



















/*private void Form1_Load(object sender, EventArgs e)
        {

        }

        int a, b, c, mvekilisayi;

        void temizle()
        {
            textBoxApartioy.Clear();
            textBoxBpartioy.Clear();
            textBoxCpartioy.Clear();
            textBoxmilletvekilisayi.Clear();
        }

        List<Parti> partiler = new List<Parti>();

        void hesapla()
        {
            partiler.Clear();
            mvekilisayi = Convert.ToInt32(textBoxmilletvekilisayi.Text);
            List<int> oylar = new List<int>();
            oylar.Add(Convert.ToInt32(textBoxApartioy.Text));
            oylar.Add(Convert.ToInt32(textBoxBpartioy.Text));
            oylar.Add(Convert.ToInt32(textBoxCpartioy.Text));

            Parti parti; for (int i = 0; i < 3; i++)
            {
                parti = new Parti();
                parti.MilletvekiliSayisi = 0;
                parti.Bolen = 1;
                parti.ToplamOy = oylar[i];
                partiler.Add(parti);
            }

            string data = String.Format("{0,-50}", "");
            for (int i = 0; i < partiler.Count; i++)
            {
                string temp = (i + 1).ToString() + ". Parti"; data += String.Format("{0,-15}", temp);
            }
            
            data = String.Format("{0,-38}", "Oy");
            for (int i = 0; i < partiler.Count; i++)
            {
                data += String.Format("{0,14}", partiler[i].ToplamOy);
            }

            while (mvekilisayi-- != 0)
            {
                parti = partiler[0];
                for (int i = 1; i < partiler.Count; i++)
                {
                    if (partiler[i].ToplamOy / partiler[i].Bolen > parti.ToplamOy / parti.Bolen)
                    {
                        parti = partiler[i];
                    }
                }
                data = String.Format("{0,-36}", (7 - mvekilisayi).ToString() + ".milletvekili");
                for (int i = 0; i < partiler.Count; i++)
                {
                    data += String.Format("{0,14}", partiler[i].HesaplanOy);
                }

                parti.MilletvekiliSayisi++; parti.Bolen++;
            }
            data = String.Format("{0,-34}", "Milletvekili Sayıları");
            for (int i = 0; i < partiler.Count; i++)
            {
                data += String.Format("{0,14}", partiler[i].MilletvekiliSayisi.ToString("00000"));
            }
        }
        

        class Parti
        {
            public Parti()
            {
            }
            private int hesaplananOy;
            private int bolen;
            private int milletvekiliSayisi;
            private int toplamOy;
            public int Bolen
            {
                get
                {
                    return bolen;
                }
                set
                {
                    bolen = value;
                }
            }
            public int MilletvekiliSayisi
            {
                get
                {
                    return milletvekiliSayisi;
                }
                set
                {
                    milletvekiliSayisi = value;
                }
            }
            public int ToplamOy
            {
                get
                {
                    return toplamOy;
                }
                set
                {
                    toplamOy = value;
                }
            }
            public int HesaplanOy
            {
                get
                {
                    return toplamOy / bolen;
                }
            }
        }
        */
