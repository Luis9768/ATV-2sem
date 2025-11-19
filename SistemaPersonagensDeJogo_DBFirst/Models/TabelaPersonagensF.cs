using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SistemaPersonagensDeJogo_DBFirst.Models;

[Table("TabelaPersonagensF")]
public partial class TabelaPersonagensF
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    public string Nome { get; set; } = null!;

    public int Nivel { get; set; }
}
