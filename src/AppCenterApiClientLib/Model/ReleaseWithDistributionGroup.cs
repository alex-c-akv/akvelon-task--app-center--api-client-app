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
    /// ReleaseWithDistributionGroup
    /// </summary>
    [DataContract]
        public partial class ReleaseWithDistributionGroup :  IEquatable<ReleaseWithDistributionGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseWithDistributionGroup" /> class.
        /// </summary>
        /// <param name="distributionGroup">Distribution group Id. .</param>
        public ReleaseWithDistributionGroup(string distributionGroup = default(string))
        {
            this.DistributionGroup = distributionGroup;
        }
        
        /// <summary>
        /// Distribution group Id. 
        /// </summary>
        /// <value>Distribution group Id. </value>
        [DataMember(Name="distribution_group", EmitDefaultValue=false)]
        public string DistributionGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseWithDistributionGroup {\n");
            sb.Append("  DistributionGroup: ").Append(DistributionGroup).Append("\n");
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
            return this.Equals(input as ReleaseWithDistributionGroup);
        }

        /// <summary>
        /// Returns true if ReleaseWithDistributionGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ReleaseWithDistributionGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReleaseWithDistributionGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistributionGroup == input.DistributionGroup ||
                    (this.DistributionGroup != null &&
                    this.DistributionGroup.Equals(input.DistributionGroup))
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
                if (this.DistributionGroup != null)
                    hashCode = hashCode * 59 + this.DistributionGroup.GetHashCode();
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
