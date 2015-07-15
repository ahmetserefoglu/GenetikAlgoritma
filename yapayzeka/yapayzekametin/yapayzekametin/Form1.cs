using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapayzekametin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kromozomlar = new string[20];
        int[,] matris = new int[10, 10];
        string[] gen = new string[600];
        string[] kromozom = new string[20];
        string[] yon = new string[200];
        string[] x = new string[200];
        string[] y = new string[200];
        string a;
        string b;
        string c;
        public void genolustur()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    matris[i, j] = 0;

                }
            }
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                a = rnd.Next(0, 5).ToString();
                b = rnd.Next(0, 5).ToString();
                c = rnd.Next(1, 5).ToString();
                //matris[Convert.ToInt32(a),Convert.ToInt32(b)] = 1;
                gen[i] =  a+ b + c;
                x[i] = a;
                y[i] = b;
                yon[i] = c;
            }
        }
        public void kromozomolustur()
        {
            genolustur();
            for (int i = 0; i < 100; i = i + 5)
            {
                for (int j = i; j < i + 5; j++)
                {
                    kromozom[i / 5] = kromozom[i / 5] + gen[j] ;
                }
            }
        }
        /*  string[] mgen = new string[30];
          string[] terim = new string[30];
          public void matrisciz()
          {

              string[] mgen = kromozom[0].Split('-');
              for (int i = 0; i < 10; i++)
              {
                  listBox2.Items.Add(mgen[i]);
              }
              //  richTextBox1.Text = richTextBox1.Text + terim[l] + "         " + terim[l + 1] + "\n";
              for (int z = 0; z < 10; z++)
              {
                  terim = mgen[z].Split(';');
              }
              for (int i = 0; i < terim.Length; i++)
              {
                  listBox3.Items.Add(terim[i]);
              }
              for (int l = 0; l < 10; l++)
              {
                  for (int n = 0; n < 10; n++)
                  {
                      richTextBox1.Text = richTextBox1.Text + "           " + "0";

                  }
                  richTextBox1.Text = richTextBox1.Text + "\r\n";
                  richTextBox1.Text = richTextBox1.Text + "\r\n";
              }


          }*/
        
        public int  uygunluk(string gelen)
        {
            char[] dizi = gelen.ToCharArray();
            int kapsamaAlani=0;
            for (int i = 0; i < dizi.Length; i = i + 3)//x
            {
                if (dizi[i].Equals('0') && dizi[i + 2].Equals('3'))//
                {
                    kapsamaAlani = kapsamaAlani + 4*30;
                }
                if (dizi[i].Equals('1') && dizi[i + 2].Equals('3'))//
                {
                    kapsamaAlani = kapsamaAlani + 3*20;
                }
                if (dizi[i].Equals('2') && dizi[i + 2].Equals('3'))//
                {
                    kapsamaAlani = kapsamaAlani + 2*15;
                }
                if (dizi[i].Equals('3') && dizi[i + 2].Equals('3'))//
                {
                    kapsamaAlani = kapsamaAlani + 1*10;
                }
                if (dizi[i].Equals('4') && dizi[i + 2].Equals('3'))//
                {
                    kapsamaAlani = kapsamaAlani + 5;
                }
                if (dizi[i].Equals('3') && dizi[i + 2].Equals('4'))//
                {
                    kapsamaAlani = kapsamaAlani + 3*20;
                }
                if (dizi[i].Equals('4') && dizi[i + 2].Equals('4'))//
                {
                    kapsamaAlani = kapsamaAlani + 4*30;
                }
                if (dizi[i].Equals('1') && dizi[i + 2].Equals('4'))//
                {
                    kapsamaAlani = kapsamaAlani + 1*10;
                }
                if (dizi[i].Equals('2') && dizi[i + 2].Equals('4'))//
                {
                    kapsamaAlani = kapsamaAlani + 2*15;
                }
                if (dizi[i].Equals('0') && dizi[i + 2].Equals('4'))//
                {
                    kapsamaAlani = kapsamaAlani + 5;
                }
            }
            for (int y = 1; y < dizi.Length; y = y + 3)//y
            {
                if (dizi[y].Equals('0') && dizi[y + 1].Equals('2'))//
                {
                    kapsamaAlani = kapsamaAlani + 4*30;
                }
                if (dizi[y].Equals('1') && dizi[y + 1].Equals('2'))//
                {
                    kapsamaAlani = kapsamaAlani + 3*20;
                }
                if (dizi[y].Equals('2') && dizi[y + 1].Equals('2'))//
                {
                    kapsamaAlani = kapsamaAlani + 2*15;
                }
                if (dizi[y].Equals('3') && dizi[y + 1].Equals('2'))//
                {
                    kapsamaAlani = kapsamaAlani + 1*10;
                }
                if (dizi[y].Equals('4') && dizi[y + 1].Equals('2'))//
                {
                    kapsamaAlani = kapsamaAlani + 5;
                }
                if (dizi[y].Equals('4') && dizi[y + 1].Equals('1'))//
                {
                    kapsamaAlani = kapsamaAlani + 4*30;
                }
                if (dizi[y].Equals('3') && dizi[y + 1].Equals('1'))//
                {
                    kapsamaAlani = kapsamaAlani + 3*20;
                }
                if (dizi[y].Equals('2') && dizi[y + 1].Equals('1'))//
                {
                    kapsamaAlani = kapsamaAlani + 2*15;
                }
                if (dizi[y].Equals('1') && dizi[y + 1].Equals('1'))//
                {
                    kapsamaAlani = kapsamaAlani + 1*10;
                }
                if (dizi[y].Equals('0') && dizi[y + 1].Equals('1'))//
                {
                    kapsamaAlani = kapsamaAlani + 5;
                }

            }

            return kapsamaAlani;          
        }
     
    
        public void mutasyon(string cros1, string cros2,int i)
        {
            string gelen,gelen1;
            char[] dizi = cros1.ToCharArray(10, 1);
            char[] dizi1 = cros2.ToCharArray(10, 1);
            gelen = cros1.Replace(dizi[0], dizi1[0]);
            gelen1 = cros2.Replace(dizi1[0], dizi[0]);
            int a = uygunluk(gelen);
            int b = uygunluk(gelen1);
            if(a>b)
            listBox4.Items.Add(i+":"+gelen+":"+a);
            else
            listBox4.Items.Add(i+":"+gelen1+":"+b);


        }
        public void crossingover(string cros1,string cros2,int i)
        {

            string gelen,gelen1,gelen2,gelen3,gelen4,gelen5;
            char[] dizi = cros1.ToCharArray(10,4);
            char[] dizi1 = cros2.ToCharArray(10, 4);
            gelen = cros1.Replace(dizi[0],dizi1[0]);
            gelen1 = cros2.Replace(dizi1[0], dizi[0]);
            gelen2 = gelen.Replace(dizi[1],dizi1[1]);
            gelen3 = gelen1.Replace(dizi1[1], dizi[1]);
            gelen4 = gelen3.Replace(dizi[2], dizi1[2]);
            gelen5 = gelen2.Replace(dizi1[2], dizi[1]);
            int a = uygunluk(gelen4);
            int b = uygunluk(gelen5);

            listBox3.Items.Add(gelen4 + ":" + a);
            listBox3.Items.Add(gelen5 + ":" + b);
            mutasyon(gelen,gelen1,i);                               
        }
        public void turnuva()
        {            
            Random rasgele = new Random();

            int[] sayilar = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {


                for (int z = 0; z < 2; z++)
                {
                    sayilar[z] = rnd.Next(0, 20);
                    int a = uygunluk(kromozomlar[sayilar[z]]);
                    listBox2.Items.Add(kromozomlar[sayilar[z]] + ":" + a);
                    crossingover(kromozomlar[sayilar[z]], kromozomlar[sayilar[z+1]],i);

                }


            }
            
                        
        }
      
        public void puanhesapla()
        {
            //string a;
            List<string> list1 = new List<string>();
            Random rnd = new Random();
            int nesil = rnd.Next(15,30);
            string[] dizi = new string[listBox4.Items.Count];
            string[] dizi1 = new string[listBox4.Items.Count];
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                dizi[i] = listBox4.Items[i].ToString();
                dizi1[i] = dizi[i].Split(':')[2]; 
                list1.Add(dizi1[i]+";");          
                list1.Sort();                             
            }
            for (int i = 0; i <listBox4.Items.Count; i++)
            {
                listBox5.Items.Add(i+".nesil:"+list1[i]);
            }
                   
                  

           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kromozomolustur();
            for (int i = 0; i < 20; i++)
            {
                kromozomlar[i] = kromozom[i];
                int a=uygunluk(kromozom[i]);
                listBox1.Items.Add(i+":kromozom:"+"uygunluk:"+a);
                
            }
            
            turnuva();
            puanhesapla();
            //turnuva1();



            
            
            
            //matrisciz();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           /* kromozomolustur();
            for (int i = 0; i < 20; i++)
            {
                kromozomlar[i] = kromozom[i];
                int a = uygunluk(kromozom[i]);
                listBox1.Items.Add(i + ":kromozom" + "uygunluk:" + a);

            }

            turnuva();
            puanhesapla();*/
        }
    }
}
