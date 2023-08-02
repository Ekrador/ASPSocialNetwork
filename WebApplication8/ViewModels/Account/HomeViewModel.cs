namespace WebApplication8.ViewModels.Account
{
    public class HomeViewModel
    {
        public RegisterViewModel RegisterView { get;}

        public LoginViewModel LoginView { get;}

        public HomeViewModel()
        {
            RegisterView = new RegisterViewModel();
            LoginView = new LoginViewModel();
        }
    }
}
