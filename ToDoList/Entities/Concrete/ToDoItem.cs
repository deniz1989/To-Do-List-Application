using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class ToDoItem : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public DateTime Deadline { get; set; }
        public Byte Status { get; set; }
        public DateTime CreateDate { get; set; }

        public int ToDoListId { get; set; }
        public virtual ToDoList ToDoList { get; set; }
    }
}
