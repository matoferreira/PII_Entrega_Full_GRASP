//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        

        public double GetStepCost()
        {
            double costostep = this.Quantity * this.Input.UnitCost + this.Equipment.HourlyCost * this.Time;
            return costostep;
        }
    }
        /*Agregamos el método que calcula el costo por paso en la clase Step,
        porque acorde al patrón expert es la que tiene toda la información para realizar los cálculos.
        Esta clase conoce el costo de los productos y materiales que están siendo usados para la elaboración de la receta en cada paso
        y por lo tanto puede calcular el resultado final de cada paso*/
 }