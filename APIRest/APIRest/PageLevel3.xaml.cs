using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIRest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLevel3 : ContentPage
	{
        private const string Url = "https://jsonplaceholder.typicode.com/comments?postId=";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Model_Comments> _comments;
        private string pId;

        public PageLevel3 (string strId)
		{
			InitializeComponent ();
            pId = strId;
		}

        protected override async void OnAppearing()
        {
            string content = await client.GetStringAsync(Url+pId);
            List<Model_Comments> comments = JsonConvert.DeserializeObject<List<Model_Comments>>(content);
            _comments = new ObservableCollection<Model_Comments>(comments);
            lstComments.ItemsSource = _comments;
            base.OnAppearing();
        }

    }
}