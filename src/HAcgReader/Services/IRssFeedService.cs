﻿using HAcgReader.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HAcgReader.Services;

/// <summary>
/// 获取神社 RSS Feed
/// </summary>
public interface IRssFeedService : IDisposable
{
    /// <summary>
    /// 异步获取下一页 RSS Feed 内容
    /// </summary>
    /// <returns>异步获取的下一页内容</returns>
    Task<IEnumerable<ArticleModel>> FetchNextAsync();
}