using System.Diagnostics;
using System.Reflection;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		SemanticScreenReader.Announce(CounterBtn.Text);

        string[] resNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
        foreach (string resName in resNames) { Debug.WriteLine(resName); }
	}

}

