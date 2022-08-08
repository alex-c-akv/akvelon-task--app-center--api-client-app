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
    /// EventCount
    /// </summary>
    [DataContract]
        public partial class EventCount :  IEquatable<EventCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventCount" /> class.
        /// </summary>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="previousTotalCount">previousTotalCount.</param>
        /// <param name="count">count.</param>
        public EventCount(long? totalCount = default(long?), long? previousTotalCount = default(long?), List<CrashCountsCrashes> count = default(List<CrashCountsCrashes>))
        {
            this.TotalCount = totalCount;
            this.PreviousTotalCount = previousTotalCount;
            this.Count = count;
        }
        
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets PreviousTotalCount
        /// </summary>
        [DataMember(Name="previous_total_count", EmitDefaultValue=false)]
        public long? PreviousTotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public List<CrashCountsCrashes> Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventCount {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  PreviousTotalCount: ").Append(PreviousTotalCount).Append("\n");
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
            return this.Equals(input as EventCount);
        }

        /// <summary>
        /// Returns true if EventCount instances are equal
        /// </summary>
        /// <param name="input">Instance of EventCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.PreviousTotalCount == input.PreviousTotalCount ||
                    (this.PreviousTotalCount != null &&
                    this.PreviousTotalCount.Equals(input.PreviousTotalCount))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count != null &&
                    input.Count != null &&
                    this.Count.SequenceEqual(input.Count)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.PreviousTotalCount != null)
                    hashCode = hashCode * 59 + this.PreviousTotalCount.GetHashCode();
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
