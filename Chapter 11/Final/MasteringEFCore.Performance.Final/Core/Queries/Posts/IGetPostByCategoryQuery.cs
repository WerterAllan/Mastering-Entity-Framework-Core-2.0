﻿using MasteringEFCore.Performance.Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.Performance.Final.Core.Queries.Posts
{
    public interface IGetPostByCategoryQuery<T> : 
        IQueryHandler<IEnumerable<Post>>, IQueryHandlerAsync<IEnumerable<Post>>
    {
        string Category { get; set; }
    }
}
