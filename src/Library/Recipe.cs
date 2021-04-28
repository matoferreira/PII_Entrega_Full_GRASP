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

        double GetProductionCost()
        {
            double costototal = 0;
            foreach (Step step in this.steps)
            {
                costototal = costototal + step.GetStepCost();
            }
            return costototal;
        }

/* En esta parte de la Recipe, agregamos el cálculo del costo total, esto se logra sumando los costos de cada
paso que tiene la receta, ya que es la única que conoce esta información.*/
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"El costo total de producción es de $ {GetProductionCost()}");
        }
    }
}