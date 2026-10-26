using PCL.Core.App.Region;

namespace PCL;

internal static class RestrictedFeaturePolicy
{
    internal static RegionAssessment Assess() => new(RegionClassification.Other, "allowed");
    internal static bool IsRestricted => false;
    internal static bool Check(string feature, bool showHint = true) => true;
    internal static void ThrowIfRestricted(string feature) { }
}
