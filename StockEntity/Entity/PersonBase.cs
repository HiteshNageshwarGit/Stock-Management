using StockEntity.Helper;
using System.Text.RegularExpressions;

namespace StockEntity.Entity
{
    public class PersonBase : BaseEntity
    {
        public const string DEFAULT_NAME = "Default";
        public const int DEALER = 1;
        public const int CUSTOMER = 2;

        #region Entity Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        #endregion

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Name is required";
            }
            else if (Name.Length > 50)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Max length of Name can be 50 charectors";
            }

            if (string.IsNullOrWhiteSpace(Address))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Address is required";
            }
            else if (Address.Length > 50)
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Max length of Address can be 50 charectors";
            }

            if (!string.IsNullOrWhiteSpace(Mobile) && !Regex.IsMatch(Mobile, @"\+?[0-9]{10}"))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Mobile No. can have 10 digits only";
            }

            if (!string.IsNullOrWhiteSpace(Email) && !IsValidEmail(Email))
            {
                EntityState.State = ValidationState.ERROR;
                EntityState.StateMessage += "\n Eamil is not valid";
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}