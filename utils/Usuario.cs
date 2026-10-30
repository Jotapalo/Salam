using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SALAM.SRV
{
    public static class Usuario
    {
        public static string name = "DEFAULT";
        public static string rol = "USER"; // Puede ser "USER" o "ADMIN"
        public static Image img_user = null;


        public static void SetName(string name)
        {
            Usuario.name = name;
            Console.WriteLine($"Hola {Usuario.name}, bienvenido a SALAM");
        }

        public static void SetRol(string rol)
        {
            if (rol == "USER" || rol == "ADMIN")
            {
                Usuario.rol = rol;
                Console.WriteLine($"Nivel de acceso establecido: {Usuario.rol}");
            }
            else
            {
                Console.WriteLine("Rol no válido. Debe ser 'USER' o 'ADMIN'.");
            }
        }

        public static void SetImage(Image img)
        {
            Usuario.img_user = img;
            Console.WriteLine("Imagen de usuario actualizada.");
        }

        public static void SetImage(byte[] imgData)
        {
            if (imgData != null && imgData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    Usuario.img_user = Image.FromStream(ms);
                }
                Console.WriteLine("Imagen de usuario actualizada desde byte array.");
            }
            else
            {
                Console.WriteLine("No se pudo actualizar la imagen de usuario: datos inválidos.");
            }
        }
    }
}
