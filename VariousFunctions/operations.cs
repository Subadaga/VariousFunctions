using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace VariousFunctions
{
    static class operations
    {
        public static void addUser(String Cuenta, String NB_Nombre, String NB_Apellido, String NB_Perfil, String NB_Puesto, String CR_Contrasena)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml"); XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            var node = doc.SelectSingleNode("//Users");

            XmlElement newUser = doc.CreateElement("User");
            newUser.SetAttribute("ID", Cuenta);

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

            ele = doc.CreateElement("FE_Baja");
            ele.InnerText = "";
            newUser.AppendChild(ele);

            ele = doc.CreateElement("BO_Status");
            ele.InnerText = "";
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

        public static bool userIsDown(String cuenta)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            String path = "//Users/User[@ID='" + cuenta + "']";
            XmlNodeList xnList = doc.SelectNodes(path);

            if (xnList.Item(0).ChildNodes.Item(6).InnerText.Equals(false))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool userExists(String cuenta)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            String path = "//Users/User[@ID='" + cuenta + "']";
            XmlNodeList xnList = doc.SelectNodes(path);

            if (xnList.Item(0) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void getUser(String cuenta)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            String path = "//Users/User[@ID='" + cuenta + "']";
            XmlNodeList xnList = doc.SelectNodes(path);

            if (xnList.Item(0) == null)
            {
                MessageBox.Show("The requester user wasn't found");
            }
            else
            {

            }


            MessageBox.Show(xnList.Item(0).ChildNodes.Item(0).InnerText);
            xnList.Item(0).ChildNodes.Item(0).InnerText = "PENE PARADO Y ENORME";

            doc.Save(abc);
        }

        public static void darDeBaja(String cuenta)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            String path = "//Users/User[@ID='" + cuenta + "']";
            XmlNodeList xnList = doc.SelectNodes(path);

            xnList.Item(0).ChildNodes.Item(6).InnerText = "false";

            xnList.Item(0).ChildNodes.Item(7).InnerText = DateTime.Now.ToLongDateString() + "," + DateTime.Now.ToLongTimeString();
            doc.Save(abc);


        }

        public static bool comparacionContrasenas(String cuenta, String password)
        {
            string abc = (System.IO.Directory.GetCurrentDirectory().ToString() + @"\Users.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(abc);

            String path = "//Users/User[@ID='" + cuenta + "']";
            XmlNodeList xnList = doc.SelectNodes(path);

            if (xnList.Item(0).ChildNodes.Item(4).InnerText.Equals(createStoredPassword(password)))
            {
                return true;
            }
            else
            {
                return false;
            }

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

        public static byte[] stringToByteArray(String textoplano)
        {
            return Encoding.ASCII.GetBytes(textoplano);
        }   

        public static byte[] createHash(byte[] byteArray)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            return mySHA256.ComputeHash(byteArray);

        }

        public static String convertToString(byte[] byteArray)
        {
            return Encoding.ASCII.GetString(byteArray);
        }

        public static String createStoredPassword(String textoplano)
        {
            SHA256 mySHA256 = SHA256Managed.Create();
            byte[] stringABytes = Encoding.ASCII.GetBytes(textoplano+ "559AEAD08264D5795D3909718CDD05ABD49572E84FE55590EEF31A88A08FDFFD");
            byte[] valorHash = mySHA256.ComputeHash(stringABytes);
            return BitConverter.ToString(valorHash).Replace("-", "");
        }
        
    }
}
