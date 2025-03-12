using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace SistemaAcademico.views
{
    public partial class Pagina1 : ContentPage
    {
        // Lista de disciplinas disponíveis
        public List<string> Disciplinas { get; set; } = new List<string>
        {
            "Matemática",
            "Português",
            "História",
            "Física",
            "Química"
        };

        // Lista de períodos disponíveis
        public List<string> Periodos { get; set; } = new List<string>
        {
            "EAD",
            "Noturno",
            "Diurno"
        };

        // Construtor da página
        public Pagina1()
        {
            InitializeComponent();

            // Define as fontes de dados para os Picker
            periodoPicker.ItemsSource = Periodos;
            disciplinasPicker.ItemsSource = Disciplinas;
        }

        // Método chamado quando um período é selecionado
        private void OnPeriodoSelected(object sender, EventArgs e)
        {
            if (periodoPicker.SelectedIndex != -1)
            {
                periodoSelecionadoLabel.Text = $"Período selecionado: {periodoPicker.SelectedItem}";
            }
            else
            {
                periodoSelecionadoLabel.Text = "Período selecionado: Nenhum";
            }
        }

        // Método chamado quando uma disciplina é selecionada
        private void OnDisciplinaSelected(object sender, EventArgs e)
        {
            if (disciplinasPicker.SelectedIndex != -1)
            {
                disciplinaSelecionadaLabel.Text = $"Disciplina selecionada: {disciplinasPicker.SelectedItem}";
            }
            else
            {
                disciplinaSelecionadaLabel.Text = "Disciplina selecionada: Nenhuma";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Pagina2());

            }
            catch (Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }
        }


    }
}