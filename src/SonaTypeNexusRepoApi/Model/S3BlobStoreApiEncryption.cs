/* 
 * Nexus Repository Manager REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3.26.1-02
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
using SwaggerDateConverter = SonaTypeNexusRepoApi.Client.SwaggerDateConverter;

namespace SonaTypeNexusRepoApi.Model
{
    /// <summary>
    /// S3BlobStoreApiEncryption
    /// </summary>
    [DataContract]
    public partial class S3BlobStoreApiEncryption :  IEquatable<S3BlobStoreApiEncryption>, IValidatableObject
    {
        /// <summary>
        /// The type of S3 server side encryption to use.
        /// </summary>
        /// <value>The type of S3 server side encryption to use.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionTypeEnum
        {
            
            /// <summary>
            /// Enum S3ManagedEncryption for value: s3ManagedEncryption
            /// </summary>
            [EnumMember(Value = "s3ManagedEncryption")]
            S3ManagedEncryption = 1,
            
            /// <summary>
            /// Enum KmsManagedEncryption for value: kmsManagedEncryption
            /// </summary>
            [EnumMember(Value = "kmsManagedEncryption")]
            KmsManagedEncryption = 2
        }

        /// <summary>
        /// The type of S3 server side encryption to use.
        /// </summary>
        /// <value>The type of S3 server side encryption to use.</value>
        [DataMember(Name="encryptionType", EmitDefaultValue=false)]
        public EncryptionTypeEnum? EncryptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="S3BlobStoreApiEncryption" /> class.
        /// </summary>
        /// <param name="encryptionType">The type of S3 server side encryption to use..</param>
        /// <param name="encryptionKey">The encryption key..</param>
        public S3BlobStoreApiEncryption(EncryptionTypeEnum? encryptionType = default(EncryptionTypeEnum?), string encryptionKey = default(string))
        {
            this.EncryptionType = encryptionType;
            this.EncryptionKey = encryptionKey;
        }
        

        /// <summary>
        /// The encryption key.
        /// </summary>
        /// <value>The encryption key.</value>
        [DataMember(Name="encryptionKey", EmitDefaultValue=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class S3BlobStoreApiEncryption {\n");
            sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  EncryptionKey: ").Append(EncryptionKey).Append("\n");
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
            return this.Equals(input as S3BlobStoreApiEncryption);
        }

        /// <summary>
        /// Returns true if S3BlobStoreApiEncryption instances are equal
        /// </summary>
        /// <param name="input">Instance of S3BlobStoreApiEncryption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(S3BlobStoreApiEncryption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EncryptionType == input.EncryptionType ||
                    (this.EncryptionType != null &&
                    this.EncryptionType.Equals(input.EncryptionType))
                ) && 
                (
                    this.EncryptionKey == input.EncryptionKey ||
                    (this.EncryptionKey != null &&
                    this.EncryptionKey.Equals(input.EncryptionKey))
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
                if (this.EncryptionType != null)
                    hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                if (this.EncryptionKey != null)
                    hashCode = hashCode * 59 + this.EncryptionKey.GetHashCode();
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
