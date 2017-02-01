using System;

namespace Laboratorio.Negocio.Ejercicio2.CodigosDeReferencia
{
    public static class GeneracionDeCodigoDeReferencia
    {
        public static string GenereElCodigoDeReferencia(System.DateTime laFecha, short elCliente, short elSistema, string elConsecutivo, string elDigito)
        {
            int elAno;
            int elDia;
            int elMes;
            string elRequerimiento;
            string elSistemaComoTexto;

            string elConsecutivoAjustado = elConsecutivo.PadLeft(12, '0');
            string laFechaComoTexto;
            elDia = laFecha.Day;
            elMes = laFecha.Month;
            string elDiaComoTexto = elDia.ToString("D2");
            elAno = laFecha.Year;
            string elMesComoTexto = elMes.ToString("D2");
            string elAnoComoTexto = elAno.ToString("D4");
            string elClienteComoTexto = elCliente.ToString("D3");
            laFechaComoTexto = elAnoComoTexto + elMesComoTexto + elDiaComoTexto;
            elSistemaComoTexto = elSistema.ToString("D2");
            elRequerimiento = laFechaComoTexto + elClienteComoTexto + elSistemaComoTexto + elConsecutivoAjustado;
            return elRequerimiento + elDigito;
        }
    }
}