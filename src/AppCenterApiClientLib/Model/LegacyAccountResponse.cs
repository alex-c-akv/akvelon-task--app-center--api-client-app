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
    /// LegacyAccountResponse
    /// </summary>
    [DataContract]
        public partial class LegacyAccountResponse :  IEquatable<LegacyAccountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyAccountResponse" /> class.
        /// </summary>
        /// <param name="account">Object containing the account information..</param>
        public LegacyAccountResponse(Dictionary<string, LegacyAccountResponseAccount> account = default(Dictionary<string, LegacyAccountResponseAccount>))
        {
            this.Account = account;
        }
        
        /// <summary>
        /// Object containing the account information.
        /// </summary>
        /// <value>Object containing the account information.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Dictionary<string, LegacyAccountResponseAccount> Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyAccountResponse {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as LegacyAccountResponse);
        }

        /// <summary>
        /// Returns true if LegacyAccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyAccountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    this.Account != null &&
                    input.Account != null &&
                    this.Account.SequenceEqual(input.Account)
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
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
