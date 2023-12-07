namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Add(int id, string firstName, string lastName)
        {
            //if (id == null || firstName == null || lastName == null)
            //    throw new ArgumentNullException();
            Console.WriteLine("Added..");
        }

        public virtual void Update(int id, string firstName, string lastName)
        {
            //if (id == null || firstName == null || lastName == null)
            //    throw new ArgumentNullException();
            Console.WriteLine("Updated..");
        }
    }
}