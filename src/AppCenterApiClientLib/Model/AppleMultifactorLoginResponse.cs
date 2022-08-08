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
    /// The response of Multifactor login. This is a 30 day session token generated by apple.
    /// </summary>
    [DataContract]
        public partial class AppleMultifactorLoginResponse :  IEquatable<AppleMultifactorLoginResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleMultifactorLoginResponse" /> class.
        /// </summary>
        /// <param name="username">the apple developer account..</param>
        /// <param name="cookie">The 30-day session Token generated by apple after successfully logging in with Multifactor authentication..</param>
        /// <param name="expires">The expiry date of the cookie generated by apple.</param>
        public AppleMultifactorLoginResponse(string username = default(string), string cookie = default(string), string expires = default(string))
        {
            this.Username = username;
            this.Cookie = cookie;
            this.Expires = expires;
        }
        
        /// <summary>
        /// the apple developer account.
        /// </summary>
        /// <value>the apple developer account.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The 30-day session Token generated by apple after successfully logging in with Multifactor authentication.
        /// </summary>
        /// <value>The 30-day session Token generated by apple after successfully logging in with Multifactor authentication.</value>
        [DataMember(Name="cookie", EmitDefaultValue=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// The expiry date of the cookie generated by apple
        /// </summary>
        /// <value>The expiry date of the cookie generated by apple</value>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleMultifactorLoginResponse {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Cookie: ").Append(Cookie).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
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
            return this.Equals(input as AppleMultifactorLoginResponse);
        }

        /// <summary>
        /// Returns true if AppleMultifactorLoginResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleMultifactorLoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleMultifactorLoginResponse input)
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
                    this.Cookie == input.Cookie ||
                    (this.Cookie != null &&
                    this.Cookie.Equals(input.Cookie))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
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
                if (this.Cookie != null)
                    hashCode = hashCode * 59 + this.Cookie.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
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