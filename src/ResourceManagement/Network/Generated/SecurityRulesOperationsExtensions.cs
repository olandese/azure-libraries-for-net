// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SecurityRulesOperations.
    /// </summary>
    public static partial class SecurityRulesOperationsExtensions
    {
        /// <summary>
        /// Deletes the specified network security rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// The name of the security rule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get the specified network security rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// The name of the security rule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SecurityRuleInner> GetAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Creates or updates a security rule in the specified network security group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// The name of the security rule.
        /// </param>
        /// <param name='securityRuleParameters'>
        /// Parameters supplied to the create or update network security rule
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SecurityRuleInner> CreateOrUpdateAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRuleInner securityRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets all security rules in a network security group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// The name of the network security group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<SecurityRuleInner>> ListAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes the specified network security rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// The name of the security rule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task BeginDeleteAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Creates or updates a security rule in the specified network security group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkSecurityGroupName'>
        /// The name of the network security group.
        /// </param>
        /// <param name='securityRuleName'>
        /// The name of the security rule.
        /// </param>
        /// <param name='securityRuleParameters'>
        /// Parameters supplied to the create or update network security rule
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SecurityRuleInner> BeginCreateOrUpdateAsync(this ISecurityRulesOperations operations, string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRuleInner securityRuleParameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets all security rules in a network security group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<SecurityRuleInner>> ListNextAsync(this ISecurityRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
