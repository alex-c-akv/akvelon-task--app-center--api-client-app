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
    /// UserProfileResponseManagement
    /// </summary>
    [DataContract]
        public partial class UserProfileResponseManagement :  IEquatable<UserProfileResponseManagement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileResponseManagement" /> class.
        /// </summary>
        /// <param name="updatedAt">The date when the app was last updated.</param>
        /// <param name="verified">A boolean flag that indicates if the user is already verified.</param>
        /// <param name="identityProviders">The identity providers associated with the user&#x27;s account.</param>
        public UserProfileResponseManagement(string updatedAt = default(string), bool? verified = default(bool?), List<UserProfileResponseManagementIdentityProviders> identityProviders = default(List<UserProfileResponseManagementIdentityProviders>))
        {
            this.UpdatedAt = updatedAt;
            this.Verified = verified;
            this.IdentityProviders = identityProviders;
        }
        
        /// <summary>
        /// The date when the app was last updated
        /// </summary>
        /// <value>The date when the app was last updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// A boolean flag that indicates if the user is already verified
        /// </summary>
        /// <value>A boolean flag that indicates if the user is already verified</value>
        [DataMember(Name="verified", EmitDefaultValue=false)]
        public bool? Verified { get; set; }

        /// <summary>
        /// The identity providers associated with the user&#x27;s account
        /// </summary>
        /// <value>The identity providers associated with the user&#x27;s account</value>
        [DataMember(Name="identity_providers", EmitDefaultValue=false)]
        public List<UserProfileResponseManagementIdentityProviders> IdentityProviders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileResponseManagement {\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
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
            return this.Equals(input as UserProfileResponseManagement);
        }

        /// <summary>
        /// Returns true if UserProfileResponseManagement instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileResponseManagement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileResponseManagement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
                ) && 
                (
                    this.IdentityProviders == input.IdentityProviders ||
                    this.IdentityProviders != null &&
                    input.IdentityProviders != null &&
                    this.IdentityProviders.SequenceEqual(input.IdentityProviders)
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
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
                if (this.IdentityProviders != null)
                    hashCode = hashCode * 59 + this.IdentityProviders.GetHashCode();
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