﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BillingWebJob.Models;

namespace BillingWebJob
{
    public static partial class CspBillingExtensions
    {
        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        public static IList<CspUsageLineItem> GetAllData(this ICspBilling operations)
        {
            return Task.Factory.StartNew((object s) => { return ((ICspBilling) s).GetAllDataAsync(); }
                    , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<CspUsageLineItem>> GetAllDataAsync(this ICspBilling operations,
            CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse
                <System.Collections.Generic.IList<BillingWebJob.Models.CspUsageLineItem>> result =
                    await operations.GetAllDataWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        public static IList<CspUsageLineItem> GetCurrentMonthData(this ICspBilling operations)
        {
            return Task.Factory.StartNew((object s) => { return ((ICspBilling) s).GetCurrentMonthDataAsync(); }
                    , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<CspUsageLineItem>> GetCurrentMonthDataAsync(this ICspBilling operations,
            CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse
                <System.Collections.Generic.IList<BillingWebJob.Models.CspUsageLineItem>> result =
                    await
                        operations.GetCurrentMonthDataWithOperationResponseAsync(cancellationToken)
                            .ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        /// <param name='startMMYYYY'>
        /// Required.
        /// </param>
        /// <param name='endMMYYYY'>
        /// Required.
        /// </param>
        public static IList<CspUsageLineItem> GetDataForMonthRange(this ICspBilling operations, string startMMYYYY,
            string endMMYYYY)
        {
            return
                Task.Factory.StartNew(
                        (object s) => { return ((ICspBilling) s).GetDataForMonthRangeAsync(startMMYYYY, endMMYYYY); }
                        , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        /// <param name='startMMYYYY'>
        /// Required.
        /// </param>
        /// <param name='endMMYYYY'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<CspUsageLineItem>> GetDataForMonthRangeAsync(this ICspBilling operations,
            string startMMYYYY, string endMMYYYY,
            CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse
                <System.Collections.Generic.IList<BillingWebJob.Models.CspUsageLineItem>> result =
                    await
                        operations.GetDataForMonthRangeWithOperationResponseAsync(startMMYYYY, endMMYYYY,
                            cancellationToken).ConfigureAwait(false);
            return result.Body;
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        /// <param name='mmyyyy'>
        /// Required.
        /// </param>
        public static IList<CspUsageLineItem> GetSingleMonthData(this ICspBilling operations, string mmyyyy)
        {
            return Task.Factory.StartNew((object s) => { return ((ICspBilling) s).GetSingleMonthDataAsync(mmyyyy); }
                    , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
        }

        /// <param name='operations'>
        /// Reference to the BillingWebJob.ICspBilling.
        /// </param>
        /// <param name='mmyyyy'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<CspUsageLineItem>> GetSingleMonthDataAsync(this ICspBilling operations,
            string mmyyyy, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse
                <System.Collections.Generic.IList<BillingWebJob.Models.CspUsageLineItem>> result =
                    await
                        operations.GetSingleMonthDataWithOperationResponseAsync(mmyyyy, cancellationToken)
                            .ConfigureAwait(false);
            return result.Body;
        }
    }
}