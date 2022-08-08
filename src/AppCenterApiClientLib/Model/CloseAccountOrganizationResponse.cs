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
    /// CloseAccountOrganizationResponse
    /// </summary>
    [DataContract]
        public partial class CloseAccountOrganizationResponse :  IEquatable<CloseAccountOrganizationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloseAccountOrganizationResponse" /> class.
        /// </summary>
        /// <param name="collaboratorsCount">The number of collaborators from the organization.</param>
        public CloseAccountOrganizationResponse(decimal? collaboratorsCount = default(decimal?))
        {
            this.CollaboratorsCount = collaboratorsCount;
        }
        
        /// <summary>
        /// The number of collaborators from the organization
        /// </summary>
        /// <value>The number of collaborators from the organization</value>
        [DataMember(Name="collaborators_count", EmitDefaultValue=false)]
        public decimal? CollaboratorsCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloseAccountOrganizationResponse {\n");
            sb.Append("  CollaboratorsCount: ").Append(CollaboratorsCount).Append("\n");
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
            return this.Equals(input as CloseAccountOrganizationResponse);
        }

        /// <summary>
        /// Returns true if CloseAccountOrganizationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CloseAccountOrganizationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloseAccountOrganizationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollaboratorsCount == input.CollaboratorsCount ||
                    (this.CollaboratorsCount != null &&
                    this.CollaboratorsCount.Equals(input.CollaboratorsCount))
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
                if (this.CollaboratorsCount != null)
                    hashCode = hashCode * 59 + this.CollaboratorsCount.GetHashCode();
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