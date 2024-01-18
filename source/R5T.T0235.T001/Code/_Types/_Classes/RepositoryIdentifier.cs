using System;

using R5T.T0142;


namespace R5T.T0235.T001
{
    [DataTypeMarker]
    public class RepositoryIdentifier : IRepositoryIdentifier
    {
        public string RepositoryOwnerName { get; set; }
        public string RepositoryName { get; set; }
    }
}
