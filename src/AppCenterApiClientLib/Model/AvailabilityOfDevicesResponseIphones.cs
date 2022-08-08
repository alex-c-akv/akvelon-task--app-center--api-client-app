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
    /// ...
    /// </summary>
    [DataContract]
        public partial class AvailabilityOfDevicesResponseIphones :  IEquatable<AvailabilityOfDevicesResponseIphones>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityOfDevicesResponseIphones" /> class.
        /// </summary>
        /// <param name="registered">registered (required).</param>
        /// <param name="available">available (required).</param>
        /// <param name="maximum">maximum (required).</param>
        public AvailabilityOfDevicesResponseIphones(decimal? registered = default(decimal?), decimal? available = default(decimal?), decimal? maximum = default(decimal?))
        {
            // to ensure "registered" is required (not null)
            if (registered == null)
            {
                throw new InvalidDataException("registered is a required property for AvailabilityOfDevicesResponseIphones and cannot be null");
            }
            else
            {
                this.Registered = registered;
            }
            // to ensure "available" is required (not null)
            if (available == null)
            {
                throw new InvalidDataException("available is a required property for AvailabilityOfDevicesResponseIphones and cannot be null");
            }
            else
            {
                this.Available = available;
            }
            // to ensure "maximum" is required (not null)
            if (maximum == null)
            {
                throw new InvalidDataException("maximum is a required property for AvailabilityOfDevicesResponseIphones and cannot be null");
            }
            else
            {
                this.Maximum = maximum;
            }
        }
        
        /// <summary>
        /// Gets or Sets Registered
        /// </summary>
        [DataMember(Name="registered", EmitDefaultValue=false)]
        public decimal? Registered { get; set; }

        /// <summary>
        /// Gets or Sets Available
        /// </summary>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public decimal? Available { get; set; }

        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityOfDevicesResponseIphones {\n");
            sb.Append("  Registered: ").Append(Registered).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
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
            return this.Equals(input as AvailabilityOfDevicesResponseIphones);
        }

        /// <summary>
        /// Returns true if AvailabilityOfDevicesResponseIphones instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailabilityOfDevicesResponseIphones to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityOfDevicesResponseIphones input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Registered == input.Registered ||
                    (this.Registered != null &&
                    this.Registered.Equals(input.Registered))
                ) && 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    (this.Maximum != null &&
                    this.Maximum.Equals(input.Maximum))
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
                if (this.Registered != null)
                    hashCode = hashCode * 59 + this.Registered.GetHashCode();
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.Maximum != null)
                    hashCode = hashCode * 59 + this.Maximum.GetHashCode();
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
