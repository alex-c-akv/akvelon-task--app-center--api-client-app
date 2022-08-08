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
    /// PerformanceReportPerformanceDataSamples
    /// </summary>
    [DataContract]
        public partial class PerformanceReportPerformanceDataSamples :  IEquatable<PerformanceReportPerformanceDataSamples>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReportPerformanceDataSamples" /> class.
        /// </summary>
        /// <param name="cpu">cpu.</param>
        /// <param name="mem">mem.</param>
        /// <param name="elapsedSecs">elapsedSecs.</param>
        public PerformanceReportPerformanceDataSamples(decimal? cpu = default(decimal?), decimal? mem = default(decimal?), decimal? elapsedSecs = default(decimal?))
        {
            this.Cpu = cpu;
            this.Mem = mem;
            this.ElapsedSecs = elapsedSecs;
        }
        
        /// <summary>
        /// Gets or Sets Cpu
        /// </summary>
        [DataMember(Name="cpu", EmitDefaultValue=false)]
        public decimal? Cpu { get; set; }

        /// <summary>
        /// Gets or Sets Mem
        /// </summary>
        [DataMember(Name="mem", EmitDefaultValue=false)]
        public decimal? Mem { get; set; }

        /// <summary>
        /// Gets or Sets ElapsedSecs
        /// </summary>
        [DataMember(Name="elapsed-secs", EmitDefaultValue=false)]
        public decimal? ElapsedSecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceReportPerformanceDataSamples {\n");
            sb.Append("  Cpu: ").Append(Cpu).Append("\n");
            sb.Append("  Mem: ").Append(Mem).Append("\n");
            sb.Append("  ElapsedSecs: ").Append(ElapsedSecs).Append("\n");
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
            return this.Equals(input as PerformanceReportPerformanceDataSamples);
        }

        /// <summary>
        /// Returns true if PerformanceReportPerformanceDataSamples instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceReportPerformanceDataSamples to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceReportPerformanceDataSamples input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Mem == input.Mem ||
                    (this.Mem != null &&
                    this.Mem.Equals(input.Mem))
                ) && 
                (
                    this.ElapsedSecs == input.ElapsedSecs ||
                    (this.ElapsedSecs != null &&
                    this.ElapsedSecs.Equals(input.ElapsedSecs))
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
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null)
                    hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.ElapsedSecs != null)
                    hashCode = hashCode * 59 + this.ElapsedSecs.GetHashCode();
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
