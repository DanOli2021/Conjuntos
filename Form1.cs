using System.Globalization;

namespace Conjuntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            txtResultados.Text = ConjuntosClass.Union(txtConjuntoA.Text, txtConjuntoB.Text);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            txtResultados.Text = ConjuntosClass.Diferencia(txtConjuntoA.Text, txtConjuntoB.Text);
        }

        private void btnDiferenciaSimetrica_Click(object sender, EventArgs e)
        {
            txtResultados.Text = ConjuntosClass.DiferenciaSimetrica(txtConjuntoA.Text, txtConjuntoB.Text);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            txtResultados.Text = ConjuntosClass.Interseccion(txtConjuntoA.Text, txtConjuntoB.Text);
        }

        private void btnComplemento_Click(object sender, EventArgs e)
        {
            txtResultados.Text = ConjuntosClass.ComplementoDeUnConjunto(txtUniverso.Text, txtConjuntoA.Text);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int elementos = int.Parse(txtAleatorios.Text);
                txtConjuntoA.Text = string.Join(",", ConjuntosClass.CreateBigArray(elementos));
                txtConjuntoB.Text = string.Join(",", ConjuntosClass.CreateBigArray(elementos));
                txtUniverso.Text = txtConjuntoA.Text + "," + txtConjuntoB.Text;

            }
            catch (Exception e1)
            {
                txtResultados.Text = "Error: btnGenerar_Click:" + e1.Message;
            }
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}