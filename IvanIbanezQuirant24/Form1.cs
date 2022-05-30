namespace IvanIbanezQuirant24
{
    public partial class Form1 : Form
    {

        public Form2 cargarPreg = new Form2();
        public Form3 jugar = new Form3();

        
        public Form1()
        {
            InitializeComponent();
            string player = textBoxJugador.Text;

        }

        static int points = 0;

        private void buttonPregunta_Click(object sender, EventArgs e)
        {
            Hide();
            cargarPreg.ShowDialog();  
            Show();

        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            Hide();
            jugar.ShowDialog();
            Show();

        }
    }
}