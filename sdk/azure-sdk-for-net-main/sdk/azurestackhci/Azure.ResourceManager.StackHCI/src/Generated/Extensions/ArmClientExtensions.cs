// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StackHCI
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region ArcSetting
        /// <summary> Gets an object representing a ArcSetting along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcSetting" /> object. </returns>
        public static ArcSetting GetArcSetting(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                ArcSetting.ValidateResourceId(id);
                return new ArcSetting(client, id);
            }
            );
        }
        #endregion

        #region HCICluster
        /// <summary> Gets an object representing a HCICluster along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HCICluster" /> object. </returns>
        public static HCICluster GetHCICluster(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                HCICluster.ValidateResourceId(id);
                return new HCICluster(client, id);
            }
            );
        }
        #endregion

        #region ArcExtension
        /// <summary> Gets an object representing a ArcExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcExtension" /> object. </returns>
        public static ArcExtension GetArcExtension(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                ArcExtension.ValidateResourceId(id);
                return new ArcExtension(client, id);
            }
            );
        }
        #endregion
    }
}
