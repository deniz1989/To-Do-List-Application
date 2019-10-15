using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoListManager>().As<IToDoListService>();
            builder.RegisterType<EfToDoListDal>().As<IToDoListDal>();

            builder.RegisterType<ToDoItemManager>().As<IToDoItemService>();
            builder.RegisterType<EfToDoItemDal>().As<IToDoItemDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
        }
    }
}
