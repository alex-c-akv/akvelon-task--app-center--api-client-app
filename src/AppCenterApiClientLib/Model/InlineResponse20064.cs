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
    /// InlineResponse20064
    /// </summary>
    [DataContract]
        public partial class InlineResponse20064 :  IEquatable<InlineResponse20064>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20064" /> class.
        /// </summary>
        /// <param name="hasCrashes">hasCrashes (required).</param>
        /// <param name="features">features (required).</param>
        public InlineResponse20064(bool? hasCrashes = default(bool?), AppCrashesInfoFeatures features = default(AppCrashesInfoFeatures))
        {
            // to ensure "hasCrashes" is required (not null)
            if (hasCrashes == null)
            {
                throw new InvalidDataException("hasCrashes is a required property for InlineResponse20064 and cannot be null");
            }
            else
            {
                this.HasCrashes = hasCrashes;
            }
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new InvalidDataException("features is a required property for InlineResponse20064 and cannot be null");
            }
            else
            {
                this.Features = features;
            }
        }
        
        /// <summary>
        /// Gets or Sets HasCrashes
        /// </summary>
        [DataMember(Name="has_crashes", EmitDefaultValue=false)]
        public bool? HasCrashes { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public AppCrashesInfoFeatures Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20064 {\n");
            sb.Append("  HasCrashes: ").Append(HasCrashes).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(input as InlineResponse20064);
        }

        /// <summary>
        /// Returns true if InlineResponse20064 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20064 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20064 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HasCrashes == input.HasCrashes ||
                    (this.HasCrashes != null &&
                    this.HasCrashes.Equals(input.HasCrashes))
                ) && 
                (
                    this.Features == input.Features ||
                    (this.Features != null &&
                    this.Features.Equals(input.Features))
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
                if (this.HasCrashes != null)
                    hashCode = hashCode * 59 + this.HasCrashes.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
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
