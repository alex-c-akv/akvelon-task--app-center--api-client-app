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
    /// Physical device screen dimensions
    /// </summary>
    [DataContract]
        public partial class V01appsownerNameappNamedeviceConfigurationsModelScreenSize :  IEquatable<V01appsownerNameappNamedeviceConfigurationsModelScreenSize>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V01appsownerNameappNamedeviceConfigurationsModelScreenSize" /> class.
        /// </summary>
        /// <param name="cm">cm.</param>
        /// <param name="_in">_in.</param>
        public V01appsownerNameappNamedeviceConfigurationsModelScreenSize(string cm = default(string), string _in = default(string))
        {
            this.Cm = cm;
            this._In = _in;
        }
        
        /// <summary>
        /// Gets or Sets Cm
        /// </summary>
        [DataMember(Name="cm", EmitDefaultValue=false)]
        public string Cm { get; set; }

        /// <summary>
        /// Gets or Sets _In
        /// </summary>
        [DataMember(Name="in", EmitDefaultValue=false)]
        public string _In { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V01appsownerNameappNamedeviceConfigurationsModelScreenSize {\n");
            sb.Append("  Cm: ").Append(Cm).Append("\n");
            sb.Append("  _In: ").Append(_In).Append("\n");
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
            return this.Equals(input as V01appsownerNameappNamedeviceConfigurationsModelScreenSize);
        }

        /// <summary>
        /// Returns true if V01appsownerNameappNamedeviceConfigurationsModelScreenSize instances are equal
        /// </summary>
        /// <param name="input">Instance of V01appsownerNameappNamedeviceConfigurationsModelScreenSize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V01appsownerNameappNamedeviceConfigurationsModelScreenSize input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cm == input.Cm ||
                    (this.Cm != null &&
                    this.Cm.Equals(input.Cm))
                ) && 
                (
                    this._In == input._In ||
                    (this._In != null &&
                    this._In.Equals(input._In))
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
                if (this.Cm != null)
                    hashCode = hashCode * 59 + this.Cm.GetHashCode();
                if (this._In != null)
                    hashCode = hashCode * 59 + this._In.GetHashCode();
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
