[![Build status](https://ci.appveyor.com/api/projects/status/7irge9no1pk1wytc/branch/master?svg=true)](https://ci.appveyor.com/project/kentico/kontent-sample-app-razorpages/branch/master)

# kontent-sample-app-razorpages
Sample .NET Core Razor Pages project using the [Kentico Kontent Delivery .NET SDK](https://github.com/Kentico/kontent-delivery-sdk-net) to retrieve content.

This application is meant for use with the Dancing Goat sample project within Kentico Kontent. The project contains the home page and article content for Dancing Goat – an imaginary chain of coffee shops. If you don't have your own Sample Project, any administrator of a Kentico Kontent subscription [can generate one](https://app.kontent.ai/sample-project-generator).

## Application setup

### Running the application
To run the app:
1. Clone the app repository with your favorite GIT client
   1. For instance, you can use [Visual Studio](https://www.visualstudio.com/vs/), [Visual Studio Code](https://code.visualstudio.com/), [GitHub Desktop](https://desktop.github.com/), etc.
   1. Alternatively, you can download the repo as a ZIP file, however, this will not adapt line endings in downloaded files to your platform (Windows, Unix).
1. Open the solution in Visual Studio (using the _kontent-sample-app-razorpages.sln_ file).
1. Run the app.

### Connecting to your sample project
If you already have a [Kentico Kontent account](https://app.kontent.ai), you can connect this sample Razor Pages application to your version of the Sample project.

1. In Kentico Kontent, choose Project settings from the app menu.
1. Under Development, choose API keys and copy the Project ID.
1. Open the `\kontent-sample-app-razorpages\appsettings.json` file.
1. Use the values from your Kentico Kontent project in the `appsettings.json` file:

    * **Project ID**: Insert your project ID into the `ProjectId` application setting.

```json
    {
    "DeliveryOptions": {
      "ProjectId": "<your Kontent project ID>"
    },
  }
```
1. Save the changes.
1. Run the application.

## Content administration
1. Navigate to <https://app.kontent.ai> in your browser.
1. Sign in with your credentials.
1. Manage content in the content administration interface of your sample project.

You can learn more about content editing with Kentico Kontent in our [Documentation](https://docs.kontent.ai/).

## Content delivery
You can retrieve content either through the [Kentico Kontent Delivery SDK](https://github.com/Kentico/kontent-delivery-sdk-net) or the [Kentico Kotent Delivery API](https://docs.kontent.ai/reference/kentico-kontent-apis-overview).

![Analytics](https://kentico-ga-beacon.azurewebsites.net/api/UA-69014260-4/Kentico/kontent-sample-app-razorpages?pixel)
