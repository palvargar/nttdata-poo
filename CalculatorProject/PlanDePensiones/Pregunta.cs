using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorProject.PlanDePensiones
{
    public class Pregunta
    {
        public static void Preguntar()
        {
            var plan = new PlanDePensiones();

            Console.WriteLine("¿Cuál es tu base imponible? ");
            plan.Base = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de persona física?");
            plan.AportacionPlanPersonaFisica = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de la empresa?" );
            plan.AportacionPlanEmpresa = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Usted invierte el dinero de los planes de pensiones en España o en Andorra?");
            plan.Pais = Console.ReadLine();

            ComprobarPais(plan);
        }

        public static void ComprobarPais(PlanDePensiones plan)
        {
            while (!plan.Pais.Equals("España") && !plan.Pais.Equals("Andorra"))
            {
                Console.WriteLine("El país introducido no es valido, introduzca un país valido");
                Console.WriteLine("¿Usted invierte el dinero de los planes de pensiones en España o en Andorra?");
                plan.Pais = Console.ReadLine();
            }
            if (plan.Pais.Equals("España"))
            {
                Console.WriteLine("Te has desgravado " + Calculo.CalcularEspana(plan) + "€ al invertir en los planes de pensiones en España.");
            }
            else
            {
                Console.WriteLine("Te has desgravado " + Calculo.CalcularAndorra(plan) + "€ al invertir en los planes de pensiones en Andorra.");
            }
        }
    }
}
