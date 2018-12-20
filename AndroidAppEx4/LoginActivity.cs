using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidAppEx4
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginPage);

            //string userName = Intent.GetStringExtra("username");
            //string password = Intent.GetStringExtra("password");

            var _person = Intent.GetStringExtra("person");
            //Person selectedPerson = JsonConvert.DeserializeObject<Person>(_person);
            Person selectedPerson = Helper.FromJson<Person>(_person);

            //Title = userName;
            Title = selectedPerson.UserName;

            TextView txtView = FindViewById<TextView>(Resource.Id.lblUserName);
            txtView.Text = selectedPerson.UserName;

        }
    }
}