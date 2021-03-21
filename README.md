# sample-azure-functions

Visual Studio and Visual Studio for Mac have **not yet** been updated to run .NET 5 Azure Functions. 

If you try to run this code using Visual Studio, it will throw a System.UriFormatException: _"Invalid URI: The hostname could not be parsed."_

Install [Azure Functions Core Tools >= v3.0.3160](https://github.com/Azure/azure-functions-core-tools/releases)

- On macOS: Open the Terminal and run the following command: `brew tap azure/functions; brew install azure-functions-core-tools@3`
- On Windows: Open the Command Prompt and run the following command: `npm i -g azure-functions-core-tools@3 --unsafe-perm true`
- On the command line, navigate to the folder containing your Azure Functions CSPROJ
- On the command line, enter the following command: `func host start --verbose`
