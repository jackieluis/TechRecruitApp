using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Final_TechRecruit
{
    public partial class webDesPage : ContentPage
    {
        List<Recruitees> webDesRecruitees = new List<Recruitees>();
        List<Recruitees> webDesRecruiteesAZ = new List<Recruitees>();

        public webDesPage()
        {
            InitializeComponent();
            PopWebDes();
        }
        private void PopWebDes()
        {
            webDesRecruitees.Add(new Recruitees("Luna", "Lovegood", "luna.jpg", "Web Design", "lovegood@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Mesa/Dobson Community College", "Creative | Positivity | Versatile", "HTML | CSS", "Adobe Dreamweaver | Wix | Weebly"));
            webDesRecruitees.Add(new Recruitees("Cho", "Chang", "cho.jpg", "Web Design", "chang@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Chandler-Gilbert", "Communication | Dependable | Punctual", "HTML | CSS", "Adobe Photoshop | Adobe Premiere"));
            webDesRecruitees.Add(new Recruitees("Fleur", "Delacour", "fleur.jpg", "Web Design", "delacour@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Scottsdale Community College", "Flexible | Passionate | Reliable", "HTML | CSS", "Weebly | Adobe Illustrator"));
            webDesRecruitees.Add(new Recruitees("Dean", "Thomas", "dean.png", "Web Design", "dthomas@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Chandler-Gilbert", "Self-starter | Efficient | Organized", "HTML | CSS", "Adobe Dreamweaver | WordPress"));
            webDesRecruitees.Add(new Recruitees("Seamus", "Finnegan", "seamus.jpg", "Web Design", "finnegan@email.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi auctor sollicitudin ligula id convallis. Curabitur vitae placerat elit. Fusce tristique velit nec risus lobortis, lacinia posuere nulla viverra. Ut congue vehicula felis vel feugiat. Aenean sit amet massa dolor. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla sed mattis nibh. Nam et ante id libero lacinia tempus eget non purus. Nullam aliquet diam ligula, ac convallis dui sagittis vitae. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin quam mi, fermentum at est ac, ultricies pharetra ipsum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin cursus, dui a fringilla finibus, tortor neque efficitur elit, sed porta ligula diam eu nisi. Integer pretium placerat varius. Donec imperdiet dolor sed turpis viverra sagittis. Cras suscipit placerat nisi, ut cursus nisi ultrices et. Morbi eu mi nisl. Nullam in quam sed arcu consequat posuere. Morbi malesuada congue dapibus. Nam sagittis dui neque, a ornare elit aliquet sed. Integer eleifend luctus risus a tempus. In scelerisque lorem leo, non elementum erat commodo eget. Nam efficitur tellus sit amet porta viverra. Mauris pharetra, metus sit amet pellentesque fermentum, nulla odio tristique neque, quis lobortis est magna a massa.", "Chandler-Gilbert", "Collaborative | Creative | Communication", "HTML | CSS", "Adobe Illustrator | Wix | Weebly"));

            var items = from xyz in webDesRecruitees
                        orderby xyz.LastName + " " + xyz.FirstName
                        select xyz;
            foreach (Recruitees rec in items)
            {
                webDesRecruiteesAZ.Add(rec);
            }
            cvWebDes.ItemsSource = webDesRecruiteesAZ;
        }
        private async void SelectionMade(object sender, EventArgs e)
        {
            foreach (Recruitees match in webDesRecruiteesAZ)
            {
                if (match.FullName == cvWebDes.SelectedItem.ToString())
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
