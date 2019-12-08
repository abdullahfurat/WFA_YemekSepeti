using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
namespace WFA_YemekSepeti
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void yemekkontrol(ComboBox item)
        {
          
                if (item.SelectedIndex!=-1 && item is ComboBox && cmbBirinciYemek.SelectedIndex == cmbIkinciYemek.SelectedIndex)
                {
                    MessageBox.Show("Aynı yemeği seçemezsiniz!");
                    item.Focus();
                    item.SelectedIndex = -1;
                }
            
        }

        void porsiyonkontrol(TextBox item,ComboBox item2)
        {

            int result = 0;
            bool sonuc = int.TryParse(item.Text.Replace(".",""), out result);
          
             if (item2.SelectedIndex < 0)
            {
                
                MessageBox.Show("Önce yemek seçmelisiniz.");
                metroLabel6.Text = "";
                item2.Focus();

            }
            else if (!sonuc && item.Text != "")
            {
                MessageBox.Show("Sayısal bir değer giriniz.");
                metroLabel6.Text = "";
                item.Focus();
            }
        }

        private void cmbBirinciYemek_TextChanged(object sender, EventArgs e)
        {
            yemekkontrol(cmbBirinciYemek);
           
        }

        private void cmbIkinciYemek_TextChanged(object sender, EventArgs e)
        {
            yemekkontrol(cmbIkinciYemek);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            porsiyonkontrol(textBox1,cmbBirinciYemek);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            porsiyonkontrol(textBox2,cmbIkinciYemek);
        }
        void yemeksecim(ComboBox item,PictureBox item1)

        {

            switch (item.SelectedIndex)
            {
                case 0:
                    item1.Image = WFA_YemekSepeti.Properties.Resources.s_85c3ef831d3e50fc125ae32e15366ea4000bc743;
                    break;
                case 1:
                    item1.Image = WFA_YemekSepeti.Properties.Resources.nohutlu_pilav;
                    break;
                default:
                    break;
            }
        }

        int fiyatbul(ComboBox item)
        {
            switch (item.SelectedIndex)
            {
                case 0:
                    return 20;
                    break;
                case 1:
                    return 10;
                    break;
                default:
                    return 0;
                    break;
            }

        }
        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            yemeksecim(cmbBirinciYemek, pictureBox1);
            yemeksecim(cmbIkinciYemek, pictureBox2);
            porsiyonkontrol(textBox1, cmbBirinciYemek);
            porsiyonkontrol(textBox2,cmbIkinciYemek);

            if (textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Porsiyon Bilgisini girmediniz.");
                metroLabel6.Text = "";
            }
            else
            {
                metroLabel6.Text = (float.Parse(textBox1.Text) * fiyatbul(cmbBirinciYemek) + float.Parse(textBox2.Text) * fiyatbul(cmbIkinciYemek)).ToString();
            }
            

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            cmbBirinciYemek.SelectedIndex = cmbIkinciYemek.SelectedIndex= - 1;
            metroLabel6.Text = "0 TL";
            MessageBox.Show("Siparişiniz iptal edilmiştir.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

