using School.Domain.Repositories.Base;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace School.Domain.Entities
{
    public class User : Entity, IAggregationInterface
    {
        public User() { }

        public User(string name, string surname, string email, string cover, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
        }
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "O campo{0} é obrigatório")]
        public int SchoolingId { get; set; }
        public Schooling? Schooling { get; set; }    
        public int? SchoolRecordsId { get; set; }
        public SchoolRecords? SchoolRecords { get; set; }

    }
}
