using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCrossPassaRegua;

namespace MvvmCrossPassaRegua.Droid
{
    [Activity(Label = "MvvmCrossPassaRegua.Droid", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/AppTheme")]
    public class MainActivity : Activity
    {
        EditText txtValor;
        SeekBar seekBarPessoas;
        TextView lblPessoas;
        TextView lblValorTotal;
        TextView lblValorIndividual;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
            txtValor = FindViewById<EditText>(Resource.Id.txtValor);
            seekBarPessoas = FindViewById<SeekBar>(Resource.Id.seekBarPessoas);
            seekBarPessoas = FindViewById<SeekBar>(Resource.Id.seekBarPessoas);
            lblPessoas = FindViewById<TextView>(Resource.Id.lblPessoas);
            lblValorTotal = FindViewById<TextView>(Resource.Id.lblValorTotal);
            lblValorIndividual = FindViewById<TextView>(Resource.Id.lblResultado);

            button.Click += (sender, e) => 
            {
                double valorTotal = 0;
                double.TryParse(txtValor.Text, out valorTotal);
                var pessoas = seekBarPessoas.Progress;

                var calculadoraSerice = new CalculadoraService();

                var valorIndividual = calculadoraSerice.CalculaIndividual(valorTotal, pessoas);

                lblValorTotal.Text = $"R$ {valorTotal.ToString("0.00")}";
                lblPessoas.Text = pessoas.ToString();
                lblValorIndividual.Text = $"R$ {valorIndividual.ToString("0.00")}";
            };
        }
    }
}

