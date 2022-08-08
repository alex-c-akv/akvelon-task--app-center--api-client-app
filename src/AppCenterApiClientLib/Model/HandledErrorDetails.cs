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
    /// HandledErrorDetails
    /// </summary>
    [DataContract]
        public partial class HandledErrorDetails :  IEquatable<HandledErrorDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandledErrorDetails" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="reasonFrames">reasonFrames.</param>
        /// <param name="appLaunchTimestamp">Timestamp when the app was launched, example: &#x27;2017-03-13T18:05:42Z&#x27;. .</param>
        /// <param name="carrierName">Carrier name (for mobile devices). .</param>
        /// <param name="jailbreak">Flag indicating if device is jailbroken .</param>
        /// <param name="properties">properties.</param>
        public HandledErrorDetails(string name = default(string), List<ErrorGroupListItemReasonFrames> reasonFrames = default(List<ErrorGroupListItemReasonFrames>), DateTime? appLaunchTimestamp = default(DateTime?), string carrierName = default(string), bool? jailbreak = default(bool?), Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            this.Name = name;
            this.ReasonFrames = reasonFrames;
            this.AppLaunchTimestamp = appLaunchTimestamp;
            this.CarrierName = carrierName;
            this.Jailbreak = jailbreak;
            this.Properties = properties;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReasonFrames
        /// </summary>
        [DataMember(Name="reasonFrames", EmitDefaultValue=false)]
        public List<ErrorGroupListItemReasonFrames> ReasonFrames { get; set; }

        /// <summary>
        /// Timestamp when the app was launched, example: &#x27;2017-03-13T18:05:42Z&#x27;. 
        /// </summary>
        /// <value>Timestamp when the app was launched, example: &#x27;2017-03-13T18:05:42Z&#x27;. </value>
        [DataMember(Name="appLaunchTimestamp", EmitDefaultValue=false)]
        public DateTime? AppLaunchTimestamp { get; set; }

        /// <summary>
        /// Carrier name (for mobile devices). 
        /// </summary>
        /// <value>Carrier name (for mobile devices). </value>
        [DataMember(Name="carrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Flag indicating if device is jailbroken 
        /// </summary>
        /// <value>Flag indicating if device is jailbroken </value>
        [DataMember(Name="jailbreak", EmitDefaultValue=false)]
        public bool? Jailbreak { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HandledErrorDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReasonFrames: ").Append(ReasonFrames).Append("\n");
            sb.Append("  AppLaunchTimestamp: ").Append(AppLaunchTimestamp).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  Jailbreak: ").Append(Jailbreak).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as HandledErrorDetails);
        }

        /// <summary>
        /// Returns true if HandledErrorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of HandledErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HandledErrorDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReasonFrames == input.ReasonFrames ||
                    this.ReasonFrames != null &&
                    input.ReasonFrames != null &&
                    this.ReasonFrames.SequenceEqual(input.ReasonFrames)
                ) && 
                (
                    this.AppLaunchTimestamp == input.AppLaunchTimestamp ||
                    (this.AppLaunchTimestamp != null &&
                    this.AppLaunchTimestamp.Equals(input.AppLaunchTimestamp))
                ) && 
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) && 
                (
                    this.Jailbreak == input.Jailbreak ||
                    (this.Jailbreak != null &&
                    this.Jailbreak.Equals(input.Jailbreak))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.ReasonFrames != null)
                    hashCode = hashCode * 59 + this.ReasonFrames.GetHashCode();
                if (this.AppLaunchTimestamp != null)
                    hashCode = hashCode * 59 + this.AppLaunchTimestamp.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.Jailbreak != null)
                    hashCode = hashCode * 59 + this.Jailbreak.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
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