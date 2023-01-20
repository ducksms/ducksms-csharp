/* 
 * Ducksms
 *
 * Ducksms is a leading SMS messaging service provider offering one-way SMS communication services from your internet enabled computer. The API allow you to directly communicate and manage a SMS with our SMS gateway system.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@ducksms.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.Ducksms.Client.OpenAPIDateConverter;

namespace Org.Ducksms.Model
{
    /// <summary>
    /// SmsSchema
    /// </summary>
    [DataContract]
    public partial class SmsSchema :  IEquatable<SmsSchema>, IValidatableObject
    {
        /// <summary>
        /// Preview the sms information
        /// </summary>
        /// <value>Preview the sms information</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PreviewEnum
        {
            /// <summary>
            /// Enum Yes for value: yes
            /// </summary>
            [EnumMember(Value = "yes")]
            Yes = 1,

            /// <summary>
            /// Enum No for value: no
            /// </summary>
            [EnumMember(Value = "no")]
            No = 2

        }

        /// <summary>
        /// Preview the sms information
        /// </summary>
        /// <value>Preview the sms information</value>
        [DataMember(Name="preview", EmitDefaultValue=false)]
        public PreviewEnum? Preview { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsSchema" /> class.
        /// </summary>
        /// <param name="preview">Preview the sms information.</param>
        /// <param name="mobileNumbers">mobileNumbers.</param>
        /// <param name="message">message.</param>
        /// <param name="senderId">senderId.</param>
        /// <param name="scheduledAt">scheduledAt.</param>
        /// <param name="callbackUrl">callbackUrl.</param>
        public SmsSchema(PreviewEnum? preview = default(PreviewEnum?), List<string> mobileNumbers = default(List<string>), string message = default(string), string senderId = default(string), string scheduledAt = default(string), string callbackUrl = default(string))
        {
            this.MobileNumbers = mobileNumbers;
            this.Message = message;
            this.SenderId = senderId;
            this.ScheduledAt = scheduledAt;
            this.CallbackUrl = callbackUrl;
            this.Preview = preview;
            this.MobileNumbers = mobileNumbers;
            this.Message = message;
            this.SenderId = senderId;
            this.ScheduledAt = scheduledAt;
            this.CallbackUrl = callbackUrl;
        }
        

        /// <summary>
        /// Gets or Sets MobileNumbers
        /// </summary>
        [DataMember(Name="mobile_numbers", EmitDefaultValue=true)]
        public List<string> MobileNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=true)]
        public string SenderId { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledAt
        /// </summary>
        [DataMember(Name="scheduled_at", EmitDefaultValue=true)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [DataMember(Name="callback_url", EmitDefaultValue=true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsSchema {\n");
            sb.Append("  Preview: ").Append(Preview).Append("\n");
            sb.Append("  MobileNumbers: ").Append(MobileNumbers).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
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
            return this.Equals(input as SmsSchema);
        }

        /// <summary>
        /// Returns true if SmsSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Preview == input.Preview ||
                    (this.Preview != null &&
                    this.Preview.Equals(input.Preview))
                ) && 
                (
                    this.MobileNumbers == input.MobileNumbers ||
                    this.MobileNumbers != null &&
                    input.MobileNumbers != null &&
                    this.MobileNumbers.SequenceEqual(input.MobileNumbers)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
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
                if (this.Preview != null)
                    hashCode = hashCode * 59 + this.Preview.GetHashCode();
                if (this.MobileNumbers != null)
                    hashCode = hashCode * 59 + this.MobileNumbers.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
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
