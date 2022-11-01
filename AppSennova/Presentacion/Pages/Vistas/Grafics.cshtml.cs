using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using AppSennova.Persistencia;
using AppSennova.Dominio;

namespace Presentacion.Pages
{
    public class GraficsModel : PageModel
    {
        private readonly IRepositorio _repo;
        public GraficsModel(IRepositorio repo){
            _repo=repo;
        }
        IEnumerable<Voltaje> listVoltajes {get;set;}
        public string Resultado;
        public List<SeriePastel> lista;
        
        public SeriePastel serie;
        public void OnGet()
        {
            serie= new SeriePastel();
            lista=new List<SeriePastel>();
            lista.Add(new SeriePastel{
                name="Lunes",
                y= 45,
                sliced= false,
                selected= false});
            lista.Add(new SeriePastel{
                name="Martes",
                y= 30,
                sliced= false,
                selected= false});
            lista.Add(new SeriePastel{
                name="Miercoles",
                y= 98,
                sliced= false,
                selected= false});
            lista.Add(new SeriePastel{
                name="Jueves",
                y= 15,
                sliced= false,
                selected= false});
            lista.Add(new SeriePastel{
                name="Viernes",
                y= 39,
                sliced= false,
                selected= false});
            lista.Add(new SeriePastel{
                name="Sabado",
                y= 60,
                sliced= false,
                selected= false});
                
            
            Resultado=JsonConvert.SerializeObject(lista);
        }

        
    }
}
