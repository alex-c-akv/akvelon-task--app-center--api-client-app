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
    /// ActiveDeviceCounts
    /// </summary>
    [DataContract]
        public partial class ActiveDeviceCounts :  IEquatable<ActiveDeviceCounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDeviceCounts" /> class.
        /// </summary>
        /// <param name="daily">The active device count for each interval..</param>
        /// <param name="weekly">The active device count for each interval with a week&#x27;s retention..</param>
        /// <param name="monthly">The active device count for each interval with a month&#x27;s retention..</param>
        public ActiveDeviceCounts(List<CrashCountsCrashes> daily = default(List<CrashCountsCrashes>), List<CrashCountsCrashes> weekly = default(List<CrashCountsCrashes>), List<CrashCountsCrashes> monthly = default(List<CrashCountsCrashes>))
        {
            this.Daily = daily;
            this.Weekly = weekly;
            this.Monthly = monthly;
        }
        
        /// <summary>
        /// The active device count for each interval.
        /// </summary>
        /// <value>The active device count for each interval.</value>
        [DataMember(Name="daily", EmitDefaultValue=false)]
        public List<CrashCountsCrashes> Daily { get; set; }

        /// <summary>
        /// The active device count for each interval with a week&#x27;s retention.
        /// </summary>
        /// <value>The active device count for each interval with a week&#x27;s retention.</value>
        [DataMember(Name="weekly", EmitDefaultValue=false)]
        public List<CrashCountsCrashes> Weekly { get; set; }

        /// <summary>
        /// The active device count for each interval with a month&#x27;s retention.
        /// </summary>
        /// <value>The active device count for each interval with a month&#x27;s retention.</value>
        [DataMember(Name="monthly", EmitDefaultValue=false)]
        public List<CrashCountsCrashes> Monthly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveDeviceCounts {\n");
            sb.Append("  Daily: ").Append(Daily).Append("\n");
            sb.Append("  Weekly: ").Append(Weekly).Append("\n");
            sb.Append("  Monthly: ").Append(Monthly).Append("\n");
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
            return this.Equals(input as ActiveDeviceCounts);
        }

        /// <summary>
        /// Returns true if ActiveDeviceCounts instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiveDeviceCounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiveDeviceCounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Daily == input.Daily ||
                    this.Daily != null &&
                    input.Daily != null &&
                    this.Daily.SequenceEqual(input.Daily)
                ) && 
                (
                    this.Weekly == input.Weekly ||
                    this.Weekly != null &&
                    input.Weekly != null &&
                    this.Weekly.SequenceEqual(input.Weekly)
                ) && 
                (
                    this.Monthly == input.Monthly ||
                    this.Monthly != null &&
                    input.Monthly != null &&
                    this.Monthly.SequenceEqual(input.Monthly)
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
                if (this.Daily != null)
                    hashCode = hashCode * 59 + this.Daily.GetHashCode();
                if (this.Weekly != null)
                    hashCode = hashCode * 59 + this.Weekly.GetHashCode();
                if (this.Monthly != null)
                    hashCode = hashCode * 59 + this.Monthly.GetHashCode();
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