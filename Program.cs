using HtmlAgilityPack;
namespace BibleVerse{
    class Progam{
        static void Main(){
            Console.WriteLine("");
            Console.WriteLine("Your Bible verse of the day: ");
            Console.WriteLine(HtmlEntity.DeEntitize(new HtmlWeb().Load("https://dailyverses.net/random-bible-verse").DocumentNode.QuerySelector("span.v1").QuerySelector(".v1").InnerText));
            Console.WriteLine("");
        }
    }
}