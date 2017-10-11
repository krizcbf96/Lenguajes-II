namespace Lenguajes_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.move_r = new System.Windows.Forms.Timer(this.components);
            this.comida_time = new System.Windows.Forms.Timer(this.components);
            this.ghosts = new System.Windows.Forms.Timer(this.components);
            this.juego = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.balon = new System.Windows.Forms.PictureBox();
            this.pelota = new System.Windows.Forms.PictureBox();
            this.ghost_1 = new System.Windows.Forms.PictureBox();
            this.hot = new System.Windows.Forms.PictureBox();
            this.hambu = new System.Windows.Forms.PictureBox();
            this.pizza = new System.Windows.Forms.PictureBox();
            this.ghost_2 = new System.Windows.Forms.PictureBox();
            this.dogo = new System.Windows.Forms.PictureBox();
            this.pared11 = new System.Windows.Forms.PictureBox();
            this.pared10 = new System.Windows.Forms.PictureBox();
            this.pared9 = new System.Windows.Forms.PictureBox();
            this.pared8 = new System.Windows.Forms.PictureBox();
            this.pared7 = new System.Windows.Forms.PictureBox();
            this.pared6 = new System.Windows.Forms.PictureBox();
            this.pared5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.move_d = new System.Windows.Forms.Timer(this.components);
            this.move_up = new System.Windows.Forms.Timer(this.components);
            this.move_l = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.balon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hambu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // move_r
            // 
            this.move_r.Enabled = true;
            this.move_r.Interval = 1;
            this.move_r.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comida_time
            // 
            this.comida_time.Enabled = true;
            this.comida_time.Interval = 1000;
            this.comida_time.Tick += new System.EventHandler(this.comida_Tick);
            // 
            // ghosts
            // 
            this.ghosts.Enabled = true;
            this.ghosts.Interval = 10000;
            this.ghosts.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // juego
            // 
            this.juego.Enabled = true;
            this.juego.Interval = 1000;
            this.juego.Tick += new System.EventHandler(this.juego_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(486, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 55;
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(62, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(916, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 53;
            // 
            // balon
            // 
            this.balon.BackColor = System.Drawing.Color.Transparent;
            this.balon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("balon.BackgroundImage")));
            this.balon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.balon.Location = new System.Drawing.Point(58, 311);
            this.balon.Name = "balon";
            this.balon.Size = new System.Drawing.Size(69, 60);
            this.balon.TabIndex = 52;
            this.balon.TabStop = false;
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.Color.Transparent;
            this.pelota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pelota.BackgroundImage")));
            this.pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pelota.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pelota.Location = new System.Drawing.Point(839, 329);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(33, 32);
            this.pelota.TabIndex = 51;
            this.pelota.TabStop = false;
            // 
            // ghost_1
            // 
            this.ghost_1.BackColor = System.Drawing.Color.Transparent;
            this.ghost_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost_1.Image = global::Lenguajes_II.Properties.Resources.tumblr_o21bscL3FW1uf5cjoo1_400;
            this.ghost_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ghost_1.Location = new System.Drawing.Point(386, 489);
            this.ghost_1.Name = "ghost_1";
            this.ghost_1.Size = new System.Drawing.Size(62, 73);
            this.ghost_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost_1.TabIndex = 50;
            this.ghost_1.TabStop = false;
            this.ghost_1.Visible = false;
            // 
            // hot
            // 
            this.hot.BackColor = System.Drawing.Color.Transparent;
            this.hot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hot.BackgroundImage")));
            this.hot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hot.Location = new System.Drawing.Point(189, 458);
            this.hot.Name = "hot";
            this.hot.Size = new System.Drawing.Size(58, 51);
            this.hot.TabIndex = 49;
            this.hot.TabStop = false;
            this.hot.Visible = false;
            // 
            // hambu
            // 
            this.hambu.BackColor = System.Drawing.Color.Transparent;
            this.hambu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hambu.BackgroundImage")));
            this.hambu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hambu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hambu.Location = new System.Drawing.Point(919, 436);
            this.hambu.Name = "hambu";
            this.hambu.Size = new System.Drawing.Size(57, 56);
            this.hambu.TabIndex = 48;
            this.hambu.TabStop = false;
            this.hambu.Visible = false;
            // 
            // pizza
            // 
            this.pizza.BackColor = System.Drawing.Color.Transparent;
            this.pizza.BackgroundImage = global::Lenguajes_II.Properties.Resources.pizza;
            this.pizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizza.Image = global::Lenguajes_II.Properties.Resources.pizza;
            this.pizza.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pizza.Location = new System.Drawing.Point(425, 79);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(50, 46);
            this.pizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pizza.TabIndex = 47;
            this.pizza.TabStop = false;
            this.pizza.Visible = false;
            // 
            // ghost_2
            // 
            this.ghost_2.BackColor = System.Drawing.Color.Transparent;
            this.ghost_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost_2.Image = global::Lenguajes_II.Properties.Resources.tumblr_o21bscL3FW1uf5cjoo1_400;
            this.ghost_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ghost_2.Location = new System.Drawing.Point(629, 2);
            this.ghost_2.Name = "ghost_2";
            this.ghost_2.Size = new System.Drawing.Size(55, 57);
            this.ghost_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost_2.TabIndex = 46;
            this.ghost_2.TabStop = false;
            this.ghost_2.Visible = false;
            // 
            // dogo
            // 
            this.dogo.BackColor = System.Drawing.Color.Transparent;
            this.dogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dogo.Image = global::Lenguajes_II.Properties.Resources._15c144e8dc552a100b3292d268854499;
            this.dogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dogo.Location = new System.Drawing.Point(93, 41);
            this.dogo.Name = "dogo";
            this.dogo.Size = new System.Drawing.Size(62, 59);
            this.dogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogo.TabIndex = 45;
            this.dogo.TabStop = false;
            // 
            // pared11
            // 
            this.pared11.BackColor = System.Drawing.Color.Transparent;
            this.pared11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared11.BackgroundImage")));
            this.pared11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared11.Location = new System.Drawing.Point(722, 388);
            this.pared11.Name = "pared11";
            this.pared11.Size = new System.Drawing.Size(21, 174);
            this.pared11.TabIndex = 44;
            this.pared11.TabStop = false;
            // 
            // pared10
            // 
            this.pared10.BackColor = System.Drawing.Color.Transparent;
            this.pared10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared10.BackgroundImage")));
            this.pared10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared10.Location = new System.Drawing.Point(530, 244);
            this.pared10.Name = "pared10";
            this.pared10.Size = new System.Drawing.Size(378, 21);
            this.pared10.TabIndex = 43;
            this.pared10.TabStop = false;
            // 
            // pared9
            // 
            this.pared9.BackColor = System.Drawing.Color.Transparent;
            this.pared9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared9.BackgroundImage")));
            this.pared9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared9.Enabled = false;
            this.pared9.Image = ((System.Drawing.Image)(resources.GetObject("pared9.Image")));
            this.pared9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared9.Location = new System.Drawing.Point(642, 2);
            this.pared9.Name = "pared9";
            this.pared9.Size = new System.Drawing.Size(21, 251);
            this.pared9.TabIndex = 42;
            this.pared9.TabStop = false;
            // 
            // pared8
            // 
            this.pared8.BackColor = System.Drawing.Color.Transparent;
            this.pared8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared8.BackgroundImage")));
            this.pared8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared8.Location = new System.Drawing.Point(400, 311);
            this.pared8.Name = "pared8";
            this.pared8.Size = new System.Drawing.Size(21, 251);
            this.pared8.TabIndex = 41;
            this.pared8.TabStop = false;
            // 
            // pared7
            // 
            this.pared7.BackColor = System.Drawing.Color.Transparent;
            this.pared7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared7.BackgroundImage")));
            this.pared7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared7.Location = new System.Drawing.Point(130, 394);
            this.pared7.Name = "pared7";
            this.pared7.Size = new System.Drawing.Size(274, 21);
            this.pared7.TabIndex = 40;
            this.pared7.TabStop = false;
            // 
            // pared6
            // 
            this.pared6.BackColor = System.Drawing.Color.Transparent;
            this.pared6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared6.BackgroundImage")));
            this.pared6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared6.Location = new System.Drawing.Point(244, 2);
            this.pared6.Name = "pared6";
            this.pared6.Size = new System.Drawing.Size(21, 251);
            this.pared6.TabIndex = 39;
            this.pared6.TabStop = false;
            // 
            // pared5
            // 
            this.pared5.BackColor = System.Drawing.Color.Transparent;
            this.pared5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared5.BackgroundImage")));
            this.pared5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pared5.Location = new System.Drawing.Point(1, 244);
            this.pared5.Name = "pared5";
            this.pared5.Size = new System.Drawing.Size(126, 21);
            this.pared5.TabIndex = 38;
            this.pared5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 560);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(1, 552);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1018, 10);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 560);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(1, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1028, 10);
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // move_d
            // 
            this.move_d.Interval = 1;
            this.move_d.Tick += new System.EventHandler(this.move_d_Tick);
            // 
            // move_up
            // 
            this.move_up.Interval = 1;
            this.move_up.Tick += new System.EventHandler(this.move_up_Tick);
            // 
            // move_l
            // 
            this.move_l.Interval = 1;
            this.move_l.Tick += new System.EventHandler(this.move_l_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Lenguajes_II.Properties.Resources._04e68499ce5b064bd912f77ed23b23e5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 558);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balon);
            this.Controls.Add(this.pelota);
            this.Controls.Add(this.ghost_1);
            this.Controls.Add(this.hot);
            this.Controls.Add(this.hambu);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.ghost_2);
            this.Controls.Add(this.dogo);
            this.Controls.Add(this.pared11);
            this.Controls.Add(this.pared10);
            this.Controls.Add(this.pared9);
            this.Controls.Add(this.pared8);
            this.Controls.Add(this.pared7);
            this.Controls.Add(this.pared6);
            this.Controls.Add(this.pared5);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Mascota";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hambu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pared5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer move_r;
        private System.Windows.Forms.Timer comida_time;
        private System.Windows.Forms.Timer ghosts;
        private System.Windows.Forms.Timer juego;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox balon;
        private System.Windows.Forms.PictureBox pelota;
        private System.Windows.Forms.PictureBox ghost_1;
        private System.Windows.Forms.PictureBox hot;
        private System.Windows.Forms.PictureBox hambu;
        private System.Windows.Forms.PictureBox pizza;
        private System.Windows.Forms.PictureBox ghost_2;
        private System.Windows.Forms.PictureBox dogo;
        private System.Windows.Forms.PictureBox pared11;
        private System.Windows.Forms.PictureBox pared10;
        private System.Windows.Forms.PictureBox pared9;
        private System.Windows.Forms.PictureBox pared8;
        private System.Windows.Forms.PictureBox pared7;
        private System.Windows.Forms.PictureBox pared6;
        private System.Windows.Forms.PictureBox pared5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer move_d;
        private System.Windows.Forms.Timer move_up;
        private System.Windows.Forms.Timer move_l;
    }
}

