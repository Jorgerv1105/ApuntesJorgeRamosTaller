using ApuntesJorgeRamosTaller.Repositories;
using ApuntesJorgeRamosTaller.Views;
using System.Threading.Tasks;

namespace ApuntesJorgeRamosTaller
{
    public partial class MainPage : ContentPage
    {
        private FilesRepository _fileRepository;

        public MainPage()
        {
            _fileRepository = new FilesRepository();
            InitializeComponent();

            CargarInformacionArchivo(); 
        }
        private async void CargarInformacionArchivo()
        { 
            string infoArchivo = await _fileRepository.ObtenerInformacionArchivo();
            InfoArchivo.Text = infoArchivo;

        }


        private async void BtnArchivo_Clicked(object sender, EventArgs e)
        {
            string texto = TxtArchivo.Text;
            bool guardar = await _fileRepository.CrearArchivo(texto);

            CargarInformacionArchivo();
        }

        private void BtnAboutPage_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new AboutPage());

        }
    }

}
