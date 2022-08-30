
using Business.Handlers.Locations.Commands;
using FluentValidation;

namespace Business.Handlers.Locations.ValidationRules
{

	public class CreateLocationValidator : AbstractValidator<CreateLocationCommand>
	{
		public CreateLocationValidator()
		{

		}
	}
	public class UpdateLocationValidator : AbstractValidator<UpdateLocationCommand>
	{
		public UpdateLocationValidator()
		{

		}
	}
}