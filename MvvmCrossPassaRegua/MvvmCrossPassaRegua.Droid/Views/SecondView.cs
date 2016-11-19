using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MvvmCrossPassaRegua.Droid.Views
{
    [Activity(Label = "Segunda página", Theme = "@style/AppTheme")]
    public class SecondView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }
    }
}
