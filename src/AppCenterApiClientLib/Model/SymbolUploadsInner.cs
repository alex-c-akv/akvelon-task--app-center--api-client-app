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
    /// A single symbol upload entity
    /// </summary>
    [DataContract]
        public partial class SymbolUploadsInner :  IEquatable<SymbolUploadsInner>, IValidatableObject
    {
        /// <summary>
        /// The current status for the symbol upload
        /// </summary>
        /// <value>The current status for the symbol upload</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Created for value: created
            /// </summary>
            [EnumMember(Value = "created")]
            Created = 1,
            /// <summary>
            /// Enum Committed for value: committed
            /// </summary>
            [EnumMember(Value = "committed")]
            Committed = 2,
            /// <summary>
            /// Enum Aborted for value: aborted
            /// </summary>
            [EnumMember(Value = "aborted")]
            Aborted = 3,
            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 4,
            /// <summary>
            /// Enum Indexed for value: indexed
            /// </summary>
            [EnumMember(Value = "indexed")]
            Indexed = 5,
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 6        }
        /// <summary>
        /// The current status for the symbol upload
        /// </summary>
        /// <value>The current status for the symbol upload</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// The type of the symbol for the current symbol upload
        /// </summary>
        /// <value>The type of the symbol for the current symbol upload</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SymbolTypeEnum
        {
            /// <summary>
            /// Enum Apple for value: Apple
            /// </summary>
            [EnumMember(Value = "Apple")]
            Apple = 1,
            /// <summary>
            /// Enum JavaScript for value: JavaScript
            /// </summary>
            [EnumMember(Value = "JavaScript")]
            JavaScript = 2,
            /// <summary>
            /// Enum Breakpad for value: Breakpad
            /// </summary>
            [EnumMember(Value = "Breakpad")]
            Breakpad = 3,
            /// <summary>
            /// Enum AndroidProguard for value: AndroidProguard
            /// </summary>
            [EnumMember(Value = "AndroidProguard")]
            AndroidProguard = 4,
            /// <summary>
            /// Enum UWP for value: UWP
            /// </summary>
            [EnumMember(Value = "UWP")]
            UWP = 5        }
        /// <summary>
        /// The type of the symbol for the current symbol upload
        /// </summary>
        /// <value>The type of the symbol for the current symbol upload</value>
        [DataMember(Name="symbol_type", EmitDefaultValue=false)]
        public SymbolTypeEnum SymbolType { get; set; }
        /// <summary>
        /// The origin of the symbol upload
        /// </summary>
        /// <value>The origin of the symbol upload</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OriginEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,
            /// <summary>
            /// Enum System for value: System
            /// </summary>
            [EnumMember(Value = "System")]
            System = 2        }
        /// <summary>
        /// The origin of the symbol upload
        /// </summary>
        /// <value>The origin of the symbol upload</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public OriginEnum? Origin { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolUploadsInner" /> class.
        /// </summary>
        /// <param name="symbolUploadId">The id for the current symbol upload (required).</param>
        /// <param name="appId">The application that this symbol upload belongs to (required).</param>
        /// <param name="user">User information of the one who intitiated the symbol upload.</param>
        /// <param name="status">The current status for the symbol upload (required).</param>
        /// <param name="symbolType">The type of the symbol for the current symbol upload (required).</param>
        /// <param name="symbolsUploaded">The symbols found in the upload. This may be empty until the status is indexed.</param>
        /// <param name="origin">The origin of the symbol upload.</param>
        /// <param name="fileName">The file name for the symbol upload.</param>
        /// <param name="fileSize">The size of the file in Mebibytes. This may be 0 until the status is indexed.</param>
        /// <param name="timestamp">When the symbol upload was committed, or last transaction time if not committed.</param>
        public SymbolUploadsInner(string symbolUploadId = default(string), string appId = default(string), Object user = default(Object), StatusEnum status = default(StatusEnum), SymbolTypeEnum symbolType = default(SymbolTypeEnum), List<Object> symbolsUploaded = default(List<Object>), OriginEnum? origin = default(OriginEnum?), string fileName = default(string), decimal? fileSize = default(decimal?), DateTime? timestamp = default(DateTime?))
        {
            // to ensure "symbolUploadId" is required (not null)
            if (symbolUploadId == null)
            {
                throw new InvalidDataException("symbolUploadId is a required property for SymbolUploadsInner and cannot be null");
            }
            else
            {
                this.SymbolUploadId = symbolUploadId;
            }
            // to ensure "appId" is required (not null)
            if (appId == null)
            {
                throw new InvalidDataException("appId is a required property for SymbolUploadsInner and cannot be null");
            }
            else
            {
                this.AppId = appId;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for SymbolUploadsInner and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "symbolType" is required (not null)
            if (symbolType == null)
            {
                throw new InvalidDataException("symbolType is a required property for SymbolUploadsInner and cannot be null");
            }
            else
            {
                this.SymbolType = symbolType;
            }
            this.User = user;
            this.SymbolsUploaded = symbolsUploaded;
            this.Origin = origin;
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// The id for the current symbol upload
        /// </summary>
        /// <value>The id for the current symbol upload</value>
        [DataMember(Name="symbol_upload_id", EmitDefaultValue=false)]
        public string SymbolUploadId { get; set; }

        /// <summary>
        /// The application that this symbol upload belongs to
        /// </summary>
        /// <value>The application that this symbol upload belongs to</value>
        [DataMember(Name="app_id", EmitDefaultValue=false)]
        public string AppId { get; set; }

        /// <summary>
        /// User information of the one who intitiated the symbol upload
        /// </summary>
        /// <value>User information of the one who intitiated the symbol upload</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public Object User { get; set; }



        /// <summary>
        /// The symbols found in the upload. This may be empty until the status is indexed
        /// </summary>
        /// <value>The symbols found in the upload. This may be empty until the status is indexed</value>
        [DataMember(Name="symbols_uploaded", EmitDefaultValue=false)]
        public List<Object> SymbolsUploaded { get; set; }


        /// <summary>
        /// The file name for the symbol upload
        /// </summary>
        /// <value>The file name for the symbol upload</value>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The size of the file in Mebibytes. This may be 0 until the status is indexed
        /// </summary>
        /// <value>The size of the file in Mebibytes. This may be 0 until the status is indexed</value>
        [DataMember(Name="file_size", EmitDefaultValue=false)]
        public decimal? FileSize { get; set; }

        /// <summary>
        /// When the symbol upload was committed, or last transaction time if not committed
        /// </summary>
        /// <value>When the symbol upload was committed, or last transaction time if not committed</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SymbolUploadsInner {\n");
            sb.Append("  SymbolUploadId: ").Append(SymbolUploadId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SymbolType: ").Append(SymbolType).Append("\n");
            sb.Append("  SymbolsUploaded: ").Append(SymbolsUploaded).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as SymbolUploadsInner);
        }

        /// <summary>
        /// Returns true if SymbolUploadsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of SymbolUploadsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SymbolUploadsInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SymbolUploadId == input.SymbolUploadId ||
                    (this.SymbolUploadId != null &&
                    this.SymbolUploadId.Equals(input.SymbolUploadId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SymbolType == input.SymbolType ||
                    (this.SymbolType != null &&
                    this.SymbolType.Equals(input.SymbolType))
                ) && 
                (
                    this.SymbolsUploaded == input.SymbolsUploaded ||
                    this.SymbolsUploaded != null &&
                    input.SymbolsUploaded != null &&
                    this.SymbolsUploaded.SequenceEqual(input.SymbolsUploaded)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    (this.FileSize != null &&
                    this.FileSize.Equals(input.FileSize))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.SymbolUploadId != null)
                    hashCode = hashCode * 59 + this.SymbolUploadId.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SymbolType != null)
                    hashCode = hashCode * 59 + this.SymbolType.GetHashCode();
                if (this.SymbolsUploaded != null)
                    hashCode = hashCode * 59 + this.SymbolsUploaded.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileSize != null)
                    hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
