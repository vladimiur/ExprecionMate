namespace ExprecionMate;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}


    // En este codigo hacemos la formula matematica
    private void Btncalcular_Clicked(object sender, EventArgs e)
    {

            var Dato1 = Convert.ToInt32(datoA.Text);
            var Dato2 = Convert.ToInt32(datoB.Text);
        double Resultado = Math.Pow(Dato1  +  Dato2,2) /2;
            resultado.Text = Convert.ToString(Resultado);
        
    }
}

