using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace ColorPicker
{
    public partial class ColorPickerPage : ContentPage, INotifyPropertyChanged
    {
        public List<MyColor> Colors { get; set; }
        
        public ColorPickerPage()
        {
            InitializeComponent();

            BindingContext = this;

            Colors = MyColor.GetColors().ToList();
            RaisePropertyChanged("Colors");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public void Handle_ItemTapped(object sender, ItemTappedEventArgs args)
        {
            var colorPage = new ContentPage();
            var hex = ((MyColor)args.Item).Hex;
            var color = Color.FromHex(hex);
            colorPage.BackgroundColor = color;
            colorPage.Title = hex;
            Navigation.PushAsync(colorPage);
        }
    }
}
