using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvanIbanezQuirant24
{
    public partial class Form2 : Form
    {
        List<QuestionModel> preguntas = new List<QuestionModel>();


        public Form2()
        {
            InitializeComponent();

        }

        private void buttonCancelaPreg_Click(object sender, EventArgs e)
        {
            
            Close();

        }

        private void buttonGuardaPreg_Click(object sender, EventArgs e)
        {
            string[] arrayPreg = { textBoxRespA.Text, textBoxRespB.Text, textBoxRespC.Text };
            int valorPuntos = int.Parse(textBoxValor.Text);
            QuestionModel pregunta = new QuestionModel(textBoxPregunta.Text, arrayPreg, valorPuntos);
            preguntas.Add(pregunta);
        }
    }
}
