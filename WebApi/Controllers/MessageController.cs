using Application.Interfaces;
using Application.Interfaces.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase
{
    private readonly ISendMessageUseCase _sendMessageUseCase;

    public MessageController(ISendMessageUseCase sendMessageUseCase)
    {
        _sendMessageUseCase = sendMessageUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> Message([FromBody] MessageDto message)
    {
        try
        {
            var category = new Category();
            var a = _sendMessageUseCase.SendMessage(message.Content!, message.Category!);
          
            return Ok(a);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}