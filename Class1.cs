using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Movies
    {
        #region fields
        private string name;
        private string category;
        private string rating;
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        #endregion

        #region constructors
        
        public Movies()
        {

        }
        public Movies(string Name, string Category, string Rating)
        {
            name = Name;
            category = Category;
            rating = Rating;
        }
        #endregion

        #region Methods
        public void PrintOff()
        {
            Console.WriteLine($"{Name} is a(n) {Category} movie with a(n) {Rating} rating");
        }
        #endregion



    }
}
