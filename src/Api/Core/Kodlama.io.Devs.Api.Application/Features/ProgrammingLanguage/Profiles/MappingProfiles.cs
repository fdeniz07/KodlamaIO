using AutoMapper;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.CreateProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Dtos;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.RemoveProgrammingLanguage;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Models;
using Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PL, CreatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<PL, CreateProgrammingLanguageCommand>().ReverseMap();
           
            CreateMap<PL, ProgrammingLanguageGetByIdDto>().ReverseMap();
           
            CreateMap<PL, ProgrammingLanguageListDto>().ReverseMap();
            CreateMap<IPaginate<PL>, ProgrammingLanguageListModel>().ReverseMap();
           
            CreateMap<PL, RemovedProgrammingLanguageDto>().ReverseMap();
            CreateMap<PL, RemoveProgrammingLanguageCommand>().ReverseMap();

            CreateMap<PL, UpdatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<PL, UpdateProgrammingLanguageCommand>().ReverseMap();
        }
    }
}
