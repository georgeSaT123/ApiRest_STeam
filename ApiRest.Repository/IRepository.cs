using ApiRest.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Repository
{
    public interface IRepository<T> : ICrud<T>
    {
    }
}
