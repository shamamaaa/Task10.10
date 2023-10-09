using System.Text;

namespace _10._10task1;
class Program
{

    static void Main(string[] args)
    {
        //Usul1
        
        Console.WriteLine("Cumle daxil edin: ");
        string input = Console.ReadLine().Trim().ToLower();
        string newtext = FormatSpaces(FormatText(input));
        Console.WriteLine("Cumlenin yeni hali: " + newtext);

        //Usul2

        string[] newstr = input.Split(' ');
        StringBuilder sb = new StringBuilder();
        foreach (string item in newstr)
        {

            if (item.Length != 0)
            {
                sb.Append(item.Substring(0,1).ToUpper());
                sb.Append(item.Substring(1).ToLower());
                sb.Append(" ");
            }
        }

        Console.WriteLine("Cumlenin yeni hali: " + sb.ToString());

    }

    public static string FormatSpaces(string input)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]!= ' ' || input[i-1]!= ' ' || i==0)
            {
                sb.Append(input[i]);
            }
        }

        return sb.ToString();
    }

    public static string FormatText(string input)
    {
        char[] chars = input.ToCharArray();

        if (chars.Length>0)
        {
            chars[0] = Char.ToUpper(chars[0]);
        }

        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i - 1] == ' ')
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }

        string ft = new string(chars);
        return ft;
    }
}
