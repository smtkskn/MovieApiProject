﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResult
            {
                MovieID = x.MovieID,
                CoverImageUrl=x.CoverImageUrl,
                CreatedYear=x.CreatedYear,
                Descirption=x.Descirption,
                Duration=x.Duration,
                Rating=x.Rating,
                RelaseDate=x.RelaseDate,
                Status=x.Status,
                Title=x.Title
            }).ToList();
        }
    }
}
