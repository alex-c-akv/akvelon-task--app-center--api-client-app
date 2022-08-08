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
    /// CrashGroupModelsModels
    /// </summary>
    [DataContract]
        public partial class CrashGroupModelsModels :  IEquatable<CrashGroupModelsModels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrashGroupModelsModels" /> class.
        /// </summary>
        /// <param name="modelName">Model&#x27;s name..</param>
        /// <param name="crashCount">Count of model..</param>
        public CrashGroupModelsModels(string modelName = default(string), long? crashCount = default(long?))
        {
            this.ModelName = modelName;
            this.CrashCount = crashCount;
        }
        
        /// <summary>
        /// Model&#x27;s name.
        /// </summary>
        /// <value>Model&#x27;s name.</value>
        [DataMember(Name="model_name", EmitDefaultValue=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// Count of model.
        /// </summary>
        /// <value>Count of model.</value>
        [DataMember(Name="crash_count", EmitDefaultValue=false)]
        public long? CrashCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrashGroupModelsModels {\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
            sb.Append("  CrashCount: ").Append(CrashCount).Append("\n");
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
            return this.Equals(input as CrashGroupModelsModels);
        }

        /// <summary>
        /// Returns true if CrashGroupModelsModels instances are equal
        /// </summary>
        /// <param name="input">Instance of CrashGroupModelsModels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrashGroupModelsModels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelName == input.ModelName ||
                    (this.ModelName != null &&
                    this.ModelName.Equals(input.ModelName))
                ) && 
                (
                    this.CrashCount == input.CrashCount ||
                    (this.CrashCount != null &&
                    this.CrashCount.Equals(input.CrashCount))
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
                if (this.ModelName != null)
                    hashCode = hashCode * 59 + this.ModelName.GetHashCode();
                if (this.CrashCount != null)
                    hashCode = hashCode * 59 + this.CrashCount.GetHashCode();
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