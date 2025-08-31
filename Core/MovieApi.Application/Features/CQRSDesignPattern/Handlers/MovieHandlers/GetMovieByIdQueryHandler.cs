using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {

        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetMovieQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieID);
            return new GetMovieQueryResult
            {
                MovieID = value.MovieID,
                CoverImageUrl = value.CoverImageUrl,
                CreatedYear = value.CreatedYear,
                Descirption = value.Descirption,
                Duration = value.Duration,
                Rating = value.Rating,
                RelaseDate = value.RelaseDate,
                Status = value.Status,
                Title = value.Title
            };
        }
    }
}
