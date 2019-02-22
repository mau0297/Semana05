using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana05.Collections
{
    public class Animals
    {

        int _id;
        string nombre;
        DateTime fecha;
        string tipo;
        string dueno;
        IList<Treatment> tratamiento;

        


    }

    public class Treatment
    {
        string tipo;
        DateTime fecha;
        decimal precio;
    }
}