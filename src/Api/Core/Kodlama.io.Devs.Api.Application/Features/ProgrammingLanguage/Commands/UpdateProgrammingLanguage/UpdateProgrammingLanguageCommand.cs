using AutoMapper;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Dtos;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Rules;
using MediatR;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Services.Repositories;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommand : IRequest<UpdatedProgrammingLanguageDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class
        UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommand,
            UpdatedProgrammingLanguageDto>
    {
        private readonly IMapper _mapper;
        private readonly ProgrammingLanguageBusinessRules _businessRules;
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public UpdateProgrammingLanguageCommandHandler(IMapper mapper, ProgrammingLanguageBusinessRules businessRules,
            IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _mapper = mapper;
            _businessRules = businessRules;
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task<UpdatedProgrammingLanguageDto> Handle(UpdateProgrammingLanguageCommand request,
            CancellationToken cancellationToken)
        {
            PL? mappedLanguage = _mapper.Map<PL>(request);
            PL updatedLanguage = await _programmingLanguageRepository.UpdateAsync(mappedLanguage);
            UpdatedProgrammingLanguageDto languageDto = _mapper.Map<UpdatedProgrammingLanguageDto>(updatedLanguage);

            return languageDto;
        }
    }
}
