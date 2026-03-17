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
    public partial class SourceGenerationContext : JsonSerializerContext
    {
        public static SourceGenerationContext Instance { get; } = new(new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = false
        });
    }
}