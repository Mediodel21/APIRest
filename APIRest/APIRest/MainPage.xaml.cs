using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace APIRest
{
	public partial class MainPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts/";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Model_Post> _post;
        public Command NextPage { get; private set; }
        
        public MainPage()
		{
			InitializeComponent();          

            NextPage = new Command(() => {
                Navigation.PushAsync(new PageLevel2()) ;
            });
            btnNextPage.Command = NextPage;
        }

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url);
            List<Model_Post> posts = JsonConvert.DeserializeObject<List<Model_Post>>(content);
            _post = new ObservableCollection<Model_Post>(posts);
            lstDatos.ItemsSource = _post;
            base.OnAppearing();
        }

        private void lstDatos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectItem = e.SelectedItem;
            var _model = selectItem as Model_Post;

            Navigation.PushAsync(
                new PageLevel2(_model)
                );
        }
    }
}
