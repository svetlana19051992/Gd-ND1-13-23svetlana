namespace lesson6_5
{
    public class Client
    {
        public Client(NewsProvider provider, News newsType)
        {
            switch (newsType)
            {
                case News.DailyNews:
                    provider.OnDailyNewsNews += HandleNews;
                    break;
                case News.Weather:
                    provider.OnWeatherNews += HandleNews;
                    break;
                case News.Sport:
                    provider.OnSportNews += HandleNews;
                    break;
                case News.Humor:
                    provider.OnHumorNews += HandleNews;
                    break;
                case News.Events:
                    provider.OnEventsNews += HandleNews;
                    break;
            }
        }

        public static void HandleNews(object sender, NewsEventArgs e)
        {
            Console.WriteLine($"Category: {e.NewsType} Text: {e.NewsText}");
        }
    }
}