namespace squispeS3AT3.Views;

public partial class vUno : ContentPage
{
	public vUno()
	{
		InitializeComponent();
	}

    string usuariof = "";
    string contrasenaf = "";

    public vUno (string usuario, string contrasena)
    {
        InitializeComponent();
        this.usuariof = usuario;
        this.contrasenaf = contrasena;
    }

    private void btnIncioSesion_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuariof && txtContrasena.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.vDos(usuariof));
        }
        else
        {
            DisplayAlert("Alerta", "usuario y contrasena incorrectos", "ok");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vTres());

    }
}