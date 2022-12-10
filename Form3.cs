using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjuntos
{
    public partial class Form3 : Form
    {

        public Bayes b = null;
        public ConsoleWriter c;

        public Form3()
        {
            InitializeComponent();
            c = new ConsoleWriter(this.txtResultados);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNodeName.Text)) 
            {
                c.WriteLine("Debe ingresar un nombre para el nodo");
                return;
            }

            if (string.IsNullOrEmpty(txtProbabilidad.Text))
            {
                c.WriteLine("Debe ingresar una probabilidad para el nodo");
                return;
            }

            if (string.IsNullOrEmpty(txtEvento.Text))
            {
                c.WriteLine("Debe ingresar la probabilidad para el evento para el nodo");
                return;
            }

            double probabilidad = 0;
            double evento = 0;

            if (!double.TryParse(txtProbabilidad.Text, out probabilidad))
            {
                c.WriteLine("La probabilidad debe ser un número decimal");
                return;
            }

            if (!double.TryParse(txtEvento.Text, out evento))
            {
                c.WriteLine("La probabilidad del evento debe ser un número decimal");
                return;
            }

            if (probabilidad < 0 || probabilidad > 1)
            {
                c.WriteLine("La probabilidad debe ser un número decimal entre 0 y 1");
                return;
            }

            if (evento < 0 || evento > 1)
            {
                c.WriteLine("La probabilidad del evento debe ser un número decimal entre 0 y 1");
                return;
            }

            if (b is null) 
            {
                b = new Bayes(txtPlanteamiento.Text);
            }
            
            string result = b.AddBayesNode(txtNodeName.Text, probabilidad, evento);
            c.WriteLine("Nodo: " + txtNodeName.Text + "-->" + result);

            txtNodeName.Text = "";
            txtProbabilidad.Text = "";
            txtEvento.Text = "";
            txtNodeName.Focus();

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (b == null)
            {
                c.WriteLine("Debe agregar al menos un nodo");
                return;
            }

            c.WriteLine("Probabilidad total: " + b.CalculationTotalProbability() + "%");
            c.WriteLine(b.CalculationTotalProbabilityDependency());
            c.WriteLine(JsonConvert.SerializeObject(b.nodes,  Formatting.Indented));                

        }

        private void buttonNuevoCalculo_Click(object sender, EventArgs e)
        {
            this.b = new Bayes(txtPlanteamiento.Text);
        }
    }
}
