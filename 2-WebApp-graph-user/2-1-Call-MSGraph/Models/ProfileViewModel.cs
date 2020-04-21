extern alias BetaLib;
using Graph = BetaLib.Microsoft.Graph;

namespace WebApp_OpenIDConnect_DotNet.Models
{
    public class ProfileViewModel
    {
        public static BetaLib.Microsoft.Graph.User Me { get; set; }

        public static System.Reflection.PropertyInfo MeProperties { get; set; }
    }
}