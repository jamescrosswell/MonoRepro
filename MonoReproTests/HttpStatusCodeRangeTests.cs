/*
 * This code has been adapted from the HttpStatusCodeRangeTests from the Sentry SDK for .NET.
 * https://github.com/getsentry/sentry-dotnet/blob/4162cad5e2d9c0aa39ac7e13f7f3644f4ea92925/test/Sentry.Tests/HttpStatusCodeRangeTests.cs#L51-L64
 */
using FluentAssertions;
using MonoRepro;

namespace MonoReproTests;

public class HttpStatusCodeRangeTests
{
    [Fact]
    public void HttpStatusCodeRange_Excludes_AboveEnd()
    {
        // Arrange
        var start = 100;
        var end = 200;
        HttpStatusCodeRange sut = (start, end);

        // Act
        var inRange = sut.Contains(201);

        // Assert
        inRange.Should().BeFalse();
    }
}