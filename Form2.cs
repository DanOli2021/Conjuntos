using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Conjuntos
{
    public partial class Form2 : Form
    {

        public Dictionary<string, double> TestData = new Dictionary<string, double>();
        public ConsoleWriter c;

        public Form2()
        {
            InitializeComponent();
            c = new ConsoleWriter(this.txtResultados);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            int n_inicial = int.Parse(txtNStart.Text);
            int n_final = int.Parse(txtNEnd.Text);

            for (int i = n_inicial; i < n_final; i++)
            {
                
                int[] a = ConjuntosClass.CreateBigArray(i);
                int[] b = ConjuntosClass.CreateBigArray(i);

                DateTime init_time = DateTime.Now;
                string result = ConjuntosClass.Union(string.Join(',', a), string.Join(',', b));
                DateTime end_time = DateTime.Now;
                TimeSpan time_span = end_time - init_time;
                double time_test = time_span.TotalMicroseconds;

                TestData.Add (i.ToString(), time_test);
                c.WriteLine("Test: " + i.ToString() + "," + time_test.ToString());

            }

            string file = Environment.CurrentDirectory + "/union.csv";

            if (File.Exists(file)) 
            {
                File.Delete(file);
            }
            string csv = string.Join(Environment.NewLine, TestData.Select(d => $"{d.Key};{d.Value};"));
            File.WriteAllText(file, csv);

            c.WriteLine("Se ha creado el archivo: " + file);

        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            int n_inicial = int.Parse(txtNStart.Text);
            int n_final = int.Parse(txtNEnd.Text);

            for (int i = n_inicial; i < n_final; i++)
            {

                int[] a = ConjuntosClass.CreateBigArray(i);
                int[] b = ConjuntosClass.CreateBigArray(i);

                DateTime init_time = DateTime.Now;
                string result = ConjuntosClass.Interseccion(string.Join(',', a), string.Join(',', b));
                DateTime end_time = DateTime.Now;
                TimeSpan time_span = end_time - init_time;
                double time_test = time_span.TotalMicroseconds;

                TestData.Add(i.ToString(), time_test);
                c.WriteLine("Test: " + i.ToString() + "," + time_test.ToString());

            }

            string file = Environment.CurrentDirectory + "/interseccion.csv";

            if (File.Exists(file))
            {
                File.Delete(file);
            }
            string csv = string.Join(Environment.NewLine, TestData.Select(d => $"{d.Key};{d.Value};"));
            File.WriteAllText(file, csv);

            c.WriteLine("Se ha creado el archivo: " + file);


        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            int n_inicial = int.Parse(txtNStart.Text);
            int n_final = int.Parse(txtNEnd.Text);

            for (int i = n_inicial; i < n_final; i++)
            {

                int[] a = ConjuntosClass.CreateBigArray(i);
                int[] b = ConjuntosClass.CreateBigArray(i);

                DateTime init_time = DateTime.Now;
                string result = ConjuntosClass.Diferencia(string.Join(',', a), string.Join(',', b));
                DateTime end_time = DateTime.Now;
                TimeSpan time_span = end_time - init_time;
                double time_test = time_span.TotalMicroseconds;

                TestData.Add(i.ToString(), time_test);
                c.WriteLine("Test: " + i.ToString() + "," + time_test.ToString());

            }

            string file = Environment.CurrentDirectory + "/diferencia.csv";

            if (File.Exists(file))
            {
                File.Delete(file);
            }
            string csv = string.Join(Environment.NewLine, TestData.Select(d => $"{d.Key};{d.Value};"));
            File.WriteAllText(file, csv);

            c.WriteLine("Se ha creado el archivo: " + file);

        }

        private void btnDiferenciaSimetrica_Click(object sender, EventArgs e)
        {
            int n_inicial = int.Parse(txtNStart.Text);
            int n_final = int.Parse(txtNEnd.Text);

            for (int i = n_inicial; i < n_final; i++)
            {

                int[] a = ConjuntosClass.CreateBigArray(i);
                int[] b = ConjuntosClass.CreateBigArray(i);

                DateTime init_time = DateTime.Now;
                string result = ConjuntosClass.DiferenciaSimetrica(string.Join(',', a), string.Join(',', b));
                DateTime end_time = DateTime.Now;
                TimeSpan time_span = end_time - init_time;
                double time_test = time_span.TotalMicroseconds;

                TestData.Add(i.ToString(), time_test);
                c.WriteLine("Test: " + i.ToString() + "," + time_test.ToString());

            }

            string file = Environment.CurrentDirectory + "/diferenciasimetrica.csv";

            if (File.Exists(file))
            {
                File.Delete(file);
            }
            string csv = string.Join(Environment.NewLine, TestData.Select(d => $"{d.Key};{d.Value};"));
            File.WriteAllText(file, csv);

            c.WriteLine("Se ha creado el archivo: " + file);

        }
    }
}
