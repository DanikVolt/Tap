using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class January : ContentPage
    {
        public January()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(3,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(2,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            Label nimetus = new Label { Text = "Январь", FontSize = 30 };
            Image img = new Image { Source = "w.jpg" };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Праздники", "1 января - Всемирный день мира (молитва о мире) (24 года) \n 4 января - День Ньютона \n 5 января - Международный день бойскаутов \n 11 января - Всемирный день «Спасибо!» \n 16 января - Всемирный день «Beatles» (19 лет) 17 января - День детских изобретений \n 19 января - Всемирный день религии \n \n 21 января - Национальный день объятий \n 23 января - День ручного письма (день почерка) \n 24 января - Международный день эскимо \n 25 января - Восточный Новый год белой крысы (металл) \n 26 января - Международный день таможенника (37 лет) \n Международный день «без Интернета» (20 лет) \n 27 января - Международный день памяти жертв Холокоста \n 28 января- Международный день защиты персональных данных (конфиденциальности) (13 лет) \n 29 января - Международный день мобилизации против ядерной войны (35 лет) \n 31 января - Международный день ювелира", "Закрыть");
            };
            Label kirjeldus = new Label { Text = "Январь - самый первый месяц года. А самое главное, что можно слепить снеговика!" };
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }

        
    }
}