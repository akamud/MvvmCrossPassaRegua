using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace MvvmCrossPassaRegua.Droid.Views
{
    [Activity(Label = "Calculadora", Theme = "@style/AppTheme")]
    public class FirstView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);
        }
    }
}
