namespace Supervisor.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}