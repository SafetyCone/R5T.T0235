using System;

using R5T.T0142;


namespace R5T.T0235.T000
{
    /// <summary>
    /// Framework-typed (string-based) IWithX interface for repository name.
    /// </summary>
    [DataTypeMarker]
    public interface IWithRepositoryName :
        IHasRepositoryName
    {
        new string RepositoryName { get; set; }
    }
}
