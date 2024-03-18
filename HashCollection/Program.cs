namespace WorkingWithHashSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Colors = new HashSet<string>();
            Colors.Add("red");
            Colors.Add("orange");
            Colors.Add("yellow");
            Colors.Add("green");
            Colors.Add("blue");

            HashSet<string> ColorsDislike = new HashSet<string>();
            ColorsDislike.Add("brown");
            ColorsDislike.Add("grey");
            ColorsDislike.Add("mint green");
            ColorsDislike.Add("neon yellow");
            ColorsDislike.Add("beige");

            HashSet<string> ColorsFavorite = new HashSet<string>();
            ColorsFavorite.Add("green");
            ColorsFavorite.Add("orange");
            ColorsFavorite.Add("red");
            ColorsFavorite.Add("black");
            ColorsFavorite.Add("white");

            Console.WriteLine("Combined list of colors and my not so favorite colors");
            Colors.UnionWith(ColorsDislike);
            foreach (string color in Colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();

            Console.WriteLine("Colors and that are also my favorite");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = Colors;
            bothLists.IntersectWith(ColorsFavorite);
            foreach (string color in bothLists)
            {
                Console.WriteLine(color);
            }
        }
    }
}