using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Final_TechRecruit
{
    public partial class RecruiteeDetails : ContentPage
    {
        string recEmail;
        public RecruiteeDetails(Recruitees rec)
        {
            InitializeComponent();
            recImage.Source = rec.ImageURL;
            fullName.Text = rec.FullName;
            recStrengths.Text = "Strengths: " + rec.Strengths;
            recBio.Text = rec.Biography + "\n\n";
            recEmail = rec.Email;
            recLanguages.Text = rec.Languages;
            recSoftware.Text = rec.Software;
            recDegree.Text = rec.Degree;
            recSchool.Text = rec.SchoolAttended;

        }
        private async void TRBanner_Tapped(Object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        private async void EmailTheRec(Object sender, EventArgs e)
        {
            _ = await Launcher.TryOpenAsync("mailto:" + recEmail);
        }
    }
}
