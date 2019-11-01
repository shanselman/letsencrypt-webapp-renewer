﻿using System;
using System.Collections.Generic;
using OhadSoft.AzureLetsEncrypt.Renewal.Management;

namespace OhadSoft.AzureLetsEncrypt.Renewal.WebJob.Tests.WebJob
{
    // Generated by Resharper (alt+insert in AzureEnvironmentParams)
    public sealed class AzureEnvironmentParamsComparer : IComparer<AzureEnvironmentParams>
    {
        public int Compare(AzureEnvironmentParams x, AzureEnvironmentParams y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            var tenantIdComparison = string.Compare(x.TenantId, y.TenantId, StringComparison.Ordinal);
            if (tenantIdComparison != 0) return tenantIdComparison;
            var subscriptionIdComparison = Nullable.Compare(x.SubscriptionId, y.SubscriptionId);
            if (subscriptionIdComparison != 0) return subscriptionIdComparison;
            var resourceGroupComparison = string.Compare(x.ResourceGroup, y.ResourceGroup, StringComparison.Ordinal);
            if (resourceGroupComparison != 0) return resourceGroupComparison;
            var clientIdComparison = Nullable.Compare(x.ClientId, y.ClientId);
            if (clientIdComparison != 0) return clientIdComparison;
            return string.Compare(x.ClientSecret, y.ClientSecret, StringComparison.Ordinal);
        }
    }
}