using BookStore.Core.Domain.Entities;
using FluentValidation;

namespace BookStore.Core.Domain.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("O Nome é obrigatório");

            RuleFor(a => a.Author)
                .NotEmpty()
                .WithMessage("O Autor é obrigatório");

            RuleFor(a => a.Description)
                .NotEmpty()
                .WithMessage("A descrição é obrigatória");

            RuleFor(a => a.Category)
                .NotEmpty()
                .WithMessage("A Categoria é obrigatória");

            RuleFor(a => a.PublishingCompany)
                .NotEmpty()
                .WithMessage("A Editora é obrigatória");
        }
    }
}
