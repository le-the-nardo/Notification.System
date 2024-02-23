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
    private readonly IGetLogMessagesUseCase _getLogMessagesUseCase;

    public MessageController(ISendMessageUseCase sendMessageUseCase, IGetLogMessagesUseCase getLogMessagesUseCase)
    {
        _sendMessageUseCase = sendMessageUseCase;
        _getLogMessagesUseCase = getLogMessagesUseCase;
    }

    [HttpPost]
    public IActionResult Message([FromBody] MessageDto message)
    {
        try
        {
            var result = _sendMessageUseCase.SendMessage(message.Content!, message.Category!);

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetLogMessages()
    {
        try
        {
            var result = await _getLogMessagesUseCase.GetLogMessages();

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}