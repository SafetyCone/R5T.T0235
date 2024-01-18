using System;

using R5T.T0142;


namespace R5T.T0235.T001
{
    [DataTypeMarker]
    public interface IWithRepositoryIdentifier :
        IHasRepositoryIdentifier
    {
        new RepositoryIdentifier RepositoryIdentifier { get; set; }
    }
}
