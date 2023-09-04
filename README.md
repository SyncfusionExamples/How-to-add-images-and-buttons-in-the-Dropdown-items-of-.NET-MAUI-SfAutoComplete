# How-to-add-images-and-buttons-in-the-Dropdown-items-of-.NET-MAUI-SfAutoComplete
This sample demonstrates how to customize the DropDown items in the .NET MAUI AutoComplete (SfAutoComplete). The ItemTemplate property helps you to decorate drop-down items using the custom templates.

**Steps**

**Step 1:Populate data in ViewModel**

Create a model class named Employee that contains information such as the employee’s image and name. And generate the collection of employee data in the ViewModel class.

```
    public class Employee
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
    
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            this.Employees = new ObservableCollection<Employee>()
            {
                new Employee{ Name = "Anne Dodsworth", Image = "anne_dodsworth.png"},
                new Employee{ Name = "Andrew Fuller", Image = "andrew_fuller.png"},
                new Employee{ Name = "Emilio Alvaro", Image = "emilio_alvaro.png" },
                new Employee{ Name = "Janet Leverling", Image = "janet_leverling.png" },
                new Employee{ Name = "Jennifer", Image = "jennifer.png"},
                new Employee{ Name = "Jackson", Image = "jackson.png"},
                new Employee{ Name = "Jacob",Image = "jacob.png"}
            };
            
        }
    }
```

**Step 2: Binding the data**

Binding the Employees property to the ItemsSource property of AutoComplete. TextMemberPath property path is used to get the value for displaying in the selection box portion of the .NET MAUI Autocomplete control when an item is selected. DisplayMemberPath property path is used to specify the name or path of the property displayed for each data item in the drop-down list.

**XAML**

```
     <ContentPage.BindingContext>
            <local:EmployeeViewModel />
     </ContentPage.BindingContext>
     <editors:SfAutocomplete Placeholder="Enter an employee"
                             TextMemberPath="Name"
                             DisplayMemberPath="Name"
                             ItemsSource="{Binding Employees}"
                             WidthRequest="280">
            ...
     </editors:SfAutocomplete>
```

**Step 3: Customize the DropDown items**

Customize the DropDown items of SfAutoComplete using ItemTemplate.

```
<editors:SfAutocomplete Placeholder="Enter an employee"
                            TextMemberPath="Name"
                            DisplayMemberPath="Name"
                            ItemsSource="{Binding Employees}"
                            WidthRequest="280">
        <editors:SfAutocomplete.ItemTemplate>
            <DataTemplate>
                 <HorizontalStackLayout HeightRequest="50"
                                        Spacing="10"
                                        Padding="0,5">
                        <Image Source="{Binding Image}"
                               Aspect="AspectFit"/>
                        <Button Text="{Binding Name}"
                                WidthRequest="220"/>
                  </HorizontalStackLayout>
            </DataTemplate>
        </editors:SfAutocomplete.ItemTemplate>
    </editors:SfAutocomplete>
```
## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio with .NET MAUI workloads and .NET SDK version in your machine before starting to work on this project. Refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

## How to run this application?

To run this application, you need to first clone the How-to-add-images-and-buttons-in-the-Dropdown-items-of-.NET-MAUI-SfAutoComplete repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing a path too long exception when building this example project, close Visual Studio rename the repository to short, and build the project.