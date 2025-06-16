using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuntesJorgeRamosTaller.Repositories
{
    internal class FilesRepository
    {
        private string filePath = FileSystem.Current.AppDataDirectory + "/archivo1.txt";
        public async Task<bool> CrearArchivo(String texto)
        {
            File.WriteAllText(filePath, texto);

            try
            {
                await File.WriteAllTextAsync(filePath, texto);
                if (File.Exists(filePath))
                {
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<string> ObtenerInformacionArchivo()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string infoArchivo = await File.ReadAllTextAsync(filePath);
                    return infoArchivo;
                }
                else
                {
                    return "El archivo no existe.";

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        }
}
