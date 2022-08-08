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
    /// InlineResponse20095
    /// </summary>
    [DataContract]
        public partial class InlineResponse20095 :  IEquatable<InlineResponse20095>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20095" /> class.
        /// </summary>
        /// <param name="count">Total crash count..</param>
        /// <param name="crashes">The total crash count for day..</param>
        public InlineResponse20095(long? count = default(long?), List<CrashCountsCrashes> crashes = default(List<CrashCountsCrashes>))
        {
            this.Count = count;
            this.Crashes = crashes;
        }
        
        /// <summary>
        /// Total crash count.
        /// </summary>
        /// <value>Total crash count.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The total crash count for day.
        /// </summary>
        /// <value>The total crash count for day.</value>
        [DataMember(Name="crashes", EmitDefaultValue=false)]
        public List<CrashCountsCrashes> Crashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20095 {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Crashes: ").Append(Crashes).Append("\n");
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
            return this.Equals(input as InlineResponse20095);
        }

        /// <summary>
        /// Returns true if InlineResponse20095 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20095 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20095 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Crashes == input.Crashes ||
                    this.Crashes != null &&
                    input.Crashes != null &&
                    this.Crashes.SequenceEqual(input.Crashes)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Crashes != null)
                    hashCode = hashCode * 59 + this.Crashes.GetHashCode();
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
