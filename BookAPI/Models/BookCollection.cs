namespace BookAPI.Models
{
    public static class BookCollection
    {
        public static Book[] BookArray { get; private set; }

        /// <summary>
        /// Populates the books into the array.
        /// </summary>
        public static void PopulateBooks()
        {
            if (BookArray != null) return;
            
            //if the array has not been populated already then we should populate it
            BookArray = new Book[2];

            Book lotr = new Book(1, "Lord of the Rings", "9780544003415", "978-0544003415");
            Book hobbit = new Book(2, "The Hobbit", "054792822X", "978-0547928227");

            BookArray[0] = lotr;
            BookArray[1] = hobbit;
        }

        public static Book GetBook(int id)
        {
            //if we try to access a book ID that is greater than than the array length then we should just return null.
            //same if we try to go below 1.
            if (id > BookArray.Length || id < 1) return null;

            //subtract one due to arrays being zero based while API is not
            Book returnBook = BookArray[id - 1];

            return returnBook;
        }
    }
}