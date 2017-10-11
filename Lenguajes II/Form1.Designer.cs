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
            this.move.Interval = 2;
            this.move.Tick += new System.EventHandler(this.timer1_Tick);
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
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // balon
            // 
            this.balon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.balon, "balon");
            this.balon.Name = "balon";
            this.balon.TabStop = false;
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pelota, "pelota");
            this.pelota.Name = "pelota";
            this.pelota.TabStop = false;
            // 
            // ghost_1
            // 
            this.ghost_1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ghost_1, "ghost_1");
            this.ghost_1.Image = global::Lenguajes_II.Properties.Resources.tumblr_o21bscL3FW1uf5cjoo1_400;
            this.ghost_1.Name = "ghost_1";
            this.ghost_1.TabStop = false;
            // 
            // hot
            // 
            this.hot.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hot, "hot");
            this.hot.Name = "hot";
            this.hot.TabStop = false;
            // 
            // hambu
            // 
            this.hambu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hambu, "hambu");
            this.hambu.Name = "hambu";
            this.hambu.TabStop = false;
            // 
            // pizza
            // 
            this.pizza.BackColor = System.Drawing.Color.Transparent;
            this.pizza.BackgroundImage = global::Lenguajes_II.Properties.Resources.pizza;
            resources.ApplyResources(this.pizza, "pizza");
            this.pizza.Image = global::Lenguajes_II.Properties.Resources.pizza;
            this.pizza.Name = "pizza";
            this.pizza.TabStop = false;
            // 
            // ghost_2
            // 
            this.ghost_2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ghost_2, "ghost_2");
            this.ghost_2.Image = global::Lenguajes_II.Properties.Resources.tumblr_o21bscL3FW1uf5cjoo1_400;
            this.ghost_2.Name = "ghost_2";
            this.ghost_2.TabStop = false;
            // 
            // dogo
            // 
            this.dogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.dogo, "dogo");
            this.dogo.Image = global::Lenguajes_II.Properties.Resources._15c144e8dc552a100b3292d268854499;
            this.dogo.Name = "dogo";
            this.dogo.TabStop = false;
            // 
            // pared11
            // 
            this.pared11.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared11, "pared11");
            this.pared11.Name = "pared11";
            this.pared11.TabStop = false;
            // 
            // pared10
            // 
            this.pared10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared10, "pared10");
            this.pared10.Name = "pared10";
            this.pared10.TabStop = false;
            // 
            // pared9
            // 
            this.pared9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared9, "pared9");
            this.pared9.Name = "pared9";
            this.pared9.TabStop = false;
            // 
            // pared8
            // 
            this.pared8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared8, "pared8");
            this.pared8.Name = "pared8";
            this.pared8.TabStop = false;
            // 
            // pared7
            // 
            this.pared7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared7, "pared7");
            this.pared7.Name = "pared7";
            this.pared7.TabStop = false;
            // 
            // pared6
            // 
            this.pared6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared6, "pared6");
            this.pared6.Name = "pared6";
            this.pared6.TabStop = false;
            // 
            // pared5
            // 
            this.pared5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pared5, "pared5");
            this.pared5.Name = "pared5";
            this.pared5.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Lenguajes_II.Properties.Resources._04e68499ce5b064bd912f77ed23b23e5;
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
            this.Name = "Form1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer move;
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
    }
}

