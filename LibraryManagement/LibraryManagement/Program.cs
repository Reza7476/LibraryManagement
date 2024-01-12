
using LibraryManagement;

Management Managemnt = new Management();
while (true)
{
    try
    {
        int exe = Managemnt.Run();
        switch (exe)
        {
            case 0:
                {
                    Environment.Exit(0);
                    break;
                }

            case 1:
                {

                    var categoryName = Managemnt.GetString("enter category name");
                    Managemnt.SetCategory(categoryName);
                    break;
                }
            case 2:
                {
                    var bookTitle = Managemnt.GetString("enter book's name");
                    var bookCategory = Managemnt.GetString("enter book category");
                    var bookAuthure = Managemnt.GetString("enter book's authure");
                    Managemnt.AddNewBook(bookCategory, bookTitle, bookAuthure);

                    break;
                }

            case 3:
                {

                    Managemnt.DisplayBooks();
                    break;
                }
            case 4:
                {
                    var bookName = Managemnt.GetString("enter book name");
                    var oldBook = Managemnt.GetBook(bookName);
                    Managemnt.EditBookNameAndAuther(oldBook);

                    break;
                }

            case 5:
                {

                    var bookName = Managemnt.GetString("enter book name");
                    Managemnt.RemoveBook(bookName);
                    break;
                }
            case 6:
                {

                    var bookName = Managemnt.GetString("enter book name");
                    Managemnt.Displaydetails(bookName);
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
    catch (Exception ex)
    {

        Managemnt.Error(ex.Message);
    }
}