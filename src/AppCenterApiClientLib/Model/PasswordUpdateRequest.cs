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
    /// PasswordUpdateRequest
    /// </summary>
    [DataContract]
        public partial class PasswordUpdateRequest :  IEquatable<PasswordUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordUpdateRequest" /> class.
        /// </summary>
        /// <param name="newPassword">The new password that will be set for the user. Needs to be at least 8 characters long and contain at least one lower- and one uppercase letter. (required).</param>
        /// <param name="oldPassword">The old password, if needed..</param>
        public PasswordUpdateRequest(string newPassword = default(string), string oldPassword = default(string))
        {
            // to ensure "newPassword" is required (not null)
            if (newPassword == null)
            {
                throw new InvalidDataException("newPassword is a required property for PasswordUpdateRequest and cannot be null");
            }
            else
            {
                this.NewPassword = newPassword;
            }
            this.OldPassword = oldPassword;
        }
        
        /// <summary>
        /// The new password that will be set for the user. Needs to be at least 8 characters long and contain at least one lower- and one uppercase letter.
        /// </summary>
        /// <value>The new password that will be set for the user. Needs to be at least 8 characters long and contain at least one lower- and one uppercase letter.</value>
        [DataMember(Name="new_password", EmitDefaultValue=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// The old password, if needed.
        /// </summary>
        /// <value>The old password, if needed.</value>
        [DataMember(Name="old_password", EmitDefaultValue=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordUpdateRequest {\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
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
            return this.Equals(input as PasswordUpdateRequest);
        }

        /// <summary>
        /// Returns true if PasswordUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
                ) && 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
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
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
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