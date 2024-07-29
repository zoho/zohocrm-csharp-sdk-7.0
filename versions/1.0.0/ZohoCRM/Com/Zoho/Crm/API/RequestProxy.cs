using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API
{
    /// <summary>
    /// This class represents the properties of proxy for the user.
    /// </summary>
    public class RequestProxy
	{
        private string host;
		private int port;
		private string userDomain;
		private string user;
		private string password;

		/// <summary>
		/// Creates a RequestProxy class instance with the specified parameters.
		/// </summary>
		/// <param name="host">A String containing the hostname or address of the proxy server</param>
		/// <param name="port">A Integer containing The port number of the proxy server</param>
		/// <param name="user">A String containing the user name of the proxy server</param>
		/// <param name="password">A String containing the password of the proxy server</param>
		/// <param name="userDomain">A String containing the domain of the proxy server</param>
		private RequestProxy(string host, int port, string user, string password, string userDomain)
		{
			this.host = host;
			this.port = port;
			this.userDomain = userDomain;
			this.user = user;
			this.password = password;
		}

		/// <summary>
		/// This is a getter method to get Proxy host.
		/// </summary>
		/// <returns>A String representing the host.</returns>
		public string Host
        {
            get
            {
				return host;
			}
        }

		/// <summary>
		/// This is a getter method to get Proxy port.
		/// </summary>
		/// <returns>A Integer representing the port.</returns>
		public int Port
		{
			get
			{
				return port;
			}
		}

		/// <summary>
		/// This is a getter method to get Proxy userDomain.
		/// </summary>
		/// <returns>A String representing the userDomain.</returns>
		public string UserDomain
		{
			get
			{
				return userDomain;
			}
		}

		/// <summary>
		/// This is a getter method to get Proxy user name.
		/// </summary>
		/// <returns>A String representing the user name.</returns>
		public string User
		{
			get
			{
				return user;
			}
		}

		/// <summary>
		/// This is a getter method to get Proxy password.
		/// </summary>
		/// <returns>A String representing the user password.</returns>
		public string Password
		{
			get
			{
				return password;
			}
		}

		public class Builder
        {
			private string host;
			private int port;
			private string userDomain;
			private string user;
			private string password = "";

			public Builder Host(string host)
            {
				Utility.AssertNotNull(host, Constants.REQUEST_PROXY_ERROR, Constants.HOST_ERROR_MESSAGE);
				this.host = host;
				return this;
			}

			public Builder Port(int port)
            {
				Utility.AssertNotNull(port, Constants.REQUEST_PROXY_ERROR, Constants.PORT_ERROR_MESSAGE);
				this.port = port;
				return this;
			}

			public Builder UserDomain(string userDomain)
            {
				this.userDomain = userDomain;
				return this;
            }

			public Builder User(string user)
			{
				this.user = user;
				return this;
			}

			public Builder Password(string password)
			{
				this.password = password;
				return this;
			}

			public RequestProxy Build()
            {
				Utility.AssertNotNull(host, Constants.REQUEST_PROXY_ERROR, Constants.HOST_ERROR_MESSAGE);
				Utility.AssertNotNull(port, Constants.REQUEST_PROXY_ERROR, Constants.PORT_ERROR_MESSAGE);
				return new RequestProxy(this.host, this.port, this.user, this.password, this.userDomain);
			}
		}
    }
}
