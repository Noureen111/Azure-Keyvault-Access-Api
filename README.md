# Azure Key Vault Access API

This project is a minimal ASP.NET Core Web API that demonstrates how to securely retrieve secrets from Azure Key Vault using the Azure SDK.

## 🔐 Features

- Connects to Azure Key Vault using `DefaultAzureCredential` for authentication
- Retrieves secret from the Key Vault
- Exposes an HTTP GET endpoint to fetch a specific secret
- Uses Dependency Injection to manage the `SecretClient`

## 🚀 Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- An Azure subscription with a Key Vault instance
- Azure CLI (for local development authentication)

### Configuration

1. Set the Key Vault URI in your `appsettings.json`:

   ```json
   {
     "KeyVault": {
       "VaultUri": "https://<your-keyvault-name>.vault.azure.net/"
     }
   }
