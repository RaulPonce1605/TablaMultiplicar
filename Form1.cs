namespace TablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonver_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }
        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxnum.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxresultados.AppendText(tabla);
        }
        private void buttonclean_Click(object sender, EventArgs e)
        {
            this.limpiaTabla();
        }
        private void limpiaTabla()
        {
            richTextBoxresultados.Text = "";
        }
    }
}
