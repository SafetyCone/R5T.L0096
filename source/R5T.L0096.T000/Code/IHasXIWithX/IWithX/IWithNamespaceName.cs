using System;

using R5T.T0240;


namespace R5T.L0096.T000
{
    /// <summary>
    /// Has a string-typed code namespace name.
    /// </summary>
    [HasXMarker]
    public interface IWithNamespaceName :
        IHasNamespaceName
    {
        new string NamespaceName { get; set; }
    }
}
