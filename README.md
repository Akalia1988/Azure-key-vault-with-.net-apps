# Azure-key-vault-with-.net-apps
Azure key vault with .net or ASP.net core applications

Azure Key Vault is a service that you can use to store secrets and other sensitive configuration data for an application. It allows you to define settings that can be shared among multiple apps, including apps running in App Service.

Key Vault allows you to separate your configuration data into sensitive and non-sensitive information. For example, you could use Application Settings to store some default settings but use Key Vault to store your API keys, connection strings, and passwords that your application depends on.

When you configure an application to connect to a Key Vault it gets added as a separate configuration source. You can then read values just as you would for any other configuration data.

var nonSensitiveSetting = Configuration[“EnableLogging”]; // read from app settings
var sensitiveSetting = Configuration[“ApiKey”]; // read from Key Vault

After moving sensitive data to KeyVault, it is stored separately from your application and secured by a separate Identity.

Configure ASP.NET Core App to access Key Vault

Install below nuget packages

Install-Package Azure.Security.KeyVault.Secrets
Install-Package Microsoft.Extensions.Configuration.AzureKeyVault
Install-Package Azure.Identity

need to modify your Host Builder logic to add the code needed. We can use the ConfiureAppConfiguration() method to plug in Azure Key Vault code into ASP.NET Core Application configuration.


Enable App Configuration in Program.cs — 
Update the CreateWebHostBuilder method to use App Configuration by calling the config.AddAzureAppConfiguration() method.

Save Key Vault settings in the appsettings.json file

Read settings in Controller.cs









