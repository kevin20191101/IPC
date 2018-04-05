﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.ResourcePerformance.SolderPastePrinting
{
    public class CleanStencilResponse : CFXMessage
    {
        public CleanStencilResponse()
        {
            Result = new RequestResult();
        }

        /// <summary>
        /// The result of the request
        /// </summary>
        public RequestResult Result
        {
            get;
            set;
        }
    }
}
