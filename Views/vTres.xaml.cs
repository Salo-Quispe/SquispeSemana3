namespace squispeS3AT3.Views;

public partial class vTres : ContentPage
{
	public vTres()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string usuarioc = txtUsuario.Text;
        string contrasenac = txtContrasena.Text;
        DisplayAlert("Alerta", "usuario almacenado", "ok");
        Navigation.PushAsync(new Views.vUno(usuarioc, contrasenac));
    }
}