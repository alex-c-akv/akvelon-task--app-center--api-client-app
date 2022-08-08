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
    /// ApiTokenResponsev2
    /// </summary>
    [DataContract]
        public partial class ApiTokenResponsev2 :  IEquatable<ApiTokenResponsev2>, IValidatableObject
    {
        /// <summary>
        /// Defines Scope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ScopeEnum
        {
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 1,
            /// <summary>
            /// Enum Inappupdate for value: in_app_update
            /// </summary>
            [EnumMember(Value = "in_app_update")]
            Inappupdate = 2,
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 3        }
        /// <summary>
        /// The token&#x27;s scope. A list of allowed roles.
        /// </summary>
        /// <value>The token&#x27;s scope. A list of allowed roles.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public List<ScopeEnum> Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTokenResponsev2" /> class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the api token (required).</param>
        /// <param name="createdAt">The creation time (required).</param>
        /// <param name="scope">The token&#x27;s scope. A list of allowed roles..</param>
        /// <param name="encryptedToken">The encrypted value of a token. This value will only be returned for token of type in_app_update..</param>
        /// <param name="description">The description of the token.</param>
        public ApiTokenResponsev2(Guid? id = default(Guid?), string createdAt = default(string), List<ScopeEnum> scope = default(List<ScopeEnum>), string encryptedToken = default(string), string description = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ApiTokenResponsev2 and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for ApiTokenResponsev2 and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            this.Scope = scope;
            this.EncryptedToken = encryptedToken;
            this.Description = description;
        }
        
        /// <summary>
        /// The unique id (UUID) of the api token
        /// </summary>
        /// <value>The unique id (UUID) of the api token</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The creation time
        /// </summary>
        /// <value>The creation time</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }


        /// <summary>
        /// The encrypted value of a token. This value will only be returned for token of type in_app_update.
        /// </summary>
        /// <value>The encrypted value of a token. This value will only be returned for token of type in_app_update.</value>
        [DataMember(Name="encrypted_token", EmitDefaultValue=false)]
        public string EncryptedToken { get; set; }

        /// <summary>
        /// The description of the token
        /// </summary>
        /// <value>The description of the token</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTokenResponsev2 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  EncryptedToken: ").Append(EncryptedToken).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ApiTokenResponsev2);
        }

        /// <summary>
        /// Returns true if ApiTokenResponsev2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiTokenResponsev2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiTokenResponsev2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope != null &&
                    input.Scope != null &&
                    this.Scope.SequenceEqual(input.Scope)
                ) && 
                (
                    this.EncryptedToken == input.EncryptedToken ||
                    (this.EncryptedToken != null &&
                    this.EncryptedToken.Equals(input.EncryptedToken))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.EncryptedToken != null)
                    hashCode = hashCode * 59 + this.EncryptedToken.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
