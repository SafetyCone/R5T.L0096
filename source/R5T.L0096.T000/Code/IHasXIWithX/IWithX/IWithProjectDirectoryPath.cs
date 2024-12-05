using System;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// With a string-typed Visual Studio (MSBuild) project directory path.
    /// </summary>
    [WithXMarker]
    public interface IWithProjectDirectoryPath :
        IHasProjectDirectoryPath
    {
        new string ProjectDirectoryPath { get; set; }
    }
}
