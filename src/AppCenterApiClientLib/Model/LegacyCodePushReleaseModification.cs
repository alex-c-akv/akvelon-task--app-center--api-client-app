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
    /// LegacyCodePushReleaseModification
    /// </summary>
    [DataContract]
        public partial class LegacyCodePushReleaseModification :  IEquatable<LegacyCodePushReleaseModification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyCodePushReleaseModification" /> class.
        /// </summary>
        /// <param name="packageInfo">The release package information (required).</param>
        public LegacyCodePushReleaseModification(Object packageInfo = default(Object))
        {
            // to ensure "packageInfo" is required (not null)
            if (packageInfo == null)
            {
                throw new InvalidDataException("packageInfo is a required property for LegacyCodePushReleaseModification and cannot be null");
            }
            else
            {
                this.PackageInfo = packageInfo;
            }
        }
        
        /// <summary>
        /// The release package information
        /// </summary>
        /// <value>The release package information</value>
        [DataMember(Name="packageInfo", EmitDefaultValue=false)]
        public Object PackageInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LegacyCodePushReleaseModification {\n");
            sb.Append("  PackageInfo: ").Append(PackageInfo).Append("\n");
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
            return this.Equals(input as LegacyCodePushReleaseModification);
        }

        /// <summary>
        /// Returns true if LegacyCodePushReleaseModification instances are equal
        /// </summary>
        /// <param name="input">Instance of LegacyCodePushReleaseModification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LegacyCodePushReleaseModification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PackageInfo == input.PackageInfo ||
                    (this.PackageInfo != null &&
                    this.PackageInfo.Equals(input.PackageInfo))
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
                if (this.PackageInfo != null)
                    hashCode = hashCode * 59 + this.PackageInfo.GetHashCode();
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
