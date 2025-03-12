﻿
namespace SistemaAcademico
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.AlunoAcademico());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var Window = base.CreateWindow(activationState);

            Window.Width = 400;
            Window.Height = 600;

            return Window;
        }
    }

}
