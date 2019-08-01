using ScreenProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject.Interface
{
    public interface IBaseRepo<T> where T : class, IBaseModle
    {

        List<T> GetALL();
        T GetID(int Id);
        void ADD(T carr);
        void UPDATE(int id, T up_car);
        void DeleteHelp(int id);


    }



}
