using System;

namespace Laboratorio.Negocio.Ejercicio3.CodigosDeReferencia
{
    public static class GeneracionDeCodigoDeReferencia
    {
        public static string GenereElCodigoDeReferencia(DateTime laFecha, short elCliente, short elSistema, string elConsecutivo, string elDigito)
        {
            string elDiaComoTexto = laFecha.Day.ToString("D2");
            string elMesComoTexto = laFecha.Month.ToString("D2");
            string laFechaComoTexto = laFecha.Year.ToString("D4") + elMesComoTexto + elDiaComoTexto;

            string elSistemaComoTexto = elSistema.ToString("D2");
            string elConsecutivoAjustado = elConsecutivo.PadLeft(12, '0');

            string elRequerimiento;
            elRequerimiento = laFechaComoTexto + elCliente.ToString("D3") + elSistemaComoTexto + elConsecutivoAjustado;

            return elRequerimiento + elDigito;
        }
    }
}