using System;

using R5T.T0142;

using R5T.T0235.T000;


namespace R5T.T0235.T001
{
    [DataTypeMarker]
    public interface IRepositoryIdentifier :
        IHasRepositoryOwnerName,
        IHasRepositoryName
    {
    }
}
