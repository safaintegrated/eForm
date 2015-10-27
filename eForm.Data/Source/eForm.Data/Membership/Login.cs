using eForm.Data.Device;

namespace eForm.Data.Membership
{
    public class Login: BaseEntity
    {
        //login
        public string Username { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public bool Locked { get; set; }

        public bool Activated { get; set; }

        //foreign key
        public int AccountId { get; set; }

        public int MachineId { get; set; }

        //relationships
        public virtual Account Account { get; set; }

        public virtual Machine Machine { get; set; }

    }
}
