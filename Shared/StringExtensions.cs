using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Shared;

public static class StringExtensions
{
    public static bool IsEmpty(this string? text)
    {
        return string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text);
    }

    public static bool HasValue(this string? text)
    {
        return !string.IsNullOrEmpty(text);
    }

    public static string OnlyNumbers(this string text)
    {
        if (text.HasValue())
        {
            return new string(text.Where(char.IsDigit).ToArray());
        }

        return "";
    }

	private static JsonSerializerSettings _settings = new()
	{
		Converters = [new StringEnumConverter()],
	};

	public static string Serialize(this object obj)
	{
		return JsonConvert.SerializeObject(obj, _settings);
	}
}
