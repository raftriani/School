using School.Domain.Repositories.Base;
using System.ComponentModel.DataAnnotations;

namespace School.Domain.Entities
{
    public class SchoolRecords : Entity, IAggregationInterface
    {
        public SchoolRecords() { }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public string Format { get; set; }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public string File { get; set; }
        public User User { get; set; }  
    }
}
