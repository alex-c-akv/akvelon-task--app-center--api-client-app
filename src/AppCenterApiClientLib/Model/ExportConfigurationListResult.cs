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
    /// List of export configurations
    /// </summary>
    [DataContract]
        public partial class ExportConfigurationListResult :  IEquatable<ExportConfigurationListResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportConfigurationListResult" /> class.
        /// </summary>
        /// <param name="values">values (required).</param>
        /// <param name="total">the total count of exports.</param>
        /// <param name="nextLink">nextLink.</param>
        public ExportConfigurationListResult(List<ExportConfigurationListResultValues> values = default(List<ExportConfigurationListResultValues>), long? total = default(long?), string nextLink = default(string))
        {
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for ExportConfigurationListResult and cannot be null");
            }
            else
            {
                this.Values = values;
            }
            this.Total = total;
            this.NextLink = nextLink;
        }
        
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<ExportConfigurationListResultValues> Values { get; set; }

        /// <summary>
        /// the total count of exports
        /// </summary>
        /// <value>the total count of exports</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name="nextLink", EmitDefaultValue=false)]
        public string NextLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportConfigurationListResult {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
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
            return this.Equals(input as ExportConfigurationListResult);
        }

        /// <summary>
        /// Returns true if ExportConfigurationListResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportConfigurationListResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportConfigurationListResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.NextLink == input.NextLink ||
                    (this.NextLink != null &&
                    this.NextLink.Equals(input.NextLink))
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.NextLink != null)
                    hashCode = hashCode * 59 + this.NextLink.GetHashCode();
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
