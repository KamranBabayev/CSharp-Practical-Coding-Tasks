using _04_LibraryManagement.Models;
namespace LibraryManagement;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 4.
        //Book class: Name, Author, PageCount (private set)
        //PageCount< 1 olarsa exception atılsın
        //Library class: List<Book> saxlasın
        //AddBook() — eyni adlı kitab varsa əlavə etməsin
        //FindBookByAuthor() — dövrlə yazılsın
        //Main(): 5 kitab əlavə et, müəllifə görə axtar.



        Library library = new Library();
        library.AddBook(new Book("1984", "George Orwell", 328));
        library.AddBook(new Book("Sefiller", "Victor Hugo", 1200));
        library.AddBook(new Book("Cinayet ve Ceza", "Dostoyevski", 671));
        library.AddBook(new Book("Simyaci", "Paulo Coelho", 208));
        library.AddBook(new Book("Kurk Mantolu Madonna", "Sabahattin Ali", 160));
        library.FindBookByAuthor("George Orwell");

    }
}
