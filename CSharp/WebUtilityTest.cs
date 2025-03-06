using System.Net;

class Program
{
    static void Main(string[] args)
    {
      HelpCommand();
      AboutCommand();
    }
    
    private void HelpCommand()
    {
      string htmlCode = """
            <h4>Midnight Help Menu</h4><br>
            <p>!quote | usage !quote <username><br>!help | Shows this help menu </p>
        """;

        string htmlEncode = WebUtility.HtmlEncode(htmlCode);
        string htmlDecode = WebUtility.HtmlDecode(htmlEncode);

        Console.WriteLine($"Printed html code: \n{htmlDecode}");
    }
    
    private void AboutCommand()
    {
      string htmlCode1 = """
        <p>About Command</p>
      """;
      
      string htmlEncode1 = WebUtility.HtmlEncode(htmlCode1);
      string htmlDecode1 = WebUtility.HtmlDecode(htmlEncode1);
      
      Console.WriteLine($"Printed html code: \n{htmlDecode1}");
    }
}
