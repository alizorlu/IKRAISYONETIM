using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim.Utilities.PasswordCreateManager
{
    public interface IPasswordCreateManager
    {
        string GetNewPass(KullanicilarType? type);
    }
    public class PasswordCreater : IPasswordCreateManager
    {
        private int _getNumber(int min,int max)
        {
            return new Random().Next(min, max);
        }
        public string GetNewPass(KullanicilarType? type)
        {
            string password = String.Empty;
            if (type==KullanicilarType.Admin)
            {
                return $"admin{_getNumber(100, 999)}";
            }
            else if (type==KullanicilarType.Musteri)
            {
                return $"ikra{_getNumber(100, 999)}";
            }
            else if (type==KullanicilarType.Personel)
            {
                return $"personel{_getNumber(100, 999)}";
            }
            return null;
           
        }
    }
    public class PasswordCreateManager 
    {
        private IPasswordCreateManager _manager;
        public PasswordCreateManager(IPasswordCreateManager manager)
        {
            _manager = manager;
        }
        public string GetNewPass(KullanicilarType? type)
        {
            return _manager.GetNewPass(type);
        }
    }
}
