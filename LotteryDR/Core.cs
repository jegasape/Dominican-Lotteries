using System.Net.Http;
using System.Threading.Tasks;

namespace LotteryDR
{
    public class Core
    {
        public async Task<string> GetData(Filter filter)
        {
            var key = 0;
            var result = string.Empty;
            var request = new HttpClient();
            var response = await request.GetStringAsync(new EndPoint().Url);

            for (var i = 0; i < 125; i++)
            {
                key++;
                var output = (int)response[0] ^ key;
                if (new System.Text.ASCIIEncoding().GetChars(new byte[] { (byte)output })[0] == (char)91)
                    break;
            }

            foreach (var v in response)
            {
                var charset = (int)v;
                var output = charset ^ key;
                var convertor = new System.Text.ASCIIEncoding();
                result += convertor.GetChars(new byte[] { (byte)output })[0];
            }

            return result;
        }
    }
    public class Filter
    {
        public string ToBegin { get; set; }
        public string ToEnd { get; set; }
    }
    public class EndPoint
    {
        public string Url { get; set; } = "https://loteriasdominicanas.com/api/sessions";
    }
}