using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands;
using UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
	public class UpdateBannerCommandHandler
	{
		private readonly IRepository<Banner> _repository;

		public UpdateBannerCommandHandler(IRepository<Banner> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBannerCommand banner)
		{
			var values = await _repository.GetByIdAsync(banner.BannerID);
			values.Description = banner.Description;
			values.Title = banner.Title;
			values.VideoUrl = banner.VideoUrl;
			values.VideoDescription = banner.VideoDescription;
			await _repository.UpdateAsync(values);
		}
	}
}
