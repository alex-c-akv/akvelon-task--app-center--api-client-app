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
    /// The information for a single iOS device
    /// </summary>
    [DataContract]
        public partial class InlineResponse2003 :  IEquatable<InlineResponse2003>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003" /> class.
        /// </summary>
        /// <param name="udid">The Unique Device IDentifier of the device (required).</param>
        /// <param name="model">The model identifier of the device, in the format iDeviceM,N (required).</param>
        /// <param name="deviceName">The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot; (required).</param>
        /// <param name="fullDeviceName">A combination of the device model name and the owner name..</param>
        /// <param name="osBuild">The last known OS version running on the device (required).</param>
        /// <param name="osVersion">The last known OS version running on the device (required).</param>
        /// <param name="serial">The device&#x27;s serial number. Always empty or undefined at present..</param>
        /// <param name="imei">The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present..</param>
        /// <param name="ownerId">The user ID of the device owner..</param>
        /// <param name="status">The provisioning status of the device. (required).</param>
        /// <param name="registeredAt">Timestamp of when the device was registered in ISO format..</param>
        public InlineResponse2003(string udid = default(string), string model = default(string), string deviceName = default(string), string fullDeviceName = default(string), string osBuild = default(string), string osVersion = default(string), string serial = default(string), string imei = default(string), string ownerId = default(string), string status = default(string), string registeredAt = default(string))
        {
            // to ensure "udid" is required (not null)
            if (udid == null)
            {
                throw new InvalidDataException("udid is a required property for InlineResponse2003 and cannot be null");
            }
            else
            {
                this.Udid = udid;
            }
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for InlineResponse2003 and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "deviceName" is required (not null)
            if (deviceName == null)
            {
                throw new InvalidDataException("deviceName is a required property for InlineResponse2003 and cannot be null");
            }
            else
            {
                this.DeviceName = deviceName;
            }
            // to ensure "osBuild" is required (not null)
            if (osBuild == null)
            {
                throw new InvalidDataException("osBuild is a required property for InlineResponse2003 and cannot be null");
            }
            else
            {
                this.OsBuild = osBuild;
            }
            // to ensure "osVersion" is required (not null)
            if (osVersion == null)
            {
                throw new InvalidDataException("osVersion is a required property for InlineResponse2003 and cannot be null");
            }
            else
            {
                this.OsVersion = osVersion;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for InlineResponse2003 and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.FullDeviceName = fullDeviceName;
            this.Serial = serial;
            this.Imei = imei;
            this.OwnerId = ownerId;
            this.RegisteredAt = registeredAt;
        }
        
        /// <summary>
        /// The Unique Device IDentifier of the device
        /// </summary>
        /// <value>The Unique Device IDentifier of the device</value>
        [DataMember(Name="udid", EmitDefaultValue=false)]
        public string Udid { get; set; }

        /// <summary>
        /// The model identifier of the device, in the format iDeviceM,N
        /// </summary>
        /// <value>The model identifier of the device, in the format iDeviceM,N</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot;
        /// </summary>
        /// <value>The device description, in the format \&quot;iPhone 7 Plus (A1784)\&quot;</value>
        [DataMember(Name="device_name", EmitDefaultValue=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// A combination of the device model name and the owner name.
        /// </summary>
        /// <value>A combination of the device model name and the owner name.</value>
        [DataMember(Name="full_device_name", EmitDefaultValue=false)]
        public string FullDeviceName { get; set; }

        /// <summary>
        /// The last known OS version running on the device
        /// </summary>
        /// <value>The last known OS version running on the device</value>
        [DataMember(Name="os_build", EmitDefaultValue=false)]
        public string OsBuild { get; set; }

        /// <summary>
        /// The last known OS version running on the device
        /// </summary>
        /// <value>The last known OS version running on the device</value>
        [DataMember(Name="os_version", EmitDefaultValue=false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// The device&#x27;s serial number. Always empty or undefined at present.
        /// </summary>
        /// <value>The device&#x27;s serial number. Always empty or undefined at present.</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }

        /// <summary>
        /// The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present.
        /// </summary>
        /// <value>The device&#x27;s International Mobile Equipment Identity number. Always empty or undefined at present.</value>
        [DataMember(Name="imei", EmitDefaultValue=false)]
        public string Imei { get; set; }

        /// <summary>
        /// The user ID of the device owner.
        /// </summary>
        /// <value>The user ID of the device owner.</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The provisioning status of the device.
        /// </summary>
        /// <value>The provisioning status of the device.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Timestamp of when the device was registered in ISO format.
        /// </summary>
        /// <value>Timestamp of when the device was registered in ISO format.</value>
        [DataMember(Name="registered_at", EmitDefaultValue=false)]
        public string RegisteredAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003 {\n");
            sb.Append("  Udid: ").Append(Udid).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  FullDeviceName: ").Append(FullDeviceName).Append("\n");
            sb.Append("  OsBuild: ").Append(OsBuild).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RegisteredAt: ").Append(RegisteredAt).Append("\n");
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
            return this.Equals(input as InlineResponse2003);
        }

        /// <summary>
        /// Returns true if InlineResponse2003 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2003 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Udid == input.Udid ||
                    (this.Udid != null &&
                    this.Udid.Equals(input.Udid))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.FullDeviceName == input.FullDeviceName ||
                    (this.FullDeviceName != null &&
                    this.FullDeviceName.Equals(input.FullDeviceName))
                ) && 
                (
                    this.OsBuild == input.OsBuild ||
                    (this.OsBuild != null &&
                    this.OsBuild.Equals(input.OsBuild))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.Serial == input.Serial ||
                    (this.Serial != null &&
                    this.Serial.Equals(input.Serial))
                ) && 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RegisteredAt == input.RegisteredAt ||
                    (this.RegisteredAt != null &&
                    this.RegisteredAt.Equals(input.RegisteredAt))
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
                if (this.Udid != null)
                    hashCode = hashCode * 59 + this.Udid.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.DeviceName != null)
                    hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.FullDeviceName != null)
                    hashCode = hashCode * 59 + this.FullDeviceName.GetHashCode();
                if (this.OsBuild != null)
                    hashCode = hashCode * 59 + this.OsBuild.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.Serial != null)
                    hashCode = hashCode * 59 + this.Serial.GetHashCode();
                if (this.Imei != null)
                    hashCode = hashCode * 59 + this.Imei.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RegisteredAt != null)
                    hashCode = hashCode * 59 + this.RegisteredAt.GetHashCode();
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
