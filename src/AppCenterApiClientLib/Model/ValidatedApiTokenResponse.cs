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
    /// ValidatedApiTokenResponse
    /// </summary>
    [DataContract]
        public partial class ValidatedApiTokenResponse :  IEquatable<ValidatedApiTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines TokenScope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TokenScopeEnum
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
        [DataMember(Name="token_scope", EmitDefaultValue=false)]
        public List<TokenScopeEnum> TokenScope { get; set; }
        /// <summary>
        /// Indicates the type of the principal (app or user)
        /// </summary>
        /// <value>Indicates the type of the principal (app or user)</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PrincipalTypeEnum
        {
            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 1,
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 2        }
        /// <summary>
        /// Indicates the type of the principal (app or user)
        /// </summary>
        /// <value>Indicates the type of the principal (app or user)</value>
        [DataMember(Name="principal_type", EmitDefaultValue=false)]
        public PrincipalTypeEnum PrincipalType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidatedApiTokenResponse" /> class.
        /// </summary>
        /// <param name="tokenId">The token&#x27;s unique id (UUID) (required).</param>
        /// <param name="tokenScope">The token&#x27;s scope. A list of allowed roles. (required).</param>
        /// <param name="principalId">The ID of the owner of the API Token (user_id or app_id) (required).</param>
        /// <param name="principalType">Indicates the type of the principal (app or user) (required).</param>
        /// <param name="claims">Collection of attributes that describe the principal of the specified API Token (required).</param>
        public ValidatedApiTokenResponse(Guid? tokenId = default(Guid?), List<TokenScopeEnum> tokenScope = default(List<TokenScopeEnum>), Guid? principalId = default(Guid?), PrincipalTypeEnum principalType = default(PrincipalTypeEnum), List<ValidatedApiTokenResponseClaims> claims = default(List<ValidatedApiTokenResponseClaims>))
        {
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new InvalidDataException("tokenId is a required property for ValidatedApiTokenResponse and cannot be null");
            }
            else
            {
                this.TokenId = tokenId;
            }
            // to ensure "tokenScope" is required (not null)
            if (tokenScope == null)
            {
                throw new InvalidDataException("tokenScope is a required property for ValidatedApiTokenResponse and cannot be null");
            }
            else
            {
                this.TokenScope = tokenScope;
            }
            // to ensure "principalId" is required (not null)
            if (principalId == null)
            {
                throw new InvalidDataException("principalId is a required property for ValidatedApiTokenResponse and cannot be null");
            }
            else
            {
                this.PrincipalId = principalId;
            }
            // to ensure "principalType" is required (not null)
            if (principalType == null)
            {
                throw new InvalidDataException("principalType is a required property for ValidatedApiTokenResponse and cannot be null");
            }
            else
            {
                this.PrincipalType = principalType;
            }
            // to ensure "claims" is required (not null)
            if (claims == null)
            {
                throw new InvalidDataException("claims is a required property for ValidatedApiTokenResponse and cannot be null");
            }
            else
            {
                this.Claims = claims;
            }
        }
        
        /// <summary>
        /// The token&#x27;s unique id (UUID)
        /// </summary>
        /// <value>The token&#x27;s unique id (UUID)</value>
        [DataMember(Name="token_id", EmitDefaultValue=false)]
        public Guid? TokenId { get; set; }


        /// <summary>
        /// The ID of the owner of the API Token (user_id or app_id)
        /// </summary>
        /// <value>The ID of the owner of the API Token (user_id or app_id)</value>
        [DataMember(Name="principal_id", EmitDefaultValue=false)]
        public Guid? PrincipalId { get; set; }


        /// <summary>
        /// Collection of attributes that describe the principal of the specified API Token
        /// </summary>
        /// <value>Collection of attributes that describe the principal of the specified API Token</value>
        [DataMember(Name="claims", EmitDefaultValue=false)]
        public List<ValidatedApiTokenResponseClaims> Claims { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidatedApiTokenResponse {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TokenScope: ").Append(TokenScope).Append("\n");
            sb.Append("  PrincipalId: ").Append(PrincipalId).Append("\n");
            sb.Append("  PrincipalType: ").Append(PrincipalType).Append("\n");
            sb.Append("  Claims: ").Append(Claims).Append("\n");
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
            return this.Equals(input as ValidatedApiTokenResponse);
        }

        /// <summary>
        /// Returns true if ValidatedApiTokenResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidatedApiTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidatedApiTokenResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TokenScope == input.TokenScope ||
                    this.TokenScope != null &&
                    input.TokenScope != null &&
                    this.TokenScope.SequenceEqual(input.TokenScope)
                ) && 
                (
                    this.PrincipalId == input.PrincipalId ||
                    (this.PrincipalId != null &&
                    this.PrincipalId.Equals(input.PrincipalId))
                ) && 
                (
                    this.PrincipalType == input.PrincipalType ||
                    (this.PrincipalType != null &&
                    this.PrincipalType.Equals(input.PrincipalType))
                ) && 
                (
                    this.Claims == input.Claims ||
                    this.Claims != null &&
                    input.Claims != null &&
                    this.Claims.SequenceEqual(input.Claims)
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
                if (this.TokenId != null)
                    hashCode = hashCode * 59 + this.TokenId.GetHashCode();
                if (this.TokenScope != null)
                    hashCode = hashCode * 59 + this.TokenScope.GetHashCode();
                if (this.PrincipalId != null)
                    hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                if (this.PrincipalType != null)
                    hashCode = hashCode * 59 + this.PrincipalType.GetHashCode();
                if (this.Claims != null)
                    hashCode = hashCode * 59 + this.Claims.GetHashCode();
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
