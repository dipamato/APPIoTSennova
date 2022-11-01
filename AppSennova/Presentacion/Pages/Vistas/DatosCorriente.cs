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
    public class DatosCorrienteModel : PageModel
    {

        private readonly IRepositorio _repo;
        public DatosCorrienteModel(IRepositorio repo)
        {
            _repo = repo;
        }
        [BindProperty]
        public IEnumerable<Corriente> listVoltajes { get; set; }
        public double Total { get; set; }
        public double cantidad { get; set; }
        [BindProperty]
        public InformeMensual Mensual { get; set; }
        [BindProperty]
        public InformeSemanal Semana { get; set; }
        [BindProperty]
        public string[] InfoDias { get; set; }
        [BindProperty]
        public double[] InfoPromedio { get; set; }
        [BindProperty]
        public string[] InfoMes { get; set; }
        [BindProperty]
        public double[] InfoPromedioMes { get; set; }
        [BindProperty]
        public SeriePastel serie { get; set; }
        [BindProperty]
        public SerieColumna serieMes { get; set; }
        [BindProperty]
        public string Resultado { get; set; }
        [BindProperty]
        public string Resultado1 { get; set; }
        [BindProperty]
        public string ResultadoM { get; set; }
        [BindProperty]
        public List<SeriePastel> lista { get; set; }
        [BindProperty]
        public List<SerieColumna> listaM { get; set; }
        public double T1 { get; set; }
        public double T2 { get; set; }
        public double T3 { get; set; }
        public double T4 { get; set; }
        public double T5 { get; set; }
        public double T6 { get; set; }
        public double T7 { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }
        public double P6 { get; set; }
        public double P7 { get; set; }
        public int C1 { get; set; }
        public int C2 { get; set; }
        public int C3 { get; set; }
        public int C4 { get; set; }
        public int C5 { get; set; }
        public int C6 { get; set; }
        public int C7 { get; set; }
        public double TM1 { get; set; }
        public double TM2 { get; set; }
        public double TM3 { get; set; }
        public double TM4 { get; set; }
        public double TM5 { get; set; }
        public double TM6 { get; set; }
        public double TM7 { get; set; }
        public double TM8 { get; set; }
        public double TM9 { get; set; }
        public double TM10 { get; set; }
        public double TM11 { get; set; }
        public double TM12 { get; set; }
        public double PM1 { get; set; }
        public double PM2 { get; set; }
        public double PM3 { get; set; }
        public double PM4 { get; set; }
        public double PM5 { get; set; }
        public double PM6 { get; set; }
        public double PM7 { get; set; }
        public double PM8 { get; set; }
        public double PM9 { get; set; }
        public double PM10 { get; set; }
        public double PM11 { get; set; }
        public double PM12 { get; set; }
        public int CM1 { get; set; }
        public int CM2 { get; set; }
        public int CM3 { get; set; }
        public int CM4 { get; set; }
        public int CM5 { get; set; }
        public int CM6 { get; set; }
        public int CM7 { get; set; }
        public int CM8 { get; set; }
        public int CM9 { get; set; }
        public int CM10 { get; set; }
        public int CM11 { get; set; }
        public int CM12 { get; set; } 

        public void OnGet(string Resultado1)
        {
            listVoltajes = new List<Corriente>();
            listVoltajes = _repo.GetAllCorrientes();
            Resultado = Resultado1;
            Console.WriteLine("list: " + Resultado1);
            listVoltajes = _repo.GetAllCorrientes();
            serieMes=new SerieColumna();
            listaM =new List<SerieColumna>();
            InfoPromedioMes = new double[12];

            InfoMes = new string[12];
            InfoMes[0] = "Enero";
            InfoMes[1] = "Febrero";
            InfoMes[2] = "Marzo";
            InfoMes[3] = "Abril";
            InfoMes[4] = "Mayo";
            InfoMes[5] = "Junio";
            InfoMes[6] = "Julio";
            InfoMes[7] = "Agosto";
            InfoMes[8] = "Septiembre";
            InfoMes[9] = "Octubre";
            InfoMes[10] = "Noviembre";
            InfoMes[11] = "Diciembre";

            foreach (var x in listVoltajes)
            {
                var m = x.Mes.ToString();
                var s = x.Semana.ToString();
                var d = x.Dia.ToString();

                switch (m)
                {
                    case "Enero":
                        TM1 = TM1 + x.Valor;
                        CM1 = CM1 + 1;
                        PM1 = TM1 / CM1;
                        InfoPromedioMes[0] = PM1;
                        break;
                    case "Febrero":
                        TM2 = TM2 + x.Valor;
                        CM2 = CM2 + 1;
                        PM2 = TM2 / CM2;
                        InfoPromedioMes[1] = PM2;
                        break;
                    case "Marzo":
                        TM3 = TM3 + x.Valor;
                        CM3 = CM3 + 1;
                        PM3 = TM3 / CM3;
                        InfoPromedioMes[2] = PM3;
                        break;
                    case "Abril":
                        TM4 = TM4 + x.Valor;
                        CM4 = CM4 + 1;
                        PM4 = TM4 / CM4;
                        InfoPromedioMes[3] = PM4;
                        break;
                    case "Mayo":
                        TM5 = TM5 + x.Valor;
                        CM5 = CM5 + 1;
                        PM5 = TM5 / CM5;
                        InfoPromedioMes[4] = PM5;
                        break;
                    case "Junio":
                        TM6 = TM6 + x.Valor;
                        CM6 = CM6 + 1;
                        PM6 = TM6 / CM6;
                        InfoPromedioMes[5] = PM6;
                        break;
                    case "Julio":
                        TM7 = TM7 + x.Valor;
                        CM7 = CM7 + 1;
                        PM7 = TM7 / CM7;
                        InfoPromedioMes[6] = PM7;
                        break;
                    case "Agosto":
                        TM8 = TM8 + x.Valor;
                        CM8 = CM8 + 1;
                        PM8 = TM8 / CM8;
                        InfoPromedioMes[7] = PM8;
                        break;
                    case "Septiembre":
                        TM9 = TM9 + x.Valor;
                        CM9 = CM9 + 1;
                        PM9 = TM9 / CM9;
                        InfoPromedioMes[8] = PM9;
                        break;
                    case "Octubre":
                        TM10 = TM10 + x.Valor;
                        CM10 = CM10 + 1;
                        PM10 = TM10 / CM10;
                        InfoPromedioMes[9] = PM10;
                        break;
                    case "Noviembre":
                        TM11 = TM11 + x.Valor;
                        CM11 = CM11 + 1;
                        PM11 = TM11 / CM11;
                        InfoPromedioMes[10] = PM11;
                        break;
                    case "Diciembre":
                        TM12 = TM12 + x.Valor;
                        CM12 = CM12 + 1;
                        PM12 = TM12 / CM12;
                        InfoPromedioMes[11] = PM12;
                        break;


                    default:
                        break;
                }

            }
            for (int i = 0; i < 12; i++)
            {
                serieMes.name=InfoMes[i];
                serieMes.y=InfoPromedioMes[i];
                Console.WriteLine(serieMes.name);
                serieMes.drilldown=InfoMes[i];
                Console.WriteLine(serieMes.y);
                listaM.Add(new SerieColumna{
                    name=serieMes.name,
                    y=serieMes.y,
                    drilldown=serieMes.drilldown
                });
            ResultadoM=JsonConvert.SerializeObject(listaM);
            }
        }

        public async Task<IActionResult> OnPostUno()
        {
            listVoltajes = _repo.GetAllCorrientes();
            var mes = Mensual.Mes.ToString();
            Console.WriteLine("Mes: " + mes);
            foreach (var x in listVoltajes)
            {
                var m = x.Mes.ToString();
                Console.WriteLine("Mes list: " + m);
                if (m.Equals(mes))
                {
                    Total = Total + x.Valor;
                    cantidad = cantidad + 1;
                    Mensual.Total = Total;
                    Mensual.Promedio = Total / cantidad;

                }


            }
            Console.WriteLine("Total M: " + Total);
            Console.WriteLine("Promedio M: " + Mensual.Promedio);
            return RedirectToPage();
        }
        public async Task<IActionResult> OnPostDos()
        {
            serie = new SeriePastel();
            lista = new List<SeriePastel>();
            var mesS = Semana.Mes.ToString();
            var semana = Semana.Semana.ToString();
            Console.WriteLine("Mes semana: " + mesS);
            Console.WriteLine("Semana semana: " + semana);
            listVoltajes = _repo.GetAllCorrientes();
            InfoDias = new string[7];
            InfoDias[0] = "Lunes";
            InfoDias[1] = "Martes";
            InfoDias[2] = "Miercoles";
            InfoDias[3] = "Jueves";
            InfoDias[4] = "Viernes";
            InfoDias[5] = "Sabado";
            InfoDias[6] = "Domingo";
            InfoPromedio = new double[7];
            foreach (var x in listVoltajes)
            {
                var m = x.Mes.ToString();
                var s = x.Semana.ToString();
                var d = x.Dia.ToString();
                if ((m.Equals(mesS)) & (s.Equals(semana)))
                {

                    switch (d)
                    {
                        case "Lunes":
                            T1 = T1 + x.Valor;
                            C1 = C1 + 1;
                            P1 = T1 / C1;
                            InfoPromedio[0] = P1;
                            break;
                        case "Martes":
                            T2 = T2 + x.Valor;
                            C2 = C2 + 1;
                            P2 = T2 / C2;
                            InfoPromedio[1] = P2;
                            break;
                        case "Miercoles":
                            T3 = T3 + x.Valor;
                            C3 = C3 + 1;
                            P3 = T3 / C3;
                            InfoPromedio[2] = P3;
                            break;
                        case "Jueves":
                            T4 = T4 + x.Valor;
                            C4 = C4 + 1;
                            P4 = T4 / C4;
                            InfoPromedio[3] = P4;
                            break;
                        case "Viernes":
                            T5 = T5 + x.Valor;
                            C5 = C5 + 1;
                            P5 = T5 / C5;
                            InfoPromedio[4] = P5;
                            break;
                        case "Sabado":
                            T6 = T6 + x.Valor;
                            C6 = C6 + 1;
                            P6 = T6 / C6;
                            InfoPromedio[5] = P6;
                            break;
                        case "Domingo":
                            T7 = T7 + x.Valor;
                            C7 = C7 + 1;
                            P7 = T7 / C7;
                            InfoPromedio[6] = P7;
                            break;



                        default:
                            break;
                    }


                }


            }
            Console.WriteLine("Total Lunes: " + InfoPromedio[0]);
            Console.WriteLine("Total Martes: " + InfoPromedio[1]);
            Console.WriteLine("Total Miercoles: " + InfoPromedio[2]);
            Console.WriteLine("Total Jueves: " + InfoPromedio[3]);
            Console.WriteLine("Total Viernes: " + InfoPromedio[4]);
            Console.WriteLine("Total Sabado: " + InfoPromedio[5]);
            Console.WriteLine("Total Domingo: " + InfoPromedio[6]);

            for (int i = 0; i < 7; i++)
            {
                serie.name = InfoDias[i];
                serie.y = InfoPromedio[i];
                Console.WriteLine(serie.name);
                serie.sliced = false;
                serie.selected = false;
                Console.WriteLine(serie.y);
                lista.Add(new SeriePastel
                {
                    name = serie.name,
                    y = serie.y,
                    sliced = serie.sliced,
                    selected = serie.selected
                });
                //Console.WriteLine("list: "+lista[0].y);
            }
            Resultado1 = JsonConvert.SerializeObject(lista);
            Console.WriteLine("list: " + Resultado1);
            return RedirectToPage("/Vistas/DatosCorriente", "Resultado", new { Resultado1 });

        }

    }
}
