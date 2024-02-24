using System;
using System.Xml.Linq;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// Has an XElement-typed Visual Studio (MSBuild) property group element.
    /// </summary>
    [HasXMarker]
    public interface IHasPropertyGroupElement : IHasXMarker
    {
        XElement PropertyGroupElement { get; }
    }
}
