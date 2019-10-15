using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        private IToDoItemService _toDoItemService;

        public ToDoItemsController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        [HttpPost("add")]
        public IActionResult Add(ToDoItem toDoItem)
        {
            var result = _toDoItemService.Add(toDoItem);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ToDoItem toDoItem)
        {
            var result = _toDoItemService.Add(toDoItem);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getlistbytodolistid")]
        public IActionResult GetListByToDoListId(int toDoListId)
        {
            var result = _toDoItemService.GetListByToDoListId(toDoListId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}