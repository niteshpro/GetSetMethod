namespace Getset
{
    public partial class Program
    {
        public class Customer
        {
            private int Id;
            private string Name;
            public void SetInfo(int id, string name)
            {
                if (id != 0)
                {
                    this.Id = id;

                }
                if (!String.IsNullOrEmpty(name))
                {
                    this.Name = name;
                }
            }
            public int GetId()
            {
                return Id;
            }
            public string GetName()
            {
                return Name;
            }
                
        }
        
    }
}