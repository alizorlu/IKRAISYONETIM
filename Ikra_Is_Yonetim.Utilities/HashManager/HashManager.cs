using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.Utilities.HashManager
{
    public interface IHashManager
    {
        string Create(string value);
        string Resolve(string value);        
    }
    public class CryptoHashManager : IHashManager
    {
        public string Create(string value)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(value);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

       

        public string Resolve(string value)
        {
            throw new NotImplementedException();
        }

    }
    public class HashManager : IHashManager
    {
        private IHashManager _manager;
        public HashManager(IHashManager manager)
        {
            _manager = manager;
        }
        public string Create(string value)
        {
            return _manager.Create(value);
        }

        public string Resolve(string value)
        {
            return _manager.Resolve(value);
        }
    }
}
