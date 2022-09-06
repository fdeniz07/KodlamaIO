namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Models
{
    using Core.Persistence.Paging;
    using Dtos;

    public class ProgrammingLanguageListModel:BasePageableModel
    {
        public IList<ProgrammingLanguageListDto> Items { get; set; }
    }
}
