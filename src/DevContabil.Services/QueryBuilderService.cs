using System.Text;
using DevContabil.Interfaces;

public class QueryBuilderService : IQueryBuilderService
{
    public string SetQuery(Dictionary<string, string> args)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var arg in args)
        {
            if (sb.Length == 0){
                sb.Append("?" + arg.Key + "=" + arg.Value);
            }else{
            sb.Append("&"+arg.Key + "=" + arg.Value);
            }
        }
        return sb.ToString();

    }
}