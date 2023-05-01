using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JasperFx.CodeGeneration;
using JasperFx.Core;
using JasperFx.Core.Reflection;
using Marten.Events.CodeGeneration;
using Marten.Events.Projections;

namespace Marten.Exceptions;

/// <summary>
///     Thrown when any configuration rules for an active projection are violated and the projection is invalid
/// </summary>
public class InvalidProjectionException: MartenException
{
    public InvalidProjectionException(string message): base(message)
    {
    }

    internal InvalidProjectionException(GeneratedProjection projection, IEnumerable<MethodSlot> invalidMethods): base(
        ToMessage(projection, invalidMethods))
    {
        InvalidMethods = invalidMethods.ToArray();
    }

    public InvalidProjectionException(string[] messages): base(messages.Join(Environment.NewLine))
    {
        InvalidMethods = new MethodSlot[0];
    }

    public MethodSlot[] InvalidMethods { get; }

    private static string ToMessage(GeneratedProjection projection, IEnumerable<MethodSlot> invalidMethods)
    {
        var writer = new StringWriter();
        writer.WriteLine($"Projection {projection.GetType().FullNameInCode()} has validation errors:");
        foreach (var slot in invalidMethods)
        {
            writer.WriteLine(slot.Signature());
            foreach (var error in slot.Errors) writer.WriteLine(" - " + error);
        }

        return writer.ToString();
    }
}
