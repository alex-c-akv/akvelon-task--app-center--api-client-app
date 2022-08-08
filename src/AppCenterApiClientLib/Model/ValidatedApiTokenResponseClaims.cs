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
    /// ValidatedApiTokenResponseClaims
    /// </summary>
    [DataContract]
        public partial class ValidatedApiTokenResponseClaims :  IEquatable<ValidatedApiTokenResponseClaims>, IValidatableObject
    {
        /// <summary>
        /// Defines ClaimType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ClaimTypeEnum
        {
            /// <summary>
            /// Enum Useremail for value: user_email
            /// </summary>
            [EnumMember(Value = "user_email")]
            Useremail = 1,
            /// <summary>
            /// Enum Userorigin for value: user_origin
            /// </summary>
            [EnumMember(Value = "user_origin")]
            Userorigin = 2,
            /// <summary>
            /// Enum Appownername for value: app_owner_name
            /// </summary>
            [EnumMember(Value = "app_owner_name")]
            Appownername = 3,
            /// <summary>
            /// Enum Appname for value: app_name
            /// </summary>
            [EnumMember(Value = "app_name")]
            Appname = 4,
            /// <summary>
            /// Enum Apporigin for value: app_origin
            /// </summary>
            [EnumMember(Value = "app_origin")]
            Apporigin = 5,
            /// <summary>
            /// Enum Appos for value: app_os
            /// </summary>
            [EnumMember(Value = "app_os")]
            Appos = 6,
            /// <summary>
            /// Enum Appplatform for value: app_platform
            /// </summary>
            [EnumMember(Value = "app_platform")]
            Appplatform = 7,
            /// <summary>
            /// Enum Appsecret for value: app_secret
            /// </summary>
            [EnumMember(Value = "app_secret")]
            Appsecret = 8        }
        /// <summary>
        /// Gets or Sets ClaimType
        /// </summary>
        [DataMember(Name="claim_type", EmitDefaultValue=false)]
        public ClaimTypeEnum? ClaimType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedApiTokenResponseClaims" /> class.
        /// </summary>
        /// <param name="claimType">claimType.</param>
        /// <param name="claimValue">claimValue.</param>
        public ValidatedApiTokenResponseClaims(ClaimTypeEnum? claimType = default(ClaimTypeEnum?), string claimValue = default(string))
        {
            this.ClaimType = claimType;
            this.ClaimValue = claimValue;
        }
        

        /// <summary>
        /// Gets or Sets ClaimValue
        /// </summary>
        [DataMember(Name="claim_value", EmitDefaultValue=false)]
        public string ClaimValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidatedApiTokenResponseClaims {\n");
            sb.Append("  ClaimType: ").Append(ClaimType).Append("\n");
            sb.Append("  ClaimValue: ").Append(ClaimValue).Append("\n");
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
            return this.Equals(input as ValidatedApiTokenResponseClaims);
        }

        /// <summary>
        /// Returns true if ValidatedApiTokenResponseClaims instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidatedApiTokenResponseClaims to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidatedApiTokenResponseClaims input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClaimType == input.ClaimType ||
                    (this.ClaimType != null &&
                    this.ClaimType.Equals(input.ClaimType))
                ) && 
                (
                    this.ClaimValue == input.ClaimValue ||
                    (this.ClaimValue != null &&
                    this.ClaimValue.Equals(input.ClaimValue))
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
                if (this.ClaimType != null)
                    hashCode = hashCode * 59 + this.ClaimType.GetHashCode();
                if (this.ClaimValue != null)
                    hashCode = hashCode * 59 + this.ClaimValue.GetHashCode();
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
