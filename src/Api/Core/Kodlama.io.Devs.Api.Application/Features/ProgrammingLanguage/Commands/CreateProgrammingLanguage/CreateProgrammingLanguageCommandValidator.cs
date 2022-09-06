namespace Kodlama.io.Devs.Api.Application.Features.ProgrammingLanguage.Commands.CreateProgrammingLanguage
{
    using FluentValidation;
    using Utilities;

    public class CreateProgrammingLanguageCommandValidator : AbstractValidator<CreateProgrammingLanguageCommand>
    {
        private readonly ValidatorMessages _validatorMessages = new ValidatorMessages();

        public CreateProgrammingLanguageCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithName("Programlama Dili").WithMessage("{PropertyName}" + _validatorMessages.NotEmpty).MinimumLength(2).WithMessage("{PropertyName} {MinLength}" + _validatorMessages.NotSmaller);
        }
    }
}
