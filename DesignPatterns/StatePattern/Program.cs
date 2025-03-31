namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document(Enums.UserRoles.Editor);
            Console.WriteLine(document.State);

            document.Publish();
            Console.WriteLine(document.State);

            Document documentTwo = new Document(Enums.UserRoles.Admin);
            Console.WriteLine(documentTwo.State);

            documentTwo.Publish();
            Console.WriteLine(documentTwo.State);

            documentTwo.Publish();
            Console.WriteLine(documentTwo.State);
        }
    }
}
