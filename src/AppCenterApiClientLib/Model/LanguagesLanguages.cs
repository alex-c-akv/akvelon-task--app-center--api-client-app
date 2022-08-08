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
    /// LanguagesLanguages
    /// </summary>
    [DataContract]
        public partial class LanguagesLanguages :  IEquatable<LanguagesLanguages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagesLanguages" /> class.
        /// </summary>
        /// <param name="languageName">Language&#x27;s name..</param>
        /// <param name="count">Count current of language..</param>
        /// <param name="previousCount">Count of previous lanugage..</param>
        public LanguagesLanguages(string languageName = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            this.LanguageName = languageName;
            this.Count = count;
            this.PreviousCount = previousCount;
        }
        
        /// <summary>
        /// Language&#x27;s name.
        /// </summary>
        /// <value>Language&#x27;s name.</value>
        [DataMember(Name="language_name", EmitDefaultValue=false)]
        public string LanguageName { get; set; }

        /// <summary>
        /// Count current of language.
        /// </summary>
        /// <value>Count current of language.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public long? Count { get; set; }

        /// <summary>
        /// Count of previous lanugage.
        /// </summary>
        /// <value>Count of previous lanugage.</value>
        [DataMember(Name="previous_count", EmitDefaultValue=false)]
        public long? PreviousCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LanguagesLanguages {\n");
            sb.Append("  LanguageName: ").Append(LanguageName).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PreviousCount: ").Append(PreviousCount).Append("\n");
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
            return this.Equals(input as LanguagesLanguages);
        }

        /// <summary>
        /// Returns true if LanguagesLanguages instances are equal
        /// </summary>
        /// <param name="input">Instance of LanguagesLanguages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LanguagesLanguages input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageName == input.LanguageName ||
                    (this.LanguageName != null &&
                    this.LanguageName.Equals(input.LanguageName))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.PreviousCount == input.PreviousCount ||
                    (this.PreviousCount != null &&
                    this.PreviousCount.Equals(input.PreviousCount))
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
                if (this.LanguageName != null)
                    hashCode = hashCode * 59 + this.LanguageName.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.PreviousCount != null)
                    hashCode = hashCode * 59 + this.PreviousCount.GetHashCode();
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