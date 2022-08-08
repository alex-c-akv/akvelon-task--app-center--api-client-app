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
    /// UploadedSymbolInfo
    /// </summary>
    [DataContract]
        public partial class UploadedSymbolInfo :  IEquatable<UploadedSymbolInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedSymbolInfo" /> class.
        /// </summary>
        /// <param name="symbolId">The symbol id of the symbol binary (required).</param>
        /// <param name="platform">The platform the symbol is associated with (required).</param>
        public UploadedSymbolInfo(string symbolId = default(string), string platform = default(string))
        {
            // to ensure "symbolId" is required (not null)
            if (symbolId == null)
            {
                throw new InvalidDataException("symbolId is a required property for UploadedSymbolInfo and cannot be null");
            }
            else
            {
                this.SymbolId = symbolId;
            }
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new InvalidDataException("platform is a required property for UploadedSymbolInfo and cannot be null");
            }
            else
            {
                this.Platform = platform;
            }
        }
        
        /// <summary>
        /// The symbol id of the symbol binary
        /// </summary>
        /// <value>The symbol id of the symbol binary</value>
        [DataMember(Name="symbol_id", EmitDefaultValue=false)]
        public string SymbolId { get; set; }

        /// <summary>
        /// The platform the symbol is associated with
        /// </summary>
        /// <value>The platform the symbol is associated with</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadedSymbolInfo {\n");
            sb.Append("  SymbolId: ").Append(SymbolId).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(input as UploadedSymbolInfo);
        }

        /// <summary>
        /// Returns true if UploadedSymbolInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadedSymbolInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadedSymbolInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SymbolId == input.SymbolId ||
                    (this.SymbolId != null &&
                    this.SymbolId.Equals(input.SymbolId))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
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
                if (this.SymbolId != null)
                    hashCode = hashCode * 59 + this.SymbolId.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
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