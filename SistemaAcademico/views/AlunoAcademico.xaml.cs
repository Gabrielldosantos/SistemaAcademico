namespace SistemaAcademico.views;

public partial class AlunoAcademico : ContentPage
{
	public AlunoAcademico()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Pagina1());

		} catch (Exception ex) 
		{
			DisplayAlert("ops", ex.Message, "OK");
		}
    }
}