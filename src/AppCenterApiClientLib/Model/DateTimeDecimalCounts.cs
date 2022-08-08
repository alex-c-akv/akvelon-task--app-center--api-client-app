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
    /// DateTimeDecimalCounts
    /// </summary>
    [DataContract]
        public partial class DateTimeDecimalCounts :  IEquatable<DateTimeDecimalCounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeDecimalCounts" /> class.
        /// </summary>
        /// <param name="datetime">The ISO 8601 datetime..</param>
        /// <param name="count">Decimal count of the object..</param>
        public DateTimeDecimalCounts(string datetime = default(string), double? count = default(double?))
        {
            this.Datetime = datetime;
            this.Count = count;
        }
        
        /// <summary>
        /// The ISO 8601 datetime.
        /// </summary>
        /// <value>The ISO 8601 datetime.</value>
        [DataMember(Name="datetime", EmitDefaultValue=false)]
        public string Datetime { get; set; }

        /// <summary>
        /// Decimal count of the object.
        /// </summary>
        /// <value>Decimal count of the object.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public double? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeDecimalCounts {\n");
            sb.Append("  Datetime: ").Append(Datetime).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as DateTimeDecimalCounts);
        }

        /// <summary>
        /// Returns true if DateTimeDecimalCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of DateTimeDecimalCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTimeDecimalCounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datetime == input.Datetime ||
                    (this.Datetime != null &&
                    this.Datetime.Equals(input.Datetime))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Datetime != null)
                    hashCode = hashCode * 59 + this.Datetime.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
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
