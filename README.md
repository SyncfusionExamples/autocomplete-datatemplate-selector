# Xamarin Forms SfAutoComplete

Essential AutoComplete for Xamarin.Forms provides a simpler way to complete the text based on the characters that the user has entered before. It also provides option to choose a suggestion from drop down or append a suggestion to the text directly.

For know more details about AutoComplete:https://www.syncfusion.com/xamarin-ui-controls/xamarin-autocomplete

AutoComplete user guide documentation:https://help.syncfusion.com/xamarin/autocomplete/getting-started

## Getting Started with AutoComplete sample
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**

```
xmlns:autocomplete="clr-namespace:Syncfusion.SfAutoComplete.XForms;assembly=Syncfusion.SfAutoComplete.XForms"

```
**[C#]**

```
using Syncfusion.SfAutoComplete.XForms;

```
Step 2: Then initialize an empty SfAutoComplete as shown in the following code:

**[XAML]**

```
 <StackLayout  VerticalOptions="Start" 
               HorizontalOptions="Start"
               Padding="30">
<autocomplete:SfAutoComplete x:Name="autoComplete"
                            HeightRequest="40"/>
</StackLayout>
```
**[C#]**
```
SfAutoComplete autoComplete = new SfAutoComplete()
 {
     HeightRequest = 40
 };

```

## DataTemplateSelector in Xamarin AutoComplete 

SfAutoComplete supports DataTemplateSelector, which is used to choose a DataTemplate based on data object.

**[XAML]**

```
   <ContentPage.BindingContext>
        <local:MobileDetailViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="default">
                <ViewCell>
                    <Grid Padding="5">
                        <Label Text="{Binding Mobile}" TextColor="Green"/>
                    </Grid>
                </ViewCell>
            </DataTemplate>
            <DataTemplate x:Key="specific">
                <ViewCell>
                    <Grid  Padding="5">
                        <Label Text="{Binding Mobile}" BackgroundColor="LightGray" TextColor="Red"/>
                    </Grid>
                </ViewCell>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <StackLayout VerticalOptions="Start" HorizontalOptions="Start" Padding="30">
        <autocomplete:SfAutoComplete DataSource="{Binding MobileCollection}" DisplayMemberPath="Mobile">
            <autocomplete:SfAutoComplete.ItemTemplate>
                <local:DataTemplateSelectorViewModel DefaultTemplate="{StaticResource default}" SpecificDataTemplate="{StaticResource specific}" />
            </autocomplete:SfAutoComplete.ItemTemplate>
        </autocomplete:SfAutoComplete>
    </StackLayout>
</ContentPage>

```

## Create and Initialize Business Models

Define a simple model class MobileDetail with fields IsAvailableInStock, Mobile and populate mobile detail in ViewModel.

**[C#]**

```

namespace AutocompleteSample
{
    public class MobileDetailViewModel
    {
        public ObservableCollection<MobileDetail> MobileCollection { get; set; }
        public MobileDetailViewModel()
        {
            this.MobileCollection = new ObservableCollection<MobileDetail>()
            {
                new MobileDetail () { Mobile="Samasung S8", IsAvailableInStock=false },
                new MobileDetail () { Mobile="Samasung S9", IsAvailableInStock=true },
                new MobileDetail () { Mobile="Samsung S10", IsAvailableInStock=true },
                new MobileDetail () { Mobile="Samsung S10 plus", IsAvailableInStock=true },
                new MobileDetail () { Mobile="iPhone 7", IsAvailableInStock=true },
                new MobileDetail () { Mobile="iPhone 8", IsAvailableInStock=true },
                new MobileDetail () { Mobile="iPhone X", IsAvailableInStock=false },
                new MobileDetail () { Mobile="iPhone XR", IsAvailableInStock=false },
                new MobileDetail () { Mobile="iPhone XS", IsAvailableInStock=true },
            };
        }
    }

    public class MobileDetail
    {
        public string Mobile { get; set; }

        public bool IsAvailableInStock { get; set; }
    }
}

```
## How to run this application?

To run this application, you need to first clone the autocomplete-datatemplate-selector repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.