﻿using Newtonsoft.Json;

namespace com.persephony.api.queue
{
    /// <summary>
    /// Represents a paginated list of Persephony Queue instances. This object will
    /// be automatically created by QueuesRequester.
    /// </summary>
    public sealed class QueueList : PersyList
    {
        /// <summary>
        /// Creates a new QueueList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a queue list from the Persephony API.</param>
        public QueueList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "queues")
        { }

        /// <summary>
        /// Used by QueueList to create Queue objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony queue instance.</param>
        /// <returns>An equivalent queue object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Queue>(element);
        }
    }
}
