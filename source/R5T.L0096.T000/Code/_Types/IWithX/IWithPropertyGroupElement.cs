using System;
using System.Xml.Linq;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// Has an XElement-typed Visual Studio (MSBuild) property group element.
    /// </summary>
    [WithXMarker]
    public interface IWithPropertyGroupElement : IWithXMarker,
        IHasPropertyGroupElement
    {
        new XElement PropertyGroupElement { get; set; }
    }
}
