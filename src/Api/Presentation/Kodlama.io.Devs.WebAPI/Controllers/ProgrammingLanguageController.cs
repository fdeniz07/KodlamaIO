using Microsoft.AspNetCore.Mvc;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.CreateProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Dtos;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.RemoveProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Models;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Queries.GetByIdProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Queries.GetListProgrammingLanguage;
using Core.Application.Requests;

namespace Kodlama.io.Devs.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguageController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProgrammingLanguageCommand command)
        {
            CreatedProgrammingLanguageDto result = await Mediator.Send(command);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListProgrammingLanguageQuery query = new() { PageRequest = pageRequest };
            ProgrammingLanguageListModel result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProgrammingLanguageQuery query)
        {
            ProgrammingLanguageGetByIdDto result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Remove([FromRoute] RemoveProgrammingLanguageCommand command)
        {
            RemovedProgrammingLanguageDto result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProgrammingLanguageCommand command)
        {
            UpdatedProgrammingLanguageDto result = await Mediator.Send(command);
            return Created("", result);
        }

    }
}
