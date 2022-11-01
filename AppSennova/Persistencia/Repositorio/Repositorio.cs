using System;
using System.Collections.Generic;
using AppSennova.Dominio;
using System.Linq;
using System.ComponentModel;

namespace AppSennova.Persistencia
{
    public class Repositorio:IRepositorio
    {
        private readonly Context _context = new Context();

        //**----VOLTAJE----**//
        public IEnumerable<Voltaje> GetAllVoltajes()
        {
            return _context.Voltajes;
        }

        public Voltaje AddVoltaje(Voltaje voltaje)
        {
            var VAdd= _context.Voltajes.Add(voltaje);
            _context.SaveChanges();
            return VAdd.Entity;

        }
        public Voltaje UpdateVoltaje(Voltaje voltaje)
        {
            var VEncontrado=_context.Voltajes.FirstOrDefault(p=>p.id==voltaje.id);
            if(VEncontrado!=null){
                VEncontrado.Dia=voltaje.Dia;
                VEncontrado.Mes=voltaje.Mes;
                VEncontrado.Hora=voltaje.Hora;
                VEncontrado.Valor=voltaje.Valor;
                
                _context.SaveChanges();

            }
            return VEncontrado;
        }

        public void DeleteVoltaje(int idVoltaje)
        {
            var VEncontrado=_context.Voltajes.FirstOrDefault(p=>p.id==idVoltaje);
            if(VEncontrado==null)
                return;

            _context.Voltajes.Remove(VEncontrado);
            _context.SaveChanges();
        }

        public Voltaje GetVoltaje(int idVoltaje)
        {
            return _context.Voltajes.FirstOrDefault(p=>p.id==idVoltaje);
        }

        //**----CORRIENTE----**//

        public IEnumerable<Corriente> GetAllCorrientes()
        {
             return _context.Corrientes;
        }
        public Corriente AddCorriente(Corriente corriente)
        {
            var IAdd= _context.Corrientes.Add(corriente);
            _context.SaveChanges();
            return IAdd.Entity;
        }
        public Corriente UpdateCorriente(Corriente corriente)
        {
            var IEncontrado=_context.Corrientes.FirstOrDefault(p=>p.id==corriente.id);
            if(IEncontrado!=null){
                IEncontrado.Dia=corriente.Dia;
                IEncontrado.Mes=corriente.Mes;
                IEncontrado.Hora=corriente.Hora;
                IEncontrado.Valor=corriente.Valor;
                
                _context.SaveChanges();

            }
            return IEncontrado; 
        }
        public void DeleteCorriente(int idCorriente)
        {
             var IEncontrado=_context.Corrientes.FirstOrDefault(p=>p.id==idCorriente);
            if(IEncontrado==null)
                return;

            _context.Corrientes.Remove(IEncontrado);
            _context.SaveChanges();
        }
        public Corriente GetCorriente(int idCorriente)
        {
            return _context.Corrientes.FirstOrDefault(p => p.id == idCorriente);
        }

        //**----USUARIO----**//

        public Usuario AddUsuario(Usuario usuario)
        {
            var UAdd= _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return UAdd.Entity;
        }

        public Usuario ConsultarUsuarioxCorreo(string correo)
        {
            return _context.Usuarios.FirstOrDefault(f => f.Correo == correo);

        }


    }
}