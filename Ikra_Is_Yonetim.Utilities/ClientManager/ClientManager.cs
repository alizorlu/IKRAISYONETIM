using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ikra_Is_Yonetim.Utilities.ClientManager
{
    public interface IClientManager
    {
        string GetClientIp();
        string GetClientAnonId();
        string GetOS();
        string GetVersion();
        string GetUserAgent();
        string GetBrowser(string useragent, string browserversion);
    }
    public class SystemClientManager : IClientManager
    {
        public string GetBrowser(string useragent, string browserversion)
        {
            string bulunanBrowser = useragent;
            foreach (var item in useragent.Split(' '))
            {
                if (item.Contains("/"))
                {
                    string arananVersion = browserversion;
                    string browser = item.Substring(0, item.IndexOf("/"));
                    string version = item.Replace(browser, "").Remove(0, 1);
                    if (version.StartsWith(arananVersion))
                    {
                        bulunanBrowser = $"{browser}-V:{version}";
                        return bulunanBrowser;
                    }
                    

                }
            }
            return bulunanBrowser;
        }

        public string GetClientAnonId()
        {
            return HttpContext.Current.Request.AnonymousID.ToString();
        }

        public string GetClientIp()
        {
            var ip = String.Empty;
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {
                ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]
                    .ToString();
            }
            else if (HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"] != null
                &&
                HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"].Length != 0
                )
            {
                ip = HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"]
                    .ToString();
            }
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
            {
                ip = HttpContext.Current.Request.UserHostName.ToString();
            }
            return ip;
        }

        public string GetOS()
        {
            return HttpContext.Current.Request.Browser.Platform.ToString();
        }

        public string GetUserAgent()
        {
            return HttpContext.Current.Request.UserAgent;
        }

        public string GetVersion()
        {
            return HttpContext.Current.Request.Browser.Version;
        }
    }
    public class ThirdPartyClientManager : IClientManager
    {
        public string GetBrowser(string useragent, string browserversion)
        {
            throw new NotImplementedException();
        }

        public string GetClientAnonId()
        {
            throw new NotImplementedException();
        }

        public string GetClientIp()
        {
            throw new NotImplementedException();
        }

        public string GetOS()
        {
            throw new NotImplementedException();
        }

        public string GetUserAgent()
        {
            throw new NotImplementedException();
        }

        public string GetVersion()
        {
            throw new NotImplementedException();
        }
    }
    public class ClientManager : IClientManager
    {
        private IClientManager _manager;
        public ClientManager(IClientManager manager)
        {
            _manager = manager;
        }

        public string GetBrowser(string useragent, string browserversion)
        {
            return _manager.GetBrowser(useragent, browserversion);
        }

        public string GetClientAnonId()
        {
            return _manager.GetClientAnonId();
        }

        public string GetClientIp()
        {
            return _manager.GetClientIp();
        }

        public string GetOS()
        {
            return _manager.GetOS();
        }

        public string GetUserAgent()
        {
            return _manager.GetUserAgent();
        }

        public string GetVersion()
        {
            return _manager.GetVersion();
        }
    }
}

