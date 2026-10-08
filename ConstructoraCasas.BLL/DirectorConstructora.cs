using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCasas.BLL
{
    public class DirectorConstructora
    {
        private ICasaBuilder _builder;

        // Inyectamos el builder que queremos usar (madera o ladrillo)
        public DirectorConstructora(ICasaBuilder builder)
        {
            _builder = builder;
        }

        // Método principal de construcción. Recibe parámetros booleanos para los pasos opcionales.
        public void ConstruirCasa(bool conSotano, bool conSegundoPiso, bool pintar)
        {
            // Pasos obligatorios
            _builder.RealizarPlanos();
            _builder.ConstruirCimientos();

            // Paso opcional
            if (conSotano)
            {
                _builder.ConstruirSotano();
            }

            // Pasos obligatorios
            _builder.ConstruirPrimerPiso();

            // Paso opcional[cite: 37]
            if (conSegundoPiso)
            {
                _builder.ConstruirSegundoPiso();
            }

            // Pasos obligatorios
            _builder.ColocarTecho();
            _builder.ColocarAcabados();

            // Paso opcional[cite: 37]
            if (pintar)
            {
                _builder.Pintar();
            }
        }
    }
}
