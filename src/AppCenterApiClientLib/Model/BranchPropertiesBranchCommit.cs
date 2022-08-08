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
    /// BranchPropertiesBranchCommit
    /// </summary>
    [DataContract]
        public partial class BranchPropertiesBranchCommit :  IEquatable<BranchPropertiesBranchCommit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchPropertiesBranchCommit" /> class.
        /// </summary>
        /// <param name="sha">The commit SHA.</param>
        /// <param name="url">The URL to the commit.</param>
        public BranchPropertiesBranchCommit(string sha = default(string), string url = default(string))
        {
            this.Sha = sha;
            this.Url = url;
        }
        
        /// <summary>
        /// The commit SHA
        /// </summary>
        /// <value>The commit SHA</value>
        [DataMember(Name="sha", EmitDefaultValue=false)]
        public string Sha { get; set; }

        /// <summary>
        /// The URL to the commit
        /// </summary>
        /// <value>The URL to the commit</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchPropertiesBranchCommit {\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as BranchPropertiesBranchCommit);
        }

        /// <summary>
        /// Returns true if BranchPropertiesBranchCommit instances are equal
        /// </summary>
        /// <param name="input">Instance of BranchPropertiesBranchCommit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchPropertiesBranchCommit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sha == input.Sha ||
                    (this.Sha != null &&
                    this.Sha.Equals(input.Sha))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Sha != null)
                    hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
