using System;

namespace AppSennova.Dominio
{
    public class Corriente{
        public int id{get;set;}
        public Dia Dia{get;set;}
        public Mes Mes{get;set;}
        public double Valor{get;set;}
        public TimeSpan Hora {get;set;}
        public Semana Semana{get;set;}
    }


}