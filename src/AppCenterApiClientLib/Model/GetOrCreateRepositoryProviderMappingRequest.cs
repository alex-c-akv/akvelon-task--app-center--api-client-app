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
    /// GetOrCreateRepositoryProviderMappingRequest
    /// </summary>
    [DataContract]
        public partial class GetOrCreateRepositoryProviderMappingRequest :  IEquatable<GetOrCreateRepositoryProviderMappingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrCreateRepositoryProviderMappingRequest" /> class.
        /// </summary>
        /// <param name="externalAccountName">The account name given by the external provider. If provided, create an organization and the mapping. If not, create mapping with user..</param>
        public GetOrCreateRepositoryProviderMappingRequest(string externalAccountName = default(string))
        {
            this.ExternalAccountName = externalAccountName;
        }
        
        /// <summary>
        /// The account name given by the external provider. If provided, create an organization and the mapping. If not, create mapping with user.
        /// </summary>
        /// <value>The account name given by the external provider. If provided, create an organization and the mapping. If not, create mapping with user.</value>
        [DataMember(Name="external_account_name", EmitDefaultValue=false)]
        public string ExternalAccountName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetOrCreateRepositoryProviderMappingRequest {\n");
            sb.Append("  ExternalAccountName: ").Append(ExternalAccountName).Append("\n");
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
            return this.Equals(input as GetOrCreateRepositoryProviderMappingRequest);
        }

        /// <summary>
        /// Returns true if GetOrCreateRepositoryProviderMappingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetOrCreateRepositoryProviderMappingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetOrCreateRepositoryProviderMappingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalAccountName == input.ExternalAccountName ||
                    (this.ExternalAccountName != null &&
                    this.ExternalAccountName.Equals(input.ExternalAccountName))
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
                if (this.ExternalAccountName != null)
                    hashCode = hashCode * 59 + this.ExternalAccountName.GetHashCode();
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
