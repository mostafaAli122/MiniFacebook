﻿using MiniFacebook.Data;
using MiniFacebook.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Models.RepoClass
{
    public class PostLikeRepo:PostLike
    {
        private readonly ApplicationDbContext context;
        public PostLikeRepo(ApplicationDbContext _context)
        {
            context = _context;
        }
    }
}
