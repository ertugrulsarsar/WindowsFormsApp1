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
        // Bir takım global değişken tanımlanır.

        public Form1()
        {
            
            InitializeComponent();
        }

        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            // buraya buton tıklanınca texboxta girilmiş olan isim listeye eklenecek
            // kullaniciListesi.Add(textBoxEkle.Text);
            Boolean dahaOnceVarmi = false;
            foreach (var kullanici in listBoxKullanicilar.Items) 
            {

                if (textBoxEkle.Text ==Convert.ToString( kullanici))
                {
                    dahaOnceVarmi = true;
                    break;
                } 
            }
            if (!dahaOnceVarmi)  // ! işareti tersi yapar.
            {
             
                listBoxKullanicilar.Items.Add(textBoxEkle.Text);
            }
            

            
        }

        private void ButtonRandomSelect_Click(object sender, EventArgs e)
        {
            //Tıklama olayında rastgele listeden eleman seçilecek ve sağ taraftaki textboxta yazdırılacak
            Random rnd = new Random();
            string selectedUser = "";
            
            selectedUser= listBoxKullanicilar.Items[rnd.Next(0, listBoxKullanicilar.Items.Count - 1)].ToString();
            textBoxSelectedName.Text = selectedUser;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var listBoxItem in listBoxKullanicilar.Items)
            {
                if (textBoxEkle.Text == listBoxItem.ToString())
                {
                    listBoxKullanicilar.Items.RemoveAt(index);
                    break;
                }
                index++;
                


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                
            {
                Boolean dahaOnceVarmi = false;
                foreach (var kullanici in listBoxKullanicilar.Items)
                {

                    if (textBoxEkle.Text == Convert.ToString(kullanici))
                    {
                        dahaOnceVarmi = true;
                        break;
                    }
                }
                if (!dahaOnceVarmi)  // ! işareti tersi yapar.
                {

                    listBoxKullanicilar.Items.Add(textBoxEkle.Text);
                }
            }
        }

        private void TextBoxEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                Boolean dahaOnceVarmi = false;
                foreach (var kullanici in listBoxKullanicilar.Items)
                {

                    if (textBoxEkle.Text == Convert.ToString(kullanici))
                    {
                        dahaOnceVarmi = true;
                        break;
                    }
                }
                if (!dahaOnceVarmi)  // ! işareti tersi yapar.
                {

                    listBoxKullanicilar.Items.Add(textBoxEkle.Text);
                }
            }
        }

        private void TextBoxEkle_TextChanged(object sender, EventArgs e)
        {
            //github kontrol
        }
    }
}
