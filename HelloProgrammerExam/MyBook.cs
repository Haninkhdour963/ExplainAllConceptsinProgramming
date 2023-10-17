namespace HelloProgrammerExam
{
    // MyBook "implements" the IBook interface
    class MyBook : IBook
    {
        // The body of BookDescription() is provided here
        void IBook.BookDescription()
        {
            Console.WriteLine("My BookDescription is the Freedom for Palestine,History,Nutural and much more");
        }

        // The body of BookName() is provided here
        void IBook.BookName()
        {
            Console.WriteLine("Jerusalem is The Capital of Palestine");
        }
    }
}