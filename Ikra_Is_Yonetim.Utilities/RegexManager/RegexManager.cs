using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.Utilities.RegexManager
{
    public interface IRegexManager
    {
        bool isValidEmail(string email);
    }
    public class SystemRegexManager : IRegexManager
    {
        public bool isValidEmail(string email)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (match.Success) return true;
                else if (!match.Success) return false;

            }
            catch (Exception)
            {

                return false;
            }
            return false;
        }
    }
    public class RegexManager 
    {
        private IRegexManager _manager;
        public RegexManager(IRegexManager manager)
        {
            _manager = manager;
        }
        public bool isValidEmail(string email)
        {
            return _manager.isValidEmail(email);
        }
    }
}
