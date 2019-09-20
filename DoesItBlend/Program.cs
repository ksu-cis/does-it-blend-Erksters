using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBlendable> blendables = new List<IBlendable>();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            blendables.Add(new CellPhone());
            blendables.Add(new IceCubes());

            String mess = "";
            foreach(dynamic ingredient in blendables)
            {
                Console.WriteLine(ingredient.Blend());
            }
        }
    }
}
