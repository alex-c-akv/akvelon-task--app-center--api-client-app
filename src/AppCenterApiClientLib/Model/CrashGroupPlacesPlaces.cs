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
    /// CrashGroupPlacesPlaces
    /// </summary>
    [DataContract]
        public partial class CrashGroupPlacesPlaces :  IEquatable<CrashGroupPlacesPlaces>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupPlacesPlaces" /> class.
        /// </summary>
        /// <param name="placeName">Place name..</param>
        /// <param name="crashCount">Count of places..</param>
        public CrashGroupPlacesPlaces(string placeName = default(string), long? crashCount = default(long?))
        {
            this.PlaceName = placeName;
            this.CrashCount = crashCount;
        }
        
        /// <summary>
        /// Place name.
        /// </summary>
        /// <value>Place name.</value>
        [DataMember(Name="place_name", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

        /// <summary>
        /// Count of places.
        /// </summary>
        /// <value>Count of places.</value>
        [DataMember(Name="crash_count", EmitDefaultValue=false)]
        public long? CrashCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupPlacesPlaces {\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
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
            return this.Equals(input as CrashGroupPlacesPlaces);
        }

        /// <summary>
        /// Returns true if CrashGroupPlacesPlaces instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupPlacesPlaces to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupPlacesPlaces input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlaceName == input.PlaceName ||
                    (this.PlaceName != null &&
                    this.PlaceName.Equals(input.PlaceName))
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
                if (this.PlaceName != null)
                    hashCode = hashCode * 59 + this.PlaceName.GetHashCode();
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
