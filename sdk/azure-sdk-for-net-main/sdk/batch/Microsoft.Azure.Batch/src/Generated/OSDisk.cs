// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Settings for the operating system disk of the compute node (VM).
    /// </summary>
    public partial class OSDisk : ITransportObjectProvider<Models.OSDisk>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<DiffDiskSettings> EphemeralOSDiskSettingsProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.EphemeralOSDiskSettingsProperty = this.CreatePropertyAccessor<DiffDiskSettings>(nameof(EphemeralOSDiskSettings), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.OSDisk protocolObject) : base(BindingState.Bound)
            {
                this.EphemeralOSDiskSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.EphemeralOSDiskSettings, o => new DiffDiskSettings(o)),
                    nameof(EphemeralOSDiskSettings),
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OSDisk"/> class.
        /// </summary>
        public OSDisk()
        {
            this.propertyContainer = new PropertyContainer();
        }

        internal OSDisk(Models.OSDisk protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region OSDisk

        /// <summary>
        /// Gets or sets specifies the ephemeral Disk Settings for the operating system disk used by the compute node (VM).
        /// </summary>
        public DiffDiskSettings EphemeralOSDiskSettings
        {
            get { return this.propertyContainer.EphemeralOSDiskSettingsProperty.Value; }
            set { this.propertyContainer.EphemeralOSDiskSettingsProperty.Value = value; }
        }

        #endregion // OSDisk

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.OSDisk ITransportObjectProvider<Models.OSDisk>.GetTransportObject()
        {
            Models.OSDisk result = new Models.OSDisk()
            {
                EphemeralOSDiskSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.EphemeralOSDiskSettings, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}