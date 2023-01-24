# Xamarin Forms SfAutoComplete

Essential AutoComplete for Xamarin.Forms provides a simpler way to complete the text based on the characters that the user has entered before. It also provides option to choose a suggestion from drop down or append a suggestion to the text directly.

For know more details about AutoComplete:https://www.syncfusion.com/xamarin-ui-controls/xamarin-autocomplete

AutoComplete user guide documentation:https://help.syncfusion.com/xamarin/autocomplete/getting-started

## Syncfusion Controls

This project uses the following Syncfusion controls:

* [SfAutoComplete](https://www.syncfusion.com/xamarin-ui-controls/xamarin-autocomplete) - To display automcomplete data template selector

## Screenshots

<img src="Images/autocomplete1.png"  Width="250"/> <img src="Images/autocomplete2.png" Width="250" /> 

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| Android   | API level 19 and later versions |
| iOS | iOS 9.0 and later versions |

Refer to the following link for more details: 
[System Requirements](https://help.syncfusion.com/xamarin/installation-and-upgrade/system-requirements)

## Requirements to run the sample

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available in Visual Studio installer)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#xamarinforms) for more details.

3. Set any one of the platform specific projects (iOS, Android or UWP) as a start-up project.
4. Clean and build the application.
5. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.

