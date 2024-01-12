namespace LibraryManagement;

public interface ILibrary
{

    void RemoveBook(string bookName);
    void Displaydetails(string bookName);
    void EditBookAuthure(string oldBookName, string newAuthure);
    void EditBookName(string oldBookName, string newBookName);

}