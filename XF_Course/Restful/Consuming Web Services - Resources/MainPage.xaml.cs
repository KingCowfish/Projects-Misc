using Xamarin.Forms;

namespace HelloWorld
{
	public class Post 
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
	}

	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
		}

		void OnAdd(object sender, System.EventArgs e)
		{
		}

		void OnUpdate(object sender, System.EventArgs e)
		{
		}

		void OnDelete(object sender, System.EventArgs e)
		{
		}
	}
}