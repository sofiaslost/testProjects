using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string htmlCode = """
            <h4>Midnight Help Menu</h4><br>
            <p>!quote | usage !quote <username><br>!help | Shows this help menu </p>
        """;

        string htmlEncode = WebUtility.HtmlEncode(htmlCode);
        string htmlDecode = WebUtility.HtmlDecode(htmlEncode);

        Console.WriteLine($"Printed html code: \n{htmlDecode}");
    }
}
