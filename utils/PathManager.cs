using System;
using System.IO;

namespace SALAM
{
    public static class PathManager
    {
        // Ruta base: bin\Debug o bin\Release
        public static readonly string RutaBase = AppDomain.CurrentDomain.BaseDirectory;

        // Ruta del proyecto (sube dos niveles desde bin)
        public static readonly string RutaProyectoBase = Directory.GetParent(RutaBase).Parent.Parent.FullName;
            

        // Rutas de archivos principales
        public static readonly string Database_inventory = Path.Combine(RutaProyectoBase, "databases\\inventory.db");
        public static readonly string Database_users = Path.Combine(RutaProyectoBase, "databases\\users.db");
        public static readonly string RegistroTxt = Path.Combine(RutaProyectoBase, "registro_SAI\\REGISTRO.txt");
        public static readonly string RegistroJson = Path.Combine(RutaProyectoBase, "registro_SAI\\REGISTRO.json");
    }
}
