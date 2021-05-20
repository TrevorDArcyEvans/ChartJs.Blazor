using System;
using System.Linq;
using ChartJs.Blazor.Common.Time;
using Newtonsoft.Json;

namespace ChartJs.Blazor.GanttChart
{
    public class GanttDateTimeIntervalConverter : JsonConverter<GanttDateTimeInterval>
    {
        private readonly string FromName = typeof(GanttDateTimeInterval)
            .GetProperty(nameof(GanttDateTimeInterval.From))
            .GetCustomAttributes(false)
            .OfType<JsonPropertyAttribute>()
            .Single()
            .PropertyName;

        private readonly string ToName = typeof(GanttDateTimeInterval)
            .GetProperty(nameof(GanttDateTimeInterval.To))
            .GetCustomAttributes(false)
            .OfType<JsonPropertyAttribute>()
            .Single()
            .PropertyName;

        public override void WriteJson(JsonWriter writer, GanttDateTimeInterval value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName(FromName);
            writer.WriteValue(value.From.ToJavascript());
            writer.WritePropertyName(ToName);
            writer.WriteValue(value.To.ToJavascript());
            writer.WriteEndObject();
        }

        public override GanttDateTimeInterval ReadJson(JsonReader reader, Type objectType, GanttDateTimeInterval existingValue, bool hasExistingValue, JsonSerializer serializer) => throw new NotImplementedException();
    }
}
