// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Customer disk job details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DataBoxCustomerDisk")]
    public partial class DataBoxCustomerDiskJobDetails : JobDetails
    {
        /// <summary>
        /// Initializes a new instance of the DataBoxCustomerDiskJobDetails
        /// class.
        /// </summary>
        public DataBoxCustomerDiskJobDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataBoxCustomerDiskJobDetails
        /// class.
        /// </summary>
        /// <param name="contactDetails">Contact details for notification and
        /// shipping.</param>
        /// <param name="returnToCustomerPackageDetails">Return package
        /// shipping details.</param>
        /// <param name="jobStages">List of stages that run in the job.</param>
        /// <param name="shippingAddress">Shipping address of the
        /// customer.</param>
        /// <param name="deliveryPackage">Delivery package shipping
        /// details.</param>
        /// <param name="returnPackage">Return package shipping
        /// details.</param>
        /// <param name="dataImportDetails">Details of the data to be imported
        /// into azure.</param>
        /// <param name="dataExportDetails">Details of the data to be exported
        /// from azure.</param>
        /// <param name="preferences">Preferences for the order.</param>
        /// <param name="copyLogDetails">List of copy log details.</param>
        /// <param name="reverseShipmentLabelSasKey">Shared access key to
        /// download the return shipment label</param>
        /// <param name="chainOfCustodySasKey">Shared access key to download
        /// the chain of custody logs</param>
        /// <param name="keyEncryptionKey">Details about which key encryption
        /// type is being used.</param>
        /// <param name="expectedDataSizeInTeraBytes">The expected size of the
        /// data, which needs to be transferred in this job, in
        /// terabytes.</param>
        /// <param name="actions">Available actions on the job.</param>
        /// <param name="lastMitigationActionOnJob">Last mitigation action
        /// performed on the job.</param>
        /// <param name="datacenterAddress">Datacenter address to ship to, for
        /// the given sku and storage location.</param>
        /// <param name="dataCenterCode">DataCenter code. Possible values
        /// include: 'Invalid', 'BY2', 'BY1', 'ORK70', 'AM2', 'AMS20', 'BY21',
        /// 'BY24', 'MWH01', 'AMS06', 'SSE90', 'SYD03', 'SYD23', 'CBR20',
        /// 'YTO20', 'CWL20', 'LON24', 'BOM01', 'BL20', 'BL7', 'SEL20',
        /// 'TYO01', 'BN1', 'SN5', 'CYS04', 'TYO22', 'YTO21', 'YQB20', 'FRA22',
        /// 'MAA01', 'CPQ02', 'CPQ20', 'SIN20', 'HKG20', 'SG2', 'MEL23',
        /// 'SEL21', 'OSA20', 'SHA03', 'BJB', 'JNB22', 'JNB21', 'MNZ21', 'SN8',
        /// 'AUH20', 'ZRH20', 'PUS20', 'AdHoc', 'CH1', 'DSM05'</param>
        /// <param name="importDiskDetailsCollection">Contains the map of disk
        /// serial number to the disk details for import jobs.</param>
        /// <param name="exportDiskDetailsCollection">Contains the map of disk
        /// serial number to the disk details for export jobs.</param>
        /// <param name="copyProgress">Copy progress per disk.</param>
        /// <param name="deliverToDcPackageDetails">Delivery package shipping
        /// details.</param>
        /// <param name="enableManifestBackup">Flag to indicate if disk
        /// manifest should be backed-up in the Storage Account.</param>
        public DataBoxCustomerDiskJobDetails(ContactDetails contactDetails, PackageCarrierDetails returnToCustomerPackageDetails, IList<JobStages> jobStages = default(IList<JobStages>), ShippingAddress shippingAddress = default(ShippingAddress), PackageShippingDetails deliveryPackage = default(PackageShippingDetails), PackageShippingDetails returnPackage = default(PackageShippingDetails), IList<DataImportDetails> dataImportDetails = default(IList<DataImportDetails>), IList<DataExportDetails> dataExportDetails = default(IList<DataExportDetails>), Preferences preferences = default(Preferences), IList<CopyLogDetails> copyLogDetails = default(IList<CopyLogDetails>), string reverseShipmentLabelSasKey = default(string), string chainOfCustodySasKey = default(string), KeyEncryptionKey keyEncryptionKey = default(KeyEncryptionKey), int? expectedDataSizeInTeraBytes = default(int?), IList<CustomerResolutionCode?> actions = default(IList<CustomerResolutionCode?>), LastMitigationActionOnJob lastMitigationActionOnJob = default(LastMitigationActionOnJob), DatacenterAddressResponse datacenterAddress = default(DatacenterAddressResponse), string dataCenterCode = default(string), IDictionary<string, ImportDiskDetails> importDiskDetailsCollection = default(IDictionary<string, ImportDiskDetails>), IDictionary<string, ExportDiskDetails> exportDiskDetailsCollection = default(IDictionary<string, ExportDiskDetails>), IList<DataBoxCustomerDiskCopyProgress> copyProgress = default(IList<DataBoxCustomerDiskCopyProgress>), PackageCarrierInfo deliverToDcPackageDetails = default(PackageCarrierInfo), bool? enableManifestBackup = default(bool?))
            : base(contactDetails, jobStages, shippingAddress, deliveryPackage, returnPackage, dataImportDetails, dataExportDetails, preferences, copyLogDetails, reverseShipmentLabelSasKey, chainOfCustodySasKey, keyEncryptionKey, expectedDataSizeInTeraBytes, actions, lastMitigationActionOnJob, datacenterAddress, dataCenterCode)
        {
            ImportDiskDetailsCollection = importDiskDetailsCollection;
            ExportDiskDetailsCollection = exportDiskDetailsCollection;
            CopyProgress = copyProgress;
            DeliverToDcPackageDetails = deliverToDcPackageDetails;
            ReturnToCustomerPackageDetails = returnToCustomerPackageDetails;
            EnableManifestBackup = enableManifestBackup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets contains the map of disk serial number to the disk
        /// details for import jobs.
        /// </summary>
        [JsonProperty(PropertyName = "importDiskDetailsCollection")]
        public IDictionary<string, ImportDiskDetails> ImportDiskDetailsCollection { get; set; }

        /// <summary>
        /// Gets contains the map of disk serial number to the disk details for
        /// export jobs.
        /// </summary>
        [JsonProperty(PropertyName = "exportDiskDetailsCollection")]
        public IDictionary<string, ExportDiskDetails> ExportDiskDetailsCollection { get; private set; }

        /// <summary>
        /// Gets copy progress per disk.
        /// </summary>
        [JsonProperty(PropertyName = "copyProgress")]
        public IList<DataBoxCustomerDiskCopyProgress> CopyProgress { get; private set; }

        /// <summary>
        /// Gets delivery package shipping details.
        /// </summary>
        [JsonProperty(PropertyName = "deliverToDcPackageDetails")]
        public PackageCarrierInfo DeliverToDcPackageDetails { get; private set; }

        /// <summary>
        /// Gets or sets return package shipping details.
        /// </summary>
        [JsonProperty(PropertyName = "returnToCustomerPackageDetails")]
        public PackageCarrierDetails ReturnToCustomerPackageDetails { get; set; }

        /// <summary>
        /// Gets or sets flag to indicate if disk manifest should be backed-up
        /// in the Storage Account.
        /// </summary>
        [JsonProperty(PropertyName = "enableManifestBackup")]
        public bool? EnableManifestBackup { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ReturnToCustomerPackageDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReturnToCustomerPackageDetails");
            }
            if (ImportDiskDetailsCollection != null)
            {
                foreach (var valueElement in ImportDiskDetailsCollection.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}