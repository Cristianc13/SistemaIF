using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using ENT;

namespace BL
{
    public class RBLDetalleVenta
    {
        //private ENTReporteVenta ERV = new ENTReporteVenta();
        //private ENTReporteListaVentas ELRV = new ENTReporteListaVentas();
        //public void Reporte(DateTime fechaInicial, DateTime fechaFinal)
        //{
        //    //implement dates
        //    ERV.FechaReporte = DateTime.Now;
        //    ERV.fechaInicio = fechaInicial;
        //    ERV.fechaFinal = fechaFinal;
        //    //create sales listing
        //    var CDV = new CADDetalleVenta();
        //    var result = CDV.GenerarReporteVenta(fechaInicial, fechaFinal);
        //    ERV.ListaVentas = new List<ENTReporteListaVentas>();
        //    foreach (System.Data.DataRow rows in result.Rows)
        //    {
        //        var salesModel = new ENTReporteListaVentas()
        //        {
        //            idVenta = Convert.ToInt32(rows[0]),
        //            fechaVenta = Convert.ToDateTime(rows[1]),
        //            cliente = Convert.ToString(rows[2]),
        //            nombreProducto = Convert.ToString(rows[3]),
        //            ventasTotales = Convert.ToDecimal(rows[4])
        //        };
        //        ERV.ListaVentas.Add(salesModel);
        //        //calculate total net sales
        //        ELRV.ventasTotales += Convert.ToDecimal(rows[4]);
        //    }
        //    //create net sales by period
        //    ////create temp list net sales by date
        //    var listSalesByDate = (from sales in ERV.ListaVentas
        //                           group sales by sales.fechaVenta
        //                    into listSales
        //                           select new
        //                           {
        //                               date = listSales.Key,
        //                               amount = listSales.Sum(item => item.ventasTotales)
        //                           }).AsEnumerable();
        //    ////obtener numero de dias
        //    int totalDays = Convert.ToInt32((fechaInicial - fechaFinal).Days);
        //    ////Reporte por dias
        //    if (totalDays <= 7)
        //    {
        //        ERV.PorPeriodo = (from sales in listSalesByDate
        //                          group sales by sales.date.ToString("dd-MMM-yyyy")
        //                   into listSales
        //                          select new ENTReporteVentasPorPeriodo
        //                          {
        //                              periodo = listSales.Key,
        //                              ventasTotales = ERV.ListaVentas.Sum(item => item.ventasTotales)
        //                          }).ToList();
        //    }
        //    ////Reporte por semanas
        //    else if (totalDays <= 30)
        //    {
        //        ERV.PorPeriodo = (from sales in listSalesByDate
        //                          group sales by
        //                          System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
        //                            sales.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
        //                into listSales
        //                          select new ENTReporteVentasPorPeriodo
        //                          {
        //                              periodo = "Week " + listSales.Key.ToString(),
        //                              ventasTotales = ERV.ListaVentas.Sum(item => item.ventasTotales)
        //                          }).ToList();
        //    }
        //    ////Reporte por meses
        //    else if (totalDays <= 365)
        //    {
        //        ERV.PorPeriodo = (from sales in listSalesByDate
        //                          group sales by sales.date.ToString("MMM-yyyy")
        //                into listSales
        //                          select new ENTReporteVentasPorPeriodo
        //                          {
        //                              periodo = listSales.Key,
        //                              ventasTotales = ERV.ListaVentas.Sum(item => item.ventasTotales)
        //                          }).ToList();
        //    }
        //    ////Reporte por anios
        //    else
        //    {
        //        ERV.PorPeriodo = (from sales in listSalesByDate
        //                          group sales by sales.date.ToString("yyyy")
        //                into listSales
        //                          select new ENTReporteVentasPorPeriodo
        //                          {
        //                              periodo = listSales.Key,
        //                              ventasTotales = ERV.ListaVentas.Sum(item => item.ventasTotales)
        //                          }).ToList();
        //    }
        //}

    }
}
