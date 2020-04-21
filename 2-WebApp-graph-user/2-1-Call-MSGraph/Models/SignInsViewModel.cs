extern alias BetaLib;
using Graph = BetaLib.Microsoft.Graph;
using System.Collections;
using System.Collections.Generic;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class SignInsViewModel
    {
        public static IList<Graph.SignIn> SignIns { get; set; }
    }
}