using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTA_Tracker
{
    class CTA_API_Requester
    {
        protected string key;

        public List<Arrival> GetArrivals(int stop) { return [new Arrival(), new Arrival(), new Arrival()]; }
    }

    class CTA_API_Requester_L : CTA_API_Requester
    {
        public string baseurl = "";
        public HttpClient httpClient;

        public CTA_API_Requester_L(string key, HttpClient httpClient)
        {
            this.key = key;
            this.httpClient = httpClient;
        }

        public List<Arrival> GetArrivals(int stop)
        {
            return [new Arrival(), new Arrival(), new Arrival()];
        }
    }

    class CTA_API_Requester_Bus : CTA_API_Requester
    {
        public string baseurl = "http://www.ctabustracker.com/bustime/api/v2/";
        public HttpClient httpClient;

        public CTA_API_Requester_Bus(string key, HttpClient httpClient)
        {
            this.key = key;
            this.httpClient = httpClient;
        }

        public List<Arrival> GetArrivals(int stop)
        {
            string url = string.Format("{0}/{1}?key={2}&stpid={3}",
                baseurl, "getpredictions", key, stop);

            var a = httpClient.GetAsync(url);

            return [new Arrival(), new Arrival(), new Arrival()];
        }
    }
}
