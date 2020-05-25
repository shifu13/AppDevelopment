using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using testing.Data;

namespace testing.DataModel
{
    class MoviePageViewModel
    {
        public ObservableCollection<Movie> MovieList { get; set; }
        public MoviePageViewModel()
        {
            MovieList = new ObservableCollection<Movie>();
            
            MovieList.Add(new Movie { Id = 0, Name = "The Lord of the Rings: The fellowship of the Ring", Resume = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron", Director = "Peter Jackson", Writers = "J.R.R Tolkien (novel)", Image= "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SY999_CR0,0,673,999_AL_.jpg" });
            MovieList.Add(new Movie { Id = 1, Name = "The Lord of the Rings: The Two Towers", Resume = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard", Director = "Peter Jackson", Writers = "J.R.R Tolkien (novel)", Image= "https://m.media-amazon.com/images/M/MV5BNGE5MzIyNTAtNWFlMC00NDA2LWJiMjItMjc4Yjg1OWM5NzhhXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,684,1000_AL_.jpg" });
            MovieList.Add(new Movie { Id = 2, Name = "The Lord of the Rings: The Return of the King", Resume = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring", Director = "Peter Jackson", Writers = "J.R.R Tolken (novel)", Image= "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,675,1000_AL_.jpg" });
        }
    }
}
