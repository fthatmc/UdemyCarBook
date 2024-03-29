﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commands.TagCloudCommand
{
    public class RemoveTagCloudCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveTagCloudCommand(int id)
        {
            Id = id;
        }
    }
}
