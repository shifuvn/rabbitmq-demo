﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace RabbitMQ.Service.Bus.Abstractions;

internal static class JsonOptions
{
	public static JsonSerializerOptions Default { get; } = new(JsonSerializerDefaults.Web)
	{
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
	};
}