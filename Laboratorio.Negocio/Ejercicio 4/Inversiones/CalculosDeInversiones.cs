using System;

namespace Laboratorio.Negocio.Ejercicio4.Inversiones
{
    public static class CalculosDeInversiones
    {
        public static double GenereElRendimientoPorDescuento(double elValorFacial,
                double elValorTransadoNeto,
                double laTasaDeImpuesto,
                DateTime laFechaDeVencimiento,
                DateTime laFechaActual,
                bool tieneTratamientoFiscal)
        {
            TimeSpan elTiempoAlVencimiento;
            elTiempoAlVencimiento = (laFechaDeVencimiento - laFechaActual);
            double losDiasAlVencimiento;
            losDiasAlVencimiento = elTiempoAlVencimiento.Days;

            double laTasaNeta;
            laTasaNeta = (elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365)) * 100;
            double laTasaBruta;
            laTasaBruta = laTasaNeta / (1 - (laTasaDeImpuesto / 100));

            double elValorTransadoBruto;
            if (tieneTratamientoFiscal)
            {
                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
            }
            else
            {
                elValorTransadoBruto = elValorTransadoNeto;
            }

            double elRendimiento = elValorFacial - elValorTransadoBruto;
            return Math.Round(elRendimiento, 4);
        }
    }
}