using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Final_TechRecruit
{
    public partial class DatabaseDevPage : ContentPage
    {
        List<Recruitees> dataDevRecruitees = new List<Recruitees>();
        List<Recruitees> dataDevRecruiteesAZ = new List<Recruitees>();

        public DatabaseDevPage()
        {
            InitializeComponent();
            PopDataDev();
        }


        private void PopDataDev()
        {
            dataDevRecruitees.Add(new Recruitees("Ron", "Weasley", "ron.jpg", "Database Development", "rweasley@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Phoenix College", "Strategic | Problem-solving |Observant", " SQL | C# |PHP", "Microsoft Access | MySQL"));
            dataDevRecruitees.Add(new Recruitees("Fred", "Weasley", "fred.jpg", "Database Development", "fweasley@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "South Mountain Community College", "Punctual | Trustworthy | Patient", "PHP | Java", "SQL Server | phpMyAdmin"));
            dataDevRecruitees.Add(new Recruitees("Neville", "Longbottom", "neville.jpg", "Database Development", "longbottom@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Mesa/Dobson Community College", "Honesty | Determined | Hard-Working", "Java | C# | Python", ""));
            dataDevRecruitees.Add(new Recruitees("George", "Weasley", "george.jpg", "Database Development", "gweasley@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "South Mountain Community College", "Honesty | Learner | Focused", "SQL | Python", "MySQL | phpMyAdmin"));
            dataDevRecruitees.Add(new Recruitees("Vincent ", "Crabbe", "vincent.jpg", "Database Development", "crabbe@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Rio Salado", "Critical | Dependable | Reliable", "Java | Python", "MongoDB | phpMyAdmin"));
            dataDevRecruitees.Add(new Recruitees("Gregory", "Goyle", "gregory.jpg", "Database Development", "goyle@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Rio Salado", "Enterprising | Honest | Problem-solving ", "SQL | Java", "SQL Server | Microsoft Access"));

            var items = from xyz in dataDevRecruitees
                        orderby xyz.LastName + " " + xyz.FirstName
                        select xyz;
            foreach (Recruitees rec in items)
            {
                dataDevRecruiteesAZ.Add(rec);
            }
            cvDDev.ItemsSource = dataDevRecruiteesAZ;
        }

        private async void SelectionMade(object sender, EventArgs e)
        {
            foreach (Recruitees match in dataDevRecruiteesAZ)
            {
                if (match.FullName == cvDDev.SelectedItem.ToString())
                {
                    Recruitees selectedRecruitees = match;
                    await Navigation.PushModalAsync(new RecruiteeDetails(selectedRecruitees));
                    break;
                }
            }
        }
        private async void TRBanner_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
