namespace ServiceLayer.CommunServices
{
    public interface IModelDataAnotationCheck
    {
        void ValidateModelDataAnotations<TDomainName>(TDomainName domainModel);
    }
}