using System;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// With a string-typed project file path.
    /// </summary>
    /// <inheritdoc cref="IHasProjectFilePath" path="/remarks"/>
    [WithXMarker]
    public interface IWithProjectFilePath :
        IHasProjectFilePath
    {
        new string ProjectFilePath { get; set; }
    }
}
