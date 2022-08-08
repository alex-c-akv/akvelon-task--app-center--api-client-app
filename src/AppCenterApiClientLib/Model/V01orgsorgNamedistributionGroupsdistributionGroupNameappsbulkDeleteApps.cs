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
    /// V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps
    /// </summary>
    [DataContract]
        public partial class V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps :  IEquatable<V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps" /> class.
        /// </summary>
        /// <param name="name">The name of the app to be deleted from the distribution group (required).</param>
        public V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps(string name = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// The name of the app to be deleted from the distribution group
        /// </summary>
        /// <value>The name of the app to be deleted from the distribution group</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps);
        }

        /// <summary>
        /// Returns true if V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps instances are equal
        /// </summary>
        /// <param name="input">Instance of V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01orgsorgNamedistributionGroupsdistributionGroupNameappsbulkDeleteApps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
