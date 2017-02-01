using System;

namespace Laboratorio.Negocio.Ejercicio5.Inversiones
{
    public static class CalculosDeInversiones
    {
        public static double GenereElRendimientoPorDescuentoRedondeado(double elValorFacial,
                double elValorTransadoNeto,
                double laTasaDeImpuesto,
                DateTime laFechaDeVencimiento,
                DateTime laFechaActual,
                bool tieneTratamientoFiscal)
        {

            double elRendimientoRedondeado;
            if (tieneTratamientoFiscal)
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
                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));

                double elRendimientoSinRedondear = elValorFacial - elValorTransadoBruto;
                elRendimientoRedondeado = Math.Round(elRendimientoSinRedondear, 4);
            }
            else
            {
                double elValorTransadoBruto;
                elValorTransadoBruto = elValorTransadoNeto;

                double elRendimientoSinRedondear = elValorFacial - elValorTransadoBruto;
                elRendimientoRedondeado = Math.Round(elRendimientoSinRedondear, 4);
            }

            return elRendimientoRedondeado;
        }
    }
}