using System.ComponentModel.DataAnnotations;

namespace Contouring_App.Application.Entities
{
    public class Manager
    {
        [Key] public int Employee_Id { get; set; }

        public string Name { get; set; }
        public int Division_id { get; set; }

        public int Tenure_year { get; set; }


        public int Salary { get; set; }
    }
}
