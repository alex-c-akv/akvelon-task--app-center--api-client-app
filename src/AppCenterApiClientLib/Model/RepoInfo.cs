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
    /// RepoInfo
    /// </summary>
    [DataContract]
        public partial class RepoInfo :  IEquatable<RepoInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepoInfo" /> class.
        /// </summary>
        /// <param name="repoUrl">The repository url (required).</param>
        /// <param name="externalUserId">The external user ID.</param>
        public RepoInfo(string repoUrl = default(string), string externalUserId = default(string))
        {
            // to ensure "repoUrl" is required (not null)
            if (repoUrl == null)
            {
                throw new InvalidDataException("repoUrl is a required property for RepoInfo and cannot be null");
            }
            else
            {
                this.RepoUrl = repoUrl;
            }
            this.ExternalUserId = externalUserId;
        }
        
        /// <summary>
        /// The repository url
        /// </summary>
        /// <value>The repository url</value>
        [DataMember(Name="repo_url", EmitDefaultValue=false)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// The external user ID
        /// </summary>
        /// <value>The external user ID</value>
        [DataMember(Name="external_user_id", EmitDefaultValue=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoInfo {\n");
            sb.Append("  RepoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  ExternalUserId: ").Append(ExternalUserId).Append("\n");
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
            return this.Equals(input as RepoInfo);
        }

        /// <summary>
        /// Returns true if RepoInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RepoInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepoInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RepoUrl == input.RepoUrl ||
                    (this.RepoUrl != null &&
                    this.RepoUrl.Equals(input.RepoUrl))
                ) && 
                (
                    this.ExternalUserId == input.ExternalUserId ||
                    (this.ExternalUserId != null &&
                    this.ExternalUserId.Equals(input.ExternalUserId))
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
                if (this.RepoUrl != null)
                    hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.ExternalUserId != null)
                    hashCode = hashCode * 59 + this.ExternalUserId.GetHashCode();
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