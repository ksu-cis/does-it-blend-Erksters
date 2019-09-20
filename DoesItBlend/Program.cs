using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> blendables = new List<Fruit>();
            Strawberry St = new Strawberry();
            Banana Ba = new Banana();
            blendables.Add(new Strawberry());
            blendables.Add(new Banana());
            Console.WriteLine(St.Blend());
            blendables.Add(St);

            String mess = "";
            foreach(Fruit ingredient in blendables)
            {
                mess += ingredient.Blend();
            }
            Console.WriteLine(mess);
        }
    }
}
