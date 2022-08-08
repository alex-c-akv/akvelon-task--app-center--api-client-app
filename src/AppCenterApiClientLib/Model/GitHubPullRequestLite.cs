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
    /// The lite version of GitHub pull request
    /// </summary>
    [DataContract]
        public partial class GitHubPullRequestLite :  IEquatable<GitHubPullRequestLite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubPullRequestLite" /> class.
        /// </summary>
        /// <param name="head">head.</param>
        /// <param name="_base">_base.</param>
        public GitHubPullRequestLite(GitHubPullRequestLiteHead head = default(GitHubPullRequestLiteHead), GitHubPullRequestLiteHead _base = default(GitHubPullRequestLiteHead))
        {
            this.Head = head;
            this._Base = _base;
        }
        
        /// <summary>
        /// Gets or Sets Head
        /// </summary>
        [DataMember(Name="head", EmitDefaultValue=false)]
        public GitHubPullRequestLiteHead Head { get; set; }

        /// <summary>
        /// Gets or Sets _Base
        /// </summary>
        [DataMember(Name="base", EmitDefaultValue=false)]
        public GitHubPullRequestLiteHead _Base { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitHubPullRequestLite {\n");
            sb.Append("  Head: ").Append(Head).Append("\n");
            sb.Append("  _Base: ").Append(_Base).Append("\n");
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
            return this.Equals(input as GitHubPullRequestLite);
        }

        /// <summary>
        /// Returns true if GitHubPullRequestLite instances are equal
        /// </summary>
        /// <param name="input">Instance of GitHubPullRequestLite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GitHubPullRequestLite input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Head == input.Head ||
                    (this.Head != null &&
                    this.Head.Equals(input.Head))
                ) && 
                (
                    this._Base == input._Base ||
                    (this._Base != null &&
                    this._Base.Equals(input._Base))
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
                if (this.Head != null)
                    hashCode = hashCode * 59 + this.Head.GetHashCode();
                if (this._Base != null)
                    hashCode = hashCode * 59 + this._Base.GetHashCode();
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
