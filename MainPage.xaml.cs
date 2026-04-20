namespace IessApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCalcularClicked(object? sender, EventArgs e)
    {
        // 1. Validaciones
        if (string.IsNullOrWhiteSpace(NombreEntry.Text) ||
            string.IsNullOrWhiteSpace(ApellidoEntry.Text) ||
            string.IsNullOrWhiteSpace(EdadEntry.Text) ||
            string.IsNullOrWhiteSpace(SalarioEntry.Text))
        {
            await DisplayAlert("Error", "Todos los campos deben estar completos", "OK");
            return;
        }

        string nombre = NombreEntry.Text;
        string apellido = ApellidoEntry.Text;
        
        if (!int.TryParse(EdadEntry.Text, out int edad))
        {
            await DisplayAlert("Error", "La edad debe ser un número válido", "OK");
            return;
        }

        if (!double.TryParse(SalarioEntry.Text, out double salario))
        {
            await DisplayAlert("Error", "El salario debe ser un número válido", "OK");
            return;
        }

        // 2. Funcionalidad: Calcular aporte (9.45% del salario)
        double aporte = salario * 0.0945;

        // 3. Salida de información
        string mensaje = $"Bienvenido {nombre} {apellido}\nTienes {edad} años\nTu aporte mensual es ${aporte:F2}";
        await DisplayAlert("Resultado", mensaje, "OK");
    }
}
