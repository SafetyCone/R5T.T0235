using System;

using R5T.T0142;


namespace R5T.T0235.T000
{
    /// <summary>
    /// Framework-typed (string-based) IWithX interface for repository owner name.
    /// </summary>
    [DataTypeMarker]
    public interface IWithRepositoryOwnerName :
        IHasRepositoryOwnerName
    {
        new string RepositoryOwnerName { get; set; }
    }
}
