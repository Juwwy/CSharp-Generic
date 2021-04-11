namespace IntergenicResearchLibraryTest
{
    public class Library : IDefaulterList
    {
        public string FullName { get; set; }
        public int Year { get; set; }

        public string BookName { get; set; }
        public int BookId { get; set; }
        public Date DateIssue { get; set; }

        public Date DateReturned { get; set; }

        public Library(string fullName, int year, string bookName, int bookId, Date dateIssue, Date dateReturned)
        {
            FullName = fullName;
            Year = year;
            BookName = bookName;
            BookId = bookId;
            DateIssue = dateIssue;
            DateReturned = dateReturned;
        }

         public string  GetName()
        {
            return FullName;
        }

        public int GetYear()
        {
            return Year;
        }

        public string  GetBook()
        {
            return $"{BookName} with ID {BookId}";
        }

        public Date  GetDateIssue()
        {
            return DateIssue;
        }

        public Date  GetDateReturned()
        {
            return DateReturned;
        }

        public string  GetDefaulter()
        {
            return $"Defaulter List:\n{FullName} {BookName} {BookId}";
        }
        public override string ToString()
        {
            return $"Student Name: {FullName}\nWorking Year: {Year}\nBook Name: {BookName}\nBook Id: {BookId}\nDate issued: {DateIssue}\nDate to be return: {DateReturned}\n";
        }
    }
}