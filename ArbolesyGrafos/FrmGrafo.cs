using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesyGrafos
{
    public partial class FrmGrafo : Form
    {
        private List<string> edificios = new List<string>();
        private Dictionary<string, List<(string destino, int peso)>> grafo = new Dictionary<string, List<(string destino, int peso)>>();

        public FrmGrafo()
        {
            InitializeComponent();
        }

        private void FrmGrafo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            string nombre = tbEdificio.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre válido.");
                return;
            }
            if (edificios.Contains(nombre))
            {
                MessageBox.Show("El edificio ya existe.");
                return;
            }

            edificios.Add(nombre);
            grafo[nombre] = new List<(string destino, int peso)>();

            cmbEdificioA.Items.Add(nombre);
            cmbEdificioB.Items.Add(nombre);

            MessageBox.Show($"Edificio '{nombre}' agregado.");
            tbEdificio.Clear();
        }

        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {
            string a = cmbEdificioA.Text;
            string b = cmbEdificioB.Text;

            if (!edificios.Contains(a) || !edificios.Contains(b))
            {
                MessageBox.Show("Seleccione edificios válidos.");
                return;
            }
            if (a == b)
            {
                MessageBox.Show("No se puede conectar un edificio consigo mismo.");
                return;
            }
            if (!int.TryParse(tbDistancia.Text, out int distancia) || distancia <= 0)
            {
                MessageBox.Show("Ingrese una distancia válida (>0).");
                return;
            }
            grafo[a].Add((b, distancia));
            grafo[b].Add((a, distancia));

            MessageBox.Show($"Conexión agregada: {a} ↔ {b} con distancia {distancia}");
            tbDistancia.Clear();
        }

        private void btnMostrarAdyacencias_Click(object sender, EventArgs e)
        {
            string resultado = "";
            foreach (var nodo in grafo)
            {
                resultado += $"{nodo.Key}: ";
                resultado += string.Join(", ", nodo.Value.Select(v => $"{v.destino}({v.peso})"));
                resultado += "\n";
            }

            MessageBox.Show(resultado, "Lista de Adyacencia");
        }

        private void btnValidarConexidad_Click(object sender, EventArgs e)
        {
            if (edificios.Count == 0)
            {
                MessageBox.Show("No hay edificios.");
                return;
            }

            HashSet<string> visitados = new HashSet<string>();
            Queue<string> cola = new Queue<string>();
            cola.Enqueue(edificios[0]);

            while (cola.Count > 0)
            {
                string actual = cola.Dequeue();
                if (!visitados.Contains(actual))
                {
                    visitados.Add(actual);
                    foreach (var vecino in grafo[actual])
                    {
                        if (!visitados.Contains(vecino.destino))
                            cola.Enqueue(vecino.destino);
                    }
                }
            }

            if (visitados.Count == edificios.Count)
                MessageBox.Show("El grafo es conexo.");
            else
                MessageBox.Show("El grafo NO es conexo.");
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            string inicio = cmbEdificioA.Text;
            string fin = cmbEdificioB.Text;

            if (!edificios.Contains(inicio) || !edificios.Contains(fin))
            {
                MessageBox.Show("Seleccione edificios válidos.");
                return;
            }

            
            var distancias = new Dictionary<string, int>();
            var prev = new Dictionary<string, string>();
            var q = new List<string>(edificios);

            foreach (var edificio in edificios)
            {
                distancias[edificio] = int.MaxValue;
                prev[edificio] = null;
            }
            distancias[inicio] = 0;

            while (q.Count > 0)
            {
                string u = q.OrderBy(x => distancias[x]).First();
                q.Remove(u);

                foreach (var vecino in grafo[u])
                {
                    int alt = distancias[u] + vecino.peso;
                    if (alt < distancias[vecino.destino])
                    {
                        distancias[vecino.destino] = alt;
                        prev[vecino.destino] = u;
                    }
                }
            }

            if (distancias[fin] == int.MaxValue)
            {
                MessageBox.Show("No hay ruta entre los edificios.");
                return;
            }

            // Reconstruir ruta
            List<string> ruta = new List<string>();
            string temp = fin;
            while (temp != null)
            {
                ruta.Insert(0, temp);
                temp = prev[temp];
            }

            MessageBox.Show($"Ruta más corta: {string.Join(" -> ", ruta)}\nDistancia total: {distancias[fin]}");
        }
    
    }
}
