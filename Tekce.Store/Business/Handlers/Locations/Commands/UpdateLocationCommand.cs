
using Business.Constants;
using Business.BusinessAspects;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

using Core.Aspects.Autofac.Validation;
using Business.Handlers.Locations.ValidationRules;
using System;
using Entities;

namespace Business.Handlers.Locations.Commands
{


	public class UpdateLocationCommand : IRequest<IResult>
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public LocationTypes Type{ get; set; }
		public Guid? Pid { get; set; }
		public Guid? ChangedBy { get; set; }
		public DateTime Changed { get; set; }

		public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand, IResult>
		{
			private readonly ILocationRepository _locationRepository;
			private readonly IMediator _mediator;

			public UpdateLocationCommandHandler(ILocationRepository locationRepository, IMediator mediator)
			{
				_locationRepository = locationRepository;
				_mediator = mediator;
			}

			[ValidationAspect(typeof(UpdateLocationValidator), Priority = 1)]
			[CacheRemoveAspect("Get")]
			[LogAspect(typeof(FileLogger))]
			[SecuredOperation(Priority = 1)]
			public async Task<IResult> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
			{
				var isThereLocationRecord = await _locationRepository.GetAsync(u => u.Id == request.Id);


				isThereLocationRecord.Pid = request.Pid;
				isThereLocationRecord.Name = request.Name;
				isThereLocationRecord.Type = request.Type;
				isThereLocationRecord.Pid = request.Pid;
				isThereLocationRecord.ChangedById = request.ChangedBy;
				isThereLocationRecord.Changed = DateTime.Now;


				_locationRepository.Update(isThereLocationRecord);
				await _locationRepository.SaveChangesAsync();
				return new SuccessResult(Messages.Updated);
			}
		}
	}
}

