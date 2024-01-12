namespace LibraryManagement;

public class Book
{
    public Book(string title, string authure, string category)
    {
        Title = title;
        Authure = authure;
        Category = category;
    }
    public string Title { get; private set; }
    public string Authure { get; private set; }

    public string Category { get; private set; }


    public void Edit(string title, string authure, string category)
    {

        Title = title;
        Authure = authure;
        Category = category;
    }


}
