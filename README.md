# grupo-rojo-repository


##modificar el login y registrar(paquetes)
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.3
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 8.0.2

##comando que se uso para modificacion
dotnet aspnet-codegenerator identity -dc grupo_rojo_repository.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout;Account.ForgotPassword;Account.ResetPassword;Account.ExternalLogin;Account.ConfirmEmail"
