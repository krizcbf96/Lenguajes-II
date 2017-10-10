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
            this.move = new System.Windows.Forms.Timer(this.components);
            this.comida_time = new System.Windows.Forms.Timer(this.components);
            this.box = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ghosts = new System.Windows.Forms.Timer(this.components);
            this.juego = new System.Windows.Forms.Timer(this.components);
            this.box.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // move
            // 
            this.move.Enabled = true;
            this.move.Interval = 2000;
            this.move.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comida_time
            // 
            this.comida_time.Enabled = true;
            this.comida_time.Interval = 1000;
            this.comida_time.Tick += new System.EventHandler(this.comida_Tick);
            // 
            // box
            // 
            this.box.BackColor = System.Drawing.Color.Transparent;
            this.box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("box.BackgroundImage")));
            this.box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box.Controls.Add(this.label5);
            this.box.Controls.Add(this.label3);
            this.box.Controls.Add(this.label2);
            this.box.Controls.Add(this.label1);
            this.box.Controls.Add(this.balon);
            this.box.Controls.Add(this.pelota);
            this.box.Controls.Add(this.ghost_1);
            this.box.Controls.Add(this.hot);
            this.box.Controls.Add(this.hambu);
            this.box.Controls.Add(this.pizza);
            this.box.Controls.Add(this.ghost_2);
            this.box.Controls.Add(this.dogo);
            this.box.Controls.Add(this.pared11);
            this.box.Controls.Add(this.pared10);
            this.box.Controls.Add(this.pared9);
            this.box.Controls.Add(this.pared8);
            this.box.Controls.Add(this.pared7);
            this.box.Controls.Add(this.pared6);
            this.box.Controls.Add(this.pared5);
            this.box.Location = new System.Drawing.Point(12, 12);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(992, 534);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 37;
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 34;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // balon
            // 
            this.balon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("balon.BackgroundImage")));
            this.balon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balon.Location = new System.Drawing.Point(194, 300);
            this.balon.Name = "balon";
            this.balon.Size = new System.Drawing.Size(69, 60);
            this.balon.TabIndex = 32;
            this.balon.TabStop = false;
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.Color.Transparent;
            this.pelota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pelota.BackgroundImage")));
            this.pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pelota.Location = new System.Drawing.Point(798, 318);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(33, 32);
            this.pelota.TabIndex = 31;
            this.pelota.TabStop = false;
            // 
            // ghost_1
            // 
            this.ghost_1.BackColor = System.Drawing.Color.Transparent;
            this.ghost_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghost_1.BackgroundImage")));
            this.ghost_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost_1.Location = new System.Drawing.Point(339, 461);
            this.ghost_1.Name = "ghost_1";
            this.ghost_1.Size = new System.Drawing.Size(62, 73);
            this.ghost_1.TabIndex = 30;
            this.ghost_1.TabStop = false;
            this.ghost_1.Visible = false;
            this.ghost_1.Click += new System.EventHandler(this.ghost_1_Click);
            // 
            // hot
            // 
            this.hot.BackColor = System.Drawing.Color.Transparent;
            this.hot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hot.BackgroundImage")));
            this.hot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hot.Location = new System.Drawing.Point(148, 447);
            this.hot.Name = "hot";
            this.hot.Size = new System.Drawing.Size(58, 51);
            this.hot.TabIndex = 29;
            this.hot.TabStop = false;
            this.hot.Visible = false;
            // 
            // hambu
            // 
            this.hambu.BackColor = System.Drawing.Color.Transparent;
            this.hambu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hambu.BackgroundImage")));
            this.hambu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hambu.Location = new System.Drawing.Point(878, 425);
            this.hambu.Name = "hambu";
            this.hambu.Size = new System.Drawing.Size(57, 56);
            this.hambu.TabIndex = 28;
            this.hambu.TabStop = false;
            this.hambu.Visible = false;
            // 
            // pizza
            // 
            this.pizza.BackColor = System.Drawing.Color.Transparent;
            this.pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pizza.BackgroundImage")));
            this.pizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pizza.Location = new System.Drawing.Point(384, 68);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(50, 46);
            this.pizza.TabIndex = 27;
            this.pizza.TabStop = false;
            this.pizza.Visible = false;
            // 
            // ghost_2
            // 
            this.ghost_2.BackColor = System.Drawing.Color.Transparent;
            this.ghost_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ghost_2.BackgroundImage")));
            this.ghost_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghost_2.Image = ((System.Drawing.Image)(resources.GetObject("ghost_2.Image")));
            this.ghost_2.Location = new System.Drawing.Point(585, 3);
            this.ghost_2.Name = "ghost_2";
            this.ghost_2.Size = new System.Drawing.Size(55, 57);
            this.ghost_2.TabIndex = 26;
            this.ghost_2.TabStop = false;
            this.ghost_2.Visible = false;
            // 
            // dogo
            // 
            this.dogo.BackColor = System.Drawing.Color.Transparent;
            this.dogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dogo.BackgroundImage")));
            this.dogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dogo.Image = ((System.Drawing.Image)(resources.GetObject("dogo.Image")));
            this.dogo.Location = new System.Drawing.Point(52, 30);
            this.dogo.Name = "dogo";
            this.dogo.Size = new System.Drawing.Size(62, 59);
            this.dogo.TabIndex = 25;
            this.dogo.TabStop = false;
            // 
            // pared11
            // 
            this.pared11.BackColor = System.Drawing.Color.Transparent;
            this.pared11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared11.BackgroundImage")));
            this.pared11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared11.Location = new System.Drawing.Point(680, 357);
            this.pared11.Name = "pared11";
            this.pared11.Size = new System.Drawing.Size(21, 174);
            this.pared11.TabIndex = 24;
            this.pared11.TabStop = false;
            // 
            // pared10
            // 
            this.pared10.BackColor = System.Drawing.Color.Transparent;
            this.pared10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared10.BackgroundImage")));
            this.pared10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared10.Location = new System.Drawing.Point(489, 251);
            this.pared10.Name = "pared10";
            this.pared10.Size = new System.Drawing.Size(378, 21);
            this.pared10.TabIndex = 23;
            this.pared10.TabStop = false;
            // 
            // pared9
            // 
            this.pared9.BackColor = System.Drawing.Color.Transparent;
            this.pared9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared9.BackgroundImage")));
            this.pared9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared9.Enabled = false;
            this.pared9.Image = ((System.Drawing.Image)(resources.GetObject("pared9.Image")));
            this.pared9.Location = new System.Drawing.Point(601, 3);
            this.pared9.Name = "pared9";
            this.pared9.Size = new System.Drawing.Size(21, 251);
            this.pared9.TabIndex = 22;
            this.pared9.TabStop = false;
            // 
            // pared8
            // 
            this.pared8.BackColor = System.Drawing.Color.Transparent;
            this.pared8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared8.BackgroundImage")));
            this.pared8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared8.Location = new System.Drawing.Point(359, 280);
            this.pared8.Name = "pared8";
            this.pared8.Size = new System.Drawing.Size(21, 251);
            this.pared8.TabIndex = 21;
            this.pared8.TabStop = false;
            // 
            // pared7
            // 
            this.pared7.BackColor = System.Drawing.Color.Transparent;
            this.pared7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared7.BackgroundImage")));
            this.pared7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared7.Location = new System.Drawing.Point(89, 383);
            this.pared7.Name = "pared7";
            this.pared7.Size = new System.Drawing.Size(274, 21);
            this.pared7.TabIndex = 20;
            this.pared7.TabStop = false;
            // 
            // pared6
            // 
            this.pared6.BackColor = System.Drawing.Color.Transparent;
            this.pared6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared6.BackgroundImage")));
            this.pared6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared6.Location = new System.Drawing.Point(203, 3);
            this.pared6.Name = "pared6";
            this.pared6.Size = new System.Drawing.Size(21, 251);
            this.pared6.TabIndex = 19;
            this.pared6.TabStop = false;
            // 
            // pared5
            // 
            this.pared5.BackColor = System.Drawing.Color.Transparent;
            this.pared5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pared5.BackgroundImage")));
            this.pared5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pared5.Location = new System.Drawing.Point(0, 233);
            this.pared5.Name = "pared5";
            this.pared5.Size = new System.Drawing.Size(126, 21);
            this.pared5.TabIndex = 18;
            this.pared5.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 558);
            this.Controls.Add(this.box);
            this.Name = "Form1";
            this.Text = "Mascota";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.Timer comida_time;
        private System.Windows.Forms.GroupBox box;
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
        private System.Windows.Forms.PictureBox balon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer ghosts;
        private System.Windows.Forms.Timer juego;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

