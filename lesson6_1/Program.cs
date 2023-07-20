// See https://aka.ms/new-console-template for more information
using lesson6_5;

NewsProvider provider = new NewsProvider();
Client weatherClient = new Client(provider, News.Weather);
Client weatherClient2 = new Client(provider, News.Weather);
Client weatherClient3 = new Client(provider, News.Weather);
Client sportClient = new Client(provider, News.Sport);
Client humorClient = new Client(provider, News.Humor);
Client eventsClient = new Client(provider, News.Events);
Client dailyNewsClient = new Client(provider, News.DailyNews);

provider.GenerateNews(News.Weather, "It's hot +30");
provider.GenerateNews(News.Weather, "It's cold -20");
provider.GenerateNews(News.Sport, "We won!");
provider.GenerateNews(News.Humor, "It's joke");
provider.GenerateNews(News.Events, "It's critical event");
provider.GenerateNews(News.DailyNews, "Today in the world");
