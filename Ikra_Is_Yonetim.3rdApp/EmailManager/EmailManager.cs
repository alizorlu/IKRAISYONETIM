using Ikra_Is_Yonetim.DAL.EntityFramework.Tables;
using Ikra_Is_Yonetim.DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ikra_Is_Yonetim._3rdApp.EmailManager
{
    public interface IEmailManager
    {
        Email Get();
        void Update(Email model);
    }
    public class EFEmailManager : IEmailManager
    {
        private UnitOfRepo _repo;
        public EFEmailManager()
        {
            _repo = new UnitOfRepo();
        }
        public Email Get()
        {
            return _repo.emailRepository.Get().FirstOrDefault();
        }     

        public void Update(Email model)
        {
            _repo.emailRepository.Update(model);
            _repo.Save();
        }
    }
    public class EmailManager 
    {
        private IEmailManager _manager;
        public EmailManager(IEmailManager manager)
        {
            _manager = manager;
        }
        public Email Get()
        {
            return _manager.Get();
        }

        public void Update(Email model)
        {
            _manager.Update(model);
        }
    }
}
