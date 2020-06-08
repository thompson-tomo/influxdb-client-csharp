/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
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
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// DBRP
    /// </summary>
    [DataContract]
    public partial class DBRP :  IEquatable<DBRP>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DBRP" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DBRP() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DBRP" /> class.
        /// </summary>
        /// <param name="orgID">the organization ID that owns this mapping. (required).</param>
        /// <param name="bucketID">the bucket ID used as target for the translation. (required).</param>
        /// <param name="database">InfluxDB v1 database (required).</param>
        /// <param name="retentionPolicy">InfluxDB v1 retention policy (required).</param>
        /// <param name="_default">Specify if this mapping represents the default retention policy for the database specificed..</param>
        /// <param name="links">links.</param>
        public DBRP(string orgID = default(string), string bucketID = default(string), string database = default(string), string retentionPolicy = default(string), bool? _default = default(bool?), Links links = default(Links))
        {
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException("orgID is a required property for DBRP and cannot be null");
            }
            else
            {
                this.OrgID = orgID;
            }
            // to ensure "bucketID" is required (not null)
            if (bucketID == null)
            {
                throw new InvalidDataException("bucketID is a required property for DBRP and cannot be null");
            }
            else
            {
                this.BucketID = bucketID;
            }
            // to ensure "database" is required (not null)
            if (database == null)
            {
                throw new InvalidDataException("database is a required property for DBRP and cannot be null");
            }
            else
            {
                this.Database = database;
            }
            // to ensure "retentionPolicy" is required (not null)
            if (retentionPolicy == null)
            {
                throw new InvalidDataException("retentionPolicy is a required property for DBRP and cannot be null");
            }
            else
            {
                this.RetentionPolicy = retentionPolicy;
            }
            this.Default = _default;
            this.Links = links;
        }

        /// <summary>
        /// the mapping identifier
        /// </summary>
        /// <value>the mapping identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// the organization ID that owns this mapping.
        /// </summary>
        /// <value>the organization ID that owns this mapping.</value>
        [DataMember(Name="orgID", EmitDefaultValue=false)]
        public string OrgID { get; set; }

        /// <summary>
        /// the bucket ID used as target for the translation.
        /// </summary>
        /// <value>the bucket ID used as target for the translation.</value>
        [DataMember(Name="bucketID", EmitDefaultValue=false)]
        public string BucketID { get; set; }

        /// <summary>
        /// InfluxDB v1 database
        /// </summary>
        /// <value>InfluxDB v1 database</value>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public string Database { get; set; }

        /// <summary>
        /// InfluxDB v1 retention policy
        /// </summary>
        /// <value>InfluxDB v1 retention policy</value>
        [DataMember(Name="retention_policy", EmitDefaultValue=false)]
        public string RetentionPolicy { get; set; }

        /// <summary>
        /// Specify if this mapping represents the default retention policy for the database specificed.
        /// </summary>
        /// <value>Specify if this mapping represents the default retention policy for the database specificed.</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DBRP {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  BucketID: ").Append(BucketID).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  RetentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as DBRP);
        }

        /// <summary>
        /// Returns true if DBRP instances are equal
        /// </summary>
        /// <param name="input">Instance of DBRP to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DBRP input)
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
                    this.OrgID == input.OrgID ||
                    (this.OrgID != null &&
                    this.OrgID.Equals(input.OrgID))
                ) && 
                (
                    this.BucketID == input.BucketID ||
                    (this.BucketID != null &&
                    this.BucketID.Equals(input.BucketID))
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.RetentionPolicy == input.RetentionPolicy ||
                    (this.RetentionPolicy != null &&
                    this.RetentionPolicy.Equals(input.RetentionPolicy))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.OrgID != null)
                    hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.BucketID != null)
                    hashCode = hashCode * 59 + this.BucketID.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.RetentionPolicy != null)
                    hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }

}