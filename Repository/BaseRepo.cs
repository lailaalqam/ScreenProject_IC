using ScreenProject.Interface;
using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Repository
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseModle
    {
        public readonly MyAppContext _appContext;
        public BaseRepo(MyAppContext context)
        {
            _appContext = context;

        }

        public void ADD(T carr)
        {
            throw new NotImplementedException();
        }

        public void DeleteHelp(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetALL()
        {
            throw new NotImplementedException();
        }

        public T GetID(int Id)
        {
            throw new NotImplementedException();
        }

        public void UPDATE(int id, T up_car)
        {
            throw new NotImplementedException();
        }
    }
        
        
       
    
}
