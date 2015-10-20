using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.DAL.Entity
{
    [Table("TB_FORNECEDOR")]
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODFORNECEDOR_PK")]
        public int IdFornecedor { get; set; }

        [Required]
        [StringLength(50)]
        [Column("NOME")]
        public string Nome { get; set; }
    }
}
