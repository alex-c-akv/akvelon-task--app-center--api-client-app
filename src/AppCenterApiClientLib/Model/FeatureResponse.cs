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
    /// FeatureResponse
    /// </summary>
    [DataContract]
        public partial class FeatureResponse :  IEquatable<FeatureResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureResponse" /> class.
        /// </summary>
        /// <param name="description">The description of the feature.</param>
        /// <param name="displayName">The friendly name of the feature (required).</param>
        /// <param name="name">The unique name of the feature (required).</param>
        /// <param name="state">The state (unset, enabled, disabled) of the feature (required).</param>
        /// <param name="createdAt">The creation date of the feature.</param>
        /// <param name="updatedAt">The date the feature was last updated at.</param>
        public FeatureResponse(string description = default(string), string displayName = default(string), string name = default(string), int? state = default(int?), string createdAt = default(string), string updatedAt = default(string))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for FeatureResponse and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for FeatureResponse and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for FeatureResponse and cannot be null");
            }
            else
            {
                this.State = state;
            }
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// The description of the feature
        /// </summary>
        /// <value>The description of the feature</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The friendly name of the feature
        /// </summary>
        /// <value>The friendly name of the feature</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The unique name of the feature
        /// </summary>
        /// <value>The unique name of the feature</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The state (unset, enabled, disabled) of the feature
        /// </summary>
        /// <value>The state (unset, enabled, disabled) of the feature</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public int? State { get; set; }

        /// <summary>
        /// The creation date of the feature
        /// </summary>
        /// <value>The creation date of the feature</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// The date the feature was last updated at
        /// </summary>
        /// <value>The date the feature was last updated at</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureResponse {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as FeatureResponse);
        }

        /// <summary>
        /// Returns true if FeatureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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