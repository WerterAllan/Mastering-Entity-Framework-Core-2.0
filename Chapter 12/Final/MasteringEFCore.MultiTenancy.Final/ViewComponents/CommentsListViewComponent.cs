﻿using MasteringEFCore.MultiTenancy.Final.Data;
using MasteringEFCore.MultiTenancy.Final.Infrastructure.Queries.Comments;
using MasteringEFCore.MultiTenancy.Final.Infrastructure.Queries.Posts;
using MasteringEFCore.MultiTenancy.Final.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.MultiTenancy.Final.ViewComponents
{
    public class CommentsListViewComponent : ViewComponent
    {
        private readonly BlogContext _context;
        private readonly ICommentRepository _postRepository;
        public CommentsListViewComponent(ICommentRepository postRepository,
            BlogContext context)
        {
            _postRepository = postRepository;
            _context = context;
        }

        public IViewComponentResult Invoke(int postId)
        {
            return View(_postRepository.Get(
                new GetCommentsByPostQuery(_context)
                {
                    IncludeData = true,
                    PostId = postId
                }));
        }
    }
}
