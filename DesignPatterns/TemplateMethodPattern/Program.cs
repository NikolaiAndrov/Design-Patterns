namespace TemplateMethodPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            coffee.Prepare();

            Tea tea = new Tea();
            tea.Prepare();

            Camomile camomile = new Camomile();
            camomile.Prepare();
        }
    }
}
