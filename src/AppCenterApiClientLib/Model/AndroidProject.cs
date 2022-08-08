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
    /// AndroidProject
    /// </summary>
    [DataContract]
        public partial class AndroidProject :  IEquatable<AndroidProject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidProject" /> class.
        /// </summary>
        /// <param name="androidModules">Android Gradle modules (required).</param>
        /// <param name="gradleWrapperPath">The path of the Gradle wrapper.</param>
        public AndroidProject(List<AndroidProjectAndroidModules> androidModules = default(List<AndroidProjectAndroidModules>), string gradleWrapperPath = default(string))
        {
            // to ensure "androidModules" is required (not null)
            if (androidModules == null)
            {
                throw new InvalidDataException("androidModules is a required property for AndroidProject and cannot be null");
            }
            else
            {
                this.AndroidModules = androidModules;
            }
            this.GradleWrapperPath = gradleWrapperPath;
        }
        
        /// <summary>
        /// Android Gradle modules
        /// </summary>
        /// <value>Android Gradle modules</value>
        [DataMember(Name="androidModules", EmitDefaultValue=false)]
        public List<AndroidProjectAndroidModules> AndroidModules { get; set; }

        /// <summary>
        /// The path of the Gradle wrapper
        /// </summary>
        /// <value>The path of the Gradle wrapper</value>
        [DataMember(Name="gradleWrapperPath", EmitDefaultValue=false)]
        public string GradleWrapperPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AndroidProject {\n");
            sb.Append("  AndroidModules: ").Append(AndroidModules).Append("\n");
            sb.Append("  GradleWrapperPath: ").Append(GradleWrapperPath).Append("\n");
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
            return this.Equals(input as AndroidProject);
        }

        /// <summary>
        /// Returns true if AndroidProject instances are equal
        /// </summary>
        /// <param name="input">Instance of AndroidProject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AndroidProject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AndroidModules == input.AndroidModules ||
                    this.AndroidModules != null &&
                    input.AndroidModules != null &&
                    this.AndroidModules.SequenceEqual(input.AndroidModules)
                ) && 
                (
                    this.GradleWrapperPath == input.GradleWrapperPath ||
                    (this.GradleWrapperPath != null &&
                    this.GradleWrapperPath.Equals(input.GradleWrapperPath))
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
                if (this.AndroidModules != null)
                    hashCode = hashCode * 59 + this.AndroidModules.GetHashCode();
                if (this.GradleWrapperPath != null)
                    hashCode = hashCode * 59 + this.GradleWrapperPath.GetHashCode();
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
