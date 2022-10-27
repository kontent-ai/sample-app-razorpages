[![Build & Test](https://github.com/kontent-ai/sample-app-razorpages/actions/workflows/integrate.yml/badge.svg)](https://github.com/kontent-ai/kontent/sample-app-razorpages/actions/workflows/integrate.yml)

# Kontent.ai sample ASP.NET Core Razor Pages web application

Sample .NET Core Razor Pages project using the [Kontent.ai Delivery .NET SDK](https://github.com/kontent-ai/delivery-sdk-net) to retrieve content.

This application is meant for use with the Dancing Goat sample project within Kontent.ai. The project contains the home page and article content for Dancing Goat – an imaginary chain of coffee shops. If you don't have your own Sample Project, any administrator of a Kontent.ai subscription [can generate one](https://app.kontent.ai/sample-project-generator).

## Application setup

### Running the application

To run the app:

1. Clone the app repository with your favorite GIT client
1. Open the solution
1. Run the app.

### Connecting to your sample project

If you already have a [Kontent.ai account](https://app.kontent.ai), you can connect this sample Razor Pages application to your version of the Sample project.

1. In Kontent.ai, choose Project settings from the app menu.
1. Under Development, choose API keys and copy the Project ID.
1. Open the `\sample-app-razorpages\appsettings.json` file.
1. Use the values from your Kontent.ai project in the `appsettings.json` file:

    * **Project ID**: Insert your project ID into the `ProjectId` application setting.

```json
    {
    "DeliveryOptions": {
      "ProjectId": "<your Kontent.ai project ID>"
    },
  }
```

1. Save the changes.
1. Run the application.

## Content administration

1. Navigate to <https://app.kontent.ai> in your browser.
1. Sign in with your credentials.
1. Manage content in the content administration interface of your sample project.

Learn more about [content editing with Kontent.ai](https://kontent.ai/learn/tutorials/write-and-collaborate/create-content/introducing-content-items).

## Content delivery

You can retrieve content either through the [Kontent.ai Delivery SDK](https://github.com/kontent-ai/delivery-sdk-net) or the [Kontent.ai Delivery API](https://kontent.ai/learn/reference/kontent-apis-overview).
