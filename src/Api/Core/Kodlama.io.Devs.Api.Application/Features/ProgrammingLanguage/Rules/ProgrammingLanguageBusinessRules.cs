using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Api.Application.Services.Repositories;
using PL = Kodlama.io.Devs.Api.Domain.Entities.ProgrammingLanguage;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task ProgrammingLanguageNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<PL> result =
                await _programmingLanguageRepository.GetListAsync(p => p.Name == name);
            if (result.Items.Any()) throw new BusinessException("Programming Language exist.");
        }

        public void ProgrammingLanguageShouldExistWhenRequested(PL language)
        {
            if (language == null)
                throw new BusinessException("Requested ProgrammingLanguage doesn't exist.");
        }

        public async Task ProgrammingLanguageShouldExistWhenDeleted(int id)
        {
            PL? language = await _programmingLanguageRepository.GetAsync(pl => pl.Id == id);
            if (language == null) throw new BusinessException("Requested language doesn't exists!");
        }

        public void LanguageShouldExistWhenRequested(PL? language)
        {
            if (language == null) throw new BusinessException("Requested language doesn't exist!");
        }
    }
}
