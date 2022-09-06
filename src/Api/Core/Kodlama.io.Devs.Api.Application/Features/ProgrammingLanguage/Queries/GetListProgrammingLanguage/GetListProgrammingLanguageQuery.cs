using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Models;
using Kodlama.io.Devs.Api.Application.Services.Repositories;
using MediatR;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Queries.GetListProgrammingLanguage
{

    public class GetListProgrammingLanguageQuery : IRequest<ProgrammingLanguageListModel>
    {
        public PageRequest PageRequest { get; set; }


        public class
            GetListProgrammingLanguageQueryHandler : IRequestHandler<GetListProgrammingLanguageQuery,
                ProgrammingLanguageListModel>
        {
            private readonly IProgrammingLanguageRepository _repository;
            private readonly IMapper _mapper;

            public GetListProgrammingLanguageQueryHandler(IMapper mapper, IProgrammingLanguageRepository repository)
            {
                _mapper = mapper;
                _repository = repository;
            }

            public async Task<ProgrammingLanguageListModel> Handle(GetListProgrammingLanguageQuery request, CancellationToken cancellationToken)
            {
                IPaginate<PL> languages =
                    await _repository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

                ProgrammingLanguageListModel mappedProgrammingLanguageListModel =
                    _mapper.Map<ProgrammingLanguageListModel>(languages);

                return mappedProgrammingLanguageListModel;
            }
        }
    }
}
