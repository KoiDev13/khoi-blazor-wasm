using khoi_blazor_api.Enums;
using System.ComponentModel.DataAnnotations;

namespace khoi_blazor_api.Entities
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? Assignee { get; set; }

        public DateTime CreatedDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }

    }
}