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
    /// OrganizationUserResponse
    /// </summary>
    [DataContract]
        public partial class OrganizationUserResponse :  IEquatable<OrganizationUserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUserResponse" /> class.
        /// </summary>
        /// <param name="email">The email address of the user (required).</param>
        /// <param name="displayName">The full name of the user. Might for example be first and last name (required).</param>
        /// <param name="joinedAt">The date when the user joined the organization (required).</param>
        /// <param name="name">The unique name that is used to identify the user. (required).</param>
        /// <param name="role">The role the user has within the organization (required).</param>
        public OrganizationUserResponse(string email = default(string), string displayName = default(string), string joinedAt = default(string), string name = default(string), string role = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for OrganizationUserResponse and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for OrganizationUserResponse and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "joinedAt" is required (not null)
            if (joinedAt == null)
            {
                throw new InvalidDataException("joinedAt is a required property for OrganizationUserResponse and cannot be null");
            }
            else
            {
                this.JoinedAt = joinedAt;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for OrganizationUserResponse and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for OrganizationUserResponse and cannot be null");
            }
            else
            {
                this.Role = role;
            }
        }
        
        /// <summary>
        /// The email address of the user
        /// </summary>
        /// <value>The email address of the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The full name of the user. Might for example be first and last name
        /// </summary>
        /// <value>The full name of the user. Might for example be first and last name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The date when the user joined the organization
        /// </summary>
        /// <value>The date when the user joined the organization</value>
        [DataMember(Name="joined_at", EmitDefaultValue=false)]
        public string JoinedAt { get; set; }

        /// <summary>
        /// The unique name that is used to identify the user.
        /// </summary>
        /// <value>The unique name that is used to identify the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The role the user has within the organization
        /// </summary>
        /// <value>The role the user has within the organization</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationUserResponse {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  JoinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as OrganizationUserResponse);
        }

        /// <summary>
        /// Returns true if OrganizationUserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationUserResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.JoinedAt != null)
                    hashCode = hashCode * 59 + this.JoinedAt.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
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