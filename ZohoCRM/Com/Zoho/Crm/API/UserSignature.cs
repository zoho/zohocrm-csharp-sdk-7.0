using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API
{
    /// <summary>
    /// This class represents the user name.
    /// </summary>
    public class UserSignature
    {
        private string name;

        /// <summary>
        /// Creates an User class instance with the specified user name.
        /// </summary>
        /// <param name="name">A String containing the user name</param>
        public UserSignature(string name)
        {
            Utility.AssertNotNull(name, Constants.MANDATORY_VALUE_ERROR, Constants.MANDATORY_KEY_ERROR + " - " + Constants.NAME);
            this.name = name;
        }

        /// <summary>
        /// This is a getter method to get user name.
        /// </summary>
        /// <returns>A String representing the user name.</returns>
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
