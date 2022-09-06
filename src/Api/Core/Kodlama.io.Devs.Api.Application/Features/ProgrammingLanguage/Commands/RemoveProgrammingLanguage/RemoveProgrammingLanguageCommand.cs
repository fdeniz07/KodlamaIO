using AutoMapper;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Dtos;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Rules;
using Kodlama.io.Devs.Api.Application.Services.Repositories;
using MediatR;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.RemoveProgrammingLanguage
{
    public class RemoveProgrammingLanguageCommand : IRequest<RemovedProgrammingLanguageDto>
    {
        public int Id { get; set; }

        public class
            RemoveProgrammingLanguageCommandHandler : IRequestHandler<RemoveProgrammingLanguageCommand,
                RemovedProgrammingLanguageDto>
        {
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _businessRules;
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

            public RemoveProgrammingLanguageCommandHandler(IMapper mapper, ProgrammingLanguageBusinessRules businessRules, IProgrammingLanguageRepository programmingLanguageRepository)
            {
                _mapper = mapper;
                _businessRules = businessRules;
                _programmingLanguageRepository = programmingLanguageRepository;
            }

            public async Task<RemovedProgrammingLanguageDto> Handle(RemoveProgrammingLanguageCommand request, CancellationToken cancellationToken)
            {
                await _businessRules.ProgrammingLanguageShouldExistWhenDeleted(request.Id);

                PL mappedLanguage = _mapper.Map<PL>(request);
                PL removedLanguage = await _programmingLanguageRepository.DeleteAsync(mappedLanguage);
                RemovedProgrammingLanguageDto languageDto = _mapper.Map<RemovedProgrammingLanguageDto>(removedLanguage);

                return languageDto;
            }
        }
    }
}
