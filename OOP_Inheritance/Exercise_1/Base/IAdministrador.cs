using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance.Exercise_1.Base
{
    public interface IAdministrador<T>
    {
        void Agregar(T elemento);
    }
}
