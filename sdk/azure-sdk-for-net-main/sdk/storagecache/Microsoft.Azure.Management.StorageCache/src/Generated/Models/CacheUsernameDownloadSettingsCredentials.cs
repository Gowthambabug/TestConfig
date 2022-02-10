// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// When present, these are the credentials for the secure LDAP connection.
    /// </summary>
    public partial class CacheUsernameDownloadSettingsCredentials
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CacheUsernameDownloadSettingsCredentials class.
        /// </summary>
        public CacheUsernameDownloadSettingsCredentials()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CacheUsernameDownloadSettingsCredentials class.
        /// </summary>
        /// <param name="bindDn">The Bind Distinguished Name identity to be
        /// used in the secure LDAP connection. This value is stored encrypted
        /// and not returned on response.</param>
        /// <param name="bindPassword">The Bind password to be used in the
        /// secure LDAP connection. This value is stored encrypted and not
        /// returned on response.</param>
        public CacheUsernameDownloadSettingsCredentials(string bindDn = default(string), string bindPassword = default(string))
        {
            BindDn = bindDn;
            BindPassword = bindPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Bind Distinguished Name identity to be used in the
        /// secure LDAP connection. This value is stored encrypted and not
        /// returned on response.
        /// </summary>
        [JsonProperty(PropertyName = "bindDn")]
        public string BindDn { get; set; }

        /// <summary>
        /// Gets or sets the Bind password to be used in the secure LDAP
        /// connection. This value is stored encrypted and not returned on
        /// response.
        /// </summary>
        [JsonProperty(PropertyName = "bindPassword")]
        public string BindPassword { get; set; }

    }
}