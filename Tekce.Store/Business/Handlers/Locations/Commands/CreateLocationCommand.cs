
using Business.BusinessAspects;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Business.Handlers.Locations.ValidationRules;
using Entities;
using System;

namespace Business.Handlers.Locations.Commands
{
	/// <summary>
	/// 
	/// </summary>
	public class CreateLocationCommand : IRequest<IResult>
	{
		public string Name { get; set; }
		public LocationTypes Type { get; set; }
        public Guid? Pid { get; set; }
		public Guid? CreatedBy { get; set; }


		public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand, IResult>
		{
			private readonly ILocationRepository _locationRepository;
			private readonly IMediator _mediator;
			public CreateLocationCommandHandler(ILocationRepository locationRepository, IMediator mediator)
			{
				_locationRepository = locationRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(CreateLocationValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
			{
					return new ErrorResult(Messages.NameAlreadyExist);

				var addedLocation = new Location
				{
					Pid = request.Pid,
					Type = request.Type,
					Name = request.Name,
					Created=DateTime.Now,
					CreatedBy=request.CreatedBy

				};

				_locationRepository.Add(addedLocation);
				await _locationRepository.SaveChangesAsync();
				return new SuccessResult(Messages.Added);
			}
		}
	}
}