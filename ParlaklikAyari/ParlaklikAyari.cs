using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParlaklikAyari
{
    public partial class ParlaklikAyari : Form
    {
        public ParlaklikAyari()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                int parlaklik = Convert.ToInt16(tbParlaklikDeger.Text);
                if (tbParlaklikDeger.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Değer Giriniz!", "Değer Girilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (parlaklik > 100)
                {
                    MessageBox.Show("100'den Büyük Değer Girdiniz, Lütfen 0-100 Arası Bir Değer Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (parlaklik < 0)
                {
                    MessageBox.Show("0'dan Küçük Değer Girdiniz, Lütfen 0-100 Arası Bir Değer Giriniz! ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Process pr = new Process();
                    pr.StartInfo.FileName = "cmd.exe";
                    pr.StartInfo.Arguments = "/k powershell (Get-WmiObject -Namespace root/WMI -Class WmiMonitorBrightnessMethods).WmiSetBrightness(1," + parlaklik + ") & exit";
                    pr.Start();
                    MessageBox.Show("Ekran Parlaklığınız " + Convert.ToString(parlaklik) + " Olarak Değiştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Harf Girişi Yaptınız, Lütfen Sayı Girişi Yapınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
