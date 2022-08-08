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
    /// AADGroup
    /// </summary>
    [DataContract]
        public partial class AADGroup :  IEquatable<AADGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AADGroup" /> class.
        /// </summary>
        /// <param name="aadGroupId">The id of the aad group (required).</param>
        /// <param name="tenantId">The id of the aad tenant (required).</param>
        /// <param name="displayName">The display name of the aad group (required).</param>
        public AADGroup(Guid? aadGroupId = default(Guid?), Guid? tenantId = default(Guid?), string displayName = default(string))
        {
            // to ensure "aadGroupId" is required (not null)
            if (aadGroupId == null)
            {
                throw new InvalidDataException("aadGroupId is a required property for AADGroup and cannot be null");
            }
            else
            {
                this.AadGroupId = aadGroupId;
            }
            // to ensure "tenantId" is required (not null)
            if (tenantId == null)
            {
                throw new InvalidDataException("tenantId is a required property for AADGroup and cannot be null");
            }
            else
            {
                this.TenantId = tenantId;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for AADGroup and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
        }
        
        /// <summary>
        /// The id of the aad group
        /// </summary>
        /// <value>The id of the aad group</value>
        [DataMember(Name="aad_group_id", EmitDefaultValue=false)]
        public Guid? AadGroupId { get; set; }

        /// <summary>
        /// The id of the aad tenant
        /// </summary>
        /// <value>The id of the aad tenant</value>
        [DataMember(Name="tenant_id", EmitDefaultValue=false)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// The display name of the aad group
        /// </summary>
        /// <value>The display name of the aad group</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AADGroup {\n");
            sb.Append("  AadGroupId: ").Append(AadGroupId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as AADGroup);
        }

        /// <summary>
        /// Returns true if AADGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of AADGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AADGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AadGroupId == input.AadGroupId ||
                    (this.AadGroupId != null &&
                    this.AadGroupId.Equals(input.AadGroupId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.AadGroupId != null)
                    hashCode = hashCode * 59 + this.AadGroupId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
