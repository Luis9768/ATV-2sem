using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SistemaVeiculos_DBFirst.Models;

public partial class TabelaVeiculo
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    public string Modelo { get; set; } = null!;

    public int Ano { get; set; }
}
