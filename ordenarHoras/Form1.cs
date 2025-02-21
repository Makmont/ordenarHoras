namespace ordenarHoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int[] horas = { int.Parse(textBoxHora1.Text), int.Parse(textBoxHora2.Text), int.Parse(textBoxHora3.Text) };
            int[] minutos = { int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text) };

            
            string[] etiquetas = { "T1", "T2", "T3" };

            
            TimeSpan[] tiempos = new TimeSpan[3];
            for (int i = 0; i < 3; i++)
            {
                tiempos[i] = new TimeSpan(horas[i], minutos[i], 0);
            }

            
            Array.Sort(tiempos, etiquetas);

            
            string[] horasMenorAMayor = new string[3];
            string[] horasMayorAMenor = new string[3];

            
            for (int i = 0; i < 3; i++)
            {
                horasMenorAMayor[i] = etiquetas[i] + ": " + tiempos[i].Hours + " horas " + tiempos[i].Minutes + " minutos";
            }

            
            textBoxTransferencia1.Text = horasMenorAMayor[0];
            textBoxTransferencia2.Text = horasMenorAMayor[1];
            textBoxTransferencia3.Text = horasMenorAMayor[2];

            
            Array.Reverse(tiempos);
            Array.Reverse(etiquetas);

            
            for (int i = 0; i < 3; i++)
            {
                horasMayorAMenor[i] = etiquetas[i] + ": " + tiempos[i].Hours + " horas " + tiempos[i].Minutes + " minutos";
            }

            
            textBoxTransferenciaMayor1.Text = horasMayorAMenor[0];
            textBoxTransferenciaMayor2.Text = horasMayorAMenor[1];
            textBoxTransferenciaMayor3.Text = horasMayorAMenor[2];
        }

        
        private void LimpiarCampos()
        {
            textBoxHora1.Text = "";
            textBoxHora2.Text = "";
            textBoxHora3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBoxTransferencia1.Text = "";
            textBoxTransferencia2.Text = "";
            textBoxTransferencia3.Text = "";
            textBoxTransferenciaMayor1.Text = "";
            textBoxTransferenciaMayor2.Text = "";
            textBoxTransferenciaMayor3.Text = "";
        }

        

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            
            LimpiarCampos();
        }
    }
}
