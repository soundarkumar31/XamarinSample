using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Xamarin1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        /// <summary>
        /// OnCreate method execute application create time
        /// </summary>
        /// <param name="savedInstanceState"></param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Login Page Example

            Button logginButton = FindViewById<Button>(Resource.Id.LoginButton);
            logginButton.Click += OnLoginButtonClick;


            //PopupMenu Example
            //Button button = FindViewById<Button>(Resource.Id.button1);

            //button.Click += (s, e) => {
            //    PopupMenu popupMenu = new PopupMenu(this, button);
            //    popupMenu.Inflate(Resource.Menu.popupMenu);
            //    popupMenu.Show();
            //};




            //AutoCompleteTextView            
            //AutoCompleteTextView autoCompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView1);
            //Button button = FindViewById<Button>(Resource.Id.button1);
            //string[] names = new string[] { "john", "soundar","mani","murali","siva" };
            //ArrayAdapter arrayAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, names);
            //autoCompleteTextView.Adapter = arrayAdapter;

            //button.Click += (s, e) =>
            //{
            //    string yourName = "Your Name is " + autoCompleteTextView.Text;
            //    if (!string.IsNullOrEmpty(autoCompleteTextView.Text))
            //    {
            //        Toast.MakeText(this, yourName, ToastLength.Short).Show();
            //    }
            //    else
            //    {
            //        Toast.MakeText(this, "Enter a Name", ToastLength.Short).Show();
            //    }
            //};

            //ToggleButton Example
            //ToggleButton toggleButton = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            //toggleButton.Click += (s, e) =>
            //{
            //    if (toggleButton.Checked)
            //    {
            //        Toast.MakeText(this, "Text is On", ToastLength.Short).Show();
            //    }
            //    else
            //    {
            //        Toast.MakeText(this, "Text is Off", ToastLength.Short).Show();
            //    }
            //};


            //RadioButton Example
            //RadioButton radio_Tirrutani = FindViewById<RadioButton> (Resource.Id.Tiruttani);
            //RadioButton radio_Arakkonam = FindViewById<RadioButton>(Resource.Id.Arakkonam);
            //RadioButton radio_Chennai = FindViewById<RadioButton>(Resource.Id.Chennai);

            //radio_Tirrutani.Click += onClickRadioButton;
            //radio_Arakkonam.Click += onClickRadioButton;
            //radio_Chennai.Click += onClickRadioButton;



            //ProgressBar Exmaple
            //ProgressBar progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            //progressBar.Progress = 76;


            //CheckBox Example
            //CheckBox checkMe = FindViewById<CheckBox>(Resource.Id.checkBox1);
            //checkMe.CheckedChange += (object sender, CompoundButton.CheckedChangeEventArgs e) =>
            //{
            //    CheckBox check = (CheckBox)sender;
            //    if (check.Checked)
            //    {
            //        check.Text = "Checkbox has been checked";
            //    }
            //    else
            //    {
            //        check.Text = "checkbox has not been checked";
            //    }
            //};

            //Button Example
            //Button button = FindViewById<Button>(Resource.Id.MyButton);
            //button.Click += delegate { button.Text = "You Click Me"; };
        }

        //private void onClickRadioButton(object sender,EventArgs e)
        //{
        //    RadioButton location = (RadioButton)sender;
        //    Toast.MakeText(this,location.Text,ToastLength.Short).Show();
        //}

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
            EditText EmailId = FindViewById<EditText>(Resource.Id.EmailId);
            EditText Password = FindViewById<EditText>(Resource.Id.Password);
            string _email = EmailId.Text;
            string _password = Password.Text;
            if (string.IsNullOrEmpty(_email))
            {
                Toast.MakeText(this, "Enter EmailId", ToastLength.Short).Show();
                return;
            }
            else if (string.IsNullOrEmpty(_password))
            {
                Toast.MakeText(this, "Enter Password", ToastLength.Short).Show();
                return;
            }
            else if (!string.IsNullOrEmpty(_email) && !string.IsNullOrEmpty(_password))
            {
                if (_email == "soundar" && _password == "12345")
                {
                    Toast.MakeText(this, "Welcome SOUNDAR", ToastLength.Short).Show();
                    return;
                }
                else
                {
                    Toast.MakeText(this, "Invalid Email or Password", ToastLength.Short).Show();
                    return;
                }
            }
        }


        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}