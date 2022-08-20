namespace Getset
{
    public partial class Program
    {
        public static void Main()
        {
            //object for class
            var nitesh = new Customer();

            //accessing the method insted of field (encapsulation)
            nitesh.SetInfo(1, "nitesh");
            Console.WriteLine("Id: {0} Name: {1}",nitesh.GetId(), nitesh.GetName());
            
            

        }
    }
}