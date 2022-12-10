using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeHesapMak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x;
        double y;
        string islem;
        //SAYI TUÞLARI CLÝCK ÝÞLEMLERÝ
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }

            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {

            textBox1.Text += "0";
        }


        //ÝÞLEM TUÞLARI CLÝCK ÝÞLEMLERÝ
        private void buttonGeri_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }



        private void ButtonEsittir_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (islem == "X")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem == "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }

        }

        private void buttonToplama_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }


        private void buttonCikartma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void buttonCarpma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "X";
            label1.Text = textBox1.Text + "X";
            textBox1.Text = "0";
        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void buttonXkare_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void buttonXkup_Click(object sender, EventArgs e)
        {
            double kup = Convert.ToDouble(textBox1.Text);
            kup = Math.Pow(kup, 3);
            textBox1.Text = Convert.ToString(kup);
        }

        private void buttonKarekok_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);

        }

        private void button1Bolux_Click(object sender, EventArgs e)
        {
            double bolux = Convert.ToDouble(textBox1.Text);
            bolux = 1 / (bolux);
            textBox1.Text = Convert.ToString(bolux);

        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
        }

        private void buttonParantezA_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            label1.Text = "(" + textBox1.Text + ")";
        }
        private void buttonNokta_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        Double pi = 3.14159;
        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(pi);
            label1.Text= "(" + textBox1.Text + ")";
        }

        private void buttonHesaplaSin_Click(object sender, EventArgs e)
        {

            Double a = Convert.ToDouble(txtSin.Text);
            textBoxTrigonometri.Text = Convert.ToString(Math.Sin(a));
        }

        private void buttonHesaplaCos_Click(object sender, EventArgs e)
        {
            Double b = Convert.ToDouble(txtCos.Text);
            textBoxTrigonometri.Text = Convert.ToString(Math.Cos(b));
        }

        private void buttonHesaplaTan_Click(object sender, EventArgs e)
        {
            Double c = Convert.ToDouble(txtTan.Text);
            textBoxTrigonometri.Text = Convert.ToString(Math.Sin(c) / Math.Cos(c));
        }

        private void buttonHesaplaCot_Click(object sender, EventArgs e)
        {
            Double d = Convert.ToDouble(txtCot.Text);
            textBoxTrigonometri.Text = Convert.ToString(Math.Cos(d) / Math.Sin(d));
        }

        private void txtHesaplaHepsi_Click(object sender, EventArgs e)
        {
            Double triDeger = Convert.ToDouble(txtHepsi.Text);
            textBoxTrigonometri.Text = Convert.ToString("Girilen deðerin sinüsü = " + Math.Sin(triDeger) + Environment.NewLine + "Girilen deðerin cosinüsü = " + Math.Cos(triDeger) + Environment.NewLine + "Girilen deðerin tanjantý = " + Math.Tan(triDeger) + Environment.NewLine + "Girilen deðerin Cotanjantý = " + 1 / Math.Tan(triDeger));


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHesaplaDortgen_Click(object sender, EventArgs e)
        {
            if (rdKare.Checked == true)
            {
                Double kenar1 = Convert.ToDouble(txtKenar1.Text);
                lblSonucDortgenAlan.Text = Convert.ToString(kenar1 * kenar1);
                lblSonucDortgenCevre.Text = Convert.ToString(kenar1 * 4);

            }
            if (rdDikdortgen.Checked == true)
            {
                Double kenar1 = Convert.ToDouble(txtKenar1.Text);
                Double kenar2 = Convert.ToDouble(txtKenar2.Text);
                lblSonucDortgenAlan.Text = Convert.ToString(kenar1 * kenar2);
                lblSonucDortgenCevre.Text = Convert.ToString(kenar1 * 4);

            }
            if (rdAltigen.Checked == true)
            {
                Double kenar1 = Convert.ToDouble(txtKenar1.Text);

                lblSonucDortgenAlan.Text = Convert.ToString((kenar1 * kenar1) * Math.Sqrt(3) / 4 * 6);
                lblSonucDortgenCevre.Text = Convert.ToString(kenar1 * 6);

            }
            if (rdSekizgen.Checked == true)
            {
                Double kenar1 = Convert.ToDouble(txtKenar1.Text);
                lblSonucDortgenCevre.Text = Convert.ToString(kenar1 * 8);
                lblSonucDortgenAlan.Text = Convert.ToString(2 * kenar1 * kenar1 * (1 + Math.Sqrt(2)));
            }

        }
        private void buttonKopyahepsi(object sender, EventArgs e) => Clipboard.SetText(textBox1.Text);


        private void buttonPaste1_Click(object sender, EventArgs e)
        {
            txtSin.Text = Clipboard.GetText();

        }

        private void buttonPaste2_Click(object sender, EventArgs e)
        {
            txtCos.Text = Clipboard.GetText();
        }

        private void buttonPaste3_Click(object sender, EventArgs e)
        {
            txtTan.Text = Clipboard.GetText();
        }

        private void buttonPaste4_Click(object sender, EventArgs e)
        {
            txtCot.Text = Clipboard.GetText();
        }

        private void buttonCopy1_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxTrigonometri.Text);
       

        private void buttonCopy2_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxTrigonometri.Text);
        

        private void buttonCopy3_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxTrigonometri.Text);
        

        private void buttonCopy4_Click(object sender, EventArgs e) => Clipboard.SetText(textBoxTrigonometri.Text);


        private void buttonPasteAna_Click(object sender, EventArgs e) 
        {
            textBox1.Text= Clipboard.GetText();
        }

        private void btnHesaplaUcgen_Click(object sender, EventArgs e)
        {
            if (chckEskenar.Checked == true) 
            {
                labelkenar1.Visible = true;
                textUcgenK1.Visible = true;

                Double kenar1 = Convert.ToDouble(textUcgenK1.Text);
                ucgenAlan.Text = Convert.ToString(Math.Pow(kenar1,2)*Math.Sqrt(3)/4);
                ucgenCevre.Text = Convert.ToString(kenar1*3);
            }


            if (chckDik.Checked==true) 
            {
                labelkenar1.Visible = true;
                labelkenar2.Visible = true;
                labelkenar3.Visible = true;
                labelYukseklik.Visible = true;
                lblTaban.Visible = true;
                textUcgenK2.Visible = true;
                textUcgenK3.Visible = true;
                textUcgenK1.Visible = true;
                textUcgenYuk.Visible = true;
                textBoxTK.Visible = true;

                Double kenar1 = Convert.ToDouble(textUcgenK1.Text);
                Double kenar2 = Convert.ToDouble(textUcgenK2.Text);
                Double kenar3 = Convert.ToDouble(textUcgenK3.Text);
                Double kenarYukeseklik = Convert.ToDouble(textUcgenYuk.Text);
                Double kenarTaban = Convert.ToDouble(textBoxTK.Text);
                ucgenAlan.Text = Convert.ToString(kenarTaban * kenarYukeseklik);
                ucgenCevre.Text = Convert.ToString(kenar1+kenar2+kenar3);
            }


            if(chckCesitkenar.Checked==true)
            {
                labelkenar1.Visible = true;
                labelkenar2.Visible = true;
                labelkenar3.Visible = true;
                labelYukseklik.Visible = false;
                lblTaban.Visible = false;
                textUcgenK1.Visible = true;
                textUcgenK2.Visible = true;
                textUcgenK3.Visible = true;
                textBoxTK.Visible = false;
                textUcgenYuk.Visible = false;


                Double kenar1 = Convert.ToDouble(textUcgenK1.Text);
                Double kenar2 = Convert.ToDouble(textUcgenK2.Text);
                Double kenar3 = Convert.ToDouble(textUcgenK3.Text);
                Double cevre = kenar1 + kenar2 + kenar3;
                Double u = cevre / 2;
                Double alan = Math.Sqrt(u * (u - kenar1) * (u - kenar2) * (u - kenar3));

                ucgenCevre.Text = Convert.ToString(cevre);
                ucgenAlan.Text = Convert.ToString(alan);


            }

        }

        private void chckEskenar_CheckedChanged(object sender, EventArgs e)
        {
            labelkenar1.Visible= true;
            textUcgenK1.Visible= true;
            labelkenar2.Visible = false;
            labelkenar3.Visible = false;
            labelYukseklik.Visible = false;
            lblTaban.Visible = false;
            textUcgenK2.Visible = false;
            textUcgenK3.Visible = false;
            textUcgenYuk.Visible = false;
            textBoxTK.Visible = false;
        }

        private void chckDik_CheckedChanged(object sender, EventArgs e)
        {
            labelkenar1.Visible = true; 
            labelkenar2.Visible = true;
            labelkenar3.Visible = true;
            labelYukseklik.Visible = true;
            lblTaban.Visible=true;
            textUcgenK2.Visible = true;
            textUcgenK3.Visible = true;
            textUcgenK1.Visible = true;
            textUcgenYuk.Visible = true;
            textBoxTK.Visible=true;
            

        }

        private void chckCesitkenar_CheckedChanged(object sender, EventArgs e)
        {
            labelkenar1.Visible = true;
            labelkenar2.Visible = true;
            labelkenar3.Visible = true;
            labelYukseklik.Visible = false;
            lblTaban.Visible = false;
            textUcgenK1.Visible = true;
            textUcgenK2.Visible = true;
            textUcgenK3.Visible = true;
            textBoxTK.Visible = false;
            textUcgenYuk.Visible= false;
            

        }

        private void btnDaireHesapla_Click(object sender, EventArgs e)
        {
            if (chckDaire.Checked == true) 
            {
                lblDaireYar.Visible = true;
                lblDaireDer.Visible = false;
                txtDaireDer.Visible = false;
                txtDaireYar.Visible = true; 

                Double pi = 3.14159;
                Double r = Convert.ToDouble(txtDaireYar.Text);
                lblCevre.Text = Convert.ToString(2 * pi * r);
                lblAlan.Text = Convert.ToString(pi * r * r);
            }
            if (chckDDilim.Checked==true)
            {
                lblDaireYar.Visible = true;
                lblDaireDer.Visible = true;
                txtDaireDer.Visible = true;
                txtDaireYar.Visible = true;

                Double pi = 3.14159;
                Double r = Convert.ToDouble(txtDaireYar.Text);
                Double d = Convert.ToDouble(txtDaireDer.Text);
                Double oran = d / 360;
                lblCevre.Text = Convert.ToString((Math.Pow(r,2) * pi*oran)+2*r);
                lblAlan.Text = Convert.ToString(Math.Pow(r, 2)*pi*oran);
            }

        }

        private void chckDaire_CheckedChanged(object sender, EventArgs e)
        {
            lblDaireYar.Visible = true;
            lblDaireDer.Visible = false;
            txtDaireDer.Visible = false;
            txtDaireYar.Visible = true;
        }

        private void chckDDilim_CheckedChanged(object sender, EventArgs e)
        {

            lblDaireYar.Visible = true;
            lblDaireDer.Visible = true;
            txtDaireDer.Visible = true;
            txtDaireYar.Visible = true;
        }
    }

        
    
}
