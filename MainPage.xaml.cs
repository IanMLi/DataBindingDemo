using DataBindingDemo.Models;

namespace DataBindingDemo;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
/* Se crea la instancia de persona */
        var persona = new Person
        {
            Name = "John Doe",
            Phone = "0125636985",
            Address = "123 Main Street"
        };
        /* Crear el Binding o enlace usando la clase Bindings */
        Binding personBinding = new Binding();
        /* Origen de la informacion  */
        personBinding.Source = persona;
        personBinding.Path = "Name";
        txtName.SetBinding(Label.TextProperty, personBinding);
    }
}