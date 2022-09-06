using AutoMapper;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Dtos;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Rules;
using Kodlama.io.Devs.Api.Application.Services.Repositories;
using MediatR;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Queries.GetByIdProgrammingLanguage
{
    public class GetByIdProgrammingLanguageQuery : IRequest<ProgrammingLanguageGetByIdDto>
    {
        public int Id { get; set; }


        public class GetByIdProgrammingLanguageQueryHandler : IRequestHandler<GetByIdProgrammingLanguageQuery, ProgrammingLanguageGetByIdDto>
        {
            private readonly IProgrammingLanguageRepository _repository;
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _businessRules;

            public GetByIdProgrammingLanguageQueryHandler(IProgrammingLanguageRepository repository, IMapper mapper, ProgrammingLanguageBusinessRules businessRules)
            {
                _repository = repository;
                _mapper = mapper;
                _businessRules = businessRules;
            }

            public async Task<ProgrammingLanguageGetByIdDto> Handle(GetByIdProgrammingLanguageQuery request, CancellationToken cancellationToken)
            {
                PL? language = await _repository.GetAsync(pl => pl.Id == request.Id);

                _businessRules.ProgrammingLanguageShouldExistWhenRequested(language);

                ProgrammingLanguageGetByIdDto programmingLanguageGetByIdDto =
                    _mapper.Map<ProgrammingLanguageGetByIdDto>(language);
                return programmingLanguageGetByIdDto;
            }
        }
    }
}
