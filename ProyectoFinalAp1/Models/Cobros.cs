﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinalAp1.Models;

public class Cobros
{
    [Key]
    public int CobroId { get; set; }

    public int DeudorId { get; set; }

    // Propiedades de navegación
    [ForeignKey("DeudorId")]

    public virtual Deudores Deudor { get; set; }

    public int CobradorId { get; set; } // Nueva propiedad de CobradorId

    [ForeignKey("CobradorId")]
    public Cobradores Cobrador { get; set; }

    public decimal Mora { get; set; }
    public decimal ImportePagar { get; set; }
    [Required(ErrorMessage = "El campo Fecha de Cobro es obligatorio.")]
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaCobro { get; set; }

    // Relación uno a muchos con CobrosDetalle
    public List<CobrosDetalle> CobrosDetalles { get; set; } = new List<CobrosDetalle>();
}