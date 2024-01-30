using System.ComponentModel.DataAnnotations;

namespace Contouring_App.Application.Entities
{
    public class Admin
    {

        [Key] public int Employee_Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
