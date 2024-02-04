using System;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// With a string-typed Visual Studio (MSBuild) project name.
    /// </summary>
    [HasXMarker]
    public interface IWithProjectName :
        IHasProjectName
    {
        new string ProjectName { get; set; }
    }
}
