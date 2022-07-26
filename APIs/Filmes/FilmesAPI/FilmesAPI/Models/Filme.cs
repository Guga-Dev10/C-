using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        // Adicionando restrições à classe

        [Required(ErrorMessage = "O Campo 'Diretor' é obrigatório!")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O Campo 'Título' é obrigatório!")]
        public string Titulo { get; set; }
        [StringLength(30, ErrorMessage = "O Campo 'GÇenero' não pode ultrapassar 30 caracteres!")]
        public string Genero { get; set; }
        [Range(1, 400, ErrorMessage = "A duração do filme deve ter entre 1 e 400 minutos!")]
        public int Duracao { get; set; }
    }
}
