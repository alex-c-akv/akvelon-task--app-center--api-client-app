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
    /// InvitationDetailResponse
    /// </summary>
    [DataContract]
        public partial class InvitationDetailResponse :  IEquatable<InvitationDetailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationDetailResponse" /> class.
        /// </summary>
        /// <param name="invitationId">The id of the invitation (required).</param>
        /// <param name="invitedBy">invitedBy (required).</param>
        /// <param name="organization">organization.</param>
        /// <param name="app">app.</param>
        public InvitationDetailResponse(Guid? invitationId = default(Guid?), AppInvitationDetailResponseInvitedBy invitedBy = default(AppInvitationDetailResponseInvitedBy), V01invitationssentOrganization organization = default(V01invitationssentOrganization), AllOfInvitationDetailResponseApp app = default(AllOfInvitationDetailResponseApp))
        {
            // to ensure "invitationId" is required (not null)
            if (invitationId == null)
            {
                throw new InvalidDataException("invitationId is a required property for InvitationDetailResponse and cannot be null");
            }
            else
            {
                this.InvitationId = invitationId;
            }
            // to ensure "invitedBy" is required (not null)
            if (invitedBy == null)
            {
                throw new InvalidDataException("invitedBy is a required property for InvitationDetailResponse and cannot be null");
            }
            else
            {
                this.InvitedBy = invitedBy;
            }
            this.Organization = organization;
            this.App = app;
        }
        
        /// <summary>
        /// The id of the invitation
        /// </summary>
        /// <value>The id of the invitation</value>
        [DataMember(Name="invitation_id", EmitDefaultValue=false)]
        public Guid? InvitationId { get; set; }

        /// <summary>
        /// Gets or Sets InvitedBy
        /// </summary>
        [DataMember(Name="invited_by", EmitDefaultValue=false)]
        public AppInvitationDetailResponseInvitedBy InvitedBy { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public V01invitationssentOrganization Organization { get; set; }

        /// <summary>
        /// Gets or Sets App
        /// </summary>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public AllOfInvitationDetailResponseApp App { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationDetailResponse {\n");
            sb.Append("  InvitationId: ").Append(InvitationId).Append("\n");
            sb.Append("  InvitedBy: ").Append(InvitedBy).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  App: ").Append(App).Append("\n");
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
            return this.Equals(input as InvitationDetailResponse);
        }

        /// <summary>
        /// Returns true if InvitationDetailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InvitationDetailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationDetailResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvitationId == input.InvitationId ||
                    (this.InvitationId != null &&
                    this.InvitationId.Equals(input.InvitationId))
                ) && 
                (
                    this.InvitedBy == input.InvitedBy ||
                    (this.InvitedBy != null &&
                    this.InvitedBy.Equals(input.InvitedBy))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
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
                if (this.InvitationId != null)
                    hashCode = hashCode * 59 + this.InvitationId.GetHashCode();
                if (this.InvitedBy != null)
                    hashCode = hashCode * 59 + this.InvitedBy.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
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
