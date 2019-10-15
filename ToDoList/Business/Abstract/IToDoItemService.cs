using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IToDoItemService
    {
        IResult Add(ToDoItem toDoItem);
        IResult Delete(ToDoItem toDoItem);
        IDataResult<List<ToDoItem>> GetList();
        IDataResult<List<ToDoItem>> GetListByToDoListId(int toDoListId);
    }
}
