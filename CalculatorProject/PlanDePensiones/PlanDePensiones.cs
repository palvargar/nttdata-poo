using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorProject.PlanDePensiones
{
    public class PlanDePensiones
    {
        public float Base { get; set; }
        public float AportacionPlanPersonaFisica { get; set; }
        public float AportacionPlanEmpresa { get; set; }
        public string Pais { get; set; }

        public PlanDePensiones() { }

        public PlanDePensiones(float baseImponible, float aportacionPlanPersonaFisica, float aportacionPlanEmpresa) 
        {
            Base = baseImponible;
            AportacionPlanPersonaFisica = aportacionPlanPersonaFisica;
            AportacionPlanEmpresa= aportacionPlanEmpresa;
        }
    }
}
