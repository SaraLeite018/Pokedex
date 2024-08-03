using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models;


[Table("Tipo")]
public class Tipo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public uint Id { get; set; }

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(30, ErrorMessage = "máximo de 30 caracteres no nome")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe a cor")]
    [StringLength(30, ErrorMessage = "A Cord deve máximo de 30 caracteres no nome")]
    public string Cor { get; set; }    
}
