using System.Text;

class StringComparison
{
    public static string UsingString(int n)
    {
        string result="";

        for(int i=0;i<n;i++)
        {
            result+="a";
        }

        return result;
    }

    public static string UsingStringBuilder(int n)
    {
        StringBuilder sb=new StringBuilder();

        for(int i=0;i<n;i++)
        {
            sb.Append("a");
        }

        return sb.ToString();
    }
}