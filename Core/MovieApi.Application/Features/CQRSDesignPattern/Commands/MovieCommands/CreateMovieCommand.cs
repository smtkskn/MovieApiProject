﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class CreateMovieCommand
    {
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Rating { get; set; }
        public string Descirption { get; set; }
        public int Duration { get; set; }
        public DateTime RelaseDate { get; set; }
        public string CreatedYear { get; set; }
        public bool Status { get; set; }
    }
}
