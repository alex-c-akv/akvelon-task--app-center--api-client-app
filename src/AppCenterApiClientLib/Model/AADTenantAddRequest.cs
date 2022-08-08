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
    /// AADTenantAddRequest
    /// </summary>
    [DataContract]
        public partial class AADTenantAddRequest :  IEquatable<AADTenantAddRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AADTenantAddRequest" /> class.
        /// </summary>
        /// <param name="userId">The user wanting to add this tenant to the organization, must be an admin of the organization (required).</param>
        /// <param name="aadTenantId">The AAD tenant id (required).</param>
        /// <param name="displayName">The name of the AAD Tenant (required).</param>
        public AADTenantAddRequest(Guid? userId = default(Guid?), Guid? aadTenantId = default(Guid?), string displayName = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for AADTenantAddRequest and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }
            // to ensure "aadTenantId" is required (not null)
            if (aadTenantId == null)
            {
                throw new InvalidDataException("aadTenantId is a required property for AADTenantAddRequest and cannot be null");
            }
            else
            {
                this.AadTenantId = aadTenantId;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for AADTenantAddRequest and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
        }
        
        /// <summary>
        /// The user wanting to add this tenant to the organization, must be an admin of the organization
        /// </summary>
        /// <value>The user wanting to add this tenant to the organization, must be an admin of the organization</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The AAD tenant id
        /// </summary>
        /// <value>The AAD tenant id</value>
        [DataMember(Name="aad_tenant_id", EmitDefaultValue=false)]
        public Guid? AadTenantId { get; set; }

        /// <summary>
        /// The name of the AAD Tenant
        /// </summary>
        /// <value>The name of the AAD Tenant</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AADTenantAddRequest {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AadTenantId: ").Append(AadTenantId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as AADTenantAddRequest);
        }

        /// <summary>
        /// Returns true if AADTenantAddRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AADTenantAddRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AADTenantAddRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AadTenantId == input.AadTenantId ||
                    (this.AadTenantId != null &&
                    this.AadTenantId.Equals(input.AadTenantId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AadTenantId != null)
                    hashCode = hashCode * 59 + this.AadTenantId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
