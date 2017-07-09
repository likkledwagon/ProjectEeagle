using System.Collections.Generic;
using Eagle.Services.Dto.News;
using Eagle.Services.Interfaces;

namespace Eagle.Services.NewsService
{
    public class NewsService : INewsService
    {
        public List<NewsItem> GetNews(int userId)
        {
            return new List<NewsItem>()
            {
                new NewsItem() {Title = "Titelding", By = "Bram", Content = "Some nws item content"},
                new NewsItem() {Title = "Titelding", By = "Bram", Content = "Some nws item content"},
                new NewsItem() {Title = "Titelding", By = "Bram", Content = "Some nws item content"}
            };
        }
    }
}