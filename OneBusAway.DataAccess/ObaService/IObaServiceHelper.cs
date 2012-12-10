﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OneBusAway.DataAccess
{
    /// <summary>
    /// This interface defines an object that talks to a web service.
    /// </summary>
    public interface IObaServiceHelper
    {
        /// <summary>
        /// Adds a name / value pair to the query string.
        /// </summary>
        void AddToQueryString(string name, string value);

        /// <summary>
        /// For some rest API calls, the format will be:
        /// 
        /// obamethod/id.xml?querystring
        /// 
        /// Instead of just 
        /// 
        /// obamethod.xml?querystring.
        /// </summary>
        void SetId(string id);

        /// <summary>
        /// Sends a payload to the service asynchronously and reads the response.
        /// </summary>
        Task<XDocument> SendAndRecieveAsync(string payload = null);
    }
}