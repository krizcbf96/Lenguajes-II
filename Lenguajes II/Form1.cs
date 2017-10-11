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
            
        }

        private void colision()
        {
            //Point(x,y)
            if (dogo.Bounds.IntersectsWith(pared6.Bounds))
            {
                if(dogo.Location.X == 200)
                {
                    move_r.Enabled = false;
                    move_d.Enabled = true;
                }
                else
                {
                    move_l.Enabled = false;
                    move_d.Enabled = true;
                }
                
            }
            if (dogo.Bounds.IntersectsWith(pared7.Bounds))
            {
                move_d.Enabled = false;
                move_r.Enabled = true;
            }
           /* if (dogo.Bounds.IntersectsWith(pared8.Bounds))
            {
                move_r.Enabled = false;
                move_up.Enabled = true;
            }*/
            if (dogo.Bounds.IntersectsWith(pared9.Bounds))
            {
                if (dogo.Location.X == 600)
                {
                    move_r.Enabled = false;
                    move_d.Enabled = true;
                }
                else
                {
                    move_l.Enabled = false;
                    move_d.Enabled = true;
                }
            }
            if (dogo.Bounds.IntersectsWith(pared10.Bounds))
            {
                if (dogo.Location.X == 600)
                {
                    move_r.Enabled = false;
                    move_l.Enabled = true;
                }
                else
                {
                    move_l.Enabled = false;
                    move_r.Enabled = true;
                }
            }
            if (dogo.Bounds.IntersectsWith(pared11.Bounds))
            {
                if (dogo.Location.X == 680)
                {
                    move_r.Enabled = false;
                    move_l.Enabled = true;
                }
                else
                {
                    move_l.Enabled = false;
                    move_r.Enabled = true;
                }
            }
            if(dogo.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                move_d.Enabled = false;
                move_up.Enabled = true;
            }
            if (dogo.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                move_l.Enabled = false;
                move_r.Enabled = true;
            }
            if (dogo.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                move_r.Enabled = false;
                move_l.Enabled = true;
            }
            if (dogo.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                move_up.Enabled = false;
                move_d.Enabled = true;
                
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
                move_r.Stop();
                MessageBox.Show("te has encontrado con un terrible destino");
                this.Close();
            }
            if (dogo.Bounds.IntersectsWith(ghost_2.Bounds))
            {
                move_r.Stop();
                MessageBox.Show("te has encontrado con un terrible destino");
                this.Close();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dogo.Location = new Point(dogo.Location.X + 1, dogo.Location.Y);
            colision();
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
                move_r.Stop();
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
            Random juego = new Random();
            if (dogo.Bounds.IntersectsWith(balon.Bounds) || dogo.Bounds.IntersectsWith(pelota.Bounds))
            {
                move_r.Stop();
                do
                {
                    game_time = game_time - 1;

                } while (game_time == 0);


                if (game_time == -1)
                {
                    move_r.Start();
                    move_r.Interval = 2;
                    label2.Visible = false;
                    game_time = 30;
                    pelota.Location = new Point(juego.Next(942), juego.Next(488));
                    balon.Location = new Point(juego.Next(942), juego.Next(488));
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
        private void dormir()
        {
            int sl = 90;
            sl -= 1;
            
            if(sl == 0)
            {
                move_r.Stop();
                label5.Visible = true;
                label5.Text = "Durmiendo: " + sl;
            }
            move_r.Interval = (1000);
            move_r.Start();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void move_d_Tick(object sender, EventArgs e)
        {
            dogo.Location = new Point(dogo.Location.X, dogo.Location.Y + 1);
            colision();
        }

        private void move_up_Tick(object sender, EventArgs e)
        {
            dogo.Location = new Point(dogo.Location.X, dogo.Location.Y - 1);
            colision();
        }

        private void move_l_Tick(object sender, EventArgs e)
        {
            dogo.Location = new Point(dogo.Location.X - 1, dogo.Location.Y);
            colision();
        }
    }
}
