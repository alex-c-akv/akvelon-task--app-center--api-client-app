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
    /// BranchPropertiesBranch
    /// </summary>
    [DataContract]
        public partial class BranchPropertiesBranch :  IEquatable<BranchPropertiesBranch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BranchPropertiesBranch" /> class.
        /// </summary>
        /// <param name="name">The branch name (required).</param>
        /// <param name="commit">commit (required).</param>
        public BranchPropertiesBranch(string name = default(string), BranchPropertiesBranchCommit commit = default(BranchPropertiesBranchCommit))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BranchPropertiesBranch and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "commit" is required (not null)
            if (commit == null)
            {
                throw new InvalidDataException("commit is a required property for BranchPropertiesBranch and cannot be null");
            }
            else
            {
                this.Commit = commit;
            }
        }
        
        /// <summary>
        /// The branch name
        /// </summary>
        /// <value>The branch name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Commit
        /// </summary>
        [DataMember(Name="commit", EmitDefaultValue=false)]
        public BranchPropertiesBranchCommit Commit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchPropertiesBranch {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
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
            return this.Equals(input as BranchPropertiesBranch);
        }

        /// <summary>
        /// Returns true if BranchPropertiesBranch instances are equal
        /// </summary>
        /// <param name="input">Instance of BranchPropertiesBranch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchPropertiesBranch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Commit == input.Commit ||
                    (this.Commit != null &&
                    this.Commit.Equals(input.Commit))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Commit != null)
                    hashCode = hashCode * 59 + this.Commit.GetHashCode();
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
