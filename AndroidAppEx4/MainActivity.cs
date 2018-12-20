using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using Android.Content;

namespace AndroidAppEx4
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnLogin;
        EditText txtUserName;
        EditText txtPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            txtUserName = FindViewById<EditText>(Resource.Id.txtUserName);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);

            Button btnGoToInsertPage = FindViewById<Button>(Resource.Id.btnGoToInsertPage);
            btnGoToInsertPage.Click += BtnGoToInsertPage_Click;

            Button btnGoToListPage = FindViewById<Button>(Resource.Id.btnGoToListPage);
            btnGoToListPage.Click += btnGoToListPage_Click;

            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Toast.MakeText(this, txtUserName.Text, ToastLength.Long).Show();
            //StartActivity(typeof(LoginActivity));

            var intent = new Intent(this, typeof(LoginActivity));
            //intent.PutExtra("username", txtUserName.Text);
            //intent.PutExtra("password", txtPassword.Text);

            Person _person = new Person
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };

            //intent.PutExtra("person", JsonConvert.SerializeObject(_person));
            intent.PutExtra("person", _person.ToJson());
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.RequestFocus();
            StartActivity(intent);

        }

        private void btnGoToListPage_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(ListActivity));
        }

        private void BtnGoToInsertPage_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(InsertActivity));
        }
    }
}

