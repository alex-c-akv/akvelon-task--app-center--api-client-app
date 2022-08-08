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
    /// UserProfileResponse
    /// </summary>
    [DataContract]
        public partial class UserProfileResponse :  IEquatable<UserProfileResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines Permissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PermissionsEnum
        {
            /// <summary>
            /// Enum Manager for value: manager
            /// </summary>
            [EnumMember(Value = "manager")]
            Manager = 1,
            /// <summary>
            /// Enum Developer for value: developer
            /// </summary>
            [EnumMember(Value = "developer")]
            Developer = 2,
            /// <summary>
            /// Enum Viewer for value: viewer
            /// </summary>
            [EnumMember(Value = "viewer")]
            Viewer = 3,
            /// <summary>
            /// Enum Tester for value: tester
            /// </summary>
            [EnumMember(Value = "tester")]
            Tester = 4        }
        /// <summary>
        /// The permissions the user has for the app
        /// </summary>
        /// <value>The permissions the user has for the app</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// The creation origin of this user
        /// </summary>
        /// <value>The creation origin of this user</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OriginEnum
        {
            /// <summary>
            /// Enum Appcenter for value: appcenter
            /// </summary>
            [EnumMember(Value = "appcenter")]
            Appcenter = 1,
            /// <summary>
            /// Enum Hockeyapp for value: hockeyapp
            /// </summary>
            [EnumMember(Value = "hockeyapp")]
            Hockeyapp = 2,
            /// <summary>
            /// Enum Codepush for value: codepush
            /// </summary>
            [EnumMember(Value = "codepush")]
            Codepush = 3        }
        /// <summary>
        /// The creation origin of this user
        /// </summary>
        /// <value>The creation origin of this user</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileResponse" /> class.
        /// </summary>
        /// <param name="id">The unique id (UUID) of the user (required).</param>
        /// <param name="avatarUrl">The avatar URL of the user.</param>
        /// <param name="canChangePassword">User is required to send an old password in order to change the password..</param>
        /// <param name="displayName">The full name of the user. Might for example be first and last name (required).</param>
        /// <param name="email">The email address of the user (required).</param>
        /// <param name="name">The unique name that is used to identify the user. (required).</param>
        /// <param name="permissions">The permissions the user has for the app.</param>
        /// <param name="origin">The creation origin of this user (required).</param>
        public UserProfileResponse(Guid? id = default(Guid?), string avatarUrl = default(string), bool? canChangePassword = default(bool?), string displayName = default(string), string email = default(string), string name = default(string), List<PermissionsEnum> permissions = default(List<PermissionsEnum>), OriginEnum origin = default(OriginEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for UserProfileResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for UserProfileResponse and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for UserProfileResponse and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for UserProfileResponse and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "origin" is required (not null)
            if (origin == null)
            {
                throw new InvalidDataException("origin is a required property for UserProfileResponse and cannot be null");
            }
            else
            {
                this.Origin = origin;
            }
            this.AvatarUrl = avatarUrl;
            this.CanChangePassword = canChangePassword;
            this.Permissions = permissions;
        }
        
        /// <summary>
        /// The unique id (UUID) of the user
        /// </summary>
        /// <value>The unique id (UUID) of the user</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The avatar URL of the user
        /// </summary>
        /// <value>The avatar URL of the user</value>
        [DataMember(Name="avatar_url", EmitDefaultValue=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// User is required to send an old password in order to change the password.
        /// </summary>
        /// <value>User is required to send an old password in order to change the password.</value>
        [DataMember(Name="can_change_password", EmitDefaultValue=false)]
        public bool? CanChangePassword { get; set; }

        /// <summary>
        /// The full name of the user. Might for example be first and last name
        /// </summary>
        /// <value>The full name of the user. Might for example be first and last name</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the user
        /// </summary>
        /// <value>The email address of the user</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The unique name that is used to identify the user.
        /// </summary>
        /// <value>The unique name that is used to identify the user.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
            sb.Append("  CanChangePassword: ").Append(CanChangePassword).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
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
            return this.Equals(input as UserProfileResponse);
        }

        /// <summary>
        /// Returns true if UserProfileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileResponse input)
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
                    this.AvatarUrl == input.AvatarUrl ||
                    (this.AvatarUrl != null &&
                    this.AvatarUrl.Equals(input.AvatarUrl))
                ) && 
                (
                    this.CanChangePassword == input.CanChangePassword ||
                    (this.CanChangePassword != null &&
                    this.CanChangePassword.Equals(input.CanChangePassword))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
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
                if (this.AvatarUrl != null)
                    hashCode = hashCode * 59 + this.AvatarUrl.GetHashCode();
                if (this.CanChangePassword != null)
                    hashCode = hashCode * 59 + this.CanChangePassword.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
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
