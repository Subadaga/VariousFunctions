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
        public static Formas.FormasAdminUsuarios.modificacionUsuarios modificacionUsuarios = new Formas.FormasAdminUsuarios.modificacionUsuarios();
        public static Formas.FormasAdminUsuarios.formaReseteoContrasena formaReseteoContrasena = new Formas.FormasAdminUsuarios.formaReseteoContrasena();
        public static Formas.FormasAdminUsuarios.listaDeUsuarios listaDeUsuarios = new Formas.FormasAdminUsuarios.listaDeUsuarios();
        public static Formas.FormasAdminUsuarios.formaDesbloqueoUsuario desbloqueoUsuarios = new Formas.FormasAdminUsuarios.formaDesbloqueoUsuario();

    }
}
