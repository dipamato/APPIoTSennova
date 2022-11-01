using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppSennova.Dominio;
using AppSennova.Persistencia;

namespace Presentacion.Pages 
{   
    public class FormulariosModel : PageModel
    {
 
        private readonly IRepositorio _repo;         
        public FormulariosModel(IRepositorio repo) 
        {
            _repo=repo; 
        } 
        [BindProperty] 
        public Voltaje voltaje{get;set;}
        [BindProperty]
        public Corriente corriente{get;set;}
        public void OnGet()
        {
            
        }
        public async Task<IActionResult> OnPostUno(){
            voltaje= _repo.AddVoltaje(voltaje);
            if(voltaje!=null){
                return Page();  
            }
            return RedirectToPage("/Error");

        }
        public async Task<IActionResult> OnPostDos(){
            corriente=_repo.AddCorriente(corriente);
            if(corriente!=null){
                return Page();
            }
            return RedirectToPage("/Error");
        }
    } 
}
