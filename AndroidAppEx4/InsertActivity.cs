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
    [Activity(Label = "InsertActivity")]
    public class InsertActivity : Activity
    {
        EditText txtInsertUser;
        EditText txtPassword;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.InsertPage);

            txtInsertUser = FindViewById<EditText>(Resource.Id.txtInsertUser);
            txtPassword = FindViewById<EditText>(Resource.Id.txtInsertPassword);

            Button btnInsert = FindViewById<Button>(Resource.Id.btnInsert);

            btnInsert.Click += BtnInsert_Click;

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            Toast.MakeText(this, txtInsertUser.Text + " was inserted.", ToastLength.Short).Show();
            txtInsertUser.Text = "";
            txtPassword.Text = "";
            txtInsertUser.RequestFocus();

        }
    }
}