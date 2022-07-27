using RadialBarChart.Controls;

namespace RadialBarChart;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        BindingContext = new ChartEntry[]
        {
            new ChartEntry
            {
                Value = 71,
                Color = Color.FromArgb("#6023FF"),
                Text = "Visual Studio Code"
            },
            new ChartEntry
            {
                Value = 33,
                Color = Color.FromArgb("#3059FE"),
                Text = "Visual Studio"
            },
            new ChartEntry
            {
                Value = 29,
                Color = Color.FromArgb("#2EF1D2"),
                Text = "Notepad++"
            },
            new ChartEntry
            {
                Value = 28,
                Color = Color.FromArgb("#F8426E"),
                Text = "IntelliJ"
            }
        };
    }
}

