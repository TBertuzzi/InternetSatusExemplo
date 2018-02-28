using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InternetSatusExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnTeste.Clicked +=  (sender, e) => {

                lblConexao.Text = CrossConnectivity.Current.IsConnected ? "Conectado" : "Coloque créditos";
            };
        }
	}
}
