using FluentValidation;
using Kodlama.io.Devs.Api.Application.Utilities;

namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.RemoveProgrammingLanguage
{
    public class RemoveProgrammingLanguageCommandValidator : AbstractValidator<RemoveProgrammingLanguageCommand>
    {
        private readonly ValidatorMessages _validatorMessages = new ValidatorMessages();

        public RemoveProgrammingLanguageCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithName("Id").WithMessage("{PropertyName}" + _validatorMessages.NotEmpty);

        }
    }
}
