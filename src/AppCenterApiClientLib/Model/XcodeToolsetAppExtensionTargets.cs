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
    /// App extension information
    /// </summary>
    [DataContract]
        public partial class XcodeToolsetAppExtensionTargets :  IEquatable<XcodeToolsetAppExtensionTargets>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeToolsetAppExtensionTargets" /> class.
        /// </summary>
        /// <param name="name">App extension name (required).</param>
        /// <param name="targetBundleIdentifier">App extension bundle identifier (required).</param>
        public XcodeToolsetAppExtensionTargets(string name = default(string), string targetBundleIdentifier = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for XcodeToolsetAppExtensionTargets and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "targetBundleIdentifier" is required (not null)
            if (targetBundleIdentifier == null)
            {
                throw new InvalidDataException("targetBundleIdentifier is a required property for XcodeToolsetAppExtensionTargets and cannot be null");
            }
            else
            {
                this.TargetBundleIdentifier = targetBundleIdentifier;
            }
        }
        
        /// <summary>
        /// App extension name
        /// </summary>
        /// <value>App extension name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// App extension bundle identifier
        /// </summary>
        /// <value>App extension bundle identifier</value>
        [DataMember(Name="targetBundleIdentifier", EmitDefaultValue=false)]
        public string TargetBundleIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XcodeToolsetAppExtensionTargets {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TargetBundleIdentifier: ").Append(TargetBundleIdentifier).Append("\n");
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
            return this.Equals(input as XcodeToolsetAppExtensionTargets);
        }

        /// <summary>
        /// Returns true if XcodeToolsetAppExtensionTargets instances are equal
        /// </summary>
        /// <param name="input">Instance of XcodeToolsetAppExtensionTargets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XcodeToolsetAppExtensionTargets input)
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
                    this.TargetBundleIdentifier == input.TargetBundleIdentifier ||
                    (this.TargetBundleIdentifier != null &&
                    this.TargetBundleIdentifier.Equals(input.TargetBundleIdentifier))
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
                if (this.TargetBundleIdentifier != null)
                    hashCode = hashCode * 59 + this.TargetBundleIdentifier.GetHashCode();
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