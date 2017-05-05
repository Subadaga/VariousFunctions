using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VariousFunctions
{
    static class CRUD
    {
        public static void addUser(String Cuenta, String NB_Nombre, String NB_Apellido, String NB_Perfil, String NB_Puesto, String CR_Contrasena)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml"); XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            var node = doc.SelectSingleNode("//Users");

            XmlElement newUser = doc.CreateElement("User");
            newUser.SetAttribute("Cuenta", Cuenta);

            XmlElement ele = doc.CreateElement("NB_Nombre");
            ele.InnerText = NB_Nombre;
            newUser.AppendChild(ele);

            ele = doc.CreateElement("NB_Apellido");
            ele.InnerText = NB_Apellido;
            newUser.AppendChild(ele);

            ele = doc.CreateElement("NB_Perfil");
            ele.InnerText = NB_Perfil;
            newUser.AppendChild(ele);

            ele = doc.CreateElement("NB_Puesto");
            ele.InnerText = NB_Puesto;
            newUser.AppendChild(ele);

            ele = doc.CreateElement("CR_Contraseña");
            ele.InnerText = CR_Contrasena;
            newUser.AppendChild(ele);

            ele = doc.CreateElement("FE_Alta");
            ele.InnerText = DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString();
            newUser.AppendChild(ele);

            ele = doc.CreateElement("BI_Status");
            ele.InnerText = "true";
            newUser.AppendChild(ele);

            ele = doc.CreateElement("FE_UltimoAcceso");
            ele.InnerText = "";
            newUser.AppendChild(ele);

            ele = doc.CreateElement("LI_Contrasenas");
            ele.InnerText = "";
            newUser.AppendChild(ele);

            node.AppendChild(newUser);
            doc.Save(abc);
        }

        public static int getUser()
        {

            return 0;
        }

        public static void deleteUser()
        {

        }

        public static void getElement()
        {

        }

        public static void modifyElement()
        {

        }

        public static String getPassword()
        {
            return "";
        }

    }
}
