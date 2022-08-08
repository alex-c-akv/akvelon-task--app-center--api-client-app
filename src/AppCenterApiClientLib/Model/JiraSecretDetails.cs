/* 
 * App Center Client
 *
 * Microsoft Visual Studio App Center API
 *
 * OpenAPI spec version: v0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AppCenterApiClientLib.Client.SwaggerDateConverter;

namespace AppCenterApiClientLib.Model
{
    /// <summary>
    /// Jira secret details
    /// </summary>
    [DataContract]
        public partial class JiraSecretDetails :  IEquatable<JiraSecretDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JiraSecretDetails" /> class.
        /// </summary>
        /// <param name="baseUrl">baseUrl to connect to jira instance (required).</param>
        /// <param name="username">username to connect to jira instance (required).</param>
        /// <param name="password">password to connect to jira instance (required).</param>
        public JiraSecretDetails(string baseUrl = default(string), string username = default(string), string password = default(string))
        {
            // to ensure "baseUrl" is required (not null)
            if (baseUrl == null)
            {
                throw new InvalidDataException("baseUrl is a required property for JiraSecretDetails and cannot be null");
            }
            else
            {
                this.BaseUrl = baseUrl;
            }
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for JiraSecretDetails and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for JiraSecretDetails and cannot be null");
            }
            else
            {
                this.Password = password;
            }
        }
        
        /// <summary>
        /// baseUrl to connect to jira instance
        /// </summary>
        /// <value>baseUrl to connect to jira instance</value>
        [DataMember(Name="baseUrl", EmitDefaultValue=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// username to connect to jira instance
        /// </summary>
        /// <value>username to connect to jira instance</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// password to connect to jira instance
        /// </summary>
        /// <value>password to connect to jira instance</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JiraSecretDetails {\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as JiraSecretDetails);
        }

        /// <summary>
        /// Returns true if JiraSecretDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of JiraSecretDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JiraSecretDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BaseUrl != null)
                    hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}