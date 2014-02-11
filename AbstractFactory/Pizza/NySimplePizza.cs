﻿using System;
using AbstractFactory.IngridientFactory;

namespace AbstractFactory.Pizza
{
    public class NySimplePizza : Pizza
    {
        private readonly IIngridientFactory _factory;

        public NySimplePizza(IIngridientFactory factory)
        {
            _factory = factory;
            Name = "NY Pizza";
        }

        public override void Prepare()
        {
            Console.WriteLine("Prepare: {0}", Name);
            clam = _factory.CreateClam();
            dough = _factory.CreateDough();
            peperoni = _factory.CreatePeperoni();
            sauce = _factory.CreateSauce();
            vegies = _factory.CreateVegies();
        }
    }
}
