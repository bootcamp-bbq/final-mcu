﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarvelCharacters.Api.Models;

namespace MarvelCharacters.Api.Services
{
    public interface IMarvelService
    {
        Task<IReadOnlyList<Character>> GetCharacters(string searchString = null, int page = 0, CancellationToken cancellationToken = default);
    }
}