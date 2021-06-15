using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Final_TechRecruit
{
    public partial class WDevPage : ContentPage
    {
        List<Recruitees> webDevRecruitees = new List<Recruitees>();
        List<Recruitees> webDevRecruiteesAZ = new List<Recruitees>();

        public WDevPage()
        {
            InitializeComponent();
            PopDevRec();
        }
        private void PopDevRec()
        {
            webDevRecruitees.Add(new Recruitees("Jackie", "Luis", "jackie.png", "Web Development", "den2070986@maricopa.edu", "Jackie Luis is finishing up her last semester at South Mountain Community College, graduating with an A.A.S in Web Development/ Graphic Design. With a focus on Developing, Jackie has taken courses in C#, PHP, MySQL, JavaScript, and HTML/CSS. She has previous work experience in education having worked as an Instructional Assistant for 2 years. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "South Mountain Community College", "Responsible | Analytical | Detail-Oriented", "C# | PHP | JavaScript |HTML | CSS", "phpMyAdmin"));
            webDevRecruitees.Add(new Recruitees("Harry", "Potter", "potter.jpg", "Web Development ", "potter@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Phoenix College", "Fast Learner | Strategic | Achiever", "Python | Java", ""));
            webDevRecruitees.Add(new Recruitees("Hermoine", "Granger", "hermione.png", "Web Development", "granger@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Phoenix College", "Trustworthy | Enthusiastic | Dedicated", "C# | Python", ""));
            webDevRecruitees.Add(new Recruitees("Draco", "Malfoy", "draco.jpg", "Web Development ", "malfoy@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Scottsdale Community College", "Team-Oriented | Communication | Responsible", "Javascript | C#", ""));
            webDevRecruitees.Add(new Recruitees("Ginny", "Weasley", "ginny.jpg", "Web Development", "gweasley@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Phoenix College", "Versatile | Determined | Strategic", "C# | JavaScript", ""));

            var items = from xyz in webDevRecruitees
                        orderby xyz.LastName + " " + xyz.FirstName
                        select xyz;
            foreach (Recruitees rec in items)
            {
                webDevRecruiteesAZ.Add(rec);
            }
            cvWD.ItemsSource = webDevRecruiteesAZ;
        }
        private async void SelectionMade(object sender, EventArgs e)
        {
            foreach (Recruitees match in webDevRecruiteesAZ)
            {
                if (match.FullName == cvWD.SelectedItem.ToString())
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

