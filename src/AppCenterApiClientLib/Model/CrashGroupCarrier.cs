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
    /// CrashGroupCarrier
    /// </summary>
    [DataContract]
        public partial class CrashGroupCarrier :  IEquatable<CrashGroupCarrier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupCarrier" /> class.
        /// </summary>
        /// <param name="carrierName">Carrier name..</param>
        /// <param name="crashCount">Crash count of carrier..</param>
        public CrashGroupCarrier(string carrierName = default(string), long? crashCount = default(long?))
        {
            this.CarrierName = carrierName;
            this.CrashCount = crashCount;
        }
        
        /// <summary>
        /// Carrier name.
        /// </summary>
        /// <value>Carrier name.</value>
        [DataMember(Name="carrier_name", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Crash count of carrier.
        /// </summary>
        /// <value>Crash count of carrier.</value>
        [DataMember(Name="crash_count", EmitDefaultValue=false)]
        public long? CrashCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupCarrier {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  CrashCount: ").Append(CrashCount).Append("\n");
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
            return this.Equals(input as CrashGroupCarrier);
        }

        /// <summary>
        /// Returns true if CrashGroupCarrier instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupCarrier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupCarrier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.CrashCount == input.CrashCount ||
                    (this.CrashCount != null &&
                    this.CrashCount.Equals(input.CrashCount))
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
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.CrashCount != null)
                    hashCode = hashCode * 59 + this.CrashCount.GetHashCode();
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