using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class HttpClient
{
    internal Uri BaseAddress;

    public HttpClient()
    {
        HttpClient client = new HttpClient();

    }
    
    public object DefaultRequestHeaders { get; internal set; }

    public static void Accept();

    public static void PutAsJsonAsync { get; set; }

    internal Task<HttpResponseMessage> PutAsJsonAsync(string v)
    {
        throw new NotImplementedException();
    }
    internal Task<HttpResponseMessage> DeleteAsync(string v)
    {
        throw new NotImplementedException();
    }

    internal Task<HttpResponseMessage> GetAsync(string v)
    {
        throw new NotImplementedException();
    }
}
