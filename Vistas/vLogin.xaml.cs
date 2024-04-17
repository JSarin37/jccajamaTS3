namespace jccajamaTS3.Vistas;

public partial class vLogin : ContentPage
{
    // Vectores de usuarios y contraseñas
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };

    public vLogin()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string username = txtUsuario.Text;
        string password = txtContraseña.Text;

        // Buscar el índice del usuario en el vector de usuarios
        int index = Array.IndexOf(users, username);

        // Verificar si el usuario existe y la contraseña coincide
        if (index != -1 && passwords[index] == password)
        {
            // Credenciales válidas, mostrar mensaje de bienvenida
            DisplayAlert("¡Bienvenido!", $"¡Hola {username}!", "OK");
            Navigation.PushAsync(new vElementos(username));
        }
        else
        {
            // Credenciales inválidas, mostrar mensaje de error
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }




    }

}