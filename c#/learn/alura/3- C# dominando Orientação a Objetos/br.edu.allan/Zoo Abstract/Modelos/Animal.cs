using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Abstract.Modelos;

abstract class Animal
{

    public abstract void Mover();

    public virtual void FazerSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
}
