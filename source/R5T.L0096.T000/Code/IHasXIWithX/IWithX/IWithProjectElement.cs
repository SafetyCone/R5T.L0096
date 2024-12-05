using System;
using System.Xml.Linq;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// With an XElement-typed Visual Studio (MSBuild) project element.
    /// </summary>
    [WithXMarker]
    public interface IWithProjectElement :
        IHasProjectElement
    {
        new XElement ProjectElement { get; set; }
    }
}
