using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;

[Table("Regiao")]
public class Regiao
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe a Região")]
    [StringLength(30, ErrorMessage = "O máximo é de 30 caracteres")]
    public string Nome { get; set; }
}

