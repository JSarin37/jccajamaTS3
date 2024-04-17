namespace jccajamaTS3.Vistas;

public partial class vLogin : ContentPage
{
    // Vectores de usuarios y contrase�as
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string username = txtUsuario.Text;
        string password = txtContrase�a.Text;

        // Buscar el �ndice del usuario en el vector de usuarios
        int index = Array.IndexOf(users, username);

        // Verificar si el usuario existe y la contrase�a coincide
        if (index != -1 && passwords[index] == password)
        {
            // Credenciales v�lidas, mostrar mensaje de bienvenida
            DisplayAlert("�Bienvenido!", $"�Hola {username}!", "OK");
            Navigation.PushAsync(new vElementos(username));
        }
        else
        {
            // Credenciales inv�lidas, mostrar mensaje de error
            DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }




    }

}