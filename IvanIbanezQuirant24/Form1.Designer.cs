namespace IvanIbanezQuirant24
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJugador = new System.Windows.Forms.TextBox();
            this.labelPuntuacion = new System.Windows.Forms.Label();
            this.buttonPregunta = new System.Windows.Forms.Button();
            this.buttonJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puntuacion";
            // 
            // textBoxJugador
            // 
            this.textBoxJugador.Location = new System.Drawing.Point(491, 84);
            this.textBoxJugador.Name = "textBoxJugador";
            this.textBoxJugador.Size = new System.Drawing.Size(125, 27);
            this.textBoxJugador.TabIndex = 3;
            // 
            // labelPuntuacion
            // 
            this.labelPuntuacion.AutoSize = true;
            this.labelPuntuacion.Location = new System.Drawing.Point(537, 183);
            this.labelPuntuacion.Name = "labelPuntuacion";
            this.labelPuntuacion.Size = new System.Drawing.Size(17, 20);
            this.labelPuntuacion.TabIndex = 4;
            this.labelPuntuacion.Text = "0";
            // 
            // buttonPregunta
            // 
            this.buttonPregunta.Location = new System.Drawing.Point(262, 382);
            this.buttonPregunta.Name = "buttonPregunta";
            this.buttonPregunta.Size = new System.Drawing.Size(227, 29);
            this.buttonPregunta.TabIndex = 5;
            this.buttonPregunta.Text = "Añadir Preguntas y Respuestas";
            this.buttonPregunta.UseVisualStyleBackColor = true;
            this.buttonPregunta.Click += new System.EventHandler(this.buttonPregunta_Click);
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(319, 461);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(94, 29);
            this.buttonJugar.TabIndex = 5;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 573);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.buttonPregunta);
            this.Controls.Add(this.labelPuntuacion);
            this.Controls.Add(this.textBoxJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Hola soy Mr Question";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxJugador;
        private Label labelPuntuacion;
        private Button buttonPregunta;
        private Button buttonJugar;
    }
}