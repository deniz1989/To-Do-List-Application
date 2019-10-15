using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class ToDoList : IEntity
    {
        public ToDoList()
        {
            ToDoItems = new List<ToDoItem>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<ToDoItem> ToDoItems { get; set; }
    }
}
