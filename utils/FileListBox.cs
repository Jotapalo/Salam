using System.Collections.Generic;
using System.Windows.Forms;

namespace SALAM.utils
{
    public class FileListBox : ListBox
    {
        // Propiedad para guardar las rutas completas de los archivos
        public List<string> FilePaths { get; set; } = new List<string>();
    }
}