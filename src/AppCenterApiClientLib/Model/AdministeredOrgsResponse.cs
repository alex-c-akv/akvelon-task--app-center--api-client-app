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
    /// AdministeredOrgsResponse
    /// </summary>
    [DataContract]
        public partial class AdministeredOrgsResponse :  IEquatable<AdministeredOrgsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministeredOrgsResponse" /> class.
        /// </summary>
        /// <param name="organizations">organizations (required).</param>
        public AdministeredOrgsResponse(V01invitationssentOrganization organizations = default(V01invitationssentOrganization))
        {
            // to ensure "organizations" is required (not null)
            if (organizations == null)
            {
                throw new InvalidDataException("organizations is a required property for AdministeredOrgsResponse and cannot be null");
            }
            else
            {
                this.Organizations = organizations;
            }
        }
        
        /// <summary>
        /// Gets or Sets Organizations
        /// </summary>
        [DataMember(Name="organizations", EmitDefaultValue=false)]
        public V01invitationssentOrganization Organizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdministeredOrgsResponse {\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
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
            return this.Equals(input as AdministeredOrgsResponse);
        }

        /// <summary>
        /// Returns true if AdministeredOrgsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AdministeredOrgsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdministeredOrgsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Organizations == input.Organizations ||
                    (this.Organizations != null &&
                    this.Organizations.Equals(input.Organizations))
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
                if (this.Organizations != null)
                    hashCode = hashCode * 59 + this.Organizations.GetHashCode();
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
