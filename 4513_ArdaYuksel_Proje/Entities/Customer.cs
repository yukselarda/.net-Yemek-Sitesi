namespace _4513_ArdaYuksel_Proje.Entities
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }


		public Customer() { 
         ID = Guid.NewGuid().ToString();
        }
	}
}
