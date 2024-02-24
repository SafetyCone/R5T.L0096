using System;
using System.Xml.Linq;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// Has an XElement-typed Visual Studio (MSBuild) project element.
    /// </summary>
    [HasXMarker]
    public interface IHasProjectElement
    {
        XElement ProjectElement { get; }
    }
}
