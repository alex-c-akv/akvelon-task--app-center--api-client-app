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
    /// UWPSolution
    /// </summary>
    [DataContract]
        public partial class UWPSolution :  IEquatable<UWPSolution>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UWPSolution" /> class.
        /// </summary>
        /// <param name="path">The path to the UWP solution (required).</param>
        /// <param name="configurations">The possible configurations detected for the UWP solution (required).</param>
        public UWPSolution(string path = default(string), List<string> configurations = default(List<string>))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for UWPSolution and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            // to ensure "configurations" is required (not null)
            if (configurations == null)
            {
                throw new InvalidDataException("configurations is a required property for UWPSolution and cannot be null");
            }
            else
            {
                this.Configurations = configurations;
            }
        }
        
        /// <summary>
        /// The path to the UWP solution
        /// </summary>
        /// <value>The path to the UWP solution</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// The possible configurations detected for the UWP solution
        /// </summary>
        /// <value>The possible configurations detected for the UWP solution</value>
        [DataMember(Name="configurations", EmitDefaultValue=false)]
        public List<string> Configurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UWPSolution {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
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
            return this.Equals(input as UWPSolution);
        }

        /// <summary>
        /// Returns true if UWPSolution instances are equal
        /// </summary>
        /// <param name="input">Instance of UWPSolution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UWPSolution input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Configurations == input.Configurations ||
                    this.Configurations != null &&
                    input.Configurations != null &&
                    this.Configurations.SequenceEqual(input.Configurations)
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Configurations != null)
                    hashCode = hashCode * 59 + this.Configurations.GetHashCode();
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
