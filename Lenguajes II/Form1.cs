using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenguajes_II
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dogo_Click(object sender, EventArgs e)
        {
          
        }
        //Movimiento Dogo 
        private void Move_dogo()
        {
            Random rand = new Random();
            dogo.Location = new Point(rand.Next(956), rand.Next(490));
            
            //Colision con paredes y ghosts
            if (dogo.Bounds.IntersectsWith(pared6.Bounds))
            {
                dogo.Location = new Point(rand.Next(100), rand.Next(50));
            }
            if (dogo.Bounds.IntersectsWith(pared7.Bounds))
            {
                dogo.Location = new Point(rand.Next(100), rand.Next(50));
            }
            if (dogo.Bounds.IntersectsWith(pared8.Bounds))
            {
                dogo.Location = new Point(rand.Next(100), rand.Next(50));
            }
            if (dogo.Bounds.IntersectsWith(pared9.Bounds))
            {
                dogo.Location = new Point(rand.Next(100), rand.Next(50));
            }
            if (dogo.Bounds.IntersectsWith(pared10.Bounds))
            {
                dogo.Location = new Point(rand.Next(100), rand.Next(50));
            }
            if (dogo.Bounds.IntersectsWith(pared11.Bounds))
            {
                dogo.Location = new Point(rand.Next(100), rand.Next(50));
            }
            if (dogo.Bounds.IntersectsWith(ghost_1.Bounds))
            {
                move.Stop();
                MessageBox.Show("te has encontrado con un terrible destino");
                this.Close();
            }
            if (dogo.Bounds.IntersectsWith(ghost_2.Bounds))
            {
                move.Stop();
                MessageBox.Show("te has encontrado con un terrible destino");
                this.Close();
            }


        }
        //Aparecer, y mover ghosts cada 10 segundos
        private void move_ghosts()
        {
            ghost_1.Visible = true;
            ghost_2.Visible = true;

            Random rand = new Random();
            ghost_1.Location = new Point(rand.Next(930), rand.Next(461));
            ghost_2.Location = new Point(rand.Next(937), rand.Next(477));

            //Colision con dogo
            if (dogo.Bounds.IntersectsWith(ghost_1.Bounds))
            {
                move.Stop();
                MessageBox.Show("te has encontrado con un terrible destino");
                this.Close();
            }
            if (dogo.Bounds.IntersectsWith(ghost_2.Bounds))
            {
                move.Stop();
                MessageBox.Show("te has encontrado con un terrible destino");
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Move_dogo();
        }

        int time = 60;

        //Cambiar de posicion comida y hacer visible a los 25 segundos
        private void comida_dogo()
        {
            time = time - 1;
            label1.Text = "Comida Time: " + time;
            if (time == 30)
            {
                pizza.Visible = true;
                hambu.Visible = true;
                hot.Visible = true;
            }
            else if (time == 0)
            {
                MessageBox.Show("te has encontrado con un terrible destino");
                move.Stop();
                this.Close();
            }

            Random comida = new Random();

            if (pizza.Bounds.IntersectsWith(dogo.Bounds))
            {
                pizza.Location = new Point(comida.Next(942), comida.Next(488));
                time = 60;
                pizza.Visible = false;
            }
            else if (hambu.Bounds.IntersectsWith(dogo.Bounds))
            {
                
                hambu.Location = new Point(comida.Next(942), comida.Next(488));
                time = 60;
                hambu.Visible = false;
            }
            else if (hot.Bounds.IntersectsWith(dogo.Bounds))
            {
                hot.Location = new Point(comida.Next(942), comida.Next(488));
                time = 60;
                hot.Visible = false;
            }
           
        }
        //Tiempo de comer 60 segundos
        private void comida_Tick(object sender, EventArgs e)
        {
            comida_dogo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void ghost_1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            move_ghosts();
        }

        int game_time = 30;

        private void game()
        {
            if (dogo.Bounds.IntersectsWith(balon.Bounds) || dogo.Bounds.IntersectsWith(pelota.Bounds))
            {

                do
                {
                    move.Stop();
                    game_time = game_time - 1;
                } while (game_time == 0);

                if (game_time == -1)
                {
                    move.Stop();
                    move.Start();
                    label2.Visible = false;
                    game_time = 30;
                    
                }
                else
                {
                    game_time = game_time - 1;
                    label2.Text = "Jugando: " + game_time;
                }
            }
            
        }

        private void juego_Tick(object sender, EventArgs e)
        {
            game();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
