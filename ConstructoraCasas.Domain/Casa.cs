using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCasas.Domain
{
    public class Casa
    {
        // Usamos una lista para ir guardando los pasos que se construyen
        public List<string> Partes { get; set; } = new List<string>();

        public string TipoCasa { get; set; }

        // Método para mostrar el resultado final
        public string MostrarDetalles()
        {
            return $"--- Casa de {TipoCasa} ---\nPartes construidas:\n- " + string.Join("\n- ", Partes);
        }
    }
}
