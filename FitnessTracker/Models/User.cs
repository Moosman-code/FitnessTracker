using System.Collections.Generic;

#nullable disable

namespace FitnessTracker.Models
{
    public partial class User
    {
        public User()
        {
            Excercises = new HashSet<Excercise>();
            Foods = new HashSet<Food>();
        }

        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public string LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public int Age { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public int Weight { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public int Height { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public string Username { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Required.")]
        public string Password { get; set; }

        public virtual ICollection<Excercise> Excercises { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
    }
}
