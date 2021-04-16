using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AV1.Models
{
    public class ProdutoViewModel
    {
        [Required(ErrorMessage = "O campo código do produto é obrigatório")]
        [DisplayName("Código do Produto")]
        public string CodigoDoProduto { get; set; }
        [Required(ErrorMessage = "O campo preço é obrigatório")]
        [DisplayName("Preço")]
        public string Preco { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo Categoria é obrigatório")]
        public string Categoria { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }

    }
}
