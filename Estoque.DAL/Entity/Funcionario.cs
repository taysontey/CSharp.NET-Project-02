using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.DAL.Entity
{
    [Table("TB_FUNCIONARIO")]
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODFUNCIONARIO_PK")]
        public int IdFuncionario { get; set; }

        [Required]
        [StringLength(50)]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [Index("IDX_LOGIN", IsUnique = true)]
        [StringLength(25)]
        [Column("LOGIN")]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        [Column("SENHA")]
        public string Senha { get; set; }

        [Required]
        [StringLength(50)]
        [Column("FOTO")]
        public string Foto { get; set; }

        [Required]
        [Column("DATACADASTRO")]
        public DateTime DataCadastro { get; set; }
    }
}
