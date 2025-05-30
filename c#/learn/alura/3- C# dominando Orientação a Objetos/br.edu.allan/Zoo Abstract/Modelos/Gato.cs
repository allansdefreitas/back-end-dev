using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Abstract.Modelos;

internal class Gato : Animal
{

    public override void Mover()
    {
        Console.WriteLine("Andando...");
    }

    public override void FazerSom()
    {
        Console.WriteLine("Miauuu!!");
    }
}
