namespace squispeS3AT3.Views;

public partial class vDos : ContentPage
{
    public vDos(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO" + usuario;
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vUno());

    }
}