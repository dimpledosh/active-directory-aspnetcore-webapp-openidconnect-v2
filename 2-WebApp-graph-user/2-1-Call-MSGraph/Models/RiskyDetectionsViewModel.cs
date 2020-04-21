extern alias BetaLib;
using Graph = BetaLib.Microsoft.Graph;
using System.Collections;
using System.Collections.Generic;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class RiskyDetectionsViewModel
    {
        public static IList<Graph.RiskDetection> RisksDetected { get; set; }
    }
}