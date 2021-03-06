// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Collections.Generic;
using System.Net.Http;

#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable SA1300 // Element must begin with upper-case letter
#pragma warning disable SA1516 // Elements must be separated by blank line
#pragma warning disable SA1649 // File name must match first type name

namespace Microsoft.Atlas.CommandLine.JsonClient
{
    public class JsonRequest
    {
        public HttpMethod method { get; set; }

        public string url { get; set; }

        public IDictionary<object, object> headers { get; set; }

        public object body { get; set; }

        public string secret { get; set; }
    }
}
