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
    /// missing symbol
    /// </summary>
    [DataContract]
        public partial class V2MissingSymbolCrashGroupMissingSymbols :  IEquatable<V2MissingSymbolCrashGroupMissingSymbols>, IValidatableObject
    {
        /// <summary>
        /// symbol status
        /// </summary>
        /// <value>symbol status</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Missing for value: missing
            /// </summary>
            [EnumMember(Value = "missing")]
            Missing = 1,
            /// <summary>
            /// Enum Ignored for value: ignored
            /// </summary>
            [EnumMember(Value = "ignored")]
            Ignored = 2,
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 3        }
        /// <summary>
        /// symbol status
        /// </summary>
        /// <value>symbol status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MissingSymbolCrashGroupMissingSymbols" /> class.
        /// </summary>
        /// <param name="symbolId">symbol id (required).</param>
        /// <param name="name">symbol name (required).</param>
        /// <param name="platform">symbol plarform.</param>
        /// <param name="status">symbol status (required).</param>
        public V2MissingSymbolCrashGroupMissingSymbols(string symbolId = default(string), string name = default(string), string platform = default(string), StatusEnum status = default(StatusEnum))
        {
            // to ensure "symbolId" is required (not null)
            if (symbolId == null)
            {
                throw new InvalidDataException("symbolId is a required property for V2MissingSymbolCrashGroupMissingSymbols and cannot be null");
            }
            else
            {
                this.SymbolId = symbolId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for V2MissingSymbolCrashGroupMissingSymbols and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for V2MissingSymbolCrashGroupMissingSymbols and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.Platform = platform;
        }
        
        /// <summary>
        /// symbol id
        /// </summary>
        /// <value>symbol id</value>
        [DataMember(Name="symbol_id", EmitDefaultValue=false)]
        public string SymbolId { get; set; }

        /// <summary>
        /// symbol name
        /// </summary>
        /// <value>symbol name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// symbol plarform
        /// </summary>
        /// <value>symbol plarform</value>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MissingSymbolCrashGroupMissingSymbols {\n");
            sb.Append("  SymbolId: ").Append(SymbolId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as V2MissingSymbolCrashGroupMissingSymbols);
        }

        /// <summary>
        /// Returns true if V2MissingSymbolCrashGroupMissingSymbols instances are equal
        /// </summary>
        /// <param name="input">Instance of V2MissingSymbolCrashGroupMissingSymbols to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MissingSymbolCrashGroupMissingSymbols input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
