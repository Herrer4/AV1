using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AV1.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome precisa ter no mínimo 5 letras", MinimumLength = 5)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [DisplayName("Número")]
        public string Numero { get; set; }
        public string Bairro { get; set; }
        [DisplayName("CEP")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        public string Telefone { get; set; }
    }
}
