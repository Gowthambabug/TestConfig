// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application stack major version. </summary>
    public partial class StackMajorVersion
    {
        /// <summary> Initializes a new instance of StackMajorVersion. </summary>
        public StackMajorVersion()
        {
            MinorVersions = new ChangeTrackingList<StackMinorVersion>();
            AppSettingsDictionary = new ChangeTrackingDictionary<string, object>();
            SiteConfigPropertiesDictionary = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of StackMajorVersion. </summary>
        /// <param name="displayVersion"> Application stack major version (display only). </param>
        /// <param name="runtimeVersion"> Application stack major version (runtime only). </param>
        /// <param name="isDefault"> &lt;code&gt;true&lt;/code&gt; if this is the default major version; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="minorVersions"> Minor versions associated with the major version. </param>
        /// <param name="applicationInsights"> &lt;code&gt;true&lt;/code&gt; if this supports Application Insights; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isPreview"> &lt;code&gt;true&lt;/code&gt; if this stack is in Preview, otherwise &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isDeprecated"> &lt;code&gt;true&lt;/code&gt; if this stack has been deprecated, otherwise &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isHidden"> &lt;code&gt;true&lt;/code&gt; if this stack should be hidden for new customers on portal, otherwise &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appSettingsDictionary">
        /// &lt;appSettings&gt;
        ///  &lt;appSetting name=&quot;FUNCTIONS_WORKER_RUNTIME&quot; value=&quot;dotnet&quot; /&gt;
        /// &lt;/appSettings&gt;
        ///  Example: All the function apps need AppSetting: &quot;FUNCTIONS_WORKER_RUNTIME&quot; to be set stack name
        /// </param>
        /// <param name="siteConfigPropertiesDictionary">
        /// &lt;siteConfigProperties&gt;
        ///  &lt;siteConfigProperty name=&quot;Use32BitWorkerProcess&quot; value=&quot;false&quot; /&gt;
        /// &lt;/siteConfigProperties&gt;
        ///  Example: All Linux Function Apps, need Use32BitWorkerProcess to be set to 0
        /// </param>
        internal StackMajorVersion(string displayVersion, string runtimeVersion, bool? isDefault, IList<StackMinorVersion> minorVersions, bool? applicationInsights, bool? isPreview, bool? isDeprecated, bool? isHidden, IDictionary<string, object> appSettingsDictionary, IDictionary<string, object> siteConfigPropertiesDictionary)
        {
            DisplayVersion = displayVersion;
            RuntimeVersion = runtimeVersion;
            IsDefault = isDefault;
            MinorVersions = minorVersions;
            ApplicationInsights = applicationInsights;
            IsPreview = isPreview;
            IsDeprecated = isDeprecated;
            IsHidden = isHidden;
            AppSettingsDictionary = appSettingsDictionary;
            SiteConfigPropertiesDictionary = siteConfigPropertiesDictionary;
        }

        /// <summary> Application stack major version (display only). </summary>
        public string DisplayVersion { get; set; }
        /// <summary> Application stack major version (runtime only). </summary>
        public string RuntimeVersion { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this is the default major version; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDefault { get; set; }
        /// <summary> Minor versions associated with the major version. </summary>
        public IList<StackMinorVersion> MinorVersions { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this supports Application Insights; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? ApplicationInsights { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this stack is in Preview, otherwise &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsPreview { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this stack has been deprecated, otherwise &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsDeprecated { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if this stack should be hidden for new customers on portal, otherwise &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHidden { get; set; }
        /// <summary>
        /// &lt;appSettings&gt;
        ///  &lt;appSetting name=&quot;FUNCTIONS_WORKER_RUNTIME&quot; value=&quot;dotnet&quot; /&gt;
        /// &lt;/appSettings&gt;
        ///  Example: All the function apps need AppSetting: &quot;FUNCTIONS_WORKER_RUNTIME&quot; to be set stack name
        /// </summary>
        public IDictionary<string, object> AppSettingsDictionary { get; }
        /// <summary>
        /// &lt;siteConfigProperties&gt;
        ///  &lt;siteConfigProperty name=&quot;Use32BitWorkerProcess&quot; value=&quot;false&quot; /&gt;
        /// &lt;/siteConfigProperties&gt;
        ///  Example: All Linux Function Apps, need Use32BitWorkerProcess to be set to 0
        /// </summary>
        public IDictionary<string, object> SiteConfigPropertiesDictionary { get; }
    }
}