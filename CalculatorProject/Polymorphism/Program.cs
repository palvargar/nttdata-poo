﻿using CalculatorProject.PlanDePensiones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Student student = new Student();
            student.Name = "Pepe";

            //Boxing amd AutoBoxing
            arrayList.Add(student);

            Console.WriteLine(((Student)arrayList[0]).Name); 

            Object obj = new Student(); //Boxing
            ((Student)obj).Name = "Alberto";
            Console.WriteLine(((Student)obj).Name);
        }
    }
}
