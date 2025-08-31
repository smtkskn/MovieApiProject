using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandler
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQueries, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetCastByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQueries request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastID);
            return new GetCastByIdQueryResult
            {
                Biography = values.Biography,
                CastID = values.CastID,
                ImageUrl = values.Biography,
                Name = values.Name,
                Surname = values.Surname,
                OverView = values.OverView,
                Title = values.Title,
            };
        }
    }
}

