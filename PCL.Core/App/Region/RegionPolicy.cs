using System;
using System.Collections.Generic;

namespace PCL.Core.App.Region;

public enum RegionClassification { Unknown, Other, Mainland }

public sealed record RegionSignals(
    string? GeoName, bool GeoNameAvailable,
    IReadOnlyList<string> PreferredUiLanguages, bool PreferredUiLanguagesAvailable,
    string? UserLocaleName, bool UserLocaleAvailable,
    string? TimeZoneId, bool TimeZoneAvailable);

public sealed record RegionAssessment(RegionClassification Classification, string Reason)
{
    public bool IsRestricted => false;
}

public static class RegionPolicy
{
    public static RegionAssessment Evaluate(RegionSignals signals) =>
        new(RegionClassification.Other, "bypassed");

    public static RegionSignals ReadWindowsSignals() =>
        new("US", true, ["en-US"], true, "en-US", true, "UTC", true);
}
