using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APIRest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLevel2 : ContentPage
	{
		public PageLevel2 ()
		{
			InitializeComponent ();
            BindingContext = this;
		}
         
        public PageLevel2(Model_Post model)
        {
            //1.Binding Context
            BindingContext = model;
            InitializeComponent();
        }

        private void btnComentario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageLevel3(lblidPost.Text));
        }
    }
}