using System;
using Xamarin.Forms;

namespace IVoteNaija
{

	public class LoginButton:Button
	{
		Button logButton1 = new Button 
		{
			Text = "Login",
			TextColor = Color.White,
			BackgroundColor = Color.FromHex("77D065")
		};
	  
		public int checkUser(Mail email, string password)
		{
			string currentUserName = "";
			currentUserName = email.Text;
			return 0;
		}

		public LoginButton(Mail thismail,Password pass)
		{

			logButton1.Clicked+= (sender, e) => {
				int zz =	checkUser(thismail,pass);
				if(zz = 0)
				{
				  
				}

			};
		}

	}
	public class Mail:Entry
	{
	
	
		Entry Email = new Entry()
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
				Placeholder = "Email"
		};
		 
	}

	public class Password:Entry
	{


		Entry Pass = new Entry()
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
			Placeholder = "Password",
		    IsPassword= true
		};

	}






	public class App


	{
		public static TabbedPage GetMainPage ()
		{	

		  
			var email = new Mail (); 
			var pass = new Password();
			var LoginPage = new ContentPage {
				Title = "Login",
				Icon = "Profile.png",
				Content = new StackLayout {
					Spacing = 20, Padding = 50,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						email,
						pass,
						new LoginButton(email,pass){}}}
			};


			var SignupPage = new ContentPage {
				Title = "Signup",
				Icon = "Settings.png",
				Content = new StackLayout {
					Spacing = 20, Padding = 50,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Entry { Placeholder = "Full Name.." },
						new Entry { Placeholder = "Email" },
						new Entry { Placeholder = "Password", IsPassword = true },
						new Button {
							Text = "Signup",
							TextColor = Color.White,
							BackgroundColor = Color.FromHex("77D065") }}}
			};
			var mainPage = new TabbedPage { Children = { LoginPage, SignupPage } };
			return mainPage;
		}

	}
}

