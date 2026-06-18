using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using Supabase.Functions.Responses;

namespace Supabase.Functions
{
    [JsonSourceGenerationOptions(WriteIndented = false)]
    [JsonSerializable(typeof(BaseResponse))]
    [JsonSerializable(typeof(Client.InvokeFunctionOptions))]
    [JsonSerializable(typeof(int))]
    [JsonSerializable(typeof(uint))]
    [JsonSerializable(typeof(long))]
    [JsonSerializable(typeof(ulong))]
    [JsonSerializable(typeof(double))]
    [JsonSerializable(typeof(float))]
    [JsonSerializable(typeof(bool))]
    public partial class SourceGenerationContext : JsonSerializerContext
    {
        public static SourceGenerationContext Instance { get; } = new(new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = false
        });
    }
}