using System.Collections;
using System.Collections.Generic;
using AppSennova.Dominio;

namespace AppSennova.Persistencia
{
    public interface IRepositorio
    {
        //**----VOLTAJE----**//

        IEnumerable<Voltaje> GetAllVoltajes();
        Voltaje AddVoltaje(Voltaje voltaje);
        Voltaje UpdateVoltaje(Voltaje voltaje);
        void DeleteVoltaje(int idVoltaje);
        Voltaje GetVoltaje(int idVoltaje);

        //**----CORRIENTE----**//

        IEnumerable<Corriente> GetAllCorrientes();
        Corriente AddCorriente(Corriente corriente);
        Corriente UpdateCorriente(Corriente corriente);
        void DeleteCorriente(int idCorriente);
        Corriente GetCorriente(int idCorriente);

        //**----USUARIO----**//

        Usuario AddUsuario(Usuario usuario);
        Usuario ConsultarUsuarioxCorreo(string correo);

    }
}