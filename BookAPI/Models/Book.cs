using System;
namespace BookAPI.Models
{
    public class Book
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public string ISBN10 { get; private set; }
        public string ISBN13 { get; private set; }


        /// <summary>
        /// Construct book object using values specified by caller
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="title">Title.</param>
        /// <param name="isbn10">Isbn10.</param>
        /// <param name="isbn13">Isbn13.</param>
        public Book(int id, string title, string isbn10, string isbn13)
        {
            ID = id;
            Title = title;
            ISBN10 = isbn10;
            ISBN13 = isbn13;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
