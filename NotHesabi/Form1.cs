using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace NotHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            



            double vize = 0;
            double final = 0;
            double uygulama = 0;
            double odev = 0;
            double quiz = 0;
            double toplam = 0;
            double ortalama = 0;
           

            vize = Convert.ToInt32(Interaction.InputBox("Vize notunu giriniz"));
            final = Convert.ToInt32(Interaction.InputBox("Final notunu giriniz"));
            uygulama = Convert.ToInt32(Interaction.InputBox("Uygulama notunu giriniz"));
            odev = Convert.ToInt32(Interaction.InputBox("Ödev notunu giriniz"));
            quiz = Convert.ToInt32(Interaction.InputBox("Quiz notunu giriniz"));

            toplam = vize + final + uygulama + odev + quiz;
            ortalama = ((vize + final + uygulama + odev + quiz)/5);

            if(vize<50 && final<50 && uygulama<50 || vize<50 && final<50 && odev<50)
            {
                MessageBox.Show("KALDINIZ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                

            }
            else
            {
                MessageBox.Show("Tebrikler geçtiniz! Ortalamanız: " +ortalama, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }


    }
}
