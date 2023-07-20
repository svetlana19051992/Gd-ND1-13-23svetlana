using lesson6_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_5
{
    public class NewsProvider
    {
        public event EventHandler<NewsEventArgs> OnDailyNewsNews;
        public event EventHandler<NewsEventArgs> OnWeatherNews;
        public event EventHandler<NewsEventArgs> OnSportNews;
        public event EventHandler<NewsEventArgs> OnHumorNews;
        public event EventHandler<NewsEventArgs> OnEventsNews;

        public void GenerateNews(News newsType, string newsText)
        {
            NewsEventArgs newsEventArgs = new NewsEventArgs();

            switch (newsType)
            {
                case News.DailyNews:
                    newsEventArgs.NewsType = News.DailyNews;
                    newsEventArgs.NewsText = newsText;
                    if (OnDailyNewsNews != null)
                    {
                        OnDailyNewsNews(this, newsEventArgs);
                    }
                    break;
                case News.Weather:
                    newsEventArgs.NewsType = News.Weather;
                    newsEventArgs.NewsText = newsText;
                    if (OnWeatherNews != null)
                    {
                        OnWeatherNews(this, newsEventArgs);
                    }
                    break;
                case News.Sport:
                    newsEventArgs.NewsType = News.Sport;
                    newsEventArgs.NewsText = newsText;
                    if (OnSportNews != null)
                    {
                        OnSportNews(this, newsEventArgs);
                    }
                    break;
                case News.Humor:
                    newsEventArgs.NewsType = News.Humor;
                    newsEventArgs.NewsText = newsText;
                    if (OnHumorNews != null)
                    {
                        OnHumorNews(this, newsEventArgs);
                    }
                    break;
                case News.Events:
                    newsEventArgs.NewsType = News.Events;
                    newsEventArgs.NewsText = newsText;
                    if (OnEventsNews != null)
                    {
                        OnEventsNews(this, newsEventArgs);
                    }
                    break;
            }
        }
    }
}