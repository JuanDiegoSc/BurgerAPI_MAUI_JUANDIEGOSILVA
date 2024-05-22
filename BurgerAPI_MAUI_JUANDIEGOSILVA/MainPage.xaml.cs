using BurgerAPI_MAUI_JUANDIEGOSILVA.Models;
using Newtonsoft.Json;

namespace BurgerAPI_MAUI_JUANDIEGOSILVA
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7057/api/"); //Cambiar el puerto del localhost
            var response = client.GetAsync("burger").Result;
            if (response.IsSuccessStatusCode)
            {
                var burgers = response.Content.ReadAsStringAsync().Result;
                var burgersList =
               JsonConvert.DeserializeObject<List<Burger>>(burgers);
                listView.ItemsSource = burgersList;
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}
