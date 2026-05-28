namespace MauiApphotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemConstratada());

		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}