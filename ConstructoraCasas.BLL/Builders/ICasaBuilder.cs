using ConstructoraCasas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCasas.BLL
{
    public interface ICasaBuilder
    {
        void RealizarPlanos();
        void ConstruirCimientos();
        void ConstruirSotano();
        void ConstruirPrimerPiso();
        void ConstruirSegundoPiso();
        void ColocarTecho();
        void ColocarAcabados();
        void Pintar();

        // Método para devolver el objeto terminado
        Casa ObtenerCasa();
    }
}
