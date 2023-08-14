using System.Text.RegularExpressions;
using Microsoft.Net.Http.Headers;

namespace Sudokoko.PersonalSite.Extensions;

public static partial class RequestExtensions
{
    [GeneratedRegex("Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini|PlayStation Vita")]
    private static partial Regex MobileCheckRegex();

    public static bool IsMobile(this HttpRequest request) => MobileCheckRegex().IsMatch(request.Headers[HeaderNames.UserAgent].ToString());
}