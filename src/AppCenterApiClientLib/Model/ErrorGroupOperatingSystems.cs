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
    /// ErrorGroupOperatingSystems
    /// </summary>
    [DataContract]
        public partial class ErrorGroupOperatingSystems :  IEquatable<ErrorGroupOperatingSystems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorGroupOperatingSystems" /> class.
        /// </summary>
        /// <param name="errorCount">errorCount.</param>
        /// <param name="operatingSystems">operatingSystems.</param>
        public ErrorGroupOperatingSystems(long? errorCount = default(long?), List<ErrorGroupOperatingSystemsOperatingSystems> operatingSystems = default(List<ErrorGroupOperatingSystemsOperatingSystems>))
        {
            this.ErrorCount = errorCount;
            this.OperatingSystems = operatingSystems;
        }
        
        /// <summary>
        /// Gets or Sets ErrorCount
        /// </summary>
        [DataMember(Name="errorCount", EmitDefaultValue=false)]
        public long? ErrorCount { get; set; }

        /// <summary>
        /// Gets or Sets OperatingSystems
        /// </summary>
        [DataMember(Name="operatingSystems", EmitDefaultValue=false)]
        public List<ErrorGroupOperatingSystemsOperatingSystems> OperatingSystems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorGroupOperatingSystems {\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  OperatingSystems: ").Append(OperatingSystems).Append("\n");
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
            return this.Equals(input as ErrorGroupOperatingSystems);
        }

        /// <summary>
        /// Returns true if ErrorGroupOperatingSystems instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorGroupOperatingSystems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorGroupOperatingSystems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ErrorCount == input.ErrorCount ||
                    (this.ErrorCount != null &&
                    this.ErrorCount.Equals(input.ErrorCount))
                ) && 
                (
                    this.OperatingSystems == input.OperatingSystems ||
                    this.OperatingSystems != null &&
                    input.OperatingSystems != null &&
                    this.OperatingSystems.SequenceEqual(input.OperatingSystems)
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
                if (this.ErrorCount != null)
                    hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.OperatingSystems != null)
                    hashCode = hashCode * 59 + this.OperatingSystems.GetHashCode();
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
