using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsBug.Controls.SampleCell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class SampleCell : ContentView
    {
        public static readonly BindableProperty InputCellProperty = BindableProperty.Create(
            nameof(InputCell),
            typeof(SampleCellModel),
            typeof(SampleCell));

        public SampleCellModel InputCell
        {
            get => (SampleCellModel)GetValue(InputCellProperty);
            set => SetValue(InputCellProperty, value);
        }

        public SampleCell() => InitializeComponent();
    }
}