using System.Collections.Generic;
using Eagle.Services.Dto.News;

namespace Eagle.Services.Interfaces
{
    public interface INewsService
    {
        List<NewsItem> GetNews(int userId);
    }
}