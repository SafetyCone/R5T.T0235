using System;

using R5T.T0142;


namespace R5T.T0235.T000
{
    /// <summary>
    /// Framework-typed (string-based) IHaxX interface for repository name.
    /// </summary>
    [DataTypeMarker]
    public interface IHasRepositoryName
    {
        string RepositoryName { get; }
    }
}
