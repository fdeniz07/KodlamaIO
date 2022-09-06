using AutoMapper;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Dtos;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Rules;
using MediatR;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Services.Repositories;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.CreateProgrammingLanguage
{
    public class CreateProgrammingLanguageCommand : IRequest<CreatedProgrammingLanguageDto>
    {
        public string Name { get; set; }


        public class CreateProgrammingLanguageCommandHandler : IRequestHandler<CreateProgrammingLanguageCommand, CreatedProgrammingLanguageDto>
        {
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _businessRules;
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

            public CreateProgrammingLanguageCommandHandler(IMapper mapper, IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules businessRules)
            {
                _mapper = mapper;
                _programmingLanguageRepository = programmingLanguageRepository;
                _businessRules = businessRules;
            }

            public async Task<CreatedProgrammingLanguageDto> Handle(CreateProgrammingLanguageCommand request, CancellationToken cancellationToken)
            {
                await _businessRules.ProgrammingLanguageNameCanNotBeDuplicatedWhenInserted(request.Name);

                PL mappedLanguage = _mapper.Map<PL>(request);
                PL createdLanguage = await _programmingLanguageRepository.AddAsync(mappedLanguage);
                CreatedProgrammingLanguageDto languageDto = _mapper.Map<CreatedProgrammingLanguageDto>(createdLanguage);

                return languageDto;
            }
        }
    }
}
