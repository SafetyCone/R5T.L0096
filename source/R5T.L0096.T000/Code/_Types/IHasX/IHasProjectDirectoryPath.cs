using System;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// Has a string-typed Visual Studio (MSBuild) project directory path.
    /// </summary>
    [HasXMarker]
    public interface IHasProjectDirectoryPath
    {
        string ProjectDirectoryPath { get; }
    }
}
