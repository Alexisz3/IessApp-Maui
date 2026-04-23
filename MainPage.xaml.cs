using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace lessApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Datos para los menús desplegables
        pckTipoId.ItemsSource = new List<string> { "CÉDULA", "RUC", "PASAPORTE" };
        pckCarrera.ItemsSource = new List<string> { "Desarrollo de Software", "Redes y Telecom.", "Diseño Gráfico" };

        // Unimos modalidad y campus para un diseño más limpio
        pckModalidad.ItemsSource = new List<string> {
            "Presencial - Sede Matriz",
            "Semipresencial - Sede Matriz",
            "En línea",
            "Presencial - Sede Sur"
        };
    }

    private async void OnGuardarClicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync("¡Excelente!", "Tu formulario luce profesional y moderno. Inscripción enviada correctamente.", "Continuar");
    }
}