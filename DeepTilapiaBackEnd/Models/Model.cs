using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepTilapiaBackEnd.Models
{
    public class SuplidorPeces
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Encargado { get; set; }
    }

    public class GrupoTilapia
    {
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public double PesoPromedio { get; set; }
        public string Etapa { get; set; }
        public DateTime FechaLlegada { get; set; }
        public double CostoXPeso { get; set; }
        public double CostoXUnidad { get; set; }
        public float TemperaturaSuplidor { get; set; }
        public float PhSuplidor { get; set; }
        public float TemperaturaTransporte { get; set; }
        public float PhTransporte { get; set; }
        public float TemperaturaRecibimiento { get; set; }
        public float PhRecibimiento { get; set; }
        public float DistanciaTransporte { get; set; }
        public DateTime FechaSalida { get; set; }
        public string MetodoTransporte { get; set; }
        public SuplidorPeces suplidorPeces { get; set; }
    }

    public class Jaula
    {
        public int ID { get; set; }
        public string TipoJaula { get; set; }
        public string Ubicacion { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public double Profundidad { get; set; }
        public double Volumen { get; set; }
        public int Capacidad { get; set; }
        public ICollection<JaulaGrupo> jaulaGrupos { get; set; }
    }

    public class JaulaGrupo
    {
        public int ID { get; set; }
        public Jaula jaula { get; set; }
        public GrupoTilapia grupo { get; set; }
        public int Cantidad { get; set; }
        public string Etapa { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public JaulaGrupo JaulaGrupoAnterior { get; set; }
        public ICollection<JaulaGrupoAgua> jaulaGrupoAguas { get; set; }
        public ICollection<JaulaGrupoAlimento> jaulaGrupoAlimentos { get; set; }
        public ICollection<JaulaGrupoMuertes> jaulaGrupoMuertes { get; set; }
        public ICollection<JaulaGrupoPeso> jaulaGrupoPesos { get; set; }
    }

    public class JaulaGrupoMuertes
    {
        public int ID { get; set; }
        public JaulaGrupo jaulaGrupo { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }

    public class JaulaGrupoAgua
    {
        public int ID { get; set; }
        public JaulaGrupo jaulaGrupo { get; set; }
        public DateTime Fecha { get; set; }
        public float Temperatura { get; set; }
        public float Ph { get; set; }
        public float Turbidez { get; set; }
        public float Iluminacion { get; set; }
    }

    public class JaulaGrupoPeso
    {
        public int ID { get; set; }
        public JaulaGrupo jaulaGrupo { get; set; }
        public double PesoPromedio { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class JaulaGrupoAlimento
    {
        public int ID { get; set; }
        public JaulaGrupo jaulaGrupo { get; set; }
        public Alimento alimento { get; set; }
        public float Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Alimento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float PorcentajeProteina { get; set; }
        public float PorcentajeCarbohidratos { get; set; }
        public string Vitaminas { get; set; }
        public float CantidadInventario { get; set; }
        public string Etapa { get; set; }
        public string Unidad { get; set; }
    }

    public class AlimentoSuplidor
    {
        public int ID { get; set; }
        public Alimento alimento { get; set; }
        public SuplidorAlimento suplidorAlimento { get; set; }
        public float Precio { get; set; }

    }

    public class SuplidorAlimento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Encargado { get; set; }
        public ICollection<AlimentoSuplidor> alimentoSuplidors { get; set; }
    }
}
