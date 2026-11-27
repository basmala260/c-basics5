namespace c_basics5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region question1
            //Book b = new Book();
            ////can't access private outside the class
            //// Console.WriteLine(b.);
            //#endregion
            //==========================================//
            //#region question2
            ////acess within project
            //Book b = new Book();
            //Console.WriteLine(b.copiesInStock);
            //#endregion
            //==========================================//
            //#region question3
            //Book b = new Book();
            //b.Title = "....";
            //Console.WriteLine(b.Title);
            //#endregion
            //=============================================//
            //#region question4
            //Book b = new Book();
            //b.book_genre = Genre.Science;
            //Console.WriteLine(b.book_genre);
            //#endregion
            //=============================================//
            //#region question5
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            //#endregion
            //=================================================//
            //#region question6
            //int genreNumber = 1;
            //Genre genreString = (Genre)genreNumber;
            //Console.WriteLine(genreString);
            //#endregion
            //================================================//
            //#region question7
            //Genre genre = Genre.Fiction;
            //String stringGenre = genre.ToString();
            //Console.WriteLine(stringGenre);
            //#endregion
            //==============================================//
            #region question8
            string genreText = "Science";
            Genre genre = Enum.Parse<Genre>(genreText);
            Console.WriteLine(genre);
            #endregion
        }
    }
}
