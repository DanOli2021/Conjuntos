using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos
{

    // Todo el código lo dejamos en una sola clase
    // Una clase estatica no es necesario inicializarla solo
    // se llama a sus metodos
    public static class ConjuntosClass
    {
        // Metodo que recibe dos conjuntos y devuelve la union de ambos conjuntos
        public static string Union(string A, string B) 
        {

            try
            {
                // Como recibimos los conjuntos como string los convertimos a un arreglo
                string[] a = A.Split(',');
                string[] b = B.Split(',');

                // Creamos un conjunto para almacenar la union de los conjuntos
                // Usamos un objeto list para poder agregar elementos
                List<string> conjunto_nuevo = new List<string>();

                //Recorremos el arreglo a y lo agregamos al conjunto nuevo
                foreach (string elemento in a)
                {
                    conjunto_nuevo.Add(elemento);
                }

                //Recorremos el arreglo b y lo agregamos al conjunto nuevo
                foreach (string elemento in b)
                {
                    conjunto_nuevo.Add(elemento);
                }

                // Convertimos el conjunto nuevo a un string y lo devolvemos
                return string.Join(",", conjunto_nuevo.ToArray());

            }
            catch (Exception e)
            {
                return "Error: Union:" + e.Message;
            }

        }


        public static string Interseccion(string A, string B)
        {
            try
            {
                // Como recibimos los conjuntos como string los convertimos a un arreglo
                string[] a = A.Split(',');
                string[] b = B.Split(',');

                // Creamos un conjunto para almacenar la union de los conjuntos
                // Usamos un objeto list para poder agregar elementos
                List<string> conjunto_nuevo = new List<string>();

                //Recorremos el arreglo a y lo agregamos al conjunto nuevo
                foreach (string elemento in a)
                {
                    // Si el elemento está en B lo agregamos
                    if (b.Contains(elemento))
                    {
                        conjunto_nuevo.Add(elemento);
                    }
                }

                // Convertimos el conjunto nuevo a un string y lo devolvemos
                return string.Join(",", conjunto_nuevo.ToArray());

            }
            catch (Exception e)
            {
                return "Error: Interseccion: " + e.Message;
            }
            

        }


        public static string Diferencia(string A, string B)
        {
            try
            {
                // Como recibimos los conjuntos como string los convertimos a un arreglo
                string[] a = A.Split(',');
                string[] b = B.Split(',');

                // Creamos un conjunto para almacenar la union de los conjuntos
                // Usamos un objeto list para poder agregar elementos
                List<string> conjunto_nuevo = new List<string>();

                //Recorremos el arreglo a y lo agregamos al conjunto nuevo
                foreach (string elemento in a)
                {
                    // Si el elemento no está en B no lo agregamos
                    if (!b.Contains(elemento))
                    {
                        conjunto_nuevo.Add(elemento);
                    }
                }

                // Convertimos el conjunto nuevo a un string y lo devolvemos
                return string.Join(",", conjunto_nuevo.ToArray());


            }
            catch (Exception e)
            {
                return "Error: Diferencia: " + e.Message;
            }
            
        }

        public static string DiferenciaSimetrica(string A, string B)
        {
            try
            {
                // Como recibimos los conjuntos como string los convertimos a un arreglo
                string[] a = A.Split(',');
                string[] b = B.Split(',');

                // Creamos un conjunto para almacenar la union de los conjuntos
                // Usamos un objeto list para poder agregar elementos
                List<string> conjunto_nuevo = new List<string>();

                //Recorremos el arreglo a y lo agregamos al conjunto nuevo
                foreach (string elemento in a)
                {
                    // Si el elemento no está en B lo agregamos
                    if (!b.Contains(elemento))
                    {
                        conjunto_nuevo.Add(elemento);
                    }
                }

                //Recorremos el arreglo a y lo agregamos al conjunto nuevo
                foreach (string elemento in b)
                {
                    // Si el elemento no está en A lo agregamos
                    if (!a.Contains(elemento))
                    {
                        conjunto_nuevo.Add(elemento);
                    }
                }

                // Convertimos el conjunto nuevo a un string y lo devolvemos
                return string.Join(",", conjunto_nuevo.ToArray());

            }
            catch (Exception e)
            {
                return "Error: DiferenciaSimetrica: " + e.Message;
            }

        }

        public static string ComplementoDeUnConjunto(string universo, string A)
        {

            try
            {
                // Como recibimos los conjuntos como string los convertimos a un arreglo
                string[] a = A.Split(',');
                string[] universo_array = universo.Split(',');

                // Creamos un conjunto para almacenar la union de los conjuntos
                // Usamos un objeto list para poder agregar elementos
                List<string> conjunto_nuevo = new List<string>();

                //Recorremos el arreglo a y lo agregamos al conjunto nuevo
                foreach (string elemento in universo_array)
                {
                    // Si el elemento no está en A lo agregamos
                    if (!a.Contains(elemento))
                    {
                        conjunto_nuevo.Add(elemento);
                    }
                }

                // Convertimos el conjunto nuevo a un string y lo devolvemos
                return string.Join(",", conjunto_nuevo.ToArray());

            }
            catch (Exception e)
            {
                return "Error: ComplementoDeUnConjunto: " + e.Message;
            }
        }


        // Creamos un arreglo de n elementos aleatorios
        // para hacer pruebas con el algoritmo de ordenamiento
        public static int[] CreateBigArray(int elements)
        {

            int[] A = new int[elements];
            Random randNum = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = randNum.Next(0, elements); ;
            }

            QuickSort(A, 0, A.Length - 1);

            return A;

        }

        // Quick Sort, es un algoritmo de ordenamiento basado en la técnica de divide y vencerás
        // Es el más eficiente de los algoritmos de ordenamiento, y es el más usado en la actualidad
        // El autor de este algoritmo es Tony Hoare, en 1959
        // Este algoritmo es muy eficiente, pero no es estable, es decir, si hay dos elementos iguales
        // no se mantienen en el mismo orden.
        // La idea central del algoritmo se toma un elemento X de una posición cualquiera del arreglo
        // y se divide el arreglo en dos sub arreglos, uno con los elementos menores que X y otro con los
        // elementos mayores que X, luego se ordenan los sub arreglos y se unen en un solo arreglo ordenado.
        public static void QuickSort(int[] A, int first, int last)
        {
            int i, j, central;
            double pivote;
            // Obetenemos el elemento central del arreglo
            central = (first + last) / 2;
            // Obtenemos el pivote
            pivote = A[central];
            i = first;
            j = last;

            // Mientras que i sea menor que j
            do
            {
                while (A[i] < pivote) i++;
                while (A[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            // Si el elemento inicial es menor que el elemento final, entonces se llama a la función
            if (first < j)
            {
                QuickSort(A, first, j);
            }

            // Si el elemento final es mayor que el elemento inicial, entonces se llama a la función
            if (i < last)
            {
                QuickSort(A, i, last);
            }
        }

    }
}


public class BayesNode
{
    public double data;
    public BayesNode A = null;
    public BayesNode B = null;
    public string NodeName;

    public enum NodeType
    {
        A,
        B
    }
    
    public string AddBayesNode(string NodeNameA, string NodeNameB, double data)        
    {

        if (data >= 1) 
        {
            return "Error: The value of data must always be less than 1.";
        }

        if (string.IsNullOrEmpty(NodeNameA)) 
        {
            return "Error: The NodeNameA parameter must not be an empty string";
        }

        if (string.IsNullOrEmpty(NodeNameB))
        {
            return "Error: The NodeNameB parameter must not be an empty string";
        }

        if (NodeNameA.Trim().ToLower() == NodeNameB.Trim().ToLower())
        {
            return "Error: NodeNameA and nodeNameB parameters must not be the same";
        }

        this.A = new BayesNode();
        this.A.data = data;
        this.A.NodeName = NodeNameA;

        this.B = new BayesNode();
        this.B.data = 1 - data;
        this.B.NodeName = NodeNameB;

        return "Ok.";
    }

    public double CalculateProbability() 
    {
         if (this.A is null) return this.data;
         return this.data * CalculateProbability();
    }

}


//Bayes' theorem algorithm


public class ConsoleWriter : TextWriter
{
    public string log_file = "";
    TextBox c;

    public ConsoleWriter( TextBox c )
    {
        this.c = c;
    }

    public override void Write(char value)
    {
        c.AppendText("" + value);
    }

    public override void Write(string value = "")
    {
        c.AppendText("" + value);
    }

    public override void WriteLine(char value)
    {
        c.AppendText("" + value + "\r\n");
    }

    public override void WriteLine(string value = "")
    {
        c.AppendText("" + value + "\r\n");
    }

    public override Encoding Encoding
    {
        get { return Encoding.UTF8; }
    }
}

