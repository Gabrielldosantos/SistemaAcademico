using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace SistemaAcademico.views
{
    public partial class Pagina1 : ContentPage
    {
        // Lista de disciplinas dispon�veis
        public List<string> Disciplinas { get; set; } = new List<string>
        {
            "Matem�tica",
            "Portugu�s",
            "Hist�ria",
            "F�sica",
            "Qu�mica"
        };

        // Lista de per�odos dispon�veis
        public List<string> Periodos { get; set; } = new List<string>
        {
            "EAD",
            "Noturno",
            "Diurno"
        };

        // Construtor da p�gina
        public Pagina1()
        {
            InitializeComponent();

            // Define as fontes de dados para os Picker
            periodoPicker.ItemsSource = Periodos;
            disciplinasPicker.ItemsSource = Disciplinas;
        }

        // M�todo chamado quando um per�odo � selecionado
        private void OnPeriodoSelected(object sender, EventArgs e)
        {
            if (periodoPicker.SelectedIndex != -1)
            {
                periodoSelecionadoLabel.Text = $"Per�odo selecionado: {periodoPicker.SelectedItem}";
            }
            else
            {
                periodoSelecionadoLabel.Text = "Per�odo selecionado: Nenhum";
            }
        }

        // M�todo chamado quando uma disciplina � selecionada
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