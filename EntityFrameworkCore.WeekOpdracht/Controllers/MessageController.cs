using EntityFrameworkCore.WeekOpdracht.Business.Entities;
using EntityFrameworkCore.WeekOpdracht.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EntityFrameworkCore.WeekOpdracht.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService messageService;
        private readonly ILogging logging;

        public MessageController(IMessageService messageService, ILogging logging)
        {
            this.messageService = messageService;
            this.logging = logging;
        }

        [HttpPost]
        public IActionResult Create(Message message)
        {
            logging.Log("creating Message", Microsoft.Extensions.Logging.LogLevel.Information);
            try
            {
                return Ok(messageService.Add(message));
            }
            catch (Exception ex)
            {
                logging.Log("test message", Microsoft.Extensions.Logging.LogLevel.Error, ex);
                    return BadRequest(new
                {
                    Message = ex.Message
                });
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(messageService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Message = ex.Message
                });
            }
        }

        [HttpGet]
        [Route("user/{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            try
            {
                return Ok(messageService.Get(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Message = ex.Message
                });
            }
        }
    }
}
