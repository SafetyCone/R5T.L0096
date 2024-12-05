using System;
using System.Xml.Linq;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// Has an XElement-typed Visual Studio (MSBuild) item group element.
    /// </summary>
    [HasXMarker]
    public interface IHasItemGroupElement : IHasXMarker
    {
        XElement ItemGroupElement { get; }
    }
}
