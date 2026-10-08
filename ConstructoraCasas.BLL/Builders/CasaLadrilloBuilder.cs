using ConstructoraCasas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCasas.BLL.Builders
{
    public class CasaLadrilloBuilder : ICasaBuilder
    {
        private Casa _casa = new Casa { TipoCasa = "Ladrillo (Ciudad)" };

        public void RealizarPlanos() => _casa.Partes.Add("Planos arquitectónicos urbanos.");
        public void ConstruirCimientos() => _casa.Partes.Add("Cimientos profundos de hormigón armado.");
        public void ConstruirSotano() => _casa.Partes.Add("Sótano de concreto impermeabilizado.");
        public void ConstruirPrimerPiso() => _casa.Partes.Add("Primer piso con paredes de ladrillo a la vista.");
        public void ConstruirSegundoPiso() => _casa.Partes.Add("Segundo piso con divisiones de ladrillo hueco.");
        public void ColocarTecho() => _casa.Partes.Add("Techo de loza plana.");
        public void ColocarAcabados() => _casa.Partes.Add("Revoque fino, yeso y molduras.");
        public void Pintar() => _casa.Partes.Add("Pintura látex lavable de colores modernos.");

        public Casa ObtenerCasa() => _casa;
    }
}
