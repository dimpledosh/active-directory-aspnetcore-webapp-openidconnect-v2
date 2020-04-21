extern alias BetaLib;
using Graph = BetaLib.Microsoft.Graph;
using System.Collections;
using System.Collections.Generic;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class RiskyUsersViewModel
    {
        public static IList<Graph.RiskyUser> RiskyUsers { get; set; }
    }
}