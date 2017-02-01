using System;

namespace Laboratorio.Negocio.Ejercicio1.Valoraciones
{
    public static class CalculosDeLaValoracion
    {
        public static decimal operacion(
            decimal montNom, 
            decimal tip,
            decimal prec,
            decimal cob, 
            Monedas mon)
        {
            decimal montoC;
            if (mon == Monedas.Colon)
            {
                montoC = montNom * tip;
            }
            else
                montoC = montNom;

            decimal val = montoC * (prec / 100);
            decimal otroMonto = val * cob;

            return Math.Round(otroMonto, 4);
        }
    }
}