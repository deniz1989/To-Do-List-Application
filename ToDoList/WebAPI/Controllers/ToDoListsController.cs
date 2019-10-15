using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private IToDoListService _toDoListService;

        public ToDoListsController(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _toDoListService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getlistbyuserid")]
        public IActionResult GetListByUserId(int userId)
        {
            var result = _toDoListService.GetListByUserId(userId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(ToDoList toDoList)
        {
            var result = _toDoListService.Add(toDoList);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ToDoList toDoList)
        {
            var result = _toDoListService.Delete(toDoList);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}