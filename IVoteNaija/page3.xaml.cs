using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IVoteNaija
{	
	public partial class page3 : ContentPage
	{	
		public page3 ()
		{
			Padding = new Thickness(20);

			var red = new Label
			{
				Text = "Stop",
				BackgroundColor = Color.Red,
				Font = Font.SystemFontOfSize (20)
			};
			var yellow = new Label
			{
				Text = "Slow down",
				BackgroundColor = Color.Yellow,
				Font = Font.SystemFontOfSize (20)
			};
			var green = new Label
			{
				Text = "Go",
				BackgroundColor = Color.Green,
				Font = Font.SystemFontOfSize (20)
			};

			Content = new StackLayout
			{
				Spacing = 10,
				Children = { red, yellow, green }
			};
		}
	}
}

