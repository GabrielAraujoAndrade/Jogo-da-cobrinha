using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_cobrinha
{
    public partial class Form1 : Form
    {
        private List<Circulo> Cobra = new List<Circulo>();
        private Circulo comida = new Circulo();
        int velocidade =75;
        int maxLargura,maxAltura;
        int pontuacao,recorde=0,facil = Properties.Settings.Default.facil, medio = Properties.Settings.Default.medio, dificil = Properties.Settings.Default.dificil;
        double porcentagem=0;
        Random rand = new Random();
        bool esq,dir,cima,baixo;
        Brush corComida = Brushes.Red;
        Brush CorCobra,aux = Brushes.DarkGreen;

        public Form1()
        {
            InitializeComponent();
            Nivel1.CheckedChanged += CheckBox_CheckedChanged;
            Nivel2.CheckedChanged += CheckBox_CheckedChanged;
            Nivel3.CheckedChanged += CheckBox_CheckedChanged;
            facil = Properties.Settings.Default.facil;
            medio = Properties.Settings.Default.medio;
            dificil = Properties.Settings.Default.dificil;

            if(facil !=0 ||  medio !=0 || dificil !=0) {

                Barra.Visible = true; Barratxt.Visible = true;

            }

            new Configs(); 
        }
            
       

        private void Start(object sender, EventArgs e)
        {
           
            Restart();

        }

        private void KeyisDown(object sender, KeyEventArgs e)
        { 
        
                if ((e.KeyCode == Keys.Left && Configs.Direcoes != "esq" && Configs.Direcoes != "dir" ))
            {
                    esq = true;

                }
                if (e.KeyCode == Keys.Right && Configs.Direcoes != "dir" && Configs.Direcoes != "esq")
                {

                    dir = true;
                }
                if (e.KeyCode == Keys.Up && Configs.Direcoes != "cima" && Configs.Direcoes != "baixo")
                {
                    cima = true;
                }
                if (e.KeyCode == Keys.Down && Configs.Direcoes != "baixo" && Configs.Direcoes != "cima")
                {
                    baixo = true;
                }


        }   

        private void KeyisUp(object sender, KeyEventArgs e)
        {
           
          
            if (e.KeyCode == Keys.Left )
            {
             
                esq = false;
            }

       
            if (e.KeyCode == Keys.Right)
            {
                dir = false;
       
            }
            if (e.KeyCode == Keys.Up )
            {
                cima = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                baixo = false;
            }
            if(e.KeyCode == Keys.Escape)
            {
                fimdejogo();
            }
            if (e.KeyCode == Keys.R)
            {
                Restart();
            }
            if (e.KeyCode == Keys.Enter)
            {
                
                Restart();
            }
         
        }
            
        private void Tempodejogo_Tick(object sender, EventArgs e)
        {
            //Configurando as direçoes

            if (esq)
            {

                Configs.Direcoes = "esq";

            }
            if(dir)
            {

                Configs.Direcoes = "dir";

            }
            if (cima)
            {

                Configs.Direcoes = "cima";

            }
            if (baixo)
            {

                Configs.Direcoes = "baixo";

            }
            // fim das direçoes

            for (int i = Cobra.Count-1; i >=0; i--)
            {
                if(i == 0)
                {

                    switch (Configs.Direcoes)
                    {
                     case "esq":
                            Cobra[i].x--;
                            break;
                        case "dir":
                            Cobra[i].x++;
                            break;
                        case "cima":
                            Cobra[i].y--;
                            break;
                        case "baixo":
                            Cobra[i].y++;
                            break;

                    }
                    if (Cobra[i].x < 0)
                    {
                        Cobra[i].x = maxLargura;
                    }
                    if (Cobra[i].x > maxLargura)
                    {
                        Cobra[i].x = 0;
                    }
                    if (Cobra[i].y < 0)
                    {
                        Cobra[i].y = maxAltura;
                    }
                    if (Cobra[i].y > maxAltura)
                    {
                        Cobra[i].y = 0;
                    }

                    if (Cobra[i].x == comida.x && Cobra[i].y == comida.y)
                    {
                        comerFruta();

                    }
                    for (int k = 1; k < Cobra.Count; k++)
                    {
                        if (Cobra[i].x == Cobra[k].x && Cobra[i].y== Cobra[k].y)
                        {
                            fimdejogo();
                        }


                    }

                }
                else
                {
                    Cobra[i].x = Cobra[i - 1].x;
                    Cobra[i].y = Cobra[i - 1].y;
                }
            }
            Fundo.Invalidate();

        }

        private void UpdateJogo(object sender, PaintEventArgs e)
        {
            Graphics tela = e.Graphics;

            if(Tempodejogo.Interval < 100) { 
            for (int i = 0; i < Cobra.Count; i++)
            {
               
                if(i == 0)
                {
                    CorCobra = Brushes.Black;

                }
                else
                {
                    CorCobra = aux;

                }

                tela.FillEllipse(CorCobra, new Rectangle
                    (Cobra[i].x * Configs.Largura,
                    Cobra[i].y * Configs.Altura,
                    Configs.Largura,
                    Configs.Altura));
            }
            tela.FillEllipse(corComida, new Rectangle
                 (comida.x * Configs.Largura,
                 comida.y * Configs.Altura,
                 Configs.Largura,
                 Configs.Altura));
                }



        }

    
        private void Rein_Click(object sender, EventArgs e)
        {
            fimdejogo();
        }

  

        private void Facil(object sender, EventArgs e)
        {
            Score.Text = $"Pontuação: 0";
            Recorde.Text = "Recorde: " + facil;
        }

        private void Medio(object sender, EventArgs e)
        { 
            Score.Text = $"Pontuação: 0";
            Recorde.Text = "Recorde: " + medio;

        }

        private void Dificil(object sender, EventArgs e)
        {
           Score.Text = $"Pontuação: 0";
            Recorde.Text = "Recorde: " + dificil;
        }

        private void Restart()
        {
            Nivel1.Enabled = Nivel2.Enabled= Nivel3.Enabled = false;
         
             corComida = Brushes.Red;
             CorCobra= aux = Brushes.DarkGreen;

            if (Nivel1.Checked)
            {
                velocidade = 75;
                recorde = facil;


            }
            else if (Nivel2.Checked)
            {
                velocidade = 50;
                recorde = medio;
            }
            else if (Nivel3.Checked)
            {
                velocidade = 25;
                recorde = dificil;
            }
            else { velocidade = 75;
            Nivel1.Checked = true;
            }
            Velocidde.Visible = true;
            Recorde.Text = "Recorde: " + recorde;
            Velocidde.Text = $"Velocidade: {velocidade}";
            start.Visible = start.Enabled = false;
            
            porcentagem = 0;
            maxLargura = Fundo.Width / Configs.Largura - 1;
            maxAltura = Fundo.Height / Configs.Altura - 1;

            Cobra.Clear();
            start.Enabled = false;

            pontuacao = 0;
            Score.Text = $"Pontuação: {pontuacao}";
            Barratxt.Text = $"Distancia ate record: {porcentagem}";
            Barra.Value = 0;



            Circulo cabeca = new Circulo {x = 10,y =5 };
            Cobra.Add(cabeca); // Cabeca esta no index 0 da Lista

            for (int i = 0; i < 4; i++)
            {
                Circulo corpo = new Circulo();
                Cobra.Add(corpo);

            }

            comida = new Circulo { x = rand.Next(2, maxLargura), y = rand.Next(2, maxAltura) };
            Tempodejogo.Start();
            Tempodejogo.Interval = velocidade;
            Properties.Settings.Default.facil = facil;
            Properties.Settings.Default.medio = medio;
            Properties.Settings.Default.dificil = dificil;
            Properties.Settings.Default.Save();

        }
        private void comerFruta()
        {
            pontuacao += 1;
            Score.Text = $"Pontuação: {pontuacao}";
            Velocidde.Text = $"Velocidade: {velocidade}";
          
            if(Nivel1.Checked && pontuacao < 25)
            {
                velocidade -= 2;
            }
            else if(Nivel2.Checked && velocidade > 20)
            {
                velocidade -= 2;

            }
            else if(Nivel3.Checked && velocidade > 15)
            {
                velocidade -= 1;
            }

    

       

                if(pontuacao>0 && recorde > 0&& pontuacao <= recorde)
            {
                Barra.Value = pontuacao;
                Barra.Maximum = recorde;
                porcentagem = (pontuacao * 100)/recorde;
                Barratxt.Text = $"Distancia ate record: {porcentagem}%";
            }
            aux = corComida;
            corComida = RandomColor();
           
            Circulo Corpo = new Circulo 
            { 
                x = Cobra[Cobra.Count - 1].x,
                y = Cobra[Cobra.Count-1].y,
            };
           
            Cobra.Add(Corpo);
            comida = new Circulo { x = rand.Next(2, maxLargura), y = rand.Next(2, maxAltura) }; 
            Tempodejogo.Interval = velocidade;
        }
        private void fimdejogo()
        {
            Nivel1.Enabled = Nivel2.Enabled = Nivel3.Enabled = true;
         
            start.Visible = start.Enabled = true;
            Velocidde.Visible = false;
            Tempodejogo.Stop();


            Barra.Visible = true; Barratxt.Visible = true;

            recordes();


        
        }     
       
        public void recordes()
        {
            if (Nivel1.Checked)
            {
                if(pontuacao > recorde) {
                facil = pontuacao;
                recorde = facil;
                Recorde.Text = "Recorde: " + recorde;
                Recorde.ForeColor = Color.Maroon;
                Properties.Settings.Default.Save();
                }

            }
            else if (Nivel2.Checked)
            {
                if(pontuacao >recorde) {
                medio = pontuacao;
                recorde = medio;
                Recorde.Text = "Recorde: " + recorde;
                Recorde.ForeColor = Color.Maroon;
                Properties.Settings.Default.Save();
                }
            }
            else if(Nivel3.Checked)
            {
                if (pontuacao > recorde) { 
                dificil = pontuacao;
                recorde = dificil;
                Recorde.Text = "Recorde: " + recorde;
                Recorde.ForeColor = Color.Maroon;
                Properties.Settings.Default.Save();}
            }
            Properties.Settings.Default.facil = facil;
            Properties.Settings.Default.medio = medio;
            Properties.Settings.Default.dificil = dificil;
            Properties.Settings.Default.Save();

        }
       static   private Brush RandomColor()
        {   Brush cor = Brushes.Green;
           Random rand = new Random();

            switch (rand.Next(0,11))
            {
                case 0:
                    cor = Brushes.Yellow;
                    break;
                case 1:
                    cor = Brushes.Red;
                    break;
                case 2:
                    cor = Brushes.DarkBlue;
                    break;
                case 3:
                    cor = Brushes.Gold;
                    break;
                case 4:
                    cor = Brushes.AliceBlue;
                    break;
                case 5:
                    cor = Brushes.DeepPink;
                    break;
                case 6:
                    cor = Brushes.DarkViolet;
                    break;
                case 7:
                    cor = Brushes.Beige;
                    break;
                case 8:
                    cor = Brushes.Magenta;
                    break;
                case 9:
                    cor = Brushes.Green;
                    break;
                case 10:
                    cor = Brushes.GreenYellow;
                    break;
                 
            }

            return cor;
        }
     

        private void reiniciarRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }


    
        private void finalizarESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fimdejogo();
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            if (currentCheckBox.Checked)
            {
                if (currentCheckBox == Nivel1)
                {
                    Nivel2.Checked = false;
                    Nivel3.Checked = false;
                }
                else if (currentCheckBox == Nivel2)
                {
                    Nivel1.Checked = false;
                    Nivel3.Checked = false;
                }
                else if (currentCheckBox == Nivel3)
                {
                    Nivel1.Checked = false;
                    Nivel2.Checked = false;
                }
            }
        }

   
    }    

}
