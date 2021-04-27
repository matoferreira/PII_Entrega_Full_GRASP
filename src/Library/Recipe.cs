//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
         public double GetProductionCost(Step step)
        {
            double costo = 0;
            costo = costo + step.Quantity * step.Input.UnitCost + step.Equipment.HourlyCost * step.Time;
            return costo;
        }
    }
            /*Agregamos el método en la clase recipe porque acorde al patrón expert es la que tiene toda la información para realizar los cálculos.
        Esta clase conoce el costo de los productos y materiales que están siendo usados para la elaboración de la receta y por lo tanto puede
         calcular el resultado final*/
}