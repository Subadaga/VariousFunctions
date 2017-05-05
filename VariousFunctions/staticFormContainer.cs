using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousFunctions
{
    static class staticFormContainer
    {
        //Formas principales
        public static formaInicioDeSesion formaLogin = new formaInicioDeSesion();
        public static formaMenuPrincipal formaMenu = new formaMenuPrincipal();
        public static Formas.formaAdministracionUsuarios formaAdminUsuarios = new Formas.formaAdministracionUsuarios();

        //Formas de la administracion de usuarios
        public static Formas.FormasAdminUsuarios.formaAltaDeUsuarios formaAltaUsuarios = new Formas.FormasAdminUsuarios.formaAltaDeUsuarios();
        public static Formas.FormasAdminUsuarios.formaBajaDeUsuarios formaBajaUsuarios = new Formas.FormasAdminUsuarios.formaBajaDeUsuarios();

    }
}
