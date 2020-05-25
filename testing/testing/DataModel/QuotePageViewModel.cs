using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using testing.Data;

namespace testing.DataModel
{
    class QuotePageViewModel
    {
        public ObservableCollection<Quote> QuoteList { get; set; }

        public QuotePageViewModel()
        {
            QuoteList = new ObservableCollection<Quote>();
   
            QuoteList.Add(new Quote { Id = 0, Text = "There is only one Lord of the Ring, only one who can bend it to his will. And he does not share power - Gandalf", Image = "https://i2.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/fotr0645.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 1, Text = "That there's some good in this world, Mr. Frodo.. And it's worth fighting for - Sam", Image = "https://i1.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/ttt1662.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 2, Text = "Even the smallest person can change the course of the future - Galadriel", Image = "https://i1.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/fotr1360.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 3, Text = "The time of the Elves.. is over. Do we leage Middle-Earth to its fate? Do we let them stand alone? - Lady of the Wood", Image = "https://i1.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/ttt0993.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 4, Text = "We swears, to serve the master of the precious. We will swear on.. on the Precious! - Gollum", Image = "https://i2.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/ttt0055.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 5, Text = "I am Gandalf the White. And I come back to you now.. at the turn of the tide - Gandalf", Image = "https://i0.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/ttt0342.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 6, Text = "Oh, it's quite simple. If you are a friend, you speak the password, and the doors wil open - Gandalf", Image = "https://i1.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/fotr0984.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 7, Text = "Well, what can I tell you? Life in the wide world goes on much as it has this past Age, full of its own comings and goings, scarcely aware of the existence of Hobbits, for which I am very thankful - Gandalf", Image = "https://i0.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/fotr0077.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 8, Text = "For the time will soon come when Hobbits will shape the fortunes of all - Galadriel", Image = "https://i2.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/fotr0039.jpg?resize=346%2C145" });
            QuoteList.Add(new Quote { Id = 9, Text = "There is no curse in Elvish, Entish, or the tongues of Men for this treachery - Treebeard", Image = "https://i0.wp.com/www-images.theonering.org/torwp/wp-content/uploads/2012/05/ttt1510.jpg?resize=346%2C145" });
        }
    }
}
