using System.Runtime.CompilerServices;

namespace DevTest.Blazor.Models
{
    public class MobilePhone
    {
        public int dialingCountryCode { get; set; }
        public string phoneNumber { get; set; }
    }

    public class Phone
    {
        public int dialingCountryCode { get; set; }
        public string phoneNumber { get; set; }
    }

    public class ProfileModel
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool firstLogin { get; set; }
        public MobilePhone mobilePhone { get; set; }
        public Phone phone { get; set; }
        public string companyName { get; set; }


		public override string ToString()
		{
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}

	}


}
