using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        private IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public IResult Add(ToDoList toDoList)
        {
            _toDoListDal.Add(toDoList);
            return new SuccessResult(Messages.ToDoListAdded);
        }

        public IResult Delete(ToDoList toDoList)
        {
            _toDoListDal.Delete(toDoList);
            return new SuccessResult(Messages.ToDoListDeleted);
        }

        public IDataResult<List<ToDoList>> GetList()
        {
            return new SuccessDataResult<List<ToDoList>>(_toDoListDal.GetList().ToList());
        }

        public IDataResult<List<ToDoList>> GetListByUserId(int userId)
        {
            return new SuccessDataResult<List<ToDoList>>(_toDoListDal.GetList(t => t.UserId == userId).ToList());
        }
    }
}
