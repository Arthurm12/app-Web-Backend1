using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_Web_Backend1.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Placa!")]
        public string Placa { get; set; }

    }
}
