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
    /// Apple secret details
    /// </summary>
    [DataContract]
        public partial class AppleSecretDetails :  IEquatable<AppleSecretDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleSecretDetails" /> class.
        /// </summary>
        /// <param name="username">username to connect to apple store..</param>
        /// <param name="authCode">6 digit auth code.</param>
        /// <param name="password">password to connect to apple store..</param>
        public AppleSecretDetails(string username = default(string), string authCode = default(string), string password = default(string))
        {
            this.Username = username;
            this.AuthCode = authCode;
            this.Password = password;
        }
        
        /// <summary>
        /// username to connect to apple store.
        /// </summary>
        /// <value>username to connect to apple store.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// 6 digit auth code
        /// </summary>
        /// <value>6 digit auth code</value>
        [DataMember(Name="authCode", EmitDefaultValue=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// password to connect to apple store.
        /// </summary>
        /// <value>password to connect to apple store.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleSecretDetails {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
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
            return this.Equals(input as AppleSecretDetails);
        }

        /// <summary>
        /// Returns true if AppleSecretDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleSecretDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleSecretDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AuthCode != null)
                    hashCode = hashCode * 59 + this.AuthCode.GetHashCode();
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
