# wpf-BusyIndicator-examples
Contains the examples for SfBusyIndicator in WPF platform
# Getting Started with BusyIndicator sample
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**

```
Namespace: Syncfusion.Windows.Controls.Notification.
Assembly: Syncfusion.SfBusyIndicator.WPF
```


Step 2: Then initialize an empty SfChipGroup as shown in the following code:

**[XAML]**

```
 <Grid Background="CornflowerBlue">
        <Notification:SfBusyIndicator/>
</Grid>
```
**[C#]**
```
SfBusyIndicator busyIndicator = new SfBusyIndicator();
```
## How to run this application?

To run this application, you need to first clone the wpf-BusyIndicator-examples repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
