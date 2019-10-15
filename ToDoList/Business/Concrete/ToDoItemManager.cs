using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using System.Linq;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class ToDoItemManager : IToDoItemService
    {
        private IToDoItemDal _toDoItemDal;

        public ToDoItemManager(IToDoItemDal toDoItemDal)
        {
            _toDoItemDal = toDoItemDal;
        }

        public IResult Add(ToDoItem toDoItem)
        {
            _toDoItemDal.Add(toDoItem);
            return new SuccessResult(Messages.ToDoListItemAdded);
        }

        public IResult Delete(ToDoItem toDoItem)
        {
            _toDoItemDal.Delete(toDoItem);
            return new SuccessResult(Messages.ToDoListItemDeleted);
        }

        public IDataResult<List<ToDoItem>> GetListByToDoListId(int toDoListId)
        {
            return new SuccessDataResult<List<ToDoItem>>(_toDoItemDal.GetList(t => t.ToDoListId == toDoListId).ToList());
        }

        public IDataResult<List<ToDoItem>> GetList()
        {
            return new SuccessDataResult<List<ToDoItem>>(_toDoItemDal.GetList().ToList());
        }
    }
}
