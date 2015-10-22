using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.DAL.Entity
{
    [Table("TB_PRODUTO")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODPRODUTO_PK")]
        public int IdProduto { get; set; }

        [Required]
        [StringLength(50)]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [Column("PRECO")]
        public decimal Preco { get; set; }

        [Required]
        [Column("QUANTIDADE")]
        public int Quantidade { get; set; }

        [Required]
        [StringLength(80)]
        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Required]
        [Column("CODFORNECEDOR_FK")]
        public int IdFornecedor { get; set; }

        #region Relacionamento
        [ForeignKey("IdFornecedor")]
        public Fornecedor Fornecedor { get; set; }
        #endregion
    }
}
