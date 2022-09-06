using FluentValidation;
using Kodlama.io.Devs.Api.Application.Utilities;


namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommandValidator : AbstractValidator<UpdateProgrammingLanguageCommand>
    {
        private readonly ValidatorMessages _validatorMessages = new ValidatorMessages();

        public UpdateProgrammingLanguageCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithName("Programlama Dili").WithMessage("{PropertyName}" + _validatorMessages.NotEmpty).MinimumLength(2).WithMessage("{PropertyName} {MinLength}" + _validatorMessages.NotSmaller);
        }
    }
}
