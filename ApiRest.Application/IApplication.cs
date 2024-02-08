using ApiRest.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.Application
{
    public interface IApplication<T> : ICrud<T>
    {
    }
}
