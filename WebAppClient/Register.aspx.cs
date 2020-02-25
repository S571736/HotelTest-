﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;
using System.Windows;

namespace WebFormsIdentity
{
    public partial class Register : System.Web.UI.Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            // Default UserStore constructor uses the default connection string named: DefaultConnection
            //var userStore = new UserStore<IdentityUser>();
            //var manager = new UserManager<IdentityUser>(userStore);

         


            //var user = new IdentityUser() { UserName = UserName.Text };
            //IdentityResult result = manager.Create(user, Password.Text);

            //if (result.Succeeded)
            //{
                // StatusMessage.Text = string.Format("User {0} was created successfully!", user.UserName);


                // create session 

                Session["id"] = 1234;
                Session["name"] = UserName.Text;

                Response.Write(Session["id"]);
                Response.Write(Session["name"]);


            StatusMessage.Text = string.Format("User {0} was created!", UserName.Text);


            MessageBox.Show(StatusMessage.Text);

            //add to DB


            //redirect

            Response.Redirect("UserEntryPage.aspx");
            //}
            //else
            //{
            //    StatusMessage.Text = result.Errors.FirstOrDefault();
            //}
        }
    }
}