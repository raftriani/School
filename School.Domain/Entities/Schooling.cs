using School.Domain.Repositories.Base;
using System.ComponentModel.DataAnnotations;

namespace School.Domain.Entities
{
    public class Schooling : Entity, IAggregationInterface
    {
        public Schooling() { }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public string Description { get; set; }
        public List<User> Users { get; set; }
    }
}
