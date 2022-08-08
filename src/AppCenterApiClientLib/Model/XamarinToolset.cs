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
    /// XamarinToolset
    /// </summary>
    [DataContract]
        public partial class XamarinToolset :  IEquatable<XamarinToolset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamarinToolset" /> class.
        /// </summary>
        /// <param name="xamarinSolutions">Xamarin solutions for the toolset (required).</param>
        public XamarinToolset(List<XamarinToolsetXamarinSolutions> xamarinSolutions = default(List<XamarinToolsetXamarinSolutions>))
        {
            // to ensure "xamarinSolutions" is required (not null)
            if (xamarinSolutions == null)
            {
                throw new InvalidDataException("xamarinSolutions is a required property for XamarinToolset and cannot be null");
            }
            else
            {
                this.XamarinSolutions = xamarinSolutions;
            }
        }
        
        /// <summary>
        /// Xamarin solutions for the toolset
        /// </summary>
        /// <value>Xamarin solutions for the toolset</value>
        [DataMember(Name="xamarinSolutions", EmitDefaultValue=false)]
        public List<XamarinToolsetXamarinSolutions> XamarinSolutions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XamarinToolset {\n");
            sb.Append("  XamarinSolutions: ").Append(XamarinSolutions).Append("\n");
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
            return this.Equals(input as XamarinToolset);
        }

        /// <summary>
        /// Returns true if XamarinToolset instances are equal
        /// </summary>
        /// <param name="input">Instance of XamarinToolset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XamarinToolset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XamarinSolutions == input.XamarinSolutions ||
                    this.XamarinSolutions != null &&
                    input.XamarinSolutions != null &&
                    this.XamarinSolutions.SequenceEqual(input.XamarinSolutions)
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
                if (this.XamarinSolutions != null)
                    hashCode = hashCode * 59 + this.XamarinSolutions.GetHashCode();
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
