using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IToDoListService
    {
        IResult Add(ToDoList toDoList);
        IResult Delete(ToDoList toDoList);
        IDataResult<List<ToDoList>> GetList();
        IDataResult<List<ToDoList>> GetListByUserId(int userId);
    }
}
