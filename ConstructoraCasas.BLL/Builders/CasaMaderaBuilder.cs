using ConstructoraCasas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCasas.BLL.Builders
{
    public class CasaMaderaBuilder : ICasaBuilder
    {
        // Instanciamos la casa vacía al inicio
        private Casa _casa = new Casa { TipoCasa = "Madera (Bosque)" };

        public void RealizarPlanos() => _casa.Partes.Add("Planos para cabaña de madera rústica.");
        public void ConstruirCimientos() => _casa.Partes.Add("Cimientos de piedra y pilotes de madera.");
        public void ConstruirSotano() => _casa.Partes.Add("Sótano revestido en madera tratada.");
        public void ConstruirPrimerPiso() => _casa.Partes.Add("Primer piso levantado con troncos de pino.");
        public void ConstruirSegundoPiso() => _casa.Partes.Add("Segundo piso tipo altillo.");
        public void ColocarTecho() => _casa.Partes.Add("Techo a dos aguas con tejas de madera.");
        public void ColocarAcabados() => _casa.Partes.Add("Acabados rústicos, sellado y barnizado.");
        public void Pintar() => _casa.Partes.Add("Pintura protectora para exteriores de madera.");

        public Casa ObtenerCasa() => _casa;
    }
}
